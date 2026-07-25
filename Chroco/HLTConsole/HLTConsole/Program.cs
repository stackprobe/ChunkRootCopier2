using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using HLTStudio.Commons;

namespace HLTStudio
{
	class Program
	{
		static void Main(string[] args)
		{
			ProcMain.CUIMain(new Program().Main2);
		}

		private void Main2(ArgsReader ar)
		{
			if (ProcMain.DEBUG)
			{
				Main3();
			}
			else
			{
				Main4(ar);
			}
			SCommon.OpenOutputDirIfCreated();
		}

		private void Main3()
		{
#if DEBUG
			// -- choose one --

			//Main4(new ArgsReader(new string[] { }));
			//Main4(new ArgsReader(new string[] { }));
			//Main4(new ArgsReader(new string[] { }));

			// --
#endif
			SCommon.Pause();
		}

		private void Main4(ArgsReader ar)
		{
			try
			{
				Main5(ar);
			}
			catch (Exception ex)
			{
				P_WriteLog(ex);

				//MessageBox.Show(ex.ToString(), $"{Path.GetFileNameWithoutExtension(ProcMain.SelfFile)} / エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

				P_WriteLog(ex);
			}
		}

		// -- 引数 --

		private string InputRootDir = null;
		private string OutputRootDir = null;
		private string TargetRelPathListFile = null;
		private string LogFile = null;
		private string SuccessfulFile = null;
		private bool DontClearOutputDir = false;
		private bool DontNormalizePathCase = false;
		private Encoding TargetRelPathListFileEncoding = Encoding.UTF8;

		// ----

		private string[] TargetRelPaths;

