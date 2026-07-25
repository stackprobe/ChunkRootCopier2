using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HLTStudio.Commons;
using HLTStudio.Dialogs;

namespace HLTStudio.Dialogs
{
	public partial class SelectDirectoryDlg : Form
	{
		public static string Run(string strPath)
		{
			using (SelectDirectoryDlg f = new SelectDirectoryDlg())
			{
				f.StrPath = strPath;

				f.ShowDialog();

				return f.StrPath;
			}
		}

		private string StrPath;

		private SelectDirectoryDlg()
		{
			InitializeComponent();
		}

		private void SelectDirectoryDlg_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;
		}

		private void SelectDirectoryDlg_Shown(object sender, EventArgs e)
		{
			this.TxtPath.Text = this.StrPath;
			this.TxtPath.SelectAll();
		}

		private void SelectDirectoryDlg_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private void SelectDirectoryDlg_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				string[] dirs = (string[])e.Data.GetData(DataFormats.FileDrop);

				if (dirs.Length != 1)
					throw new Exception("1つのフォルダをドラッグ＆ドロップしてください。");

				string dir = SCommon.MakeFullPath(dirs[0]);

				if (!Directory.Exists(dir))
					throw new Exception("ドラッグ＆ドロップされたフォルダは存在しません。");

				this.TxtPath.Text = dir;
			}
			catch (Exception ex)
			{
				MessageDlg.Run(
					MessageDlg.Kind_e.Warning,
					"フォルダのドラッグ＆ドロップに失敗しました",
					ex.Message,
					ex,
					new string[] { "OK" }
					);
			}
		}

		private void TxtPathMenu_コピー_Click(object sender, EventArgs e)
		{
			try
			{
				string text = this.TxtPath.Text;

				if (text == "")
					Clipboard.Clear();
				else
					Clipboard.SetText(text);
			}
			catch
			{ }
		}

		private void TxtPathMenu_貼り付け_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Clipboard.GetText();

				if (string.IsNullOrEmpty(text))
					throw new Exception("クリップボードにテキストがありません。");

				text = new string(text.Where(chr => ' ' <= chr).ToArray());

				if (this.TxtPath.MaxLength < text.Length)
					throw new Exception("クリップボードのテキストは長すぎます。");

				this.TxtPath.Text = text;
			}
			catch (Exception ex)
			{
				MessageDlg.Run(
					MessageDlg.Kind_e.Warning,
					"クリップボードの貼り付けに失敗しました",
					ex.Message,
					ex,
					new string[] { "OK" }
					);
			}
		}

		private void TxtPathMenu_クリア_Click(object sender, EventArgs e)
		{
			this.TxtPath.Clear();
		}

		private void Btn元に戻す_Click(object sender, EventArgs e)
		{
			this.TxtPath.Text = this.StrPath;
		}

		private void Btn参照_Click(object sender, EventArgs e)
		{
			try
			{
				string homeDir = Directory.GetCurrentDirectory();
				try
				{
					string initialSelectedPath;
					try
					{
						initialSelectedPath = SCommon.MakeFullPath(this.TxtPath.Text);

						if (!Directory.Exists(initialSelectedPath))
							throw null; // goto catch
					}
					catch
					{
						initialSelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
					}

					using (FolderBrowserDialog fbd = new FolderBrowserDialog())
					{
						const bool 新しいフォルダの作成を許可するか_Flag = true;

						fbd.Description = "フォルダを選択してください。";
						fbd.RootFolder = Environment.SpecialFolder.Desktop;
						fbd.SelectedPath = initialSelectedPath;
						fbd.ShowNewFolderButton = 新しいフォルダの作成を許可するか_Flag;

						if (fbd.ShowDialog() == DialogResult.OK)
						{
							string selectedPath = SCommon.MakeFullPath(fbd.SelectedPath);

							if (!Directory.Exists(selectedPath))
								throw null; // 存在しないディレクトリは選択できないはず！

							this.TxtPath.Text = selectedPath;
						}
					}
				}
				finally
				{
					Directory.SetCurrentDirectory(homeDir);
				}
			}
			catch (Exception ex)
			{
				MessageDlg.Run(
					MessageDlg.Kind_e.Warning,
					"フォルダの選択に失敗しました",
					ex.Message,
					ex,
					new string[] { "OK" }
					);
			}
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			try
			{
				string strPath = SCommon.MakeFullPath(this.TxtPath.Text);

				if (!Directory.Exists(strPath))
					throw new Exception("指定されたフォルダは存在しません。");

				this.StrPath = strPath;
				this.Close();
				return;
			}
			catch (Exception ex)
			{
				MessageDlg.Run(
					MessageDlg.Kind_e.Warning,
					"入力フォルダを確定できません",
					ex.Message,
					ex,
					new string[] { "OK" }
					);
			}
		}

		private void Btnキャンセル_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
