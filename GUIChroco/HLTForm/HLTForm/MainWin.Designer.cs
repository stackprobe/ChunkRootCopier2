namespace HLTStudio
{
	partial class MainWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
			this.MenuBar = new System.Windows.Forms.MenuStrip();
			this.MenuBar_アプリケーション = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuBar_アプリケーション_終了 = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuBar_ツール = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuBar_ツール_設定 = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.MainStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.SubStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.Grpコピー元 = new System.Windows.Forms.GroupBox();
			this.L004 = new System.Windows.Forms.Label();
			this.Grp対象パスリスト = new System.Windows.Forms.GroupBox();
			this.TargetRelPathList = new System.Windows.Forms.ListBox();
			this.TargetRelPathListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TargetRelPathListMenu_コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.TargetRelPathListStatus = new System.Windows.Forms.Label();
			this.Chk大文字小文字は対象パスリストに合わせる = new System.Windows.Forms.CheckBox();
			this.Chkコピー前にコピー先をクリアする = new System.Windows.Forms.CheckBox();
			this.BtnEditList = new System.Windows.Forms.Button();
			this.BtnEditTree = new System.Windows.Forms.Button();
			this.BtnInputRootDir = new System.Windows.Forms.Button();
			this.TxtInputRootDir = new System.Windows.Forms.TextBox();
			this.TxtInputRootDirMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TxtInputRootDirMenu_コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.L002 = new System.Windows.Forms.Label();
			this.L001 = new System.Windows.Forms.Label();
			this.Grpコピー先 = new System.Windows.Forms.GroupBox();
			this.OutputRootDirErrorMessage = new System.Windows.Forms.Label();
			this.BtnOutputRootDir = new System.Windows.Forms.Button();
			this.TxtOutputRootDir = new System.Windows.Forms.TextBox();
			this.TxtOutputRootDirMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TxtOutputRootDirMenu_コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.L003 = new System.Windows.Forms.Label();
			this.BtnExecute = new System.Windows.Forms.Button();
			this.Btnインポート = new System.Windows.Forms.Button();
			this.Btnエクスポート = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.MenuBar.SuspendLayout();
			this.StatusBar.SuspendLayout();
			this.Grpコピー元.SuspendLayout();
			this.Grp対象パスリスト.SuspendLayout();
			this.TargetRelPathListMenu.SuspendLayout();
			this.TxtInputRootDirMenu.SuspendLayout();
			this.Grpコピー先.SuspendLayout();
			this.TxtOutputRootDirMenu.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuBar
			// 
			this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBar_アプリケーション,
            this.MenuBar_ツール});
			this.MenuBar.Location = new System.Drawing.Point(0, 0);
			this.MenuBar.Name = "MenuBar";
			this.MenuBar.Size = new System.Drawing.Size(784, 24);
			this.MenuBar.TabIndex = 0;
			this.MenuBar.Text = "MenuBar";
			// 
			// MenuBar_アプリケーション
			// 
			this.MenuBar_アプリケーション.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBar_アプリケーション_終了});
			this.MenuBar_アプリケーション.Name = "MenuBar_アプリケーション";
			this.MenuBar_アプリケーション.Size = new System.Drawing.Size(104, 20);
			this.MenuBar_アプリケーション.Text = "アプリケーション(&A)";
			// 
			// MenuBar_アプリケーション_終了
			// 
			this.MenuBar_アプリケーション_終了.Name = "MenuBar_アプリケーション_終了";
			this.MenuBar_アプリケーション_終了.Size = new System.Drawing.Size(113, 22);
			this.MenuBar_アプリケーション_終了.Text = "終了(&X)";
			this.MenuBar_アプリケーション_終了.Click += new System.EventHandler(this.MenuBar_アプリケーション_終了_Click);
			// 
			// MenuBar_ツール
			// 
			this.MenuBar_ツール.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBar_ツール_設定});
			this.MenuBar_ツール.Name = "MenuBar_ツール";
			this.MenuBar_ツール.Size = new System.Drawing.Size(60, 20);
			this.MenuBar_ツール.Text = "ツール(&T)";
			// 
			// MenuBar_ツール_設定
			// 
			this.MenuBar_ツール_設定.Name = "MenuBar_ツール_設定";
			this.MenuBar_ツール_設定.Size = new System.Drawing.Size(112, 22);
			this.MenuBar_ツール_設定.Text = "設定(&S)";
			this.MenuBar_ツール_設定.Click += new System.EventHandler(this.MenuBar_ツール_設定_Click);
			// 
			// StatusBar
			// 
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainStatus,
            this.SubStatus});
			this.StatusBar.Location = new System.Drawing.Point(0, 539);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(784, 22);
			this.StatusBar.TabIndex = 5;
			this.StatusBar.Text = "statusStrip1";
			// 
			// MainStatus
			// 
			this.MainStatus.Name = "MainStatus";
			this.MainStatus.Size = new System.Drawing.Size(710, 17);
			this.MainStatus.Spring = true;
			this.MainStatus.Text = "MainStatus";
			this.MainStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SubStatus
			// 
			this.SubStatus.Name = "SubStatus";
			this.SubStatus.Size = new System.Drawing.Size(59, 17);
			this.SubStatus.Text = "SubStatus";
			// 
			// Grpコピー元
			// 
			this.Grpコピー元.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Grpコピー元.Controls.Add(this.L004);
			this.Grpコピー元.Controls.Add(this.Grp対象パスリスト);
			this.Grpコピー元.Controls.Add(this.BtnInputRootDir);
			this.Grpコピー元.Controls.Add(this.TxtInputRootDir);
			this.Grpコピー元.Controls.Add(this.L002);
			this.Grpコピー元.Location = new System.Drawing.Point(12, 27);
			this.Grpコピー元.Name = "Grpコピー元";
			this.Grpコピー元.Size = new System.Drawing.Size(634, 303);
			this.Grpコピー元.TabIndex = 1;
			this.Grpコピー元.TabStop = false;
			this.Grpコピー元.Text = "コピー元";
			// 
			// L004
			// 
			this.L004.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.L004.AutoSize = true;
			this.L004.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.L004.ForeColor = System.Drawing.Color.Teal;
			this.L004.Location = new System.Drawing.Point(262, 23);
			this.L004.Name = "L004";
			this.L004.Size = new System.Drawing.Size(360, 17);
			this.L004.TabIndex = 0;
			this.L004.Text = "※コンテキストファイルをドラッグ＆ドロップしても読み込まれます。";
			// 
			// Grp対象パスリスト
			// 
			this.Grp対象パスリスト.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Grp対象パスリスト.Controls.Add(this.TargetRelPathList);
			this.Grp対象パスリスト.Controls.Add(this.TargetRelPathListStatus);
			this.Grp対象パスリスト.Controls.Add(this.Chk大文字小文字は対象パスリストに合わせる);
			this.Grp対象パスリスト.Controls.Add(this.Chkコピー前にコピー先をクリアする);
			this.Grp対象パスリスト.Controls.Add(this.BtnEditList);
			this.Grp対象パスリスト.Controls.Add(this.BtnEditTree);
			this.Grp対象パスリスト.Location = new System.Drawing.Point(6, 142);
			this.Grp対象パスリスト.Name = "Grp対象パスリスト";
			this.Grp対象パスリスト.Size = new System.Drawing.Size(622, 155);
			this.Grp対象パスリスト.TabIndex = 4;
			this.Grp対象パスリスト.TabStop = false;
			this.Grp対象パスリスト.Text = "対象パスリスト";
			// 
			// TargetRelPathList
			// 
			this.TargetRelPathList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TargetRelPathList.ContextMenuStrip = this.TargetRelPathListMenu;
			this.TargetRelPathList.FormattingEnabled = true;
			this.TargetRelPathList.ItemHeight = 20;
			this.TargetRelPathList.Items.AddRange(new object[] {
            "src\\Main.java",
            "src\\SubModule.java",
            "src\\Utilities.java",
            "res\\Logo.png"});
			this.TargetRelPathList.Location = new System.Drawing.Point(6, 55);
			this.TargetRelPathList.Name = "TargetRelPathList";
			this.TargetRelPathList.Size = new System.Drawing.Size(484, 64);
			this.TargetRelPathList.TabIndex = 1;
			// 
			// TargetRelPathListMenu
			// 
			this.TargetRelPathListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TargetRelPathListMenu_コピー});
			this.TargetRelPathListMenu.Name = "TargetRelPathListMenu";
			this.TargetRelPathListMenu.Size = new System.Drawing.Size(115, 26);
			// 
			// TargetRelPathListMenu_コピー
			// 
			this.TargetRelPathListMenu_コピー.Name = "TargetRelPathListMenu_コピー";
			this.TargetRelPathListMenu_コピー.Size = new System.Drawing.Size(114, 22);
			this.TargetRelPathListMenu_コピー.Text = "コピー(&C)";
			this.TargetRelPathListMenu_コピー.Click += new System.EventHandler(this.TargetRelPathListMenu_コピー_Click);
			// 
			// TargetRelPathListStatus
			// 
			this.TargetRelPathListStatus.AutoSize = true;
			this.TargetRelPathListStatus.Location = new System.Drawing.Point(6, 32);
			this.TargetRelPathListStatus.Name = "TargetRelPathListStatus";
			this.TargetRelPathListStatus.Size = new System.Drawing.Size(346, 20);
			this.TargetRelPathListStatus.TabIndex = 0;
			this.TargetRelPathListStatus.Text = "対象ファイル数：999999　( 欠損ファイル数：999999 )";
			this.TargetRelPathListStatus.Click += new System.EventHandler(this.TargetRelPathListStatus_Click);
			// 
			// Chk大文字小文字は対象パスリストに合わせる
			// 
			this.Chk大文字小文字は対象パスリストに合わせる.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Chk大文字小文字は対象パスリストに合わせる.AutoSize = true;
			this.Chk大文字小文字は対象パスリストに合わせる.Location = new System.Drawing.Point(235, 125);
			this.Chk大文字小文字は対象パスリストに合わせる.Name = "Chk大文字小文字は対象パスリストに合わせる";
			this.Chk大文字小文字は対象パスリストに合わせる.Size = new System.Drawing.Size(275, 24);
			this.Chk大文字小文字は対象パスリストに合わせる.TabIndex = 3;
			this.Chk大文字小文字は対象パスリストに合わせる.Text = "大文字小文字は対象パスリストに合わせる";
			this.Chk大文字小文字は対象パスリストに合わせる.UseVisualStyleBackColor = true;
			// 
			// Chkコピー前にコピー先をクリアする
			// 
			this.Chkコピー前にコピー先をクリアする.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Chkコピー前にコピー先をクリアする.AutoSize = true;
			this.Chkコピー前にコピー先をクリアする.Location = new System.Drawing.Point(6, 125);
			this.Chkコピー前にコピー先をクリアする.Name = "Chkコピー前にコピー先をクリアする";
			this.Chkコピー前にコピー先をクリアする.Size = new System.Drawing.Size(223, 24);
			this.Chkコピー前にコピー先をクリアする.TabIndex = 2;
			this.Chkコピー前にコピー先をクリアする.Text = "コピー前にコピー先をクリアする";
			this.Chkコピー前にコピー先をクリアする.UseVisualStyleBackColor = true;
			// 
			// BtnEditList
			// 
			this.BtnEditList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnEditList.Location = new System.Drawing.Point(496, 79);
			this.BtnEditList.Name = "BtnEditList";
			this.BtnEditList.Size = new System.Drawing.Size(120, 40);
			this.BtnEditList.TabIndex = 5;
			this.BtnEditList.Text = "変更(リスト)";
			this.BtnEditList.UseVisualStyleBackColor = true;
			this.BtnEditList.Click += new System.EventHandler(this.BtnEditList_Click);
			// 
			// BtnEditTree
			// 
			this.BtnEditTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnEditTree.Location = new System.Drawing.Point(496, 33);
			this.BtnEditTree.Name = "BtnEditTree";
			this.BtnEditTree.Size = new System.Drawing.Size(120, 40);
			this.BtnEditTree.TabIndex = 4;
			this.BtnEditTree.Text = "変更(ツリー)";
			this.BtnEditTree.UseVisualStyleBackColor = true;
			this.BtnEditTree.Click += new System.EventHandler(this.BtnEditTree_Click);
			// 
			// BtnInputRootDir
			// 
			this.BtnInputRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnInputRootDir.Location = new System.Drawing.Point(502, 96);
			this.BtnInputRootDir.Name = "BtnInputRootDir";
			this.BtnInputRootDir.Size = new System.Drawing.Size(80, 30);
			this.BtnInputRootDir.TabIndex = 3;
			this.BtnInputRootDir.Text = "変更...";
			this.BtnInputRootDir.UseVisualStyleBackColor = true;
			this.BtnInputRootDir.Click += new System.EventHandler(this.BtnInputRootDir_Click);
			// 
			// TxtInputRootDir
			// 
			this.TxtInputRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtInputRootDir.ContextMenuStrip = this.TxtInputRootDirMenu;
			this.TxtInputRootDir.Location = new System.Drawing.Point(44, 63);
			this.TxtInputRootDir.Name = "TxtInputRootDir";
			this.TxtInputRootDir.ReadOnly = true;
			this.TxtInputRootDir.Size = new System.Drawing.Size(538, 27);
			this.TxtInputRootDir.TabIndex = 2;
			// 
			// TxtInputRootDirMenu
			// 
			this.TxtInputRootDirMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtInputRootDirMenu_コピー});
			this.TxtInputRootDirMenu.Name = "TxtInputRootDirMenu";
			this.TxtInputRootDirMenu.Size = new System.Drawing.Size(115, 26);
			// 
			// TxtInputRootDirMenu_コピー
			// 
			this.TxtInputRootDirMenu_コピー.Name = "TxtInputRootDirMenu_コピー";
			this.TxtInputRootDirMenu_コピー.Size = new System.Drawing.Size(114, 22);
			this.TxtInputRootDirMenu_コピー.Text = "コピー(&C)";
			this.TxtInputRootDirMenu_コピー.Click += new System.EventHandler(this.TxtInputRootDirMenu_コピー_Click);
			// 
			// L002
			// 
			this.L002.AutoSize = true;
			this.L002.Location = new System.Drawing.Point(40, 40);
			this.L002.Name = "L002";
			this.L002.Size = new System.Drawing.Size(100, 20);
			this.L002.TabIndex = 1;
			this.L002.Text = "コピー元パス：";
			// 
			// L001
			// 
			this.L001.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.L001.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.L001.ForeColor = System.Drawing.Color.Navy;
			this.L001.Location = new System.Drawing.Point(11, 333);
			this.L001.Name = "L001";
			this.L001.Size = new System.Drawing.Size(634, 50);
			this.L001.TabIndex = 2;
			this.L001.Text = "▼";
			this.L001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Grpコピー先
			// 
			this.Grpコピー先.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Grpコピー先.Controls.Add(this.OutputRootDirErrorMessage);
			this.Grpコピー先.Controls.Add(this.BtnOutputRootDir);
			this.Grpコピー先.Controls.Add(this.TxtOutputRootDir);
			this.Grpコピー先.Controls.Add(this.L003);
			this.Grpコピー先.Location = new System.Drawing.Point(12, 386);
			this.Grpコピー先.Name = "Grpコピー先";
			this.Grpコピー先.Size = new System.Drawing.Size(634, 150);
			this.Grpコピー先.TabIndex = 3;
			this.Grpコピー先.TabStop = false;
			this.Grpコピー先.Text = "コピー先";
			// 
			// OutputRootDirErrorMessage
			// 
			this.OutputRootDirErrorMessage.AutoSize = true;
			this.OutputRootDirErrorMessage.ForeColor = System.Drawing.Color.Red;
			this.OutputRootDirErrorMessage.Location = new System.Drawing.Point(40, 101);
			this.OutputRootDirErrorMessage.Name = "OutputRootDirErrorMessage";
			this.OutputRootDirErrorMessage.Size = new System.Drawing.Size(187, 20);
			this.OutputRootDirErrorMessage.TabIndex = 3;
			this.OutputRootDirErrorMessage.Text = "OutputRootDirErrorMessage";
			// 
			// BtnOutputRootDir
			// 
			this.BtnOutputRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOutputRootDir.Location = new System.Drawing.Point(502, 96);
			this.BtnOutputRootDir.Name = "BtnOutputRootDir";
			this.BtnOutputRootDir.Size = new System.Drawing.Size(80, 30);
			this.BtnOutputRootDir.TabIndex = 2;
			this.BtnOutputRootDir.Text = "変更...";
			this.BtnOutputRootDir.UseVisualStyleBackColor = true;
			this.BtnOutputRootDir.Click += new System.EventHandler(this.BtnOutputRootDir_Click);
			// 
			// TxtOutputRootDir
			// 
			this.TxtOutputRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtOutputRootDir.ContextMenuStrip = this.TxtOutputRootDirMenu;
			this.TxtOutputRootDir.Location = new System.Drawing.Point(44, 63);
			this.TxtOutputRootDir.Name = "TxtOutputRootDir";
			this.TxtOutputRootDir.ReadOnly = true;
			this.TxtOutputRootDir.Size = new System.Drawing.Size(538, 27);
			this.TxtOutputRootDir.TabIndex = 1;
			// 
			// TxtOutputRootDirMenu
			// 
			this.TxtOutputRootDirMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtOutputRootDirMenu_コピー});
			this.TxtOutputRootDirMenu.Name = "contextMenuStrip1";
			this.TxtOutputRootDirMenu.Size = new System.Drawing.Size(115, 26);
			// 
			// TxtOutputRootDirMenu_コピー
			// 
			this.TxtOutputRootDirMenu_コピー.Name = "TxtOutputRootDirMenu_コピー";
			this.TxtOutputRootDirMenu_コピー.Size = new System.Drawing.Size(114, 22);
			this.TxtOutputRootDirMenu_コピー.Text = "コピー(&C)";
			this.TxtOutputRootDirMenu_コピー.Click += new System.EventHandler(this.TxtOutputRootDirMenu_コピー_Click);
			// 
			// L003
			// 
			this.L003.AutoSize = true;
			this.L003.Location = new System.Drawing.Point(40, 40);
			this.L003.Name = "L003";
			this.L003.Size = new System.Drawing.Size(100, 20);
			this.L003.TabIndex = 0;
			this.L003.Text = "コピー先パス：";
			// 
			// BtnExecute
			// 
			this.BtnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnExecute.Location = new System.Drawing.Point(3, 476);
			this.BtnExecute.Name = "BtnExecute";
			this.BtnExecute.Size = new System.Drawing.Size(117, 60);
			this.BtnExecute.TabIndex = 2;
			this.BtnExecute.Text = "実　行";
			this.BtnExecute.UseVisualStyleBackColor = true;
			this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
			// 
			// Btnインポート
			// 
			this.Btnインポート.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Btnインポート.Location = new System.Drawing.Point(3, 34);
			this.Btnインポート.Name = "Btnインポート";
			this.Btnインポート.Size = new System.Drawing.Size(117, 60);
			this.Btnインポート.TabIndex = 0;
			this.Btnインポート.Text = "インポート";
			this.Btnインポート.UseVisualStyleBackColor = true;
			this.Btnインポート.Click += new System.EventHandler(this.Btnインポート_Click);
			// 
			// Btnエクスポート
			// 
			this.Btnエクスポート.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Btnエクスポート.Location = new System.Drawing.Point(3, 100);
			this.Btnエクスポート.Name = "Btnエクスポート";
			this.Btnエクスポート.Size = new System.Drawing.Size(117, 60);
			this.Btnエクスポート.TabIndex = 1;
			this.Btnエクスポート.Text = "エクスポート";
			this.Btnエクスポート.UseVisualStyleBackColor = true;
			this.Btnエクスポート.Click += new System.EventHandler(this.Btnエクスポート_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.panel1.Controls.Add(this.Btnインポート);
			this.panel1.Controls.Add(this.BtnExecute);
			this.panel1.Controls.Add(this.Btnエクスポート);
			this.panel1.Location = new System.Drawing.Point(652, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(160, 580);
			this.panel1.TabIndex = 4;
			// 
			// MainWin
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.Grpコピー先);
			this.Controls.Add(this.L001);
			this.Controls.Add(this.Grpコピー元);
			this.Controls.Add(this.StatusBar);
			this.Controls.Add(this.MenuBar);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuBar;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChunkRootCopier";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWin_FormClosed);
			this.Load += new System.EventHandler(this.MainWin_Load);
			this.Shown += new System.EventHandler(this.MainWin_Shown);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWin_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWin_DragEnter);
			this.MenuBar.ResumeLayout(false);
			this.MenuBar.PerformLayout();
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.Grpコピー元.ResumeLayout(false);
			this.Grpコピー元.PerformLayout();
			this.Grp対象パスリスト.ResumeLayout(false);
			this.Grp対象パスリスト.PerformLayout();
			this.TargetRelPathListMenu.ResumeLayout(false);
			this.TxtInputRootDirMenu.ResumeLayout(false);
			this.Grpコピー先.ResumeLayout(false);
			this.Grpコピー先.PerformLayout();
			this.TxtOutputRootDirMenu.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MenuBar;
		private System.Windows.Forms.ToolStripMenuItem MenuBar_アプリケーション;
		private System.Windows.Forms.ToolStripMenuItem MenuBar_アプリケーション_終了;
		private System.Windows.Forms.ToolStripMenuItem MenuBar_ツール;
		private System.Windows.Forms.ToolStripMenuItem MenuBar_ツール_設定;
		private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.ToolStripStatusLabel MainStatus;
		private System.Windows.Forms.ToolStripStatusLabel SubStatus;
		private System.Windows.Forms.GroupBox Grpコピー元;
		private System.Windows.Forms.Label L001;
		private System.Windows.Forms.GroupBox Grpコピー先;
		private System.Windows.Forms.Button BtnExecute;
		private System.Windows.Forms.Button Btnインポート;
		private System.Windows.Forms.Button Btnエクスポート;
		private System.Windows.Forms.TextBox TxtInputRootDir;
		private System.Windows.Forms.Label L002;
		private System.Windows.Forms.GroupBox Grp対象パスリスト;
		private System.Windows.Forms.Button BtnInputRootDir;
		private System.Windows.Forms.Button BtnEditList;
		private System.Windows.Forms.Button BtnEditTree;
		private System.Windows.Forms.Button BtnOutputRootDir;
		private System.Windows.Forms.TextBox TxtOutputRootDir;
		private System.Windows.Forms.Label L003;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox Chkコピー前にコピー先をクリアする;
		private System.Windows.Forms.CheckBox Chk大文字小文字は対象パスリストに合わせる;
		private System.Windows.Forms.Label L004;
		private System.Windows.Forms.Label TargetRelPathListStatus;
		private System.Windows.Forms.ListBox TargetRelPathList;
		private System.Windows.Forms.ContextMenuStrip TxtInputRootDirMenu;
		private System.Windows.Forms.ToolStripMenuItem TxtInputRootDirMenu_コピー;
		private System.Windows.Forms.ContextMenuStrip TxtOutputRootDirMenu;
		private System.Windows.Forms.ToolStripMenuItem TxtOutputRootDirMenu_コピー;
		private System.Windows.Forms.ContextMenuStrip TargetRelPathListMenu;
		private System.Windows.Forms.ToolStripMenuItem TargetRelPathListMenu_コピー;
		private System.Windows.Forms.Label OutputRootDirErrorMessage;
	}
}