		private void Main5(ArgsReader ar)
		{
			for (; ; )
			{
				if (ar.ArgIs("/R"))
				{
					InputRootDir = SCommon.MakeFullPath(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/D"))
				{
					OutputRootDir = SCommon.MakeFullPath(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/P"))
				{
					TargetRelPathListFile = SCommon.MakeFullPath(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/L"))
				{
					LogFile = SCommon.MakeFullPath(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/S"))
				{
					SuccessfulFile = SCommon.MakeFullPath(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/-C"))
				{
					DontClearOutputDir = true;
					continue;
				}
				if (ar.ArgIs("/-N"))
				{
					DontNormalizePathCase = true;
					continue;
				}
				if (ar.ArgIs("/PS"))
				{
					TargetRelPathListFileEncoding = SCommon.ENCODING_SJIS;
					continue;
				}
				if (ar.ArgIs("/@"))
				{
					string responseFile = SCommon.MakeFullPath(ar.NextArg());
					string[] resLines = File.ReadAllLines(responseFile, Encoding.UTF8);
					int r = 0;

					InputRootDir = SCommon.MakeFullPath(resLines[r++]);
					OutputRootDir = SCommon.MakeFullPath(resLines[r++]);
					TargetRelPathListFile = SCommon.MakeFullPath(resLines[r++]);
					LogFile = SCommon.MakeFullPath(resLines[r++]);
					DontClearOutputDir = int.Parse(resLines[r++]) != 0;
					DontNormalizePathCase = int.Parse(resLines[r++]) != 0;
					SuccessfulFile = SCommon.MakeFullPath(resLines[r++]);

					if (resLines.Length != r)
						throw new Exception("レスポンスファイルの行数が不正です。");

					continue;
				}
				break;
			}
			ar.End();

			// -- 引数チェック --

			if (InputRootDir == null)
				throw new Exception("入力フォルダを指定してください。");

			if (!Directory.Exists(InputRootDir))
				throw new Exception("入力フォルダが存在しません。");

			if (OutputRootDir == null)
				throw new Exception("出力フォルダを指定してください。");

			if (!Directory.Exists(OutputRootDir))
				throw new Exception("出力フォルダが存在しません。");

			if (TargetRelPathListFile == null)
				throw new Exception("対象パスリストファイルを指定してください。");

			if (!File.Exists(TargetRelPathListFile))
				throw new Exception("対象パスリストファイルが存在しません。");

			// LogFile
			// SuccessfulFile
			// DontClearOutputDir
			// DontNormalizePathCase
			// TargetRelPathListFileEncoding

			// ----

			P_WriteLog("-- Parameters --");
			P_WriteLog($"InputRootDir：{InputRootDir}");
			P_WriteLog($"OutputRootDir：{OutputRootDir}");
			P_WriteLog($"TargetRelPathListFile：{TargetRelPathListFile}");
			P_WriteLog($"LogFile：{LogFile}");
			P_WriteLog($"DontClearOutputDir：{DontClearOutputDir}");
			P_WriteLog($"DontNormalizePathCase：{DontNormalizePathCase}");
			P_WriteLog($"TargetRelPathListFileEncoding：{TargetRelPathListFileEncoding}");
			P_WriteLog("----");

			TargetRelPaths = File.ReadAllLines(TargetRelPathListFile, TargetRelPathListFileEncoding);

			if (!DontNormalizePathCase)
				NormalizeTargetRelPaths();

			if (!DontClearOutputDir)
				P_ClearDir(OutputRootDir);

			P_WriteLog("★コピー処理を開始します。");

			int count1 = 0;
			int count2 = 0;
			int count3 = 0;
			int count4 = 0;

			foreach (string targetRelPath in TargetRelPaths)
			{
				string inputPath = Path.Combine(InputRootDir, targetRelPath);
				string outputPath = Path.Combine(OutputRootDir, targetRelPath);

				P_WriteLog($"< {inputPath}");
				P_WriteLog($"> {outputPath}");

				if (File.Exists(outputPath))
				{
					P_WriteLog($"コピー先の既存ファイルを削除します...");

					SCommon.DeletePath(outputPath);

					P_WriteLog($"コピー先の既存ファイルを削除しました。");
					count1++;
				}

				if (File.Exists(inputPath))
				{
					P_WriteLog($"ファイルをコピーします...");

					SCommon.CreateDir(SCommon.ToParentPath(outputPath));
					File.Copy(inputPath, outputPath);

					P_WriteLog($"ファイルをコピーしました。");
					count2++;
				}
				else if (Directory.Exists(inputPath))
				{
					P_WriteLog($"ディレクトリを作成します...");

					SCommon.CreateDir(outputPath);

					P_WriteLog($"ディレクトリを作成しました。");
					count3++;
				}
				else
				{
					P_WriteLog($"コピー元が存在しないためスキップします。");
					count4++;
				}
			}
			P_WriteLog("★コピー処理が完了しました。");

			P_WriteLog("-- 結果 --");
			P_WriteLog($"上書き回数：{count1}");
			P_WriteLog($"コピー件数：{count2}");
			P_WriteLog($"ディレクトリ作成回数：{count3}");
			P_WriteLog($"スキップ回数：{count4}");
			P_WriteLog("----");

			if (SuccessfulFile != null)
				File.WriteAllBytes(SuccessfulFile, SCommon.EMPTY_BYTES);
		}

		private void NormalizeTargetRelPaths()
		{
			P_WriteLog("パスを正規化します...");

			TargetRelPaths = TargetRelPaths
				.Select(targetRelPath => NormalizePathCase(targetRelPath, InputRootDir))
				.ToArray();

			P_WriteLog("パスを正規化しました。");
		}

		private string NormalizePathCase(string srcPath, string dir)
		{
			string[] srcPathTokens = srcPath.Split('\\');
			string[] destPathTokens = srcPathTokens.ToArray();

			for (int index = 0; index < srcPathTokens.Length; index++)
			{
				string srcPathToken = srcPathTokens[index];

				string destPathToken = Directory.EnumerateFileSystemEntries(dir, "*")
					.Select(p => Path.GetFileName(p))
					.FirstOrDefault(pn => pn.EqualsIgnoreCase(srcPathToken));

				if (destPathToken == null)
					break;

				destPathTokens[index] = destPathToken;
				dir = Path.Combine(dir, destPathToken);
			}
			string destPath = string.Join("\\", destPathTokens);

			if (srcPath != destPath)
			{
				P_WriteLog("N< " + srcPath);
				P_WriteLog("N> " + destPath);
			}
			return destPath;
		}

		private void P_ClearDir(string dir)
		{
			P_WriteLog($"ディレクトリ \"{dir}\" をクリーンアップします...");

			// zantei
			if (dir.Length <= 3)
				throw new Exception("安全のためルートディレクトリはクリーンアップできません！");

			foreach (string subDir in Directory.GetDirectories(dir))
				SCommon.DeletePath(subDir);

			foreach (string file in Directory.GetFiles(dir))
				SCommon.DeletePath(file);

			P_WriteLog($"ディレクトリ \"{dir}\" をクリーンアップしました。");
		}

		private void P_WriteLog(object message)
		{
			try
			{
				string line = $"[{SimpleDateTime.Now}] {message}";

				Console.WriteLine(line);

				if (LogFile != null)
				{
					using (StreamWriter writer = new StreamWriter(LogFile, true, Encoding.UTF8))
					{
						writer.WriteLine(line);
					}
				}
			}
			catch
			{ }
		}
	}
}
