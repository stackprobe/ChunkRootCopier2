namespace HLTStudio
{
	partial class EditListWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditListWin));
			this.MainSheet = new System.Windows.Forms.DataGridView();
			this.Btnキャンセル = new System.Windows.Forms.Button();
			this.BtnOK = new System.Windows.Forms.Button();
			this.MainSheetMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MainSheetMenu_選択されている行を対象にする = new System.Windows.Forms.ToolStripMenuItem();
			this.MainSheetMenu_選択されている行を対象から外す = new System.Windows.Forms.ToolStripMenuItem();
			this.Btn検索 = new System.Windows.Forms.Button();
			this.LblStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.MainSheet)).BeginInit();
			this.MainSheetMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainSheet
			// 
			this.MainSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MainSheet.Location = new System.Drawing.Point(12, 12);
			this.MainSheet.Name = "MainSheet";
			this.MainSheet.RowTemplate.Height = 21;
			this.MainSheet.Size = new System.Drawing.Size(634, 537);
			this.MainSheet.TabIndex = 0;
			this.MainSheet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainSheet_CellValueChanged);
			this.MainSheet.SelectionChanged += new System.EventHandler(this.MainSheet_SelectionChanged);
			// 
			// Btnキャンセル
			// 
			this.Btnキャンセル.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Btnキャンセル.Location = new System.Drawing.Point(652, 489);
			this.Btnキャンセル.Name = "Btnキャンセル";
			this.Btnキャンセル.Size = new System.Drawing.Size(120, 60);
			this.Btnキャンセル.TabIndex = 3;
			this.Btnキャンセル.Text = "キャンセル";
			this.Btnキャンセル.UseVisualStyleBackColor = true;
			this.Btnキャンセル.Click += new System.EventHandler(this.Btnキャンセル_Click);
			// 
			// BtnOK
			// 
			this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOK.Location = new System.Drawing.Point(652, 423);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(120, 60);
			this.BtnOK.TabIndex = 2;
			this.BtnOK.Text = "OK";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// MainSheetMenu
			// 
			this.MainSheetMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainSheetMenu_選択されている行を対象にする,
            this.MainSheetMenu_選択されている行を対象から外す});
			this.MainSheetMenu.Name = "MainSheetMenu";
			this.MainSheetMenu.Size = new System.Drawing.Size(248, 48);
			// 
			// MainSheetMenu_選択されている行を対象にする
			// 
			this.MainSheetMenu_選択されている行を対象にする.Name = "MainSheetMenu_選択されている行を対象にする";
			this.MainSheetMenu_選択されている行を対象にする.Size = new System.Drawing.Size(247, 22);
			this.MainSheetMenu_選択されている行を対象にする.Text = "選択されている行を対象にする(&S)";
			this.MainSheetMenu_選択されている行を対象にする.Click += new System.EventHandler(this.MainSheetMenu_選択されている行を対象にする_Click);
			// 
			// MainSheetMenu_選択されている行を対象から外す
			// 
			this.MainSheetMenu_選択されている行を対象から外す.Name = "MainSheetMenu_選択されている行を対象から外す";
			this.MainSheetMenu_選択されている行を対象から外す.Size = new System.Drawing.Size(247, 22);
			this.MainSheetMenu_選択されている行を対象から外す.Text = "選択されている行を対象から外す(&U)";
			this.MainSheetMenu_選択されている行を対象から外す.Click += new System.EventHandler(this.MainSheetMenu_選択されている行を対象から外す_Click);
			// 
			// Btn検索
			// 
			this.Btn検索.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn検索.Location = new System.Drawing.Point(652, 12);
			this.Btn検索.Name = "Btn検索";
			this.Btn検索.Size = new System.Drawing.Size(120, 60);
			this.Btn検索.TabIndex = 1;
			this.Btn検索.Text = "検　索";
			this.Btn検索.UseVisualStyleBackColor = true;
			this.Btn検索.Click += new System.EventHandler(this.Btn検索_Click);
			// 
			// LblStatus
			// 
			this.LblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LblStatus.AutoSize = true;
			this.LblStatus.Location = new System.Drawing.Point(652, 75);
			this.LblStatus.Name = "LblStatus";
			this.LblStatus.Size = new System.Drawing.Size(113, 60);
			this.LblStatus.TabIndex = 4;
			this.LblStatus.Text = "選択：999999 件\r\n対象：999999 件\r\n総数：999999 件";
			// 
			// EditListWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.LblStatus);
			this.Controls.Add(this.Btn検索);
			this.Controls.Add(this.Btnキャンセル);
			this.Controls.Add(this.BtnOK);
			this.Controls.Add(this.MainSheet);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "EditListWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChunkRootCopier - 対象パスリスト変更 (リストモード)";
			this.Load += new System.EventHandler(this.EditListWin_Load);
			this.Shown += new System.EventHandler(this.EditListWin_Shown);
			this.Click += new System.EventHandler(this.EditListWin_Click);
			((System.ComponentModel.ISupportInitialize)(this.MainSheet)).EndInit();
			this.MainSheetMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView MainSheet;
		private System.Windows.Forms.Button Btnキャンセル;
		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.ContextMenuStrip MainSheetMenu;
		private System.Windows.Forms.ToolStripMenuItem MainSheetMenu_選択されている行を対象にする;
		private System.Windows.Forms.ToolStripMenuItem MainSheetMenu_選択されている行を対象から外す;
		private System.Windows.Forms.Button Btn検索;
		private System.Windows.Forms.Label LblStatus;
	}
}