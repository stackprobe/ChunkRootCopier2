namespace HLTStudio
{
	partial class EditTreeWin
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTreeWin));
			this.BtnOK = new System.Windows.Forms.Button();
			this.Btnキャンセル = new System.Windows.Forms.Button();
			this.MainTreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MainTreeMenu_配下を全て開く = new System.Windows.Forms.ToolStripMenuItem();
			this.MainTreeMenu_配下を全て閉じる = new System.Windows.Forms.ToolStripMenuItem();
			this.S001 = new System.Windows.Forms.ToolStripSeparator();
			this.MainTreeMenu_配下も含めて選択オン = new System.Windows.Forms.ToolStripMenuItem();
			this.MainTreeMenu_配下も含めて選択オフ = new System.Windows.Forms.ToolStripMenuItem();
			this.S002 = new System.Windows.Forms.ToolStripSeparator();
			this.MainTreeMenu_チェックされている項目のみ展開する = new System.Windows.Forms.ToolStripMenuItem();
			this.S003 = new System.Windows.Forms.ToolStripSeparator();
			this.MainTreeMenu_チェック状態の確認 = new System.Windows.Forms.ToolStripMenuItem();
			this.Btnチェックのみ展開する = new System.Windows.Forms.Button();
			this.MainTree = new HLTStudio.CustomControls.NoDoubleClickTreeView();
			this.MainTreeMenu.SuspendLayout();
			this.SuspendLayout();
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
			// MainTreeMenu
			// 
			this.MainTreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainTreeMenu_配下を全て開く,
            this.MainTreeMenu_配下を全て閉じる,
            this.S001,
            this.MainTreeMenu_配下も含めて選択オン,
            this.MainTreeMenu_配下も含めて選択オフ,
            this.S002,
            this.MainTreeMenu_チェックされている項目のみ展開する,
            this.S003,
            this.MainTreeMenu_チェック状態の確認});
			this.MainTreeMenu.Name = "MainTreeMenu";
			this.MainTreeMenu.Size = new System.Drawing.Size(257, 154);
			// 
			// MainTreeMenu_配下を全て開く
			// 
			this.MainTreeMenu_配下を全て開く.Name = "MainTreeMenu_配下を全て開く";
			this.MainTreeMenu_配下を全て開く.Size = new System.Drawing.Size(256, 22);
			this.MainTreeMenu_配下を全て開く.Text = "配下を全て開く(&O)";
			this.MainTreeMenu_配下を全て開く.Click += new System.EventHandler(this.MainTreeMenu_配下を全て開く_Click);
			// 
			// MainTreeMenu_配下を全て閉じる
			// 
			this.MainTreeMenu_配下を全て閉じる.Name = "MainTreeMenu_配下を全て閉じる";
			this.MainTreeMenu_配下を全て閉じる.Size = new System.Drawing.Size(256, 22);
			this.MainTreeMenu_配下を全て閉じる.Text = "配下を全て閉じる(&C)";
			this.MainTreeMenu_配下を全て閉じる.Click += new System.EventHandler(this.MainTreeMenu_配下を全て閉じる_Click);
			// 
			// S001
			// 
			this.S001.Name = "S001";
			this.S001.Size = new System.Drawing.Size(253, 6);
			// 
			// MainTreeMenu_配下も含めて選択オン
			// 
			this.MainTreeMenu_配下も含めて選択オン.Name = "MainTreeMenu_配下も含めて選択オン";
			this.MainTreeMenu_配下も含めて選択オン.Size = new System.Drawing.Size(256, 22);
			this.MainTreeMenu_配下も含めて選択オン.Text = "配下も含めて選択する(&S)";
			this.MainTreeMenu_配下も含めて選択オン.Click += new System.EventHandler(this.MainTreeMenu_配下も含めて選択オン_Click);
			// 
			// MainTreeMenu_配下も含めて選択オフ
			// 
			this.MainTreeMenu_配下も含めて選択オフ.Name = "MainTreeMenu_配下も含めて選択オフ";
			this.MainTreeMenu_配下も含めて選択オフ.Size = new System.Drawing.Size(256, 22);
			this.MainTreeMenu_配下も含めて選択オフ.Text = "配下も含めて選択解除(&U)";
			this.MainTreeMenu_配下も含めて選択オフ.Click += new System.EventHandler(this.MainTreeMenu_配下も含めて選択オフ_Click);
			// 
			// S002
			// 
			this.S002.Name = "S002";
			this.S002.Size = new System.Drawing.Size(253, 6);
			// 
			// MainTreeMenu_チェックされている項目のみ展開する
			// 
			this.MainTreeMenu_チェックされている項目のみ展開する.Name = "MainTreeMenu_チェックされている項目のみ展開する";
			this.MainTreeMenu_チェックされている項目のみ展開する.Size = new System.Drawing.Size(256, 22);
			this.MainTreeMenu_チェックされている項目のみ展開する.Text = "チェックされている項目のみ展開する(&L)";
			this.MainTreeMenu_チェックされている項目のみ展開する.Click += new System.EventHandler(this.MainTreeMenu_チェックされている項目のみ展開する_Click);
			// 
			// S003
			// 
			this.S003.Name = "S003";
			this.S003.Size = new System.Drawing.Size(253, 6);
			// 
			// MainTreeMenu_チェック状態の確認
			// 
			this.MainTreeMenu_チェック状態の確認.Name = "MainTreeMenu_チェック状態の確認";
			this.MainTreeMenu_チェック状態の確認.Size = new System.Drawing.Size(256, 22);
			this.MainTreeMenu_チェック状態の確認.Text = "チェック状態の確認";
			this.MainTreeMenu_チェック状態の確認.Click += new System.EventHandler(this.MainTreeMenu_チェック状態の確認_Click);
			// 
			// Btnチェックのみ展開する
			// 
			this.Btnチェックのみ展開する.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Btnチェックのみ展開する.Location = new System.Drawing.Point(652, 12);
			this.Btnチェックのみ展開する.Name = "Btnチェックのみ展開する";
			this.Btnチェックのみ展開する.Size = new System.Drawing.Size(120, 80);
			this.Btnチェックのみ展開する.TabIndex = 1;
			this.Btnチェックのみ展開する.Text = "チェックのみ\r\n展開する";
			this.Btnチェックのみ展開する.UseVisualStyleBackColor = true;
			this.Btnチェックのみ展開する.Click += new System.EventHandler(this.Btnチェックのみ展開する_Click);
			// 
			// MainTree
			// 
			this.MainTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainTree.CheckBoxes = true;
			this.MainTree.ContextMenuStrip = this.MainTreeMenu;
			this.MainTree.Location = new System.Drawing.Point(12, 12);
			this.MainTree.Name = "MainTree";
			this.MainTree.Size = new System.Drawing.Size(634, 537);
			this.MainTree.TabIndex = 0;
			this.MainTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.MainTree_AfterCheck);
			this.MainTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTree_AfterSelect);
			this.MainTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTree_NodeMouseClick);
			this.MainTree.Click += new System.EventHandler(this.MainTree_Click);
			// 
			// EditTreeWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.Btnチェックのみ展開する);
			this.Controls.Add(this.Btnキャンセル);
			this.Controls.Add(this.BtnOK);
			this.Controls.Add(this.MainTree);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "EditTreeWin";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChunkRootCopier - 対象パスリスト変更 (ツリーモード)";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditTreeWin_FormClosed);
			this.Load += new System.EventHandler(this.EditTreeWin_Load);
			this.Shown += new System.EventHandler(this.EditTreeWin_Shown);
			this.MainTreeMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private CustomControls.NoDoubleClickTreeView MainTree;
		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.Button Btnキャンセル;
		private System.Windows.Forms.ContextMenuStrip MainTreeMenu;
		private System.Windows.Forms.ToolStripMenuItem MainTreeMenu_配下を全て開く;
		private System.Windows.Forms.ToolStripMenuItem MainTreeMenu_配下を全て閉じる;
		private System.Windows.Forms.ToolStripSeparator S001;
		private System.Windows.Forms.ToolStripMenuItem MainTreeMenu_配下も含めて選択オン;
		private System.Windows.Forms.ToolStripMenuItem MainTreeMenu_配下も含めて選択オフ;
		private System.Windows.Forms.ToolStripSeparator S002;
		private System.Windows.Forms.ToolStripMenuItem MainTreeMenu_チェック状態の確認;
		private System.Windows.Forms.ToolStripMenuItem MainTreeMenu_チェックされている項目のみ展開する;
		private System.Windows.Forms.ToolStripSeparator S003;
		private System.Windows.Forms.Button Btnチェックのみ展開する;
	}
}

