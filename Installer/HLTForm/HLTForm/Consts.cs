using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HLTStudio
{
	public static class Consts
	{
		/// <summary>
		/// ベンダーフォルダ名
		/// </summary>
		public static readonly string VENDOR_FOLDER_NAME = "HLTWorks";

		/// <summary>
		/// アプリケーション名
		/// 用途：表示・フォルダ名・ショートカット名
		/// </summary>
		public static readonly string APPLICATION_NAME = "ChunkRootCopier";

		/// <summary>
		/// アプリケーション名
		/// 用途：表示
		/// </summary>
		public static readonly string APPLICATION_LONG_NAME = "CHROCO - CHunk ROot COpier";

		/// <summary>
		/// デフォルトのインストール先
		/// </summary>
		public static string DEFAULT_INSTALL_DIR
		{
			get
			{
				string appDataLocalDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

				if (
					string.IsNullOrEmpty(appDataLocalDir) ||
					!Directory.Exists(appDataLocalDir)
					)
					throw new Exception("Bad appDataLocalDir");

				return Path.Combine(appDataLocalDir, VENDOR_FOLDER_NAME, APPLICATION_NAME);
			}
		}

		/// <summary>
		/// クラスタファイルの一覧
		/// </summary>
		public static readonly string[] CLUSTER_FILES = new string[]
		{
			"Chroco.cmp-gz",
			"GUIChroco.cmp-gz",
		};

		/// <summary>
		/// クラスタファイルのハッシュ値ファイル用の拡張子
		/// </summary>
		public static readonly string HASH_EXTENSION = ".hash";

		/// <summary>
		/// 起動プログラム
		/// インストール先からの相対パス
		/// </summary>
		public static readonly string MAIN_PROGRAM = @"GUIChroco\GUIChroco.exe";

		/// <summary>
		/// インストール先に配置するシグネチャ・ファイル名
		/// --
		/// 既インストール先の判定に使用する。
		/// インストール先の末端フォルダ名はアプリケーション名によって異なるため、
		/// (重複を避ける目的で)いちいち変える必要は無い。
		/// </summary>
		public static readonly string INSTALLED_SIGNATURE = "HLT_{dc63e002-fe96-4123-b93e-c5795ed66f42}";
	}
}
