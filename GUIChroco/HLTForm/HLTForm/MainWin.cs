using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HLTStudio.Commons;
using HLTStudio.Dialogs;
using HLTStudio.Tools;

namespace HLTStudio
{
	public partial class MainWin : Form
	{
		// 隠しコントロール値 >>>

		private int HVal_欠損ファイル数 = 0;

		// <<< 隠しコントロール値

		public MainWin()
		{
			InitializeComponent();
		}

		private void MainWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;
		}

		private void MainWin_Shown(object sender, EventArgs e)
		{
			Settings.LoadSettings();

			this.TxtInputRootDir.Text = "";
			this.TargetRelPathList.Items.Clear();
			this.TxtOutputRootDir.Text = "";

			this.RefreshView();

			// ----

			try
			{
				ArgsReader ar = ProcMain.ArgsReader;

				if (ar.HasArgs())
				{
					string contextFile = SCommon.MakeFullPath(ar.NextArg());

					if (!File.Exists(contextFile))
						throw new Exception("指定されたコンテキストファイルは存在しません。");

					if (!Path.GetExtension(contextFile).EqualsIgnoreCase(".xml"))
						throw new Exception("指定されたコンテキストファイルは .xml ではありません。");

					this.ImportMain(contextFile);
				}
				ar.End();
			}
			catch (Exception ex)
			{
				MessageDlg.Run(
					MessageDlg.Kind_e.Error,
					"引数の処理に失敗しました",
					ex.Message,
					ex,
					new string[] { "OK" }
					);
			}
		}

