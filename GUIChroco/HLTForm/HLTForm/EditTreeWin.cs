using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HLTStudio.Commons;
using HLTStudio.Dialogs;

namespace HLTStudio
{
	public partial class EditTreeWin : Form
	{
		public string RootDir;
		public string[] TargetRelPaths;
		public bool ValueChanged = false;

		// <--- 引数と返却値

		public EditTreeWin()
		{
			InitializeComponent();
		}

		private void EditTreeWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;
		}

		private void EditTreeWin_Shown(object sender, EventArgs e)
		{
			this.MT_SetDirectory(this.RootDir, this.TargetRelPaths);
			this.MT_CheckParentIfAllChildrenChecked();
		}

		private void EditTreeWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.MT_Clear(); // ツリーが巨大な場合、クリアしないとプログラム終了に時間が掛かる。
		}

		#region MainTree

		private void MainTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			// none -- デザイナ、ダブルクリックで飛んでくる用
		}

		private void MainTree_Click(object sender, EventArgs e)
		{
			// このイベントでは、選択されたノードを取得できないらしい。
		}

		private void MainTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.MainTree.SelectedNode = e.Node; // 右クリックメニューのために、右クリックしたときもノード選択させる。
			}
		}

		private SCommon.SortedArray<string> MT_SD_InitialCheckedRelPaths;

		private void MT_SetDirectory(string rootDir, string[] initialCheckedRelPaths)
		{
			MT_SD_InitialCheckedRelPaths = new SCommon.SortedArray<string>(initialCheckedRelPaths, SCommon.CompIgnoreCase);

			this.MainTree.BeginUpdate();
			this.MainTree.Nodes.Clear();
			this.MainTree.Nodes.Add(this.MT_CreateDirectoryNode(rootDir, true));
			this.MainTree.EndUpdate();

			MT_SD_InitialCheckedRelPaths = null;
		}

		private void MT_Clear()
		{
			this.MainTree.BeginUpdate();
			this.MainTree.Nodes.Clear();
			this.MainTree.EndUpdate();
		}

		private enum MT_EntryKind_e
		{
			Directory = 1,
			File,
		}

		private class MT_Entry_t
		{
			public string StrPath;
			public MT_EntryKind_e Kind;
		}

		private TreeNode MT_CreateDirectoryNode(string dir, bool rootFlag)
		{
			TreeNode node = new TreeNode($"📁{(rootFlag ? dir : Path.GetFileName(dir))}")
			{
				Tag = new MT_Entry_t()
				{
					StrPath = dir,
					Kind = MT_EntryKind_e.Directory,
				},

				ForeColor = Utility_m.Approach(Color.DarkOrange, Color.Black, 0.5),
			};

			string[] subDirs = Directory.GetDirectories(dir)
				.OrderBy(SCommon.CompIgnoreCase)
				.ToArray();

			string[] files = Directory.GetFiles(dir)
				.OrderBy(SCommon.CompIgnoreCase)
				.ToArray();

			foreach (string subDir in subDirs)
				node.Nodes.Add(this.MT_CreateDirectoryNode(subDir, false));

			foreach (string file in files)
				node.Nodes.Add(this.MT_CreateFileNode(file));

			if (rootFlag)
				node.Expand();

			return node;
		}

		private TreeNode MT_CreateFileNode(string file)
		{
			TreeNode node = new TreeNode($"📄{Path.GetFileName(file)}")
			{
				Tag = new MT_Entry_t()
				{
					StrPath = file,
					Kind = MT_EntryKind_e.File,
				},

				ForeColor = Utility_m.Approach(Color.DarkGreen, Color.Black, 0.25),
			};

			bool initialCheckFlag = MT_SD_InitialCheckedRelPaths.GetIndex(SCommon.EraseRoot(((MT_Entry_t)node.Tag).StrPath, this.RootDir)) != -1;

			if (initialCheckFlag)
				node.Checked = true;

			return node;
		}

		private bool MT_AfterCheckDisabled = false;

		private void MainTree_AfterCheck(object sender, TreeViewEventArgs e)
		{
			if (MT_AfterCheckDisabled)
				return;

			MT_SetDescendantsCheck(e.Node, e.Node.Checked);
		}

		private static void MT_SetDescendantsCheck(TreeNode node, bool value)
		{
			foreach (TreeNode subNode in node.Nodes)
			{
				subNode.Checked = value;
			}
		}

		private void MainTreeMenu_配下を全て開く_Click(object sender, EventArgs e)
		{
			MT_MenuAction(node =>
			{
				node.ExpandAll();
			});
		}

		private void MainTreeMenu_配下を全て閉じる_Click(object sender, EventArgs e)
		{
			MT_MenuAction(node =>
			{
				node.Collapse();
			});
		}

		private void MainTreeMenu_配下も含めて選択オン_Click(object sender, EventArgs e)
		{
			MT_MenuAction(node =>
			{
				node.Checked = true;
				MT_SetDescendantsCheck(node, true);
			});
		}

		private void MainTreeMenu_配下も含めて選択オフ_Click(object sender, EventArgs e)
		{
			MT_MenuAction(node =>
			{
				node.Checked = false;
				MT_SetDescendantsCheck(node, false);
			});
		}

		private void MainTreeMenu_チェックされている項目のみ展開する_Click(object sender, EventArgs e)
		{
			MT_MenuAction(node =>
			{
				MT_チェックされている項目のみ展開する(node);
			});
		}

		private void MainTreeMenu_チェック状態の確認_Click(object sender, EventArgs e)
		{
			MT_MenuAction(node =>
			{
				MessageBox.Show(node.Checked.ToString());
			});
		}

		private void MT_MenuAction(Action<TreeNode> action)
		{
			TreeNode node = this.MainTree.SelectedNode;

			if (node == null)
			{
				MessageDlg.Run(
					MessageDlg.Kind_e.Warning,
					"ツリーメニューのアクションを実行できません",
					"ツリーノードを選択してください。",
					null,
					new string[] { "OK" }
					);

				return;
			}
			action(node);
		}

		private IEnumerable<TreeNode> MT_GetAllNodes()
		{
			Queue<TreeNodeCollection> q = new Queue<TreeNodeCollection>();

			q.Enqueue(this.MainTree.Nodes);

			while (1 <= q.Count)
			{
				foreach (TreeNode node in q.Dequeue())
				{
					yield return node;

					q.Enqueue(node.Nodes);
				}
			}
		}

		private void MT_CheckParentIfAllChildrenChecked()
		{
			MT_AfterCheckDisabled = true;

			foreach (TreeNode node in this.MainTree.Nodes)
			{
				Main(node);
			}

			MT_AfterCheckDisabled = false;

			void Main(TreeNode node)
			{
				if (node.Nodes.Count == 0)
					return;

				foreach (TreeNode child in node.Nodes)
					Main(child);

				if (IsAllChildrenChecked(node))
					node.Checked = true;
			}

			bool IsAllChildrenChecked(TreeNode node)
			{
				foreach (TreeNode child in node.Nodes)
					if (!child.Checked && !IsEmptyDirectory(child))
						return false;

				return true;
			}

			bool IsEmptyDirectory(TreeNode node)
			{
				return
					((MT_Entry_t)node.Tag).Kind == MT_EntryKind_e.Directory &&
					node.Nodes.Count == 0;
			}
		}

		private void MT_チェックされている項目のみ展開する(TreeNode root)
		{
			Main(root);

			bool Main(TreeNode node)
			{
				bool expanded = false;

				foreach (TreeNode child in node.Nodes)
					expanded |= Main(child);

				if (expanded || HasCheckedChildren(node))
				{
					node.Expand();
					return true;
				}
				else
				{
					node.Collapse();
					return false;
				}
			}

			bool HasCheckedChildren(TreeNode node)
			{
				foreach (TreeNode child in node.Nodes)
					if (child.Checked)
						return true;

				return false;
			}
		}

		#endregion

		private static class Utility_m
		{
			public static Color Approach(Color colorFrom, Color colorTo, double rate)
			{
				return Color.FromArgb(
					SCommon.ToInt(colorFrom.R * (1.0 - rate) + colorTo.R * rate, 0, 255),
					SCommon.ToInt(colorFrom.G * (1.0 - rate) + colorTo.G * rate, 0, 255),
					SCommon.ToInt(colorFrom.B * (1.0 - rate) + colorTo.B * rate, 0, 255)
					);
			}
		}

		private void Btnチェックのみ展開する_Click(object sender, EventArgs e)
		{
			this.MT_チェックされている項目のみ展開する(this.MainTree.Nodes[0]);
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			this.TargetRelPaths = this.MT_GetAllNodes()
				.Where(node => node.Checked)
				.Select(node => node.Tag)
				.Cast<MT_Entry_t>()
				.Where(entry => entry.Kind == MT_EntryKind_e.File)
				.Select(entry => SCommon.EraseRoot(entry.StrPath, this.RootDir))
				.OrderBy(SCommon.CompIgnoreCase)
				.ToArray();

			this.ValueChanged = true;

			this.Close();
		}

		private void Btnキャンセル_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
