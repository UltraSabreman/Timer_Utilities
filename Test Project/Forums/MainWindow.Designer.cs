namespace Time_Utils
{
    partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.Clocks = new System.Windows.Forms.TabControl();
			this.Stopwatch = new System.Windows.Forms.TabPage();
			this.SWdisplay = new System.Windows.Forms.Label();
			this.SWLapTimes = new System.Windows.Forms.ListView();
			this.lap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.times = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SWresetButton = new System.Windows.Forms.Button();
			this.SWstartButton = new System.Windows.Forms.Button();
			this.Countdown = new System.Windows.Forms.TabPage();
			this.alarmOptions = new System.Windows.Forms.GroupBox();
			this.chkForeg = new System.Windows.Forms.CheckBox();
			this.chkPopUp = new System.Windows.Forms.CheckBox();
			this.chkTrayNot = new System.Windows.Forms.CheckBox();
			this.chkRun = new System.Windows.Forms.CheckBox();
			this.chkPlys = new System.Windows.Forms.CheckBox();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.CDresetB = new System.Windows.Forms.Button();
			this.CDprogress = new System.Windows.Forms.ProgressBar();
			this.CDstart = new System.Windows.Forms.Button();
			this.KeyPad = new System.Windows.Forms.Panel();
			this.KeyPadDel = new System.Windows.Forms.Button();
			this.KeyPad0 = new System.Windows.Forms.Button();
			this.KeyPad3 = new System.Windows.Forms.Button();
			this.KeyPad2 = new System.Windows.Forms.Button();
			this.KeyPad1 = new System.Windows.Forms.Button();
			this.KeyPad6 = new System.Windows.Forms.Button();
			this.KeyPad5 = new System.Windows.Forms.Button();
			this.KeyPad4 = new System.Windows.Forms.Button();
			this.KeyPad9 = new System.Windows.Forms.Button();
			this.KeyPad8 = new System.Windows.Forms.Button();
			this.KeyPad7 = new System.Windows.Forms.Button();
			this.todo = new System.Windows.Forms.TabPage();
			this.TDtodoList = new System.Windows.Forms.ListView();
			this.X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TodoMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.priority = new System.Windows.Forms.ToolStripMenuItem();
			this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.removeAllCompleatedItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TimerStats = new System.Windows.Forms.NotifyIcon(this.components);
			this.TrayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TrayCntOpenTimer = new System.Windows.Forms.ToolStripMenuItem();
			this.TrayCntQuickView = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.TrayCntOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.TrayCntExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTips = new System.Windows.Forms.ToolTip(this.components);
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileStripMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenDataFile = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsDiag = new System.Windows.Forms.ToolStripMenuItem();
			this.ReloadData = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitApp = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpStripMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpButton = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutDiag = new System.Windows.Forms.ToolStripMenuItem();
			this.CDdisplay = new System.Windows.Forms.Label();
			this.Clocks.SuspendLayout();
			this.Stopwatch.SuspendLayout();
			this.Countdown.SuspendLayout();
			this.alarmOptions.SuspendLayout();
			this.KeyPad.SuspendLayout();
			this.todo.SuspendLayout();
			this.TodoMenu.SuspendLayout();
			this.TrayIconContextMenu.SuspendLayout();
			this.MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// Clocks
			// 
			this.Clocks.Controls.Add(this.Stopwatch);
			this.Clocks.Controls.Add(this.Countdown);
			this.Clocks.Controls.Add(this.todo);
			this.Clocks.Location = new System.Drawing.Point(12, 27);
			this.Clocks.Name = "Clocks";
			this.Clocks.SelectedIndex = 0;
			this.Clocks.Size = new System.Drawing.Size(358, 311);
			this.Clocks.TabIndex = 0;
			// 
			// Stopwatch
			// 
			this.Stopwatch.Controls.Add(this.SWdisplay);
			this.Stopwatch.Controls.Add(this.SWLapTimes);
			this.Stopwatch.Controls.Add(this.SWresetButton);
			this.Stopwatch.Controls.Add(this.SWstartButton);
			this.Stopwatch.Location = new System.Drawing.Point(4, 22);
			this.Stopwatch.Name = "Stopwatch";
			this.Stopwatch.Padding = new System.Windows.Forms.Padding(3);
			this.Stopwatch.Size = new System.Drawing.Size(350, 285);
			this.Stopwatch.TabIndex = 0;
			this.Stopwatch.Text = "Stop Watch";
			this.Stopwatch.UseVisualStyleBackColor = true;
			// 
			// SWdisplay
			// 
			this.SWdisplay.BackColor = System.Drawing.SystemColors.Control;
			this.SWdisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SWdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SWdisplay.Location = new System.Drawing.Point(3, 6);
			this.SWdisplay.Name = "SWdisplay";
			this.SWdisplay.Size = new System.Drawing.Size(344, 38);
			this.SWdisplay.TabIndex = 4;
			this.SWdisplay.Text = "00 : 00 : 00.000";
			this.SWdisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SWdisplay.DoubleClick += new System.EventHandler(this.SWdisplay_DoubleClick);
			// 
			// SWLapTimes
			// 
			this.SWLapTimes.Activation = System.Windows.Forms.ItemActivation.TwoClick;
			this.SWLapTimes.AutoArrange = false;
			this.SWLapTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lap,
            this.times});
			this.SWLapTimes.FullRowSelect = true;
			this.SWLapTimes.GridLines = true;
			this.SWLapTimes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.SWLapTimes.Location = new System.Drawing.Point(3, 50);
			this.SWLapTimes.Name = "SWLapTimes";
			this.SWLapTimes.ShowGroups = false;
			this.SWLapTimes.Size = new System.Drawing.Size(344, 189);
			this.SWLapTimes.TabIndex = 3;
			this.SWLapTimes.UseCompatibleStateImageBehavior = false;
			this.SWLapTimes.View = System.Windows.Forms.View.Details;
			this.SWLapTimes.DoubleClick += new System.EventHandler(this.SWlapTimes_DoubleClick);
			// 
			// lap
			// 
			this.lap.Text = "Lap #";
			this.lap.Width = 40;
			// 
			// times
			// 
			this.times.Text = "Time";
			this.times.Width = 250;
			// 
			// SWresetButton
			// 
			this.SWresetButton.Location = new System.Drawing.Point(182, 245);
			this.SWresetButton.Name = "SWresetButton";
			this.SWresetButton.Size = new System.Drawing.Size(165, 34);
			this.SWresetButton.TabIndex = 1;
			this.SWresetButton.Text = "Reset";
			this.SWresetButton.UseVisualStyleBackColor = true;
			this.SWresetButton.Click += new System.EventHandler(this.SWresetButton_Click);
			// 
			// SWstartButton
			// 
			this.SWstartButton.Location = new System.Drawing.Point(3, 245);
			this.SWstartButton.Name = "SWstartButton";
			this.SWstartButton.Size = new System.Drawing.Size(165, 34);
			this.SWstartButton.TabIndex = 0;
			this.SWstartButton.Text = "Start";
			this.SWstartButton.UseVisualStyleBackColor = true;
			this.SWstartButton.Click += new System.EventHandler(this.SWstartButton_Click);
			// 
			// Countdown
			// 
			this.Countdown.Controls.Add(this.CDdisplay);
			this.Countdown.Controls.Add(this.alarmOptions);
			this.Countdown.Controls.Add(this.CDresetB);
			this.Countdown.Controls.Add(this.CDprogress);
			this.Countdown.Controls.Add(this.CDstart);
			this.Countdown.Controls.Add(this.KeyPad);
			this.Countdown.Location = new System.Drawing.Point(4, 22);
			this.Countdown.Name = "Countdown";
			this.Countdown.Padding = new System.Windows.Forms.Padding(3);
			this.Countdown.Size = new System.Drawing.Size(350, 285);
			this.Countdown.TabIndex = 1;
			this.Countdown.Text = "Count Down";
			this.Countdown.UseVisualStyleBackColor = true;
			// 
			// alarmOptions
			// 
			this.alarmOptions.Controls.Add(this.chkForeg);
			this.alarmOptions.Controls.Add(this.chkPopUp);
			this.alarmOptions.Controls.Add(this.chkTrayNot);
			this.alarmOptions.Controls.Add(this.chkRun);
			this.alarmOptions.Controls.Add(this.chkPlys);
			this.alarmOptions.Controls.Add(this.shapeContainer1);
			this.alarmOptions.Location = new System.Drawing.Point(183, 90);
			this.alarmOptions.Name = "alarmOptions";
			this.alarmOptions.Size = new System.Drawing.Size(164, 149);
			this.alarmOptions.TabIndex = 10;
			this.alarmOptions.TabStop = false;
			this.alarmOptions.Text = "Alarm Action";
			// 
			// chkForeg
			// 
			this.chkForeg.AutoSize = true;
			this.chkForeg.Location = new System.Drawing.Point(6, 66);
			this.chkForeg.Name = "chkForeg";
			this.chkForeg.Size = new System.Drawing.Size(119, 17);
			this.chkForeg.TabIndex = 14;
			this.chkForeg.Text = "Bring to Foreground";
			this.chkForeg.UseVisualStyleBackColor = true;
			this.chkForeg.CheckedChanged += new System.EventHandler(this.chkForeg_CheckedChanged);
			// 
			// chkPopUp
			// 
			this.chkPopUp.AutoSize = true;
			this.chkPopUp.Location = new System.Drawing.Point(6, 42);
			this.chkPopUp.Name = "chkPopUp";
			this.chkPopUp.Size = new System.Drawing.Size(131, 17);
			this.chkPopUp.TabIndex = 13;
			this.chkPopUp.Text = "Super Popup of Doom";
			this.toolTips.SetToolTip(this.chkPopUp, "\"WARNING: This WILL bring you out of anything you\'re doing!\"");
			this.chkPopUp.UseVisualStyleBackColor = true;
			this.chkPopUp.CheckedChanged += new System.EventHandler(this.chkPopUp_CheckedChanged);
			// 
			// chkTrayNot
			// 
			this.chkTrayNot.AutoSize = true;
			this.chkTrayNot.Checked = true;
			this.chkTrayNot.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTrayNot.Location = new System.Drawing.Point(6, 19);
			this.chkTrayNot.Name = "chkTrayNot";
			this.chkTrayNot.Size = new System.Drawing.Size(103, 17);
			this.chkTrayNot.TabIndex = 12;
			this.chkTrayNot.Text = "Tray Notification";
			this.chkTrayNot.UseVisualStyleBackColor = true;
			this.chkTrayNot.CheckedChanged += new System.EventHandler(this.chkTrayNot_CheckedChanged);
			// 
			// chkRun
			// 
			this.chkRun.AutoSize = true;
			this.chkRun.Location = new System.Drawing.Point(6, 126);
			this.chkRun.Name = "chkRun";
			this.chkRun.Size = new System.Drawing.Size(99, 17);
			this.chkRun.TabIndex = 11;
			this.chkRun.Text = "Run Something";
			this.chkRun.UseVisualStyleBackColor = true;
			this.chkRun.CheckedChanged += new System.EventHandler(this.chkRun_CheckedChanged);
			// 
			// chkPlys
			// 
			this.chkPlys.AutoSize = true;
			this.chkPlys.Checked = true;
			this.chkPlys.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkPlys.Location = new System.Drawing.Point(6, 103);
			this.chkPlys.Name = "chkPlys";
			this.chkPlys.Size = new System.Drawing.Size(80, 17);
			this.chkPlys.TabIndex = 10;
			this.chkPlys.Text = "Play Sound";
			this.chkPlys.UseVisualStyleBackColor = true;
			this.chkPlys.CheckedChanged += new System.EventHandler(this.chkPlys_CheckedChanged);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
			this.shapeContainer1.Size = new System.Drawing.Size(158, 130);
			this.shapeContainer1.TabIndex = 15;
			this.shapeContainer1.TabStop = false;
			// 
			// lineShape1
			// 
			this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 4;
			this.lineShape1.X2 = 156;
			this.lineShape1.Y1 = 77;
			this.lineShape1.Y2 = 77;
			// 
			// CDresetB
			// 
			this.CDresetB.Location = new System.Drawing.Point(182, 245);
			this.CDresetB.Name = "CDresetB";
			this.CDresetB.Size = new System.Drawing.Size(165, 34);
			this.CDresetB.TabIndex = 7;
			this.CDresetB.Text = "Reset";
			this.CDresetB.UseVisualStyleBackColor = true;
			this.CDresetB.Click += new System.EventHandler(this.CDresetB_Click);
			// 
			// CDprogress
			// 
			this.CDprogress.Location = new System.Drawing.Point(183, 50);
			this.CDprogress.MarqueeAnimationSpeed = 1;
			this.CDprogress.Name = "CDprogress";
			this.CDprogress.Size = new System.Drawing.Size(164, 34);
			this.CDprogress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.CDprogress.TabIndex = 6;
			// 
			// CDstart
			// 
			this.CDstart.Location = new System.Drawing.Point(3, 245);
			this.CDstart.Name = "CDstart";
			this.CDstart.Size = new System.Drawing.Size(165, 34);
			this.CDstart.TabIndex = 5;
			this.CDstart.Text = "Start";
			this.CDstart.UseVisualStyleBackColor = true;
			this.CDstart.Click += new System.EventHandler(this.CDstart_Click);
			// 
			// KeyPad
			// 
			this.KeyPad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.KeyPad.Controls.Add(this.KeyPadDel);
			this.KeyPad.Controls.Add(this.KeyPad0);
			this.KeyPad.Controls.Add(this.KeyPad3);
			this.KeyPad.Controls.Add(this.KeyPad2);
			this.KeyPad.Controls.Add(this.KeyPad1);
			this.KeyPad.Controls.Add(this.KeyPad6);
			this.KeyPad.Controls.Add(this.KeyPad5);
			this.KeyPad.Controls.Add(this.KeyPad4);
			this.KeyPad.Controls.Add(this.KeyPad9);
			this.KeyPad.Controls.Add(this.KeyPad8);
			this.KeyPad.Controls.Add(this.KeyPad7);
			this.KeyPad.Location = new System.Drawing.Point(3, 50);
			this.KeyPad.Name = "KeyPad";
			this.KeyPad.Size = new System.Drawing.Size(165, 190);
			this.KeyPad.TabIndex = 4;
			// 
			// KeyPadDel
			// 
			this.KeyPadDel.Location = new System.Drawing.Point(115, 141);
			this.KeyPadDel.Name = "KeyPadDel";
			this.KeyPadDel.Size = new System.Drawing.Size(45, 40);
			this.KeyPadDel.TabIndex = 10;
			this.KeyPadDel.Text = "<=";
			this.KeyPadDel.UseVisualStyleBackColor = true;
			this.KeyPadDel.Click += new System.EventHandler(this.KeyPadDel_Click);
			// 
			// KeyPad0
			// 
			this.KeyPad0.Location = new System.Drawing.Point(3, 141);
			this.KeyPad0.Name = "KeyPad0";
			this.KeyPad0.Size = new System.Drawing.Size(101, 40);
			this.KeyPad0.TabIndex = 9;
			this.KeyPad0.Text = "0";
			this.KeyPad0.UseVisualStyleBackColor = true;
			this.KeyPad0.Click += new System.EventHandler(this.KeyPad0_Click);
			// 
			// KeyPad3
			// 
			this.KeyPad3.Location = new System.Drawing.Point(115, 95);
			this.KeyPad3.Name = "KeyPad3";
			this.KeyPad3.Size = new System.Drawing.Size(45, 40);
			this.KeyPad3.TabIndex = 8;
			this.KeyPad3.Text = "3";
			this.KeyPad3.UseVisualStyleBackColor = true;
			this.KeyPad3.Click += new System.EventHandler(this.KeyPad3_Click);
			// 
			// KeyPad2
			// 
			this.KeyPad2.Location = new System.Drawing.Point(59, 95);
			this.KeyPad2.Name = "KeyPad2";
			this.KeyPad2.Size = new System.Drawing.Size(45, 40);
			this.KeyPad2.TabIndex = 7;
			this.KeyPad2.Text = "2";
			this.KeyPad2.UseVisualStyleBackColor = true;
			this.KeyPad2.Click += new System.EventHandler(this.KeyPad2_Click);
			// 
			// KeyPad1
			// 
			this.KeyPad1.Location = new System.Drawing.Point(3, 95);
			this.KeyPad1.Name = "KeyPad1";
			this.KeyPad1.Size = new System.Drawing.Size(45, 40);
			this.KeyPad1.TabIndex = 6;
			this.KeyPad1.Text = "1";
			this.KeyPad1.UseVisualStyleBackColor = true;
			this.KeyPad1.Click += new System.EventHandler(this.KeyPad1_Click);
			// 
			// KeyPad6
			// 
			this.KeyPad6.Location = new System.Drawing.Point(115, 49);
			this.KeyPad6.Name = "KeyPad6";
			this.KeyPad6.Size = new System.Drawing.Size(45, 40);
			this.KeyPad6.TabIndex = 5;
			this.KeyPad6.Text = "6";
			this.KeyPad6.UseVisualStyleBackColor = true;
			this.KeyPad6.Click += new System.EventHandler(this.KeyPad6_Click);
			// 
			// KeyPad5
			// 
			this.KeyPad5.Location = new System.Drawing.Point(59, 49);
			this.KeyPad5.Name = "KeyPad5";
			this.KeyPad5.Size = new System.Drawing.Size(45, 40);
			this.KeyPad5.TabIndex = 4;
			this.KeyPad5.Text = "5";
			this.KeyPad5.UseVisualStyleBackColor = true;
			this.KeyPad5.Click += new System.EventHandler(this.KeyPad5_Click);
			// 
			// KeyPad4
			// 
			this.KeyPad4.Location = new System.Drawing.Point(3, 49);
			this.KeyPad4.Name = "KeyPad4";
			this.KeyPad4.Size = new System.Drawing.Size(45, 40);
			this.KeyPad4.TabIndex = 3;
			this.KeyPad4.Text = "4";
			this.KeyPad4.UseVisualStyleBackColor = true;
			this.KeyPad4.Click += new System.EventHandler(this.KeyPad4_Click);
			// 
			// KeyPad9
			// 
			this.KeyPad9.Location = new System.Drawing.Point(115, 3);
			this.KeyPad9.Name = "KeyPad9";
			this.KeyPad9.Size = new System.Drawing.Size(45, 40);
			this.KeyPad9.TabIndex = 2;
			this.KeyPad9.Text = "9";
			this.KeyPad9.UseVisualStyleBackColor = true;
			this.KeyPad9.Click += new System.EventHandler(this.KeyPad9_Click);
			// 
			// KeyPad8
			// 
			this.KeyPad8.Location = new System.Drawing.Point(59, 3);
			this.KeyPad8.Name = "KeyPad8";
			this.KeyPad8.Size = new System.Drawing.Size(45, 40);
			this.KeyPad8.TabIndex = 1;
			this.KeyPad8.Text = "8";
			this.KeyPad8.UseVisualStyleBackColor = true;
			this.KeyPad8.Click += new System.EventHandler(this.KeyPad8_Click);
			// 
			// KeyPad7
			// 
			this.KeyPad7.Location = new System.Drawing.Point(3, 3);
			this.KeyPad7.Name = "KeyPad7";
			this.KeyPad7.Size = new System.Drawing.Size(45, 40);
			this.KeyPad7.TabIndex = 0;
			this.KeyPad7.Text = "7";
			this.KeyPad7.UseVisualStyleBackColor = true;
			this.KeyPad7.Click += new System.EventHandler(this.KeyPad7_Click);
			// 
			// todo
			// 
			this.todo.Controls.Add(this.TDtodoList);
			this.todo.Location = new System.Drawing.Point(4, 22);
			this.todo.Name = "todo";
			this.todo.Padding = new System.Windows.Forms.Padding(3);
			this.todo.Size = new System.Drawing.Size(350, 285);
			this.todo.TabIndex = 2;
			this.todo.Text = "To-Do";
			this.todo.UseVisualStyleBackColor = true;
			// 
			// TDtodoList
			// 
			this.TDtodoList.AutoArrange = false;
			this.TDtodoList.CheckBoxes = true;
			this.TDtodoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.X,
            this.ItemName});
			this.TDtodoList.ContextMenuStrip = this.TodoMenu;
			this.TDtodoList.FullRowSelect = true;
			this.TDtodoList.GridLines = true;
			this.TDtodoList.Location = new System.Drawing.Point(3, 6);
			this.TDtodoList.Name = "TDtodoList";
			this.TDtodoList.RightToLeftLayout = true;
			this.TDtodoList.Size = new System.Drawing.Size(341, 276);
			this.TDtodoList.TabIndex = 2;
			this.TDtodoList.UseCompatibleStateImageBehavior = false;
			this.TDtodoList.View = System.Windows.Forms.View.Details;
			this.TDtodoList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TDtodoList_MouseDown);
			// 
			// X
			// 
			this.X.Text = "X";
			this.X.Width = 22;
			// 
			// ItemName
			// 
			this.ItemName.Text = "Item Name";
			this.ItemName.Width = 311;
			// 
			// TodoMenu
			// 
			this.TodoMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.EditItem,
            this.removeItemToolStripMenuItem,
            this.priority,
            this.toolStripSeparator2,
            this.removeAllCompleatedItemsToolStripMenuItem});
			this.TodoMenu.Name = "TodoMenu";
			this.TodoMenu.Size = new System.Drawing.Size(178, 120);
			this.TodoMenu.Opening += new System.ComponentModel.CancelEventHandler(this.TDtodoMenu_Opening);
			// 
			// addItemToolStripMenuItem
			// 
			this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
			this.addItemToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.addItemToolStripMenuItem.Text = "Add Item";
			this.addItemToolStripMenuItem.Click += new System.EventHandler(this.TDaddItemToolStripMenuItem_Click);
			// 
			// EditItem
			// 
			this.EditItem.Name = "EditItem";
			this.EditItem.Size = new System.Drawing.Size(177, 22);
			this.EditItem.Text = "Edit Item";
			this.EditItem.Click += new System.EventHandler(this.TDeditItem_Click);
			// 
			// removeItemToolStripMenuItem
			// 
			this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
			this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.removeItemToolStripMenuItem.Text = "Remove Item";
			this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.TDremoveItemToolStripMenuItem_Click);
			// 
			// priority
			// 
			this.priority.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.lowToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.highToolStripMenuItem});
			this.priority.Name = "priority";
			this.priority.Size = new System.Drawing.Size(177, 22);
			this.priority.Text = "Set Priority";
			// 
			// noneToolStripMenuItem
			// 
			this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
			this.noneToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.noneToolStripMenuItem.Text = "None";
			this.noneToolStripMenuItem.Click += new System.EventHandler(this.TDnoneToolStripMenuItem_Click);
			// 
			// lowToolStripMenuItem
			// 
			this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
			this.lowToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.lowToolStripMenuItem.Text = "Low";
			this.lowToolStripMenuItem.Click += new System.EventHandler(this.TDlowToolStripMenuItem_Click);
			// 
			// mediumToolStripMenuItem
			// 
			this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
			this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.mediumToolStripMenuItem.Text = "Medium";
			this.mediumToolStripMenuItem.Click += new System.EventHandler(this.TDmediumToolStripMenuItem_Click);
			// 
			// highToolStripMenuItem
			// 
			this.highToolStripMenuItem.Name = "highToolStripMenuItem";
			this.highToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.highToolStripMenuItem.Text = "High";
			this.highToolStripMenuItem.Click += new System.EventHandler(this.TDhighToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
			// 
			// removeAllCompleatedItemsToolStripMenuItem
			// 
			this.removeAllCompleatedItemsToolStripMenuItem.Name = "removeAllCompleatedItemsToolStripMenuItem";
			this.removeAllCompleatedItemsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.removeAllCompleatedItemsToolStripMenuItem.Text = "Remove All Marked";
			this.removeAllCompleatedItemsToolStripMenuItem.Click += new System.EventHandler(this.TDremoveAllCompleatedItemsToolStripMenuItem_Click);
			// 
			// TimerStats
			// 
			this.TimerStats.ContextMenuStrip = this.TrayIconContextMenu;
			this.TimerStats.Icon = ((System.Drawing.Icon)(resources.GetObject("TimerStats.Icon")));
			this.TimerStats.Text = "TimerStats";
			this.TimerStats.Visible = true;
			this.TimerStats.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TimerStats_MouseClick);
			this.TimerStats.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TimerStats_MouseDoubleClick);
			// 
			// TrayIconContextMenu
			// 
			this.TrayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayCntOpenTimer,
            this.TrayCntQuickView,
            this.toolStripSeparator3,
            this.TrayCntOptions,
            this.TrayCntExit});
			this.TrayIconContextMenu.Name = "TrayIconContextMenu";
			this.TrayIconContextMenu.Size = new System.Drawing.Size(180, 98);
			// 
			// TrayCntOpenTimer
			// 
			this.TrayCntOpenTimer.Name = "TrayCntOpenTimer";
			this.TrayCntOpenTimer.Size = new System.Drawing.Size(179, 22);
			this.TrayCntOpenTimer.Text = "Open Timer Utilities";
			this.TrayCntOpenTimer.Click += new System.EventHandler(this.TrayCntOpenTimer_Click);
			// 
			// TrayCntQuickView
			// 
			this.TrayCntQuickView.Name = "TrayCntQuickView";
			this.TrayCntQuickView.Size = new System.Drawing.Size(179, 22);
			this.TrayCntQuickView.Text = "Quick View";
			this.TrayCntQuickView.Click += new System.EventHandler(this.TrayCntQuickView_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
			// 
			// TrayCntOptions
			// 
			this.TrayCntOptions.Name = "TrayCntOptions";
			this.TrayCntOptions.Size = new System.Drawing.Size(179, 22);
			this.TrayCntOptions.Text = "Options";
			this.TrayCntOptions.Click += new System.EventHandler(this.TrayCntOptions_Click);
			// 
			// TrayCntExit
			// 
			this.TrayCntExit.Name = "TrayCntExit";
			this.TrayCntExit.Size = new System.Drawing.Size(179, 22);
			this.TrayCntExit.Text = "Exit";
			this.TrayCntExit.Click += new System.EventHandler(this.TrayCntExit_Click);
			// 
			// MenuStrip
			// 
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenu,
            this.HelpStripMenu});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(379, 24);
			this.MenuStrip.TabIndex = 1;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// FileStripMenu
			// 
			this.FileStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenDataFile,
            this.OptionsDiag,
            this.ReloadData,
            this.toolStripSeparator1,
            this.ExitApp});
			this.FileStripMenu.Name = "FileStripMenu";
			this.FileStripMenu.Size = new System.Drawing.Size(37, 20);
			this.FileStripMenu.Text = "File";
			// 
			// OpenDataFile
			// 
			this.OpenDataFile.Name = "OpenDataFile";
			this.OpenDataFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.OpenDataFile.Size = new System.Drawing.Size(194, 22);
			this.OpenDataFile.Text = "Open Data File";
			this.OpenDataFile.Click += new System.EventHandler(this.OpenDataFile_Click);
			// 
			// OptionsDiag
			// 
			this.OptionsDiag.Name = "OptionsDiag";
			this.OptionsDiag.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.OptionsDiag.Size = new System.Drawing.Size(194, 22);
			this.OptionsDiag.Text = "Options";
			this.OptionsDiag.Click += new System.EventHandler(this.OptionsDiag_Click);
			// 
			// ReloadData
			// 
			this.ReloadData.Name = "ReloadData";
			this.ReloadData.Size = new System.Drawing.Size(194, 22);
			this.ReloadData.Text = "Reload Data File";
			this.ReloadData.Click += new System.EventHandler(this.ReloadData_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
			// 
			// ExitApp
			// 
			this.ExitApp.Name = "ExitApp";
			this.ExitApp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.ExitApp.Size = new System.Drawing.Size(194, 22);
			this.ExitApp.Text = "Exit";
			this.ExitApp.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// HelpStripMenu
			// 
			this.HelpStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpButton,
            this.AboutDiag});
			this.HelpStripMenu.Name = "HelpStripMenu";
			this.HelpStripMenu.Size = new System.Drawing.Size(44, 20);
			this.HelpStripMenu.Text = "Help";
			// 
			// HelpButton
			// 
			this.HelpButton.Name = "HelpButton";
			this.HelpButton.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.HelpButton.Size = new System.Drawing.Size(118, 22);
			this.HelpButton.Text = "Help";
			this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
			// 
			// AboutDiag
			// 
			this.AboutDiag.Name = "AboutDiag";
			this.AboutDiag.Size = new System.Drawing.Size(118, 22);
			this.AboutDiag.Text = "About";
			this.AboutDiag.Click += new System.EventHandler(this.AboutDiag_Click);
			// 
			// CDdisplay
			// 
			this.CDdisplay.BackColor = System.Drawing.SystemColors.Control;
			this.CDdisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CDdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CDdisplay.Location = new System.Drawing.Point(3, 6);
			this.CDdisplay.Name = "CDdisplay";
			this.CDdisplay.Size = new System.Drawing.Size(344, 38);
			this.CDdisplay.TabIndex = 11;
			this.CDdisplay.Text = "00 : 00 : 00";
			this.CDdisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CDdisplay.DoubleClick += new System.EventHandler(this.CDdisplay_DoubleClick);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(379, 353);
			this.Controls.Add(this.Clocks);
			this.Controls.Add(this.MenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuStrip;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Time Utilities";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
			this.Clocks.ResumeLayout(false);
			this.Stopwatch.ResumeLayout(false);
			this.Countdown.ResumeLayout(false);
			this.alarmOptions.ResumeLayout(false);
			this.alarmOptions.PerformLayout();
			this.KeyPad.ResumeLayout(false);
			this.todo.ResumeLayout(false);
			this.TodoMenu.ResumeLayout(false);
			this.TrayIconContextMenu.ResumeLayout(false);
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Clocks;
        private System.Windows.Forms.TabPage Stopwatch;
        private System.Windows.Forms.TabPage Countdown;
        private System.Windows.Forms.Button SWresetButton;
		private System.Windows.Forms.Button SWstartButton;
        private System.Windows.Forms.ListView SWLapTimes;
        private System.Windows.Forms.ColumnHeader lap;
		private System.Windows.Forms.ColumnHeader times;
        private System.Windows.Forms.Button CDstart;
        private System.Windows.Forms.Panel KeyPad;
        private System.Windows.Forms.Button KeyPadDel;
        private System.Windows.Forms.Button KeyPad0;
        private System.Windows.Forms.Button KeyPad3;
        private System.Windows.Forms.Button KeyPad2;
        private System.Windows.Forms.Button KeyPad1;
        private System.Windows.Forms.Button KeyPad6;
        private System.Windows.Forms.Button KeyPad5;
        private System.Windows.Forms.Button KeyPad4;
        private System.Windows.Forms.Button KeyPad9;
        private System.Windows.Forms.Button KeyPad8;
        private System.Windows.Forms.Button KeyPad7;
		private System.Windows.Forms.ProgressBar CDprogress;
        private System.Windows.Forms.Button CDresetB;
		private System.Windows.Forms.NotifyIcon TimerStats;
		private System.Windows.Forms.GroupBox alarmOptions;
		private System.Windows.Forms.CheckBox chkPopUp;
		private System.Windows.Forms.CheckBox chkTrayNot;
		private System.Windows.Forms.CheckBox chkRun;
		private System.Windows.Forms.CheckBox chkPlys;
		private System.Windows.Forms.CheckBox chkForeg;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
		private System.Windows.Forms.TabPage todo;
		private System.Windows.Forms.ToolTip toolTips;
		private System.Windows.Forms.ListView TDtodoList;
		private System.Windows.Forms.ColumnHeader X;
		private System.Windows.Forms.ColumnHeader ItemName;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem FileStripMenu;
		private System.Windows.Forms.ToolStripMenuItem OpenDataFile;
		private System.Windows.Forms.ToolStripMenuItem OptionsDiag;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ExitApp;
		private System.Windows.Forms.ContextMenuStrip TodoMenu;
		private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem removeAllCompleatedItemsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem priority;
		private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditItem;
		private System.Windows.Forms.ToolStripMenuItem HelpStripMenu;
		private System.Windows.Forms.ToolStripMenuItem HelpButton;
		private System.Windows.Forms.ToolStripMenuItem AboutDiag;
		private System.Windows.Forms.ToolStripMenuItem ReloadData;
		private System.Windows.Forms.ContextMenuStrip TrayIconContextMenu;
		private System.Windows.Forms.ToolStripMenuItem TrayCntOpenTimer;
		private System.Windows.Forms.ToolStripMenuItem TrayCntQuickView;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem TrayCntOptions;
		private System.Windows.Forms.ToolStripMenuItem TrayCntExit;
		private System.Windows.Forms.Label SWdisplay;
		private System.Windows.Forms.Label CDdisplay;

    }
}