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

namespace HLTStudio
{
	public partial class CompleteWin : Form
	{
		public bool SuccessfulFlag;
		public string[] LogLines;

		// <--- 引数

		public CompleteWin()
		{
			InitializeComponent();
		}

		private void CompleteWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;
		}

		private void CompleteWin_Shown(object sender, EventArgs e)
		{
			if (this.SuccessfulFlag)
			{
				this.SuccessfulIcon.Visible = true;
				this.SuccessfulIcon.Left = this.ErrorIcon.Left;
				this.SuccessfulIcon.Top = this.ErrorIcon.Top;
				this.ErrorIcon.Visible = false;

				this.MainMessage.Text = "コピー処理は成功しました。";
			}
			else
			{
				this.MainMessage.Text = "コピー処理に失敗しました。↓のログを確認してください。";
			}

			this.LBLog.BeginUpdate();
			this.LBLog.Items.Clear();
			this.LBLog.Items.AddRange(this.LogLines);
			this.LBLog.EndUpdate();
		}

		private void CompleteWin_Click(object sender, EventArgs e)
		{
			this.LBLog.ClearSelected();
		}

		private void LBLogMenu_コピー_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(SCommon.LinesToText(this.LogLines));
			}
			catch
			{ }
		}

		private void Btn閉じる_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
