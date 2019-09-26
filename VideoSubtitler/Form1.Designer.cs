namespace VideoSubtitler
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPlayStop = new System.Windows.Forms.Button();
            this.valPosition = new System.Windows.Forms.TrackBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditSubtitle = new System.Windows.Forms.Button();
            this.listAddedSubtitles = new System.Windows.Forms.ListView();
            this.colStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPlayBackSpeed = new System.Windows.Forms.Label();
            this.valPlaybackSpeed = new System.Windows.Forms.TrackBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAdd5Sec = new System.Windows.Forms.Button();
            this.btnAdd1Sec = new System.Windows.Forms.Button();
            this.btnSub5Sec = new System.Windows.Forms.Button();
            this.btnSub1Sec = new System.Windows.Forms.Button();
            this.lblRealTimeSubtitle = new System.Windows.Forms.Label();
            this.videoView = new VideoSubtitler.VideoView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddFromTxt = new System.Windows.Forms.LinkLabel();
            this.btnAddByHind = new System.Windows.Forms.LinkLabel();
            this.btnClear = new System.Windows.Forms.LinkLabel();
            this.listReadyAdd = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUnDo = new System.Windows.Forms.Button();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPrevs = new System.Windows.Forms.Label();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNexts = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnBeginAdd = new System.Windows.Forms.Button();
            this.btnEndAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.立刻保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.valPosition)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valPlaybackSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 33;
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlayStop.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.btnPlayStop.Location = new System.Drawing.Point(3, 323);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Size = new System.Drawing.Size(103, 47);
            this.btnPlayStop.TabIndex = 1;
            this.btnPlayStop.Text = "Play";
            this.btnPlayStop.UseVisualStyleBackColor = true;
            this.btnPlayStop.Click += new System.EventHandler(this.BtnPlayBack_Click);
            // 
            // valPosition
            // 
            this.valPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valPosition.AutoSize = false;
            this.valPosition.LargeChange = 1000;
            this.valPosition.Location = new System.Drawing.Point(4, 372);
            this.valPosition.Name = "valPosition";
            this.valPosition.Size = new System.Drawing.Size(467, 29);
            this.valPosition.TabIndex = 2;
            this.valPosition.TickFrequency = 1000;
            this.valPosition.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.valPosition.Scroll += new System.EventHandler(this.ValPosition_Scroll);
            this.valPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ValPosition_MouseDown);
            this.valPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ValPosition_MouseUp);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(156, 323);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(268, 47);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "00:00:00.000";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEditSubtitle);
            this.groupBox1.Controls.Add(this.listAddedSubtitles);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 342);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已添加的字幕";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(88, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEditSubtitle
            // 
            this.btnEditSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditSubtitle.Location = new System.Drawing.Point(7, 313);
            this.btnEditSubtitle.Name = "btnEditSubtitle";
            this.btnEditSubtitle.Size = new System.Drawing.Size(75, 23);
            this.btnEditSubtitle.TabIndex = 1;
            this.btnEditSubtitle.Text = "修改内容";
            this.btnEditSubtitle.UseVisualStyleBackColor = true;
            // 
            // listAddedSubtitles
            // 
            this.listAddedSubtitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAddedSubtitles.CheckBoxes = true;
            this.listAddedSubtitles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStartTime,
            this.colContent});
            this.listAddedSubtitles.FullRowSelect = true;
            this.listAddedSubtitles.GridLines = true;
            this.listAddedSubtitles.HideSelection = false;
            this.listAddedSubtitles.Location = new System.Drawing.Point(7, 21);
            this.listAddedSubtitles.Name = "listAddedSubtitles";
            this.listAddedSubtitles.Size = new System.Drawing.Size(277, 290);
            this.listAddedSubtitles.TabIndex = 0;
            this.listAddedSubtitles.UseCompatibleStateImageBehavior = false;
            this.listAddedSubtitles.View = System.Windows.Forms.View.Details;
            // 
            // colStartTime
            // 
            this.colStartTime.Text = "开始时间";
            this.colStartTime.Width = 90;
            // 
            // colContent
            // 
            this.colContent.Text = "内容";
            this.colContent.Width = 999;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblPlayBackSpeed);
            this.groupBox2.Controls.Add(this.valPlaybackSpeed);
            this.groupBox2.Location = new System.Drawing.Point(3, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 47);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "倍速播放";
            // 
            // lblPlayBackSpeed
            // 
            this.lblPlayBackSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayBackSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayBackSpeed.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPlayBackSpeed.Location = new System.Drawing.Point(226, 16);
            this.lblPlayBackSpeed.Name = "lblPlayBackSpeed";
            this.lblPlayBackSpeed.Size = new System.Drawing.Size(60, 23);
            this.lblPlayBackSpeed.TabIndex = 1;
            this.lblPlayBackSpeed.Text = "1.0x";
            this.lblPlayBackSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valPlaybackSpeed
            // 
            this.valPlaybackSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valPlaybackSpeed.AutoSize = false;
            this.valPlaybackSpeed.Location = new System.Drawing.Point(5, 16);
            this.valPlaybackSpeed.Maximum = 25;
            this.valPlaybackSpeed.Minimum = 3;
            this.valPlaybackSpeed.Name = "valPlaybackSpeed";
            this.valPlaybackSpeed.Size = new System.Drawing.Size(215, 27);
            this.valPlaybackSpeed.TabIndex = 0;
            this.valPlaybackSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.valPlaybackSpeed.Value = 10;
            this.valPlaybackSpeed.Scroll += new System.EventHandler(this.ValPlaybackSpeed_Scroll);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd5Sec);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd1Sec);
            this.splitContainer1.Panel1.Controls.Add(this.btnSub5Sec);
            this.splitContainer1.Panel1.Controls.Add(this.btnSub1Sec);
            this.splitContainer1.Panel1.Controls.Add(this.lblRealTimeSubtitle);
            this.splitContainer1.Panel1.Controls.Add(this.valPosition);
            this.splitContainer1.Panel1.Controls.Add(this.videoView);
            this.splitContainer1.Panel1.Controls.Add(this.btnPlayStop);
            this.splitContainer1.Panel1.Controls.Add(this.lblTime);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(789, 406);
            this.splitContainer1.SplitterDistance = 479;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnAdd5Sec
            // 
            this.btnAdd5Sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd5Sec.Location = new System.Drawing.Point(430, 347);
            this.btnAdd5Sec.Name = "btnAdd5Sec";
            this.btnAdd5Sec.Size = new System.Drawing.Size(41, 23);
            this.btnAdd5Sec.TabIndex = 5;
            this.btnAdd5Sec.Tag = "5000";
            this.btnAdd5Sec.Text = "+5s";
            this.btnAdd5Sec.UseVisualStyleBackColor = true;
            this.btnAdd5Sec.Click += new System.EventHandler(this.BtnSub1Sec_Click);
            // 
            // btnAdd1Sec
            // 
            this.btnAdd1Sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd1Sec.Location = new System.Drawing.Point(430, 323);
            this.btnAdd1Sec.Name = "btnAdd1Sec";
            this.btnAdd1Sec.Size = new System.Drawing.Size(41, 23);
            this.btnAdd1Sec.TabIndex = 5;
            this.btnAdd1Sec.Tag = "1000";
            this.btnAdd1Sec.Text = "+1s";
            this.btnAdd1Sec.UseVisualStyleBackColor = true;
            this.btnAdd1Sec.Click += new System.EventHandler(this.BtnSub1Sec_Click);
            // 
            // btnSub5Sec
            // 
            this.btnSub5Sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSub5Sec.Location = new System.Drawing.Point(112, 347);
            this.btnSub5Sec.Name = "btnSub5Sec";
            this.btnSub5Sec.Size = new System.Drawing.Size(38, 23);
            this.btnSub5Sec.TabIndex = 5;
            this.btnSub5Sec.Tag = "-5000";
            this.btnSub5Sec.Text = "-5s";
            this.btnSub5Sec.UseVisualStyleBackColor = true;
            this.btnSub5Sec.Click += new System.EventHandler(this.BtnSub1Sec_Click);
            // 
            // btnSub1Sec
            // 
            this.btnSub1Sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSub1Sec.Location = new System.Drawing.Point(112, 323);
            this.btnSub1Sec.Name = "btnSub1Sec";
            this.btnSub1Sec.Size = new System.Drawing.Size(38, 23);
            this.btnSub1Sec.TabIndex = 5;
            this.btnSub1Sec.Tag = "-1000";
            this.btnSub1Sec.Text = "-1s";
            this.btnSub1Sec.UseVisualStyleBackColor = true;
            this.btnSub1Sec.Click += new System.EventHandler(this.BtnSub1Sec_Click);
            // 
            // lblRealTimeSubtitle
            // 
            this.lblRealTimeSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRealTimeSubtitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRealTimeSubtitle.Location = new System.Drawing.Point(3, 281);
            this.lblRealTimeSubtitle.Name = "lblRealTimeSubtitle";
            this.lblRealTimeSubtitle.Size = new System.Drawing.Size(468, 38);
            this.lblRealTimeSubtitle.TabIndex = 4;
            this.lblRealTimeSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // videoView
            // 
            this.videoView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoView.BackColor = System.Drawing.Color.Black;
            this.videoView.Location = new System.Drawing.Point(3, 3);
            this.videoView.Name = "videoView";
            this.videoView.PlayBackSpeed = 1D;
            this.videoView.Position = System.TimeSpan.Parse("00:00:00");
            this.videoView.PositionInt = 0;
            this.videoView.Size = new System.Drawing.Size(468, 275);
            this.videoView.TabIndex = 0;
            this.videoView.PlayStateChanged += new System.EventHandler<System.EventArgs>(this.VideoView_PlayStateChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(4, 28);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(789, 636);
            this.splitContainer2.SplitterDistance = 406;
            this.splitContainer2.TabIndex = 7;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer3.Size = new System.Drawing.Size(789, 226);
            this.splitContainer3.SplitterDistance = 479;
            this.splitContainer3.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel1);
            this.groupBox3.Controls.Add(this.listReadyAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 224);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "准备添加的字幕";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnAddFromTxt);
            this.flowLayoutPanel1.Controls.Add(this.btnAddByHind);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(465, 12);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnAddFromTxt
            // 
            this.btnAddFromTxt.AutoSize = true;
            this.btnAddFromTxt.Location = new System.Drawing.Point(3, 0);
            this.btnAddFromTxt.Name = "btnAddFromTxt";
            this.btnAddFromTxt.Size = new System.Drawing.Size(59, 12);
            this.btnAddFromTxt.TabIndex = 0;
            this.btnAddFromTxt.TabStop = true;
            this.btnAddFromTxt.Text = "从TXT添加";
            this.btnAddFromTxt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnAddFromTxt_LinkClicked);
            // 
            // btnAddByHind
            // 
            this.btnAddByHind.AutoSize = true;
            this.btnAddByHind.Location = new System.Drawing.Point(68, 0);
            this.btnAddByHind.Name = "btnAddByHind";
            this.btnAddByHind.Size = new System.Drawing.Size(53, 12);
            this.btnAddByHind.TabIndex = 1;
            this.btnAddByHind.TabStop = true;
            this.btnAddByHind.Text = "手动添加";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(127, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 12);
            this.btnClear.TabIndex = 2;
            this.btnClear.TabStop = true;
            this.btnClear.Text = "清空列表";
            // 
            // listReadyAdd
            // 
            this.listReadyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listReadyAdd.CheckBoxes = true;
            this.listReadyAdd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listReadyAdd.FullRowSelect = true;
            this.listReadyAdd.GridLines = true;
            this.listReadyAdd.HideSelection = false;
            this.listReadyAdd.Location = new System.Drawing.Point(6, 30);
            this.listReadyAdd.Name = "listReadyAdd";
            this.listReadyAdd.Size = new System.Drawing.Size(465, 185);
            this.listReadyAdd.TabIndex = 0;
            this.listReadyAdd.UseCompatibleStateImageBehavior = false;
            this.listReadyAdd.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "内容";
            this.columnHeader2.Width = 999;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUnDo);
            this.groupBox4.Controls.Add(this.splitContainer6);
            this.groupBox4.Controls.Add(this.splitContainer4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 224);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "实时添加字幕";
            // 
            // btnUnDo
            // 
            this.btnUnDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnDo.Enabled = false;
            this.btnUnDo.Location = new System.Drawing.Point(8, 191);
            this.btnUnDo.Name = "btnUnDo";
            this.btnUnDo.Size = new System.Drawing.Size(287, 23);
            this.btnUnDo.TabIndex = 4;
            this.btnUnDo.Text = "撤销刚才一条";
            this.btnUnDo.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(8, 54);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.flowLayoutPanel4);
            this.splitContainer6.Size = new System.Drawing.Size(287, 133);
            this.splitContainer6.SplitterDistance = 79;
            this.splitContainer6.TabIndex = 3;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.flowLayoutPanel2);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.btnCurrent);
            this.splitContainer5.Size = new System.Drawing.Size(287, 79);
            this.splitContainer5.SplitterDistance = 42;
            this.splitContainer5.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(287, 42);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.lblPrevs);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 27);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(47, 12);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // lblPrevs
            // 
            this.lblPrevs.AutoEllipsis = true;
            this.lblPrevs.AutoSize = true;
            this.lblPrevs.Location = new System.Drawing.Point(3, 0);
            this.lblPrevs.Name = "lblPrevs";
            this.lblPrevs.Size = new System.Drawing.Size(41, 12);
            this.lblPrevs.TabIndex = 0;
            this.lblPrevs.Text = "上一条";
            this.lblPrevs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnCurrent
            // 
            this.btnCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCurrent.Enabled = false;
            this.btnCurrent.Location = new System.Drawing.Point(0, 0);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(287, 33);
            this.btnCurrent.TabIndex = 0;
            this.btnCurrent.Text = ">  <";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.BtnCurrent_Click);
            this.btnCurrent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnCurrent_MouseDown);
            this.btnCurrent.MouseEnter += new System.EventHandler(this.BtnCurrent_MouseEnter);
            this.btnCurrent.MouseLeave += new System.EventHandler(this.BtnCurrent_MouseLeave);
            this.btnCurrent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCurrent_MouseUp);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(287, 50);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.lblNexts);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(47, 12);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // lblNexts
            // 
            this.lblNexts.AutoEllipsis = true;
            this.lblNexts.AutoSize = true;
            this.lblNexts.Location = new System.Drawing.Point(3, 0);
            this.lblNexts.Name = "lblNexts";
            this.lblNexts.Size = new System.Drawing.Size(41, 12);
            this.lblNexts.TabIndex = 1;
            this.lblNexts.Text = "下一条";
            this.lblNexts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(8, 18);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btnBeginAdd);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnEndAdd);
            this.splitContainer4.Size = new System.Drawing.Size(287, 30);
            this.splitContainer4.SplitterDistance = 141;
            this.splitContainer4.SplitterWidth = 1;
            this.splitContainer4.TabIndex = 2;
            // 
            // btnBeginAdd
            // 
            this.btnBeginAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBeginAdd.Location = new System.Drawing.Point(0, 0);
            this.btnBeginAdd.Name = "btnBeginAdd";
            this.btnBeginAdd.Size = new System.Drawing.Size(141, 30);
            this.btnBeginAdd.TabIndex = 1;
            this.btnBeginAdd.Text = "开始添加";
            this.btnBeginAdd.UseVisualStyleBackColor = true;
            this.btnBeginAdd.Click += new System.EventHandler(this.BtnBeginAdd_Click);
            // 
            // btnEndAdd
            // 
            this.btnEndAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEndAdd.Enabled = false;
            this.btnEndAdd.Location = new System.Drawing.Point(0, 0);
            this.btnEndAdd.Name = "btnEndAdd";
            this.btnEndAdd.Size = new System.Drawing.Size(145, 30);
            this.btnEndAdd.TabIndex = 1;
            this.btnEndAdd.Text = "停止添加";
            this.btnEndAdd.UseVisualStyleBackColor = true;
            this.btnEndAdd.Click += new System.EventHandler(this.BtnEndAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.立刻保存ToolStripMenuItem,
            this.关闭工程ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 立刻保存ToolStripMenuItem
            // 
            this.立刻保存ToolStripMenuItem.Name = "立刻保存ToolStripMenuItem";
            this.立刻保存ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.立刻保存ToolStripMenuItem.Text = "立刻保存";
            // 
            // 关闭工程ToolStripMenuItem
            // 
            this.关闭工程ToolStripMenuItem.Name = "关闭工程ToolStripMenuItem";
            this.关闭工程ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭工程ToolStripMenuItem.Text = "关闭工程";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "文本文件|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(795, 667);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "视频加字幕神器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valPosition)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valPlaybackSpeed)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer mainTimer;
        private VideoView videoView;
        private System.Windows.Forms.Button btnPlayStop;
        private System.Windows.Forms.TrackBar valPosition;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar valPlaybackSpeed;
        private System.Windows.Forms.Label lblPlayBackSpeed;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditSubtitle;
        private System.Windows.Forms.ListView listAddedSubtitles;
        private System.Windows.Forms.ColumnHeader colStartTime;
        private System.Windows.Forms.ColumnHeader colContent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblRealTimeSubtitle;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listReadyAdd;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btnBeginAdd;
        private System.Windows.Forms.Button btnEndAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel btnAddFromTxt;
        private System.Windows.Forms.LinkLabel btnAddByHind;
        private System.Windows.Forms.LinkLabel btnClear;
        private System.Windows.Forms.Button btnUnDo;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Label lblPrevs;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Label lblNexts;
        private System.Windows.Forms.Button btnAdd5Sec;
        private System.Windows.Forms.Button btnAdd1Sec;
        private System.Windows.Forms.Button btnSub5Sec;
        private System.Windows.Forms.Button btnSub1Sec;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 立刻保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭工程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    }
}

