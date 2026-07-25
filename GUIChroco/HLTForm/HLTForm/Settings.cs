using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HLTStudio.Commons;

namespace HLTStudio
{
	public static class Settings
	{
		public static readonly int LOADABLE_PATH_COUNT_MAX_MIN = 1;
		public static readonly int LOADABLE_PATH_COUNT_MAX_DEF = 10000;
		public static readonly int LOADABLE_PATH_COUNT_MAX_MAX = SCommon.IMAX;

		// Items >>>

		public static int LoadablePathCountMax = LOADABLE_PATH_COUNT_MAX_DEF;
		public static string SCD_LastSearchWord = "";
		public static SearchCondDlg.MatchType_e SCD_LastMatchType = SearchCondDlg.MatchType_e.部分一致;

		// <<< Items

		public static void LoadSettings()
		{
			try
			{
				string[] src = SCommon.Serializer.I.Split(File.ReadAllBytes(Consts.SettingsFile));
				int r = 0;

				// Items >>>

				LoadablePathCountMax = SCommon.ToInt(src[r++], 1, SCommon.IMAX, LoadablePathCountMax);
				SCD_LastSearchWord = src[r++];
				SCD_LastMatchType = (SearchCondDlg.MatchType_e)int.Parse(src[r++]);

				// <<< Items
			}
			catch
			{ }
		}

		public static void SaveSettings()
		{
			List<string> dest = new List<string>();

			// Items >>>

			dest.Add(LoadablePathCountMax.ToString());
			dest.Add(SCD_LastSearchWord);
			dest.Add(((int)SCD_LastMatchType).ToString());

			// <<< Items

			File.WriteAllBytes(Consts.SettingsFile, SCommon.Serializer.I.BinJoin(dest));
		}
	}
}
