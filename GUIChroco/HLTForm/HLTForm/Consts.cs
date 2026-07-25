using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HLTStudio.Commons;

namespace HLTStudio
{
	public static class Consts
	{
		public static string SettingsFile => ProcMain.SelfFile + ".settings.dat";

		public static string ChrocoExeFile
		{
			get
			{
				string file = Path.Combine(ProcMain.SelfDir, @"..\Chroco\Chroco.exe"); // リリース時

				if (!File.Exists(file))
				{
					file = Path.Combine(ProcMain.SelfDir, @"..\..\..\..\..\Chroco\HLTConsole\HLTConsole\bin\Release\HLTConsole.exe"); // 開発環境

					if (!File.Exists(file))
						throw null; // ファイルが無い！ビルドして！
				}
				return file;
			}
		}
	}
}