		private void MainWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.SaveSettings();
		}

		private void MenuBar_アプリケーション_終了_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MenuBar_ツール_設定_Click(object sender, EventArgs e)
		{
			using (SettingsWin f = new SettingsWin())
			{
				f.ShowDialog();
			}
		}

		private void BtnInputRootDir_Click(object sender, EventArgs e)
		{
			string retPath = SelectDirectoryDlg.Run(this.TxtInputRootDir.Text);

			if (!retPath.EqualsIgnoreCase(this.TxtInputRootDir.Text))
			{
				this.TxtInputRootDir.Text = retPath;
				this.TargetRelPathList.Items.Clear();
				this.HVal_欠損ファイル数 = 0;
				this.RefreshView();
			}
		}

		private void BtnOutputRootDir_Click(object sender, EventArgs e)
		{
			string retPath = SelectDirectoryDlg.Run(this.TxtOutputRootDir.Text);

			if (!retPath.EqualsIgnoreCase(this.TxtOutputRootDir.Text))
			{
				this.TxtOutputRootDir.Text = retPath;
				this.RefreshView();
			}
		}

		private void BtnEditTree_Click(object sender, EventArgs e)
		{
			if (!CheckBeforeEdit())
				return;

			this.Visible = false;

			using (EditTreeWin f = new EditTreeWin())
			{
				f.RootDir = this.TxtInputRootDir.Text;
				f.TargetRelPaths = this.GetTargetRelPaths();

				f.ShowDialog();

				if (f.ValueChanged)
				{
					this.SetTargetRelPaths(f.TargetRelPaths);
					this.HVal_欠損ファイル数 = 0;
					this.RefreshView();
				}
			}
			this.Visible = true;
		}

		private void BtnEditList_Click(object sender, EventArgs e)
		{
			if (!CheckBeforeEdit())
				return;

			this.Visible = false;

			using (EditListWin f = new EditListWin())
			{
				f.RootDir = this.TxtInputRootDir.Text;
				f.TargetRelPaths = this.GetTargetRelPaths();

				f.ShowDialog();

				if (f.ValueChanged)
				{
					this.SetTargetRelPaths(f.TargetRelPaths);
					this.HVal_欠損ファイル数 = 0;
					this.RefreshView();
				}
			}
			this.Visible = true;
		}

		private bool CheckBeforeEdit()
		{
			if (this.TxtInputRootDir.Text == "")
			{
				MessageDlg.Run(
					MessageDlg.Kind_e.Warning,
					"編集を開始できません",
					"入力フォルダを設定してください。",
					null,
					new string[] { "OK" }
					);

				return false;
			}

			var dirAndFiles = Directory.EnumerateFileSystemEntries(
				this.TxtInputRootDir.Text,
				"*",
				SearchOption.AllDirectories
				);

			if (Settings.LoadablePathCountMax < dirAndFiles.Take(Settings.LoadablePathCountMax + 1).Count())
			{
				MessageDlg.Run(
					MessageDlg.Kind_e.Warning,
					"編集を開始できません",
					"入力フォルダ配下のオブジェクト数が制限を超えています。\r\n"
					+ "(制限は設定から変更できます)",
					null,
					new string[] { "OK" }
					);

				return false;
			}

			return true;
		}

		private void Btnインポート_Click(object sender, EventArgs e)
		{
			try
			{
				string homeDir = Directory.GetCurrentDirectory();
				try
				{
					using (OpenFileDialog ofd = new OpenFileDialog())
					{
						ofd.FileName = "Context.xml";

						//ofd.InitialDirectory = "C:\\";
						ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

						//ofd.Filter = "JPEGファイル(*.jpg;*.jpeg)|*.jpg;*.jpeg|PNGファイル(*.png)|*.png|すべてのファイル(*.*)|*.*";
						//ofd.FilterIndex = 1; // JPEGファイル
						//ofd.FilterIndex = 2; // PNGファイル
						//ofd.FilterIndex = 3; // すべてのファイル
						ofd.Filter = "XMLファイル(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
						ofd.FilterIndex = 1;

						ofd.Title = "インポートするファイルを選択してください";
						ofd.RestoreDirectory = true;
						//ofd.CheckFileExists = true;
						//ofd.CheckPathExists = true;

						if (ofd.ShowDialog() == DialogResult.OK)
						{
							string selectedPath = SCommon.MakeFullPath(ofd.FileName);

							if (!File.Exists(selectedPath))
								throw null; // 存在しないファイルは選択できないはず！

							this.ImportMain(selectedPath);
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
					"インポートに失敗しました",
					ex.Message,
					ex,
					new string[] { "OK" }
					);
			}
		}

		private void Btnエクスポート_Click(object sender, EventArgs e)
		{
			try
			{
				string homeDir = Directory.GetCurrentDirectory();
				try
				{
					using (SaveFileDialog sfd = new SaveFileDialog())
					{
						sfd.FileName = "Context.xml";

						//sfd.InitialDirectory = "C:\\";
						sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

						//sfd.Filter = "JPEGファイル(*.jpg;*.jpeg)|*.jpg;*.jpeg|PNGファイル(*.png)|*.png|すべてのファイル(*.*)|*.*";
						//sfd.FilterIndex = 1; // JPEGファイル
						//sfd.FilterIndex = 2; // PNGファイル
						//sfd.FilterIndex = 3; // すべてのファイル
						sfd.Filter = "XMLファイル(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
						sfd.FilterIndex = 1;

						sfd.Title = "エクスポート先ファイルを選択してください";
						sfd.RestoreDirectory = true;
						//sfd.OverwritePrompt = true;
						//sfd.CheckPathExists = true;

						if (sfd.ShowDialog() == DialogResult.OK)
						{
							string selectedPath = sfd.FileName;

							// 存在しなくても良い。
							//if (!File.Exists(selectedPath))
							//throw null;

							this.ExportMain(selectedPath);
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
					"エクスポートに失敗しました",
					ex.Message,
					ex,
					new string[] { "OK" }
					);
			}
		}

		private void ImportMain(string contextFile)
		{
			try
			{
				XMLTools.Node root = XMLTools.LoadFromFile(contextFile);

				string inputRootDir = root["Context/InputRootDir"].Value;
				string outputRootDir = root["Context/OutputRootDir"].Value;
				string[] targetRelPaths = root.GetNodes("Context/TargetRelPaths/TargetRelPath").Select(node => node.Value).ToArray();
				bool check1 = root["Context/Check1"].Value.StartsWithIgnoreCase("T"); // ? True
				bool check2 = root["Context/Check2"].Value.StartsWithIgnoreCase("T"); // ? True

				if (inputRootDir != "")
				{
					inputRootDir = SCommon.MakeFullPath(inputRootDir);

					if (!Directory.Exists(inputRootDir))
						throw new Exception("入力フォルダが存在しません。");
				}

				if (outputRootDir != "")
				{
					outputRootDir = SCommon.MakeFullPath(outputRootDir);

					if (!Directory.Exists(outputRootDir))
						throw new Exception("出力フォルダが存在しません。");
				}

				if (Settings.LoadablePathCountMax < targetRelPaths.Length)
					throw new Exception("対象パス数が制限を超えています。(制限は設定から変更できます)");

				int 欠損ファイル数 = 0;

				foreach (string targetRelPath in targetRelPaths)
				{
					if (!P_IsFairTargetRelPath(targetRelPath))
						throw new Exception("不正な対象パスが含まれています。_" + targetRelPath);

					string inputPath = Path.Combine(inputRootDir, targetRelPath);

					if (!File.Exists(inputPath))
						欠損ファイル数++;
				}

				this.TxtInputRootDir.Text = inputRootDir;
				this.SetTargetRelPaths(targetRelPaths);
				this.HVal_欠損ファイル数 = 欠損ファイル数;
				this.TxtOutputRootDir.Text = outputRootDir;
				this.Chkコピー前にコピー先をクリアする.Checked = check1;
				this.Chk大文字小文字は対象パスリストに合わせる.Checked = check2;

				this.RefreshView();
			}
			catch (Exception ex)
			{
				throw new Exception("コンテキストファイルの読み込みに失敗しました。", ex);
			}
		}

		private bool P_IsFairTargetRelPath(string targetRelPath)
		{
			if (string.IsNullOrWhiteSpace(targetRelPath))
				return false;

			if (targetRelPath.Contains(':')) // ? ドライブ名を含んでいる。
				return false;

			if (targetRelPath.Contains("\\\\")) // ? 空のパストークン
				return false;

			if (targetRelPath.StartsWith("\\")) // ? パストークンで始まっていない。
				return false;

			if (targetRelPath.EndsWith("\\")) // ? パストークンで終わっていない。
				return false;

			return true;
		}

		private void ExportMain(string contextFile)
		{
			XMLTools.Node root = new XMLTools.Node()
			{
				Name = "ChunkRootCopier",
			};

			XMLTools.Node context = new XMLTools.Node()
			{
				Name = "Context",
			};

			root.Children.Add(context);

			context.Children.Add(new XMLTools.Node()
			{
				Name = "InputRootDir",
				Value = this.TxtInputRootDir.Text,
			});

			context.Children.Add(new XMLTools.Node()
			{
				Name = "OutputRootDir",
				Value = this.TxtOutputRootDir.Text,
			});

			XMLTools.Node targetRelPathsNode = new XMLTools.Node()
			{
				Name = "TargetRelPaths",
			};

			context.Children.Add(targetRelPathsNode);

			foreach (string targetRelPath in this.GetTargetRelPaths())
			{
				targetRelPathsNode.Children.Add(new XMLTools.Node()
				{
					Name = "TargetRelPath",
					Value = targetRelPath,
				});
			}

			context.Children.Add(new XMLTools.Node()
			{
				Name = "Check1",
				Value = this.Chkコピー前にコピー先をクリアする.Checked.ToString(),
			});

			context.Children.Add(new XMLTools.Node()
			{
				Name = "Check2",
				Value = this.Chk大文字小文字は対象パスリストに合わせる.Checked.ToString(),
			});

			XMLTools.WriteToFile(root, contextFile);
		}

		private string[] GetTargetRelPaths()
		{
			return this.TargetRelPathList.Items
				.Cast<object>()
				.Select(item => item.ToString())
				.ToArray();
		}

		private void SetTargetRelPaths(string[] targetRelPaths)
		{
			this.TargetRelPathList.BeginUpdate();
			this.TargetRelPathList.Items.Clear();
			this.TargetRelPathList.Items.AddRange(targetRelPaths);
			this.TargetRelPathList.EndUpdate();
		}

		private void RefreshView()
		{
			List<string> 未入力項目s = new List<string>();

			bool error1 = false;
			bool error2 = false;
			bool error3 = false;

			if (this.TxtInputRootDir.Text == "")
			{
				未入力項目s.Add("入力フォルダ");
				error1 = true;
			}

			if (this.TargetRelPathList.Items.Count == 0)
			{
				未入力項目s.Add("対象パス");
				error2 = true;
			}

			if (this.TxtOutputRootDir.Text == "")
			{
				未入力項目s.Add("出力フォルダ");
				error3 = true;
			}

			if (未入力項目s.Count != 0)
				this.MainStatus.Text = $"{string.Join("・", 未入力項目s)} ... が未入力です。";
			else
				this.MainStatus.Text = "準備ができたら「実行」ボタンを押してください。";

			if (
				this.TxtInputRootDir.Text != "" &&
				this.TxtInputRootDir.Text.EqualsIgnoreCase(this.TxtOutputRootDir.Text)
				)
			{
				this.OutputRootDirErrorMessage.Text = "コピー元フォルダと同じです！";
				error3 = true;
			}
			else
			{
				this.OutputRootDirErrorMessage.Text = "";
			}

			if (this.TargetRelPathList.Items.Count == 0)
			{
				this.TargetRelPathListStatus.Text = "対象パスが選択されていません。";
				this.TargetRelPathListStatus.ForeColor = Color.Black;
				error2 = true;
			}
			else if (this.HVal_欠損ファイル数 == 0)
			{
				this.TargetRelPathListStatus.Text = $"対象ファイル数：{this.TargetRelPathList.Items.Count}";
				this.TargetRelPathListStatus.ForeColor = Color.Black;
			}
			else
			{
				this.TargetRelPathListStatus.Text = $"対象ファイル数：{this.TargetRelPathList.Items.Count}　( 欠損ファイル数：{this.HVal_欠損ファイル数} )";
				this.TargetRelPathListStatus.ForeColor = Color.Red;
				error2 = true;
			}

			this.SubStatus.Text = ""; // HACK: 使ってない。

			{
				Color VERY_LIGHT_GRAY = Color.FromArgb(250, 250, 250);

				this.TxtInputRootDir.BackColor = error1 ?
					Color.LightYellow :
					VERY_LIGHT_GRAY;
				this.TargetRelPathList.BackColor = error2 ?
					Color.LightYellow :
					Color.White;
				this.TxtOutputRootDir.BackColor = error3 ?
					Color.LightYellow :
					VERY_LIGHT_GRAY;
			}
		}

		private void TxtInputRootDirMenu_コピー_Click(object sender, EventArgs e)
		{
			P_クリップボードへコピー(this.TxtInputRootDir.Text);
		}

		private void TxtOutputRootDirMenu_コピー_Click(object sender, EventArgs e)
		{
			P_クリップボードへコピー(this.TxtOutputRootDir.Text);
		}

		private void TargetRelPathListMenu_コピー_Click(object sender, EventArgs e)
		{
			P_クリップボードへコピー(SCommon.LinesToText(this.GetTargetRelPaths()));
		}

		private static void P_クリップボードへコピー(string text)
		{
			try
			{
				if (string.IsNullOrEmpty(text))
					Clipboard.Clear();
				else
					Clipboard.SetText(text);
			}
			catch
			{ }
		}

		private void TargetRelPathListStatus_Click(object sender, EventArgs e)
		{
			this.TargetRelPathList.ClearSelected();
		}

		private void MainWin_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private void MainWin_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

				if (files.Length != 1)
					throw new Exception("1つのファイルをドラッグ＆ドロップしてください。");

				string file = SCommon.MakeFullPath(files[0]);

				if (!File.Exists(file))
					throw new Exception("ドラッグ＆ドロップされたファイルは存在しません。");

				if (!Path.GetExtension(file).EqualsIgnoreCase(".xml"))
					throw new Exception("ドラッグ＆ドロップされたファイルは .xml ではありません。");

				this.ImportMain(file);
			}
			catch (Exception ex)
			{
				MessageDlg.Run(
					MessageDlg.Kind_e.Warning,
					"インポートに失敗しました",
					ex.Message,
					ex,
					new string[] { "OK" }
					);

				return;
			}
		}

		#region Execute

		private void BtnExecute_Click(object sender, EventArgs e)
		{
			try
			{
				this.ExecuteMain();
			}
			catch (Exception ex)
			{
				MessageDlg.Run(
					MessageDlg.Kind_e.Error,
					"コピー処理でエラーが発生しました",
					ex.Message,
					ex,
					new string[] { "OK" }
					);
			}
		}

		private void ExecuteMain()
		{
			if (this.TxtInputRootDir.Text == "")
			{
				EM_ShowCannotStartMessage("入力フォルダを設定してください。");
				return;
			}
			if (this.TargetRelPathList.Items.Count == 0)
			{
				EM_ShowCannotStartMessage("対象パスリストを設定してください。");
				return;
			}
			if (this.TxtOutputRootDir.Text == "")
			{
				EM_ShowCannotStartMessage("出力フォルダを設定してください。");
				return;
			}
			if (this.TxtInputRootDir.Text.EqualsIgnoreCase(this.TxtOutputRootDir.Text))
			{
				EM_ShowCannotStartMessage("入力フォルダと出力フォルダが同じです。");
				return;
			}

			if (this.HVal_欠損ファイル数 != 0)
			{
				int ret = MessageDlg.Run(
					MessageDlg.Kind_e.Warning,
					"コピー処理開始前確認",
					"対象パスリストに欠損ファイルがあるようです。\r\n"
					+ "欠損ファイルはスキップされます。続行してよろしいですか？",
					null,
					new string[] { "はい", "いいえ", "キャンセル" }
					);

				if (ret != 1)
					return;
			}

			// Confirm
			{
				string 対象パス件数_trailer = this.HVal_欠損ファイル数 == 0 ? "" : $"\u3000( 欠損ファイル数：{this.HVal_欠損ファイル数} )";

				int ret = MessageDlg.Run(
					MessageDlg.Kind_e.Question,
					"コピー処理開始前確認",
					"コピー処理を開始します。よろしいですか？\r\n"
					+ $"・入力フォルダ：{this.TxtInputRootDir.Text}\r\n"
					+ $"・対象パス件数：{this.GetTargetRelPaths().Length} 件{対象パス件数_trailer}\r\n"
					+ $"・出力フォルダ：{this.TxtOutputRootDir.Text}\r\n"
					+ $"・コピー前にコピー先をクリアする：{(this.Chkコピー前にコピー先をクリアする.Checked ? "はい" : "いいえ")}\r\n"
					+ $"・大文字小文字は対象パスリストに合わせる：{(this.Chk大文字小文字は対象パスリストに合わせる.Checked ? "はい" : "いいえ")}",
					null,
					new string[] { "開始", "キャンセル" }
					);

				if (ret != 1)
					return;
			}

			using (WorkingDir wd = new WorkingDir())
			{
				string S_0 = 0.ToString();
				string S_1 = 1.ToString();

				string logFile = wd.MakePath() + ".log";
				string targetRelPathListFile = wd.MakePath() + "_TargetRelPathList.txt";
				string responseFile = wd.MakePath() + ".response";
				string successfulFile = wd.MakePath() + ".successful";

				File.WriteAllLines(
					targetRelPathListFile,
					this.GetTargetRelPaths(),
					Encoding.UTF8
					);

				File.WriteAllLines(
					responseFile,
					new string[]
					{
						this.TxtInputRootDir.Text,
						this.TxtOutputRootDir.Text,
						targetRelPathListFile,
						logFile,
						this.Chkコピー前にコピー先をクリアする.Checked ? S_0 : S_1, // 0/1 であることに注意！
						this.Chk大文字小文字は対象パスリストに合わせる.Checked ? S_1 : S_0,
						successfulFile,
					},
					Encoding.UTF8
					);

				this.Visible = false;
				try
				{
					ProcessingDlg.Run("コピー処理中", "コピー処理を実行しています...", () =>
					{
						SCommon.Batch(new string[]
						{
							$"\"{Consts.ChrocoExeFile}\" /@ \"{responseFile}\"",
						});
					});

					using (CompleteWin f = new CompleteWin())
					{
						f.SuccessfulFlag = File.Exists(successfulFile);
						f.LogLines = File.ReadAllLines(logFile, Encoding.UTF8);

						f.ShowDialog();
					}
				}
				finally
				{
					this.Visible = true;
				}
			}
		}

		private void EM_ShowCannotStartMessage(string message)
		{
			MessageDlg.Run(
				MessageDlg.Kind_e.Warning,
				"コピー処理を開始できません",
				message,
				null,
				new string[] { "OK" }
				);
		}

		#endregion
	}
}
