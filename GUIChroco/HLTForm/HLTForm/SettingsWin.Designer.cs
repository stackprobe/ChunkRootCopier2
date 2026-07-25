namespace HLTStudio
{
	partial class SettingsWin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWin));
			this.Btnキャンセル = new System.Windows.Forms.Button();
			this.BtnOK = new System.Windows.Forms.Button();
			this.TxtLoadablePathCountMax = new System.Windows.Forms.TextBox();
			this.L001 = new System.Windows.Forms.Label();
			this.Btnデフォルトに戻す = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Btnキャンセル
			// 
			this.Btnキャンセル.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Btnキャンセル.Location = new System.Drawing.Point(412, 149);
			this.Btnキャンセル.Name = "Btnキャンセル";
			this.Btnキャンセル.Size = new System.Drawing.Size(120, 40);
			this.Btnキャンセル.TabIndex = 4;
			this.Btnキャンセル.Text = "キャンセル";
			this.Btnキャンセル.UseVisualStyleBackColor = true;
			this.Btnキャンセル.Click += new System.EventHandler(this.Btnキャンセル_Click);
			// 
			// BtnOK
			// 
			this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOK.Location = new System.Drawing.Point(286, 149);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(120, 40);
			this.BtnOK.TabIndex = 3;
			this.BtnOK.Text = "OK";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// TxtLoadablePathCountMax
			// 
			this.TxtLoadablePathCountMax.Location = new System.Drawing.Point(211, 57);
			this.TxtLoadablePathCountMax.MaxLength = 10;
			this.TxtLoadablePathCountMax.Name = "TxtLoadablePathCountMax";
			this.TxtLoadablePathCountMax.Size = new System.Drawing.Size(120, 27);
			this.TxtLoadablePathCountMax.TabIndex = 1;
			this.TxtLoadablePathCountMax.Text = "9999999999";
			this.TxtLoadablePathCountMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// L001
			// 
			this.L001.AutoSize = true;
			this.L001.Location = new System.Drawing.Point(40, 60);
			this.L001.Name = "L001";
			this.L001.Size = new System.Drawing.Size(165, 20);
			this.L001.TabIndex = 0;
			this.L001.Text = "ロード可能なパス数の上限";
			// 
			// Btnデフォルトに戻す
			// 
			this.Btnデフォルトに戻す.Location = new System.Drawing.Point(337, 57);
			this.Btnデフォルトに戻す.Name = "Btnデフォルトに戻す";
			this.Btnデフォルトに戻す.Size = new System.Drawing.Size(140, 27);
			this.Btnデフォルトに戻す.TabIndex = 2;
			this.Btnデフォルトに戻す.Text = "デフォルトに戻す";
			this.Btnデフォルトに戻す.UseVisualStyleBackColor = true;
			this.Btnデフォルトに戻す.Click += new System.EventHandler(this.Btnデフォルトに戻す_Click);
			// 
			// SettingsWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 201);
			this.Controls.Add(this.Btnデフォルトに戻す);
			this.Controls.Add(this.L001);
			this.Controls.Add(this.TxtLoadablePathCountMax);
			this.Controls.Add(this.Btnキャンセル);
			this.Controls.Add(this.BtnOK);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsWin";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "設定";
			this.Load += new System.EventHandler(this.SettingsWin_Load);
			this.Shown += new System.EventHandler(this.SettingsWin_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Btnキャンセル;
		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.TextBox TxtLoadablePathCountMax;
		private System.Windows.Forms.Label L001;
		private System.Windows.Forms.Button Btnデフォルトに戻す;
	}
}