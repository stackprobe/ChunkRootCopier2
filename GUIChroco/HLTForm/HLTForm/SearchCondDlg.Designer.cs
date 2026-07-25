namespace HLTStudio
{
	partial class SearchCondDlg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCondDlg));
			this.TxtSearchWord = new System.Windows.Forms.TextBox();
			this.G001 = new System.Windows.Forms.GroupBox();
			this.RdBtn後方一致 = new System.Windows.Forms.RadioButton();
			this.RdBtn部分一致 = new System.Windows.Forms.RadioButton();
			this.RdBtn完全一致 = new System.Windows.Forms.RadioButton();
			this.L001 = new System.Windows.Forms.Label();
			this.Btnキャンセル = new System.Windows.Forms.Button();
			this.Btn検索 = new System.Windows.Forms.Button();
			this.L002 = new System.Windows.Forms.Label();
			this.G001.SuspendLayout();
			this.SuspendLayout();
			// 
			// TxtSearchWord
			// 
			this.TxtSearchWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtSearchWord.Location = new System.Drawing.Point(12, 32);
			this.TxtSearchWord.MaxLength = 300;
			this.TxtSearchWord.Name = "TxtSearchWord";
			this.TxtSearchWord.Size = new System.Drawing.Size(626, 27);
			this.TxtSearchWord.TabIndex = 1;
			this.TxtSearchWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchWord_KeyPress);
			// 
			// G001
			// 
			this.G001.Controls.Add(this.RdBtn後方一致);
			this.G001.Controls.Add(this.RdBtn部分一致);
			this.G001.Controls.Add(this.RdBtn完全一致);
			this.G001.Location = new System.Drawing.Point(12, 65);
			this.G001.Name = "G001";
			this.G001.Size = new System.Drawing.Size(140, 150);
			this.G001.TabIndex = 2;
			this.G001.TabStop = false;
			this.G001.Text = "一致パターン";
			// 
			// RdBtn後方一致
			// 
			this.RdBtn後方一致.AutoSize = true;
			this.RdBtn後方一致.Location = new System.Drawing.Point(20, 100);
			this.RdBtn後方一致.Name = "RdBtn後方一致";
			this.RdBtn後方一致.Size = new System.Drawing.Size(79, 24);
			this.RdBtn後方一致.TabIndex = 2;
			this.RdBtn後方一致.Text = "後方一致";
			this.RdBtn後方一致.UseVisualStyleBackColor = true;
			this.RdBtn後方一致.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RdBtn後方一致_KeyPress);
			// 
			// RdBtn部分一致
			// 
			this.RdBtn部分一致.AutoSize = true;
			this.RdBtn部分一致.Checked = true;
			this.RdBtn部分一致.Location = new System.Drawing.Point(20, 70);
			this.RdBtn部分一致.Name = "RdBtn部分一致";
			this.RdBtn部分一致.Size = new System.Drawing.Size(79, 24);
			this.RdBtn部分一致.TabIndex = 1;
			this.RdBtn部分一致.TabStop = true;
			this.RdBtn部分一致.Text = "部分一致";
			this.RdBtn部分一致.UseVisualStyleBackColor = true;
			this.RdBtn部分一致.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RdBtn部分一致_KeyPress);
			// 
			// RdBtn完全一致
			// 
			this.RdBtn完全一致.AutoSize = true;
			this.RdBtn完全一致.Location = new System.Drawing.Point(20, 40);
			this.RdBtn完全一致.Name = "RdBtn完全一致";
			this.RdBtn完全一致.Size = new System.Drawing.Size(79, 24);
			this.RdBtn完全一致.TabIndex = 0;
			this.RdBtn完全一致.Text = "完全一致";
			this.RdBtn完全一致.UseVisualStyleBackColor = true;
			this.RdBtn完全一致.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RdBtn完全一致_KeyPress);
			// 
			// L001
			// 
			this.L001.AutoSize = true;
			this.L001.Location = new System.Drawing.Point(12, 9);
			this.L001.Name = "L001";
			this.L001.Size = new System.Drawing.Size(87, 20);
			this.L001.TabIndex = 0;
			this.L001.Text = "検索文字列：";
			// 
			// Btnキャンセル
			// 
			this.Btnキャンセル.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Btnキャンセル.Location = new System.Drawing.Point(518, 155);
			this.Btnキャンセル.Name = "Btnキャンセル";
			this.Btnキャンセル.Size = new System.Drawing.Size(120, 60);
			this.Btnキャンセル.TabIndex = 5;
			this.Btnキャンセル.Text = "キャンセル";
			this.Btnキャンセル.UseVisualStyleBackColor = true;
			this.Btnキャンセル.Click += new System.EventHandler(this.Btnキャンセル_Click);
			// 
			// Btn検索
			// 
			this.Btn検索.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn検索.Location = new System.Drawing.Point(392, 155);
			this.Btn検索.Name = "Btn検索";
			this.Btn検索.Size = new System.Drawing.Size(120, 60);
			this.Btn検索.TabIndex = 4;
			this.Btn検索.Text = "検　索";
			this.Btn検索.UseVisualStyleBackColor = true;
			this.Btn検索.Click += new System.EventHandler(this.Btn検索_Click);
			// 
			// L002
			// 
			this.L002.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.L002.AutoSize = true;
			this.L002.ForeColor = System.Drawing.Color.Teal;
			this.L002.Location = new System.Drawing.Point(382, 100);
			this.L002.Name = "L002";
			this.L002.Size = new System.Drawing.Size(256, 20);
			this.L002.TabIndex = 3;
			this.L002.Text = "検索にヒットした行を選択状態にします。";
			// 
			// SearchCondDlg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 227);
			this.Controls.Add(this.L002);
			this.Controls.Add(this.Btn検索);
			this.Controls.Add(this.Btnキャンセル);
			this.Controls.Add(this.L001);
			this.Controls.Add(this.G001);
			this.Controls.Add(this.TxtSearchWord);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchCondDlg";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "検索";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchCondDlg_FormClosed);
			this.Load += new System.EventHandler(this.SearchCondDlg_Load);
			this.Shown += new System.EventHandler(this.SearchCondDlg_Shown);
			this.G001.ResumeLayout(false);
			this.G001.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtSearchWord;
		private System.Windows.Forms.GroupBox G001;
		private System.Windows.Forms.RadioButton RdBtn部分一致;
		private System.Windows.Forms.RadioButton RdBtn完全一致;
		private System.Windows.Forms.Label L001;
		private System.Windows.Forms.Button Btnキャンセル;
		private System.Windows.Forms.Button Btn検索;
		private System.Windows.Forms.Label L002;
		private System.Windows.Forms.RadioButton RdBtn後方一致;
	}
}