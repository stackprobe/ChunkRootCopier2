using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HLTStudio.Dialogs;

namespace HLTStudio
{
	public partial class SearchCondDlg : Form
	{
		public enum MatchType_e
		{
			完全一致 = 1,
			部分一致,
			後方一致,
		}

		public string SearchWord;
		public MatchType_e MatchType;
		public bool ExecuteFlag = false;

		// <--- 返却値

		public SearchCondDlg()
		{
			InitializeComponent();
		}

		private void SearchCondDlg_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;
		}

		private void SearchCondDlg_Shown(object sender, EventArgs e)
		{
			this.TxtSearchWord.Text = Settings.SCD_LastSearchWord;
			this.TxtSearchWord.SelectAll();

			switch (Settings.SCD_LastMatchType)
			{
				case MatchType_e.完全一致: this.RdBtn完全一致.Checked = true; break;
				case MatchType_e.部分一致: this.RdBtn部分一致.Checked = true; break;
				case MatchType_e.後方一致: this.RdBtn後方一致.Checked = true; break;

				default:
					throw null; // never
			}
		}

		private void SearchCondDlg_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.SCD_LastSearchWord = this.TxtSearchWord.Text;

			if (this.RdBtn完全一致.Checked)
				Settings.SCD_LastMatchType = MatchType_e.完全一致;
			else if (this.RdBtn部分一致.Checked)
				Settings.SCD_LastMatchType = MatchType_e.部分一致;
			else if (this.RdBtn後方一致.Checked)
				Settings.SCD_LastMatchType = MatchType_e.後方一致;
			else
				throw null; // never
		}

		private void TxtSearchWord_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13) // Enter
			{
				this.Btn検索_Click(null, null);
			}
		}

		private void RdBtn完全一致_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13) // Enter
			{
				this.Btn検索_Click(null, null);
			}
		}

		private void RdBtn部分一致_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13) // Enter
			{
				this.Btn検索_Click(null, null);
			}
		}

		private void RdBtn後方一致_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13) // Enter
			{
				this.Btn検索_Click(null, null);
			}
		}

		private void Btn検索_Click(object sender, EventArgs e)
		{
			try
			{
				this.SanitizeAndValidate();

				MatchType_e matchType;
				if (this.RdBtn完全一致.Checked)
					matchType = MatchType_e.完全一致;
				else if (this.RdBtn部分一致.Checked)
					matchType = MatchType_e.部分一致;
				else if (this.RdBtn後方一致.Checked)
					matchType = MatchType_e.後方一致;
				else
					throw null; // never

				this.SearchWord = this.TxtSearchWord.Text;
				this.MatchType = matchType;
				this.ExecuteFlag = true;

				this.Close();
				return;
			}
			catch (Exception ex)
			{
				MessageDlg.Run(
					MessageDlg.Kind_e.Warning,
					"検索できません",
					ex.Message,
					ex,
					new string[] { "OK" }
					);
			}
		}

		private void SanitizeAndValidate()
		{
			this.TxtSearchWord.Text = this.TxtSearchWord.Text.Trim();

			if (this.TxtSearchWord.Text == "")
			{
				throw new Exception("検索文字列が入力されていません。");
			}
		}

		private void Btnキャンセル_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
