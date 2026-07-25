namespace HLTStudio
{
	partial class CompleteWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteWin));
			this.MainMessage = new System.Windows.Forms.Label();
			this.LBLog = new System.Windows.Forms.ListBox();
			this.Btn閉じる = new System.Windows.Forms.Button();
			this.ErrorIcon = new System.Windows.Forms.PictureBox();
			this.LBLogMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.LBLogMenu_コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.SuccessfulIcon = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
			this.LBLogMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SuccessfulIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// MainMessage
			// 
			this.MainMessage.AutoSize = true;
			this.MainMessage.Location = new System.Drawing.Point(90, 40);
			this.MainMessage.Name = "MainMessage";
			this.MainMessage.Size = new System.Drawing.Size(86, 20);
			this.MainMessage.TabIndex = 0;
			this.MainMessage.Text = "(メッセージ)";
			// 
			// LBLog
			// 
			this.LBLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LBLog.ContextMenuStrip = this.LBLogMenu;
			this.LBLog.FormattingEnabled = true;
			this.LBLog.ItemHeight = 20;
			this.LBLog.Location = new System.Drawing.Point(12, 90);
			this.LBLog.Name = "LBLog";
			this.LBLog.Size = new System.Drawing.Size(760, 404);
			this.LBLog.TabIndex = 1;
			// 
			// Btn閉じる
			// 
			this.Btn閉じる.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn閉じる.Location = new System.Drawing.Point(655, 500);
			this.Btn閉じる.Name = "Btn閉じる";
			this.Btn閉じる.Size = new System.Drawing.Size(117, 49);
			this.Btn閉じる.TabIndex = 2;
			this.Btn閉じる.Text = "閉じる";
			this.Btn閉じる.UseVisualStyleBackColor = true;
			this.Btn閉じる.Click += new System.EventHandler(this.Btn閉じる_Click);
			// 
			// ErrorIcon
			// 
			this.ErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("ErrorIcon.Image")));
			this.ErrorIcon.Location = new System.Drawing.Point(12, 12);
			this.ErrorIcon.Name = "ErrorIcon";
			this.ErrorIcon.Size = new System.Drawing.Size(72, 72);
			this.ErrorIcon.TabIndex = 4;
			this.ErrorIcon.TabStop = false;
			// 
			// LBLogMenu
			// 
			this.LBLogMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBLogMenu_コピー});
			this.LBLogMenu.Name = "LBLogMenu";
			this.LBLogMenu.Size = new System.Drawing.Size(115, 26);
			// 
			// LBLogMenu_コピー
			// 
			this.LBLogMenu_コピー.Name = "LBLogMenu_コピー";
			this.LBLogMenu_コピー.Size = new System.Drawing.Size(114, 22);
			this.LBLogMenu_コピー.Text = "コピー(&C)";
			this.LBLogMenu_コピー.Click += new System.EventHandler(this.LBLogMenu_コピー_Click);
			// 
			// SuccessfulIcon
			// 
			this.SuccessfulIcon.Image = ((System.Drawing.Image)(resources.GetObject("SuccessfulIcon.Image")));
			this.SuccessfulIcon.Location = new System.Drawing.Point(700, 12);
			this.SuccessfulIcon.Name = "SuccessfulIcon";
			this.SuccessfulIcon.Size = new System.Drawing.Size(72, 72);
			this.SuccessfulIcon.TabIndex = 5;
			this.SuccessfulIcon.TabStop = false;
			this.SuccessfulIcon.Visible = false;
			// 
			// CompleteWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.SuccessfulIcon);
			this.Controls.Add(this.ErrorIcon);
			this.Controls.Add(this.Btn閉じる);
			this.Controls.Add(this.LBLog);
			this.Controls.Add(this.MainMessage);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "CompleteWin";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChunkRootCopier - コピー処理結果";
			this.Load += new System.EventHandler(this.CompleteWin_Load);
			this.Shown += new System.EventHandler(this.CompleteWin_Shown);
			this.Click += new System.EventHandler(this.CompleteWin_Click);
			((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
			this.LBLogMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SuccessfulIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label MainMessage;
		private System.Windows.Forms.ListBox LBLog;
		private System.Windows.Forms.Button Btn閉じる;
		private System.Windows.Forms.PictureBox ErrorIcon;
		private System.Windows.Forms.ContextMenuStrip LBLogMenu;
		private System.Windows.Forms.ToolStripMenuItem LBLogMenu_コピー;
		private System.Windows.Forms.PictureBox SuccessfulIcon;
	}
}