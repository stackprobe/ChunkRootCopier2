using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HLTStudio.Commons;
using HLTStudio.Dialogs;

namespace HLTStudio
{
	public partial class SettingsWin : Form
	{
		public SettingsWin()
		{
			InitializeComponent();
		}

		private void SettingsWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;
		}

		private void SettingsWin_Shown(object sender, EventArgs e)
		{
			this.TxtLoadablePathCountMax.Text = Settings.LoadablePathCountMax.ToString();
			this.TxtLoadablePathCountMax.SelectAll();
		}

		private void Btnデフォルトに戻す_Click(object sender, EventArgs e)
		{
			this.TxtLoadablePathCountMax.Text = Settings.LOADABLE_PATH_COUNT_MAX_DEF.ToString();
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			try
			{
				Settings.LoadablePathCountMax = P_ToInt(
					this.TxtLoadablePathCountMax.Text,
					Settings.LOADABLE_PATH_COUNT_MAX_MIN,
					Settings.LOADABLE_PATH_COUNT_MAX_MAX
					);

				this.Close();
			}
			catch (Exception ex)
			{
				MessageDlg.Run(
					MessageDlg.Kind_e.Warning,
					"設定を確定できません",
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

		private static int P_ToInt(string text, int minval, int maxval)
		{
			int value = int.Parse(text);

			if (value < minval || maxval < value)
				throw new Exception($"{minval} ～ {maxval} の範囲で値を入力してください。");

			return value;
		}
	}
}
