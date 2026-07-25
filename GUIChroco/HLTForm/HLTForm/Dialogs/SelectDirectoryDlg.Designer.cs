namespace HLTStudio.Dialogs
{
	partial class SelectDirectoryDlg
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDirectoryDlg));
			this.BtnOK = new System.Windows.Forms.Button();
			this.Btnキャンセル = new System.Windows.Forms.Button();
			this.TxtPath = new System.Windows.Forms.TextBox();
			this.TxtPathMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TxtPathMenu_コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.TxtPathMenu_貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			this.S002 = new System.Windows.Forms.ToolStripSeparator();
			this.TxtPathMenu_クリア = new System.Windows.Forms.ToolStripMenuItem();
			this.Btn参照 = new System.Windows.Forms.Button();
			this.L001 = new System.Windows.Forms.Label();
			this.L002 = new System.Windows.Forms.Label();
			this.Btn元に戻す = new System.Windows.Forms.Button();
			this.TxtPathMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnOK
			// 
			this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOK.Location = new System.Drawing.Point(526, 189);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(120, 60);
			this.BtnOK.TabIndex = 5;
			this.BtnOK.Text = "OK";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// Btnキャンセル
			// 
			this.Btnキャンセル.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Btnキャンセル.Location = new System.Drawing.Point(652, 189);
			this.Btnキャンセル.Name = "Btnキャンセル";
			this.Btnキャンセル.Size = new System.Drawing.Size(120, 60);
			this.Btnキャンセル.TabIndex = 6;
			this.Btnキャンセル.Text = "キャンセル";
			this.Btnキャンセル.UseVisualStyleBackColor = true;
			this.Btnキャンセル.Click += new System.EventHandler(this.Btnキャンセル_Click);
			// 
			// TxtPath
			// 
			this.TxtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtPath.ContextMenuStrip = this.TxtPathMenu;
			this.TxtPath.Location = new System.Drawing.Point(12, 73);
			this.TxtPath.MaxLength = 300;
			this.TxtPath.Name = "TxtPath";
			this.TxtPath.Size = new System.Drawing.Size(760, 27);
			this.TxtPath.TabIndex = 1;
			// 
			// TxtPathMenu
			// 
			this.TxtPathMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtPathMenu_コピー,
            this.TxtPathMenu_貼り付け,
            this.S002,
            this.TxtPathMenu_クリア});
			this.TxtPathMenu.Name = "TxtPathMenu";
			this.TxtPathMenu.Size = new System.Drawing.Size(131, 76);
			// 
			// TxtPathMenu_コピー
			// 
			this.TxtPathMenu_コピー.Name = "TxtPathMenu_コピー";
			this.TxtPathMenu_コピー.Size = new System.Drawing.Size(130, 22);
			this.TxtPathMenu_コピー.Text = "コピー(&C)";
			this.TxtPathMenu_コピー.Click += new System.EventHandler(this.TxtPathMenu_コピー_Click);
			// 
			// TxtPathMenu_貼り付け
			// 
			this.TxtPathMenu_貼り付け.Name = "TxtPathMenu_貼り付け";
			this.TxtPathMenu_貼り付け.Size = new System.Drawing.Size(130, 22);
			this.TxtPathMenu_貼り付け.Text = "貼り付け(&P)";
			this.TxtPathMenu_貼り付け.Click += new System.EventHandler(this.TxtPathMenu_貼り付け_Click);
			// 
			// S002
			// 
			this.S002.Name = "S002";
			this.S002.Size = new System.Drawing.Size(127, 6);
			// 
			// TxtPathMenu_クリア
			// 
			this.TxtPathMenu_クリア.Name = "TxtPathMenu_クリア";
			this.TxtPathMenu_クリア.Size = new System.Drawing.Size(130, 22);
			this.TxtPathMenu_クリア.Text = "クリア(&L)";
			this.TxtPathMenu_クリア.Click += new System.EventHandler(this.TxtPathMenu_クリア_Click);
			// 
			// Btn参照
			// 
			this.Btn参照.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn参照.Location = new System.Drawing.Point(692, 106);
			this.Btn参照.Name = "Btn参照";
			this.Btn参照.Size = new System.Drawing.Size(80, 40);
			this.Btn参照.TabIndex = 3;
			this.Btn参照.Text = "参照...";
			this.Btn参照.UseVisualStyleBackColor = true;
			this.Btn参照.Click += new System.EventHandler(this.Btn参照_Click);
			// 
			// L001
			// 
			this.L001.AutoSize = true;
			this.L001.Location = new System.Drawing.Point(12, 50);
			this.L001.Name = "L001";
			this.L001.Size = new System.Drawing.Size(113, 20);
			this.L001.TabIndex = 0;
			this.L001.Text = "選択されたパス：";
			// 
			// L002
			// 
			this.L002.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.L002.AutoSize = true;
			this.L002.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.L002.Location = new System.Drawing.Point(12, 192);
			this.L002.Name = "L002";
			this.L002.Size = new System.Drawing.Size(334, 60);
			this.L002.TabIndex = 4;
			this.L002.Text = "上部のテキストボックスに直接入力するか、\r\n右側の［参照...］ボタンで選択するか、\r\nこの領域にドラッグ＆ドロップして指定してください。";
			// 
			// Btn元に戻す
			// 
			this.Btn元に戻す.Location = new System.Drawing.Point(12, 106);
			this.Btn元に戻す.Name = "Btn元に戻す";
			this.Btn元に戻す.Size = new System.Drawing.Size(120, 40);
			this.Btn元に戻す.TabIndex = 2;
			this.Btn元に戻す.Text = "元に戻す";
			this.Btn元に戻す.UseVisualStyleBackColor = true;
			this.Btn元に戻す.Click += new System.EventHandler(this.Btn元に戻す_Click);
			// 
			// SelectDirectoryDlg
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 261);
			this.Controls.Add(this.L001);
			this.Controls.Add(this.TxtPath);
			this.Controls.Add(this.Btn参照);
			this.Controls.Add(this.Btn元に戻す);
			this.Controls.Add(this.L002);
			this.Controls.Add(this.Btnキャンセル);
			this.Controls.Add(this.BtnOK);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectDirectoryDlg";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "フォルダを選択してください";
			this.Load += new System.EventHandler(this.SelectDirectoryDlg_Load);
			this.Shown += new System.EventHandler(this.SelectDirectoryDlg_Shown);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SelectDirectoryDlg_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SelectDirectoryDlg_DragEnter);
			this.TxtPathMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.Button Btnキャンセル;
		private System.Windows.Forms.TextBox TxtPath;
		private System.Windows.Forms.Button Btn参照;
		private System.Windows.Forms.Label L001;
		private System.Windows.Forms.Label L002;
		private System.Windows.Forms.ContextMenuStrip TxtPathMenu;
		private System.Windows.Forms.ToolStripMenuItem TxtPathMenu_コピー;
		private System.Windows.Forms.ToolStripMenuItem TxtPathMenu_貼り付け;
		private System.Windows.Forms.ToolStripSeparator S002;
		private System.Windows.Forms.ToolStripMenuItem TxtPathMenu_クリア;
		private System.Windows.Forms.Button Btn元に戻す;
	}
}