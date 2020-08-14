namespace SQLAutoBackup
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.MyTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MyMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MyNotifyIconContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowHideNotifyIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitNotifyIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.MyParentPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.AuthCoBox = new System.Windows.Forms.ComboBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DBCoBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackupNameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HostCoBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.SaveCkBox = new System.Windows.Forms.CheckBox();
            this.TestConnectionBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BackupPathTxt = new System.Windows.Forms.TextBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.RepeatRadio = new System.Windows.Forms.RadioButton();
            this.DaysLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SatBox = new System.Windows.Forms.CheckBox();
            this.SunBox = new System.Windows.Forms.CheckBox();
            this.MonBox = new System.Windows.Forms.CheckBox();
            this.TueBox = new System.Windows.Forms.CheckBox();
            this.WedBox = new System.Windows.Forms.CheckBox();
            this.ThuBox = new System.Windows.Forms.CheckBox();
            this.FriBox = new System.Windows.Forms.CheckBox();
            this.SpecificRadio = new System.Windows.Forms.RadioButton();
            this.SpecifyLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.MinutesRadio = new System.Windows.Forms.RadioButton();
            this.HoursRadio = new System.Windows.Forms.RadioButton();
            this.DaysRadio = new System.Windows.Forms.RadioButton();
            this.WeeksRadio = new System.Windows.Forms.RadioButton();
            this.MonthsRadio = new System.Windows.Forms.RadioButton();
            this.SpecificNum = new System.Windows.Forms.NumericUpDown();
            this.IsEnabledBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MyToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloneBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BackupStatusBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MyMenuStrip.SuspendLayout();
            this.MyNotifyIconContext.SuspendLayout();
            this.MyParentPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.DaysLayout.SuspendLayout();
            this.SpecifyLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecificNum)).BeginInit();
            this.MyToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyTreeView
            // 
            this.MyTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.MyTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.MyTreeView.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.MyTreeView.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyTreeView.FullRowSelect = true;
            this.MyTreeView.HideSelection = false;
            this.MyTreeView.ImageIndex = 0;
            this.MyTreeView.ImageList = this.imageList1;
            this.MyTreeView.Indent = 100;
            this.MyTreeView.ItemHeight = 55;
            this.MyTreeView.Location = new System.Drawing.Point(0, 94);
            this.MyTreeView.Name = "MyTreeView";
            this.MyTreeView.SelectedImageIndex = 0;
            this.MyTreeView.ShowLines = false;
            this.MyTreeView.ShowNodeToolTips = true;
            this.MyTreeView.ShowPlusMinus = false;
            this.MyTreeView.ShowRootLines = false;
            this.MyTreeView.Size = new System.Drawing.Size(186, 467);
            this.MyTreeView.TabIndex = 0;
            this.MyTreeView.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.MyTreeView_DrawNode);
            this.MyTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MyTreeView_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Database_48.png");
            // 
            // MyMenuStrip
            // 
            this.MyMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.MyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.MyMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MyMenuStrip.Name = "MyMenuStrip";
            this.MyMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MyMenuStrip.TabIndex = 1;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBackupToolStripMenuItem,
            this.toolStripSeparator3,
            this.ExitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // NewBackupToolStripMenuItem
            // 
            this.NewBackupToolStripMenuItem.Name = "NewBackupToolStripMenuItem";
            this.NewBackupToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.NewBackupToolStripMenuItem.Text = "New &Backup";
            this.NewBackupToolStripMenuItem.Click += new System.EventHandler(this.ConnectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(137, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ExitToolStripMenuItem.Text = "&Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MyNotifyIcon
            // 
            this.MyNotifyIcon.ContextMenuStrip = this.MyNotifyIconContext;
            this.MyNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MyNotifyIcon.Icon")));
            this.MyNotifyIcon.Text = "SQL Auto Backup";
            this.MyNotifyIcon.Visible = true;
            this.MyNotifyIcon.Click += new System.EventHandler(this.MyNotifyIcon_Click);
            // 
            // MyNotifyIconContext
            // 
            this.MyNotifyIconContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowHideNotifyIcon,
            this.ExitNotifyIcon});
            this.MyNotifyIconContext.Name = "MyNotifyIconContext";
            this.MyNotifyIconContext.Size = new System.Drawing.Size(104, 48);
            this.MyNotifyIconContext.Opening += new System.ComponentModel.CancelEventHandler(this.MyNotifyIconContext_Opening);
            // 
            // ShowHideNotifyIcon
            // 
            this.ShowHideNotifyIcon.Name = "ShowHideNotifyIcon";
            this.ShowHideNotifyIcon.Size = new System.Drawing.Size(103, 22);
            this.ShowHideNotifyIcon.Text = "Show";
            this.ShowHideNotifyIcon.Click += new System.EventHandler(this.ShowHideNotifyIcon_Click);
            // 
            // ExitNotifyIcon
            // 
            this.ExitNotifyIcon.Name = "ExitNotifyIcon";
            this.ExitNotifyIcon.Size = new System.Drawing.Size(103, 22);
            this.ExitNotifyIcon.Text = "&Exit";
            this.ExitNotifyIcon.Click += new System.EventHandler(this.ExitNotifyIcon_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(186, 94);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 467);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // MyParentPanel
            // 
            this.MyParentPanel.Controls.Add(this.tableLayoutPanel1);
            this.MyParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyParentPanel.Location = new System.Drawing.Point(189, 94);
            this.MyParentPanel.Name = "MyParentPanel";
            this.MyParentPanel.Size = new System.Drawing.Size(595, 467);
            this.MyParentPanel.TabIndex = 1;
            this.MyParentPanel.Visible = false;
            this.MyParentPanel.VisibleChanged += new System.EventHandler(this.MyParentPanel_VisibleChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 15);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.PassLbl, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.AuthCoBox, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.UsernameLbl, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.DBCoBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BackupNameTxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.HostCoBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.UsernameTxt, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.PassTxt, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.SaveCkBox, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.TestConnectionBtn, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.BackupPathTxt, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.BrowseBtn, 4, 11);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.TimePicker, 3, 14);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.RepeatRadio, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.DaysLayout, 3, 15);
            this.tableLayoutPanel1.Controls.Add(this.SpecificRadio, 2, 17);
            this.tableLayoutPanel1.Controls.Add(this.SpecifyLayout, 3, 18);
            this.tableLayoutPanel1.Controls.Add(this.SpecificNum, 2, 18);
            this.tableLayoutPanel1.Controls.Add(this.IsEnabledBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 17);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 467);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(135, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "Repeat:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(135, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 26);
            this.label9.TabIndex = 14;
            this.label9.Text = "Time:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(135, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Backup Path:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassLbl.Location = new System.Drawing.Point(135, 162);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(94, 26);
            this.PassLbl.TabIndex = 10;
            this.PassLbl.Text = "Password:";
            this.PassLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AuthCoBox
            // 
            this.AuthCoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthCoBox.FormattingEnabled = true;
            this.AuthCoBox.Items.AddRange(new object[] {
            "SQL Server Authentication",
            "Windows Authentication"});
            this.AuthCoBox.Location = new System.Drawing.Point(235, 113);
            this.AuthCoBox.Name = "AuthCoBox";
            this.AuthCoBox.Size = new System.Drawing.Size(256, 21);
            this.AuthCoBox.TabIndex = 2;
            this.AuthCoBox.SelectedIndexChanged += new System.EventHandler(this.AuthCoBox_SelectedIndexChanged);
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameLbl.Location = new System.Drawing.Point(135, 136);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(94, 26);
            this.UsernameLbl.TabIndex = 8;
            this.UsernameLbl.Text = "User Name:";
            this.UsernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(135, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Authentication:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DBCoBox
            // 
            this.DBCoBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DBCoBox.FormattingEnabled = true;
            this.DBCoBox.Location = new System.Drawing.Point(235, 87);
            this.DBCoBox.Name = "DBCoBox";
            this.DBCoBox.Size = new System.Drawing.Size(256, 21);
            this.DBCoBox.TabIndex = 1;
            this.DBCoBox.Enter += new System.EventHandler(this.DBCoBox_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(135, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Database:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BackupNameTxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BackupNameTxt, 2);
            this.BackupNameTxt.Location = new System.Drawing.Point(135, 19);
            this.BackupNameTxt.MaxLength = 255;
            this.BackupNameTxt.Name = "BackupNameTxt";
            this.BackupNameTxt.Size = new System.Drawing.Size(265, 20);
            this.BackupNameTxt.TabIndex = 1;
            this.BackupNameTxt.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SQLAutoBackup.Properties.Resources.SqlConnection_48;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = global::SQLAutoBackup.Properties.Resources.SqlConnection_48;
            this.pictureBox1.Location = new System.Drawing.Point(3, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(109, 72);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // HostCoBox
            // 
            this.HostCoBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.HostCoBox.Location = new System.Drawing.Point(235, 61);
            this.HostCoBox.Name = "HostCoBox";
            this.HostCoBox.Size = new System.Drawing.Size(256, 21);
            this.HostCoBox.TabIndex = 0;
            this.HostCoBox.Enter += new System.EventHandler(this.HostCoBox_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(135, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Host:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(235, 139);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(185, 20);
            this.UsernameTxt.TabIndex = 3;
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(235, 165);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(185, 20);
            this.PassTxt.TabIndex = 4;
            this.PassTxt.UseSystemPasswordChar = true;
            // 
            // SaveCkBox
            // 
            this.SaveCkBox.AutoSize = true;
            this.SaveCkBox.Checked = true;
            this.SaveCkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveCkBox.Location = new System.Drawing.Point(235, 191);
            this.SaveCkBox.Name = "SaveCkBox";
            this.SaveCkBox.Size = new System.Drawing.Size(99, 17);
            this.SaveCkBox.TabIndex = 5;
            this.SaveCkBox.Text = "Save password";
            this.SaveCkBox.UseVisualStyleBackColor = true;
            // 
            // TestConnectionBtn
            // 
            this.TestConnectionBtn.Location = new System.Drawing.Point(235, 217);
            this.TestConnectionBtn.Name = "TestConnectionBtn";
            this.TestConnectionBtn.Size = new System.Drawing.Size(141, 24);
            this.TestConnectionBtn.TabIndex = 6;
            this.TestConnectionBtn.Text = "Test Connection";
            this.TestConnectionBtn.UseVisualStyleBackColor = true;
            this.TestConnectionBtn.Click += new System.EventHandler(this.TestConnectionBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label7, 2);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "SQL Connection";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BackupPathTxt
            // 
            this.BackupPathTxt.BackColor = System.Drawing.Color.Red;
            this.BackupPathTxt.Location = new System.Drawing.Point(235, 263);
            this.BackupPathTxt.Name = "BackupPathTxt";
            this.BackupPathTxt.Size = new System.Drawing.Size(256, 20);
            this.BackupPathTxt.TabIndex = 7;
            this.BackupPathTxt.TextChanged += new System.EventHandler(this.BackupPathTxt_TextChanged);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(497, 263);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(39, 20);
            this.BrowseBtn.TabIndex = 8;
            this.BrowseBtn.Text = "...";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SQLAutoBackup.Properties.Resources.backup_folder_48;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox2, 2);
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 247);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox2, 3);
            this.pictureBox2.Size = new System.Drawing.Size(109, 52);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "hh:mm tt";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(235, 331);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(200, 20);
            this.TimePicker.TabIndex = 11;
            this.TimePicker.Value = new System.DateTime(2020, 8, 6, 0, 0, 0, 0);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::SQLAutoBackup.Properties.Resources.Backup_clock__48;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox3, 2);
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(3, 322);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox3, 4);
            this.pictureBox3.Size = new System.Drawing.Size(109, 71);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // RepeatRadio
            // 
            this.RepeatRadio.AutoSize = true;
            this.RepeatRadio.Dock = System.Windows.Forms.DockStyle.Right;
            this.RepeatRadio.Location = new System.Drawing.Point(169, 305);
            this.RepeatRadio.Name = "RepeatRadio";
            this.RepeatRadio.Size = new System.Drawing.Size(60, 20);
            this.RepeatRadio.TabIndex = 9;
            this.RepeatRadio.Text = "Repeat";
            this.RepeatRadio.UseVisualStyleBackColor = true;
            this.RepeatRadio.CheckedChanged += new System.EventHandler(this.RepeatRadio_CheckedChanged);
            // 
            // DaysLayout
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.DaysLayout, 2);
            this.DaysLayout.Controls.Add(this.SatBox);
            this.DaysLayout.Controls.Add(this.SunBox);
            this.DaysLayout.Controls.Add(this.MonBox);
            this.DaysLayout.Controls.Add(this.TueBox);
            this.DaysLayout.Controls.Add(this.WedBox);
            this.DaysLayout.Controls.Add(this.ThuBox);
            this.DaysLayout.Controls.Add(this.FriBox);
            this.DaysLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DaysLayout.Location = new System.Drawing.Point(235, 357);
            this.DaysLayout.Name = "DaysLayout";
            this.DaysLayout.Size = new System.Drawing.Size(357, 20);
            this.DaysLayout.TabIndex = 12;
            // 
            // SatBox
            // 
            this.SatBox.AutoSize = true;
            this.SatBox.Checked = true;
            this.SatBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SatBox.Location = new System.Drawing.Point(3, 3);
            this.SatBox.Name = "SatBox";
            this.SatBox.Size = new System.Drawing.Size(42, 17);
            this.SatBox.TabIndex = 0;
            this.SatBox.Text = "Sat";
            this.SatBox.UseVisualStyleBackColor = true;
            // 
            // SunBox
            // 
            this.SunBox.AutoSize = true;
            this.SunBox.Checked = true;
            this.SunBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SunBox.Location = new System.Drawing.Point(51, 3);
            this.SunBox.Name = "SunBox";
            this.SunBox.Size = new System.Drawing.Size(44, 17);
            this.SunBox.TabIndex = 1;
            this.SunBox.Text = "Sun";
            this.SunBox.UseVisualStyleBackColor = true;
            // 
            // MonBox
            // 
            this.MonBox.AutoSize = true;
            this.MonBox.Checked = true;
            this.MonBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MonBox.Location = new System.Drawing.Point(101, 3);
            this.MonBox.Name = "MonBox";
            this.MonBox.Size = new System.Drawing.Size(46, 17);
            this.MonBox.TabIndex = 2;
            this.MonBox.Text = "Mon";
            this.MonBox.UseVisualStyleBackColor = true;
            // 
            // TueBox
            // 
            this.TueBox.AutoSize = true;
            this.TueBox.Checked = true;
            this.TueBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TueBox.Location = new System.Drawing.Point(153, 3);
            this.TueBox.Name = "TueBox";
            this.TueBox.Size = new System.Drawing.Size(44, 17);
            this.TueBox.TabIndex = 3;
            this.TueBox.Text = "Tue";
            this.TueBox.UseVisualStyleBackColor = true;
            // 
            // WedBox
            // 
            this.WedBox.AutoSize = true;
            this.WedBox.Checked = true;
            this.WedBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WedBox.Location = new System.Drawing.Point(203, 3);
            this.WedBox.Name = "WedBox";
            this.WedBox.Size = new System.Drawing.Size(48, 17);
            this.WedBox.TabIndex = 4;
            this.WedBox.Text = "Wed";
            this.WedBox.UseVisualStyleBackColor = true;
            // 
            // ThuBox
            // 
            this.ThuBox.AutoSize = true;
            this.ThuBox.Checked = true;
            this.ThuBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ThuBox.Location = new System.Drawing.Point(257, 3);
            this.ThuBox.Name = "ThuBox";
            this.ThuBox.Size = new System.Drawing.Size(44, 17);
            this.ThuBox.TabIndex = 5;
            this.ThuBox.Text = "Thu";
            this.ThuBox.UseVisualStyleBackColor = true;
            // 
            // FriBox
            // 
            this.FriBox.AutoSize = true;
            this.FriBox.Checked = true;
            this.FriBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FriBox.Location = new System.Drawing.Point(307, 3);
            this.FriBox.Name = "FriBox";
            this.FriBox.Size = new System.Drawing.Size(38, 17);
            this.FriBox.TabIndex = 6;
            this.FriBox.Text = "Fri";
            this.FriBox.UseVisualStyleBackColor = true;
            // 
            // SpecificRadio
            // 
            this.SpecificRadio.AutoSize = true;
            this.SpecificRadio.Dock = System.Windows.Forms.DockStyle.Right;
            this.SpecificRadio.Location = new System.Drawing.Point(168, 399);
            this.SpecificRadio.Name = "SpecificRadio";
            this.SpecificRadio.Size = new System.Drawing.Size(61, 20);
            this.SpecificRadio.TabIndex = 10;
            this.SpecificRadio.Text = "Specific";
            this.SpecificRadio.UseVisualStyleBackColor = true;
            this.SpecificRadio.CheckedChanged += new System.EventHandler(this.SpecificRadio_CheckedChanged);
            // 
            // SpecifyLayout
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.SpecifyLayout, 2);
            this.SpecifyLayout.Controls.Add(this.MinutesRadio);
            this.SpecifyLayout.Controls.Add(this.HoursRadio);
            this.SpecifyLayout.Controls.Add(this.DaysRadio);
            this.SpecifyLayout.Controls.Add(this.WeeksRadio);
            this.SpecifyLayout.Controls.Add(this.MonthsRadio);
            this.SpecifyLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecifyLayout.Location = new System.Drawing.Point(235, 425);
            this.SpecifyLayout.Name = "SpecifyLayout";
            this.SpecifyLayout.Size = new System.Drawing.Size(357, 20);
            this.SpecifyLayout.TabIndex = 19;
            // 
            // MinutesRadio
            // 
            this.MinutesRadio.AutoSize = true;
            this.MinutesRadio.Location = new System.Drawing.Point(3, 3);
            this.MinutesRadio.Name = "MinutesRadio";
            this.MinutesRadio.Size = new System.Drawing.Size(62, 17);
            this.MinutesRadio.TabIndex = 0;
            this.MinutesRadio.TabStop = true;
            this.MinutesRadio.Text = "Minutes";
            this.MinutesRadio.UseVisualStyleBackColor = true;
            // 
            // HoursRadio
            // 
            this.HoursRadio.AutoSize = true;
            this.HoursRadio.Location = new System.Drawing.Point(71, 3);
            this.HoursRadio.Name = "HoursRadio";
            this.HoursRadio.Size = new System.Drawing.Size(53, 17);
            this.HoursRadio.TabIndex = 1;
            this.HoursRadio.TabStop = true;
            this.HoursRadio.Text = "Hours";
            this.HoursRadio.UseVisualStyleBackColor = true;
            // 
            // DaysRadio
            // 
            this.DaysRadio.AutoSize = true;
            this.DaysRadio.Location = new System.Drawing.Point(130, 3);
            this.DaysRadio.Name = "DaysRadio";
            this.DaysRadio.Size = new System.Drawing.Size(49, 17);
            this.DaysRadio.TabIndex = 2;
            this.DaysRadio.TabStop = true;
            this.DaysRadio.Text = "Days";
            this.DaysRadio.UseVisualStyleBackColor = true;
            // 
            // WeeksRadio
            // 
            this.WeeksRadio.AutoSize = true;
            this.WeeksRadio.Location = new System.Drawing.Point(185, 3);
            this.WeeksRadio.Name = "WeeksRadio";
            this.WeeksRadio.Size = new System.Drawing.Size(57, 17);
            this.WeeksRadio.TabIndex = 3;
            this.WeeksRadio.TabStop = true;
            this.WeeksRadio.Text = "Weeks";
            this.WeeksRadio.UseVisualStyleBackColor = true;
            // 
            // MonthsRadio
            // 
            this.MonthsRadio.AutoSize = true;
            this.MonthsRadio.Location = new System.Drawing.Point(248, 3);
            this.MonthsRadio.Name = "MonthsRadio";
            this.MonthsRadio.Size = new System.Drawing.Size(60, 17);
            this.MonthsRadio.TabIndex = 4;
            this.MonthsRadio.TabStop = true;
            this.MonthsRadio.Text = "Months";
            this.MonthsRadio.UseVisualStyleBackColor = true;
            // 
            // SpecificNum
            // 
            this.SpecificNum.DecimalPlaces = 3;
            this.SpecificNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecificNum.Location = new System.Drawing.Point(135, 425);
            this.SpecificNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.SpecificNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SpecificNum.Name = "SpecificNum";
            this.SpecificNum.Size = new System.Drawing.Size(94, 20);
            this.SpecificNum.TabIndex = 18;
            this.SpecificNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IsEnabledBox
            // 
            this.IsEnabledBox.AutoSize = true;
            this.IsEnabledBox.Checked = true;
            this.IsEnabledBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsEnabledBox.Location = new System.Drawing.Point(497, 19);
            this.IsEnabledBox.Name = "IsEnabledBox";
            this.IsEnabledBox.Size = new System.Drawing.Size(64, 17);
            this.IsEnabledBox.TabIndex = 20;
            this.IsEnabledBox.Text = "Enabled";
            this.IsEnabledBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Backup Schedule";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MyToolStrip
            // 
            this.MyToolStrip.AutoSize = false;
            this.MyToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.MyToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MyToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBackup,
            this.toolStripSeparator1,
            this.CloneBackup,
            this.toolStripSeparator2,
            this.SaveBackup,
            this.CloseBackup,
            this.toolStripSeparator4,
            this.DeleteBackup,
            this.toolStripSeparator5,
            this.BackupStatusBtn});
            this.MyToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MyToolStrip.Name = "MyToolStrip";
            this.MyToolStrip.Size = new System.Drawing.Size(784, 70);
            this.MyToolStrip.TabIndex = 4;
            this.MyToolStrip.Text = "toolStrip1";
            // 
            // NewBackup
            // 
            this.NewBackup.AutoSize = false;
            this.NewBackup.Image = global::SQLAutoBackup.Properties.Resources.SQLBackup2_48;
            this.NewBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewBackup.Name = "NewBackup";
            this.NewBackup.Size = new System.Drawing.Size(80, 67);
            this.NewBackup.Text = "New Backup";
            this.NewBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewBackup.Click += new System.EventHandler(this.NewBackup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            this.toolStripSeparator1.Visible = false;
            // 
            // CloneBackup
            // 
            this.CloneBackup.AutoSize = false;
            this.CloneBackup.Image = global::SQLAutoBackup.Properties.Resources.SQLSet_48;
            this.CloneBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloneBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CloneBackup.Name = "CloneBackup";
            this.CloneBackup.Size = new System.Drawing.Size(80, 67);
            this.CloneBackup.Text = "Clone";
            this.CloneBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CloneBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CloneBackup.Visible = false;
            this.CloneBackup.Click += new System.EventHandler(this.CloneBackup_Click);
            this.CloneBackup.VisibleChanged += new System.EventHandler(this.CloneBackup_VisibleChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            this.toolStripSeparator2.Visible = false;
            // 
            // SaveBackup
            // 
            this.SaveBackup.AutoSize = false;
            this.SaveBackup.Image = global::SQLAutoBackup.Properties.Resources.SQLSave_48_2;
            this.SaveBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveBackup.Name = "SaveBackup";
            this.SaveBackup.Size = new System.Drawing.Size(80, 67);
            this.SaveBackup.Text = "Save";
            this.SaveBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveBackup.Visible = false;
            this.SaveBackup.Click += new System.EventHandler(this.SaveBackup_Click);
            this.SaveBackup.VisibleChanged += new System.EventHandler(this.SaveBackup_VisibleChanged);
            // 
            // CloseBackup
            // 
            this.CloseBackup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseBackup.AutoSize = false;
            this.CloseBackup.Image = global::SQLAutoBackup.Properties.Resources.CloseIcon_481;
            this.CloseBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CloseBackup.Name = "CloseBackup";
            this.CloseBackup.Size = new System.Drawing.Size(80, 67);
            this.CloseBackup.Text = "Close";
            this.CloseBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CloseBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CloseBackup.Visible = false;
            this.CloseBackup.Click += new System.EventHandler(this.CloseBackup_Click);
            this.CloseBackup.VisibleChanged += new System.EventHandler(this.CloseBackup_VisibleChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 70);
            this.toolStripSeparator4.Visible = false;
            // 
            // DeleteBackup
            // 
            this.DeleteBackup.AutoSize = false;
            this.DeleteBackup.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBackup.Image")));
            this.DeleteBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteBackup.Name = "DeleteBackup";
            this.DeleteBackup.Size = new System.Drawing.Size(80, 67);
            this.DeleteBackup.Text = "Delete";
            this.DeleteBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteBackup.Visible = false;
            this.DeleteBackup.Click += new System.EventHandler(this.DeleteBackup_Click);
            this.DeleteBackup.VisibleChanged += new System.EventHandler(this.DeleteBackup_VisibleChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 70);
            this.toolStripSeparator5.Visible = false;
            // 
            // BackupStatusBtn
            // 
            this.BackupStatusBtn.AutoSize = false;
            this.BackupStatusBtn.Image = global::SQLAutoBackup.Properties.Resources.SQLStatus2_48;
            this.BackupStatusBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BackupStatusBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BackupStatusBtn.Name = "BackupStatusBtn";
            this.BackupStatusBtn.Size = new System.Drawing.Size(80, 67);
            this.BackupStatusBtn.Text = "Status...";
            this.BackupStatusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BackupStatusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BackupStatusBtn.Visible = false;
            this.BackupStatusBtn.Click += new System.EventHandler(this.BackupStatusBtn_Click);
            this.BackupStatusBtn.VisibleChanged += new System.EventHandler(this.BackupStatusBtn_VisibleChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MyParentPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.MyTreeView);
            this.Controls.Add(this.MyToolStrip);
            this.Controls.Add(this.MyMenuStrip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MyMenuStrip;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Auto Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SQLAutoBackup_FormClosing);
            this.Load += new System.EventHandler(this.SQLAutoBackup_Load);
            this.MyMenuStrip.ResumeLayout(false);
            this.MyMenuStrip.PerformLayout();
            this.MyNotifyIconContext.ResumeLayout(false);
            this.MyParentPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.DaysLayout.ResumeLayout(false);
            this.DaysLayout.PerformLayout();
            this.SpecifyLayout.ResumeLayout(false);
            this.SpecifyLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecificNum)).EndInit();
            this.MyToolStrip.ResumeLayout(false);
            this.MyToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog MyFolderBrowserDialog;
        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem NewBackupToolStripMenuItem;
        private System.Windows.Forms.Panel MyParentPanel;
        private System.Windows.Forms.ContextMenuStrip MyNotifyIconContext;
        private System.Windows.Forms.ToolStripMenuItem ShowHideNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem ExitNotifyIcon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BackupNameTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AuthCoBox;
        private System.Windows.Forms.ComboBox DBCoBox;
        private System.Windows.Forms.ComboBox HostCoBox;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.CheckBox SaveCkBox;
        private System.Windows.Forms.Button TestConnectionBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BackupPathTxt;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton RepeatRadio;
        private System.Windows.Forms.FlowLayoutPanel DaysLayout;
        private System.Windows.Forms.CheckBox SatBox;
        private System.Windows.Forms.CheckBox SunBox;
        private System.Windows.Forms.CheckBox MonBox;
        private System.Windows.Forms.CheckBox TueBox;
        private System.Windows.Forms.CheckBox WedBox;
        private System.Windows.Forms.CheckBox ThuBox;
        private System.Windows.Forms.CheckBox FriBox;
        private System.Windows.Forms.RadioButton SpecificRadio;
        private System.Windows.Forms.NumericUpDown SpecificNum;
        private System.Windows.Forms.FlowLayoutPanel SpecifyLayout;
        private System.Windows.Forms.RadioButton MinutesRadio;
        private System.Windows.Forms.RadioButton HoursRadio;
        private System.Windows.Forms.RadioButton DaysRadio;
        private System.Windows.Forms.RadioButton WeeksRadio;
        private System.Windows.Forms.RadioButton MonthsRadio;
        private System.Windows.Forms.ToolStrip MyToolStrip;
        private System.Windows.Forms.ToolStripMenuItem NewBackup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.CheckBox IsEnabledBox;
        private System.Windows.Forms.ToolStripMenuItem CloseBackup;
        private System.Windows.Forms.ToolStripMenuItem SaveBackup;
        private System.Windows.Forms.ToolStripMenuItem CloneBackup;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TreeView MyTreeView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem DeleteBackup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem BackupStatusBtn;
    }
}

