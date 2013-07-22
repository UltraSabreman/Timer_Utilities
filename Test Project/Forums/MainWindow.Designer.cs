namespace Timer_Utils
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "hhhhh",
            "hhhnnnnn333"}, -1);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.Clocks = new System.Windows.Forms.TabControl();
			this.Stopwatch = new System.Windows.Forms.TabPage();
			this.LapTimes = new System.Windows.Forms.ListView();
			this.lap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.times = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SWdisplay = new System.Windows.Forms.TextBox();
			this.SWreset = new System.Windows.Forms.Button();
			this.SWstart = new System.Windows.Forms.Button();
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
			this.CDdisplay = new System.Windows.Forms.TextBox();
			this.todo = new System.Windows.Forms.TabPage();
			this.TodoList = new System.Windows.Forms.ListView();
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
			this.Calendar = new System.Windows.Forms.TabPage();
			this.EventActions = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.BeifEventView = new System.Windows.Forms.ListView();
			this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Discription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Calender1 = new System.Windows.Forms.MonthCalendar();
			this.TimerStats = new System.Windows.Forms.NotifyIcon(this.components);
			this.toolTips = new System.Windows.Forms.ToolTip(this.components);
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Clocks.SuspendLayout();
			this.Stopwatch.SuspendLayout();
			this.Countdown.SuspendLayout();
			this.alarmOptions.SuspendLayout();
			this.KeyPad.SuspendLayout();
			this.todo.SuspendLayout();
			this.TodoMenu.SuspendLayout();
			this.Calendar.SuspendLayout();
			this.EventActions.SuspendLayout();
			this.MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// Clocks
			// 
			this.Clocks.Controls.Add(this.Stopwatch);
			this.Clocks.Controls.Add(this.Countdown);
			this.Clocks.Controls.Add(this.todo);
			this.Clocks.Controls.Add(this.Calendar);
			this.Clocks.Location = new System.Drawing.Point(12, 27);
			this.Clocks.Name = "Clocks";
			this.Clocks.SelectedIndex = 0;
			this.Clocks.Size = new System.Drawing.Size(358, 311);
			this.Clocks.TabIndex = 0;
			// 
			// Stopwatch
			// 
			this.Stopwatch.Controls.Add(this.LapTimes);
			this.Stopwatch.Controls.Add(this.SWdisplay);
			this.Stopwatch.Controls.Add(this.SWreset);
			this.Stopwatch.Controls.Add(this.SWstart);
			this.Stopwatch.Location = new System.Drawing.Point(4, 22);
			this.Stopwatch.Name = "Stopwatch";
			this.Stopwatch.Padding = new System.Windows.Forms.Padding(3);
			this.Stopwatch.Size = new System.Drawing.Size(350, 285);
			this.Stopwatch.TabIndex = 0;
			this.Stopwatch.Text = "Stop Watch";
			this.Stopwatch.UseVisualStyleBackColor = true;
			// 
			// LapTimes
			// 
			this.LapTimes.Activation = System.Windows.Forms.ItemActivation.TwoClick;
			this.LapTimes.AutoArrange = false;
			this.LapTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lap,
            this.times});
			this.LapTimes.FullRowSelect = true;
			this.LapTimes.GridLines = true;
			this.LapTimes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.LapTimes.Location = new System.Drawing.Point(3, 50);
			this.LapTimes.Name = "LapTimes";
			this.LapTimes.ShowGroups = false;
			this.LapTimes.Size = new System.Drawing.Size(344, 189);
			this.LapTimes.TabIndex = 3;
			this.LapTimes.UseCompatibleStateImageBehavior = false;
			this.LapTimes.View = System.Windows.Forms.View.Details;
			this.LapTimes.SelectedIndexChanged += new System.EventHandler(this.LapTimes_SelectedIndexChanged);
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
			// SWdisplay
			// 
			this.SWdisplay.BackColor = System.Drawing.SystemColors.Control;
			this.SWdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.SWdisplay.Location = new System.Drawing.Point(3, 6);
			this.SWdisplay.Name = "SWdisplay";
			this.SWdisplay.ReadOnly = true;
			this.SWdisplay.Size = new System.Drawing.Size(344, 38);
			this.SWdisplay.TabIndex = 2;
			this.SWdisplay.Text = "00 : 00 : 00";
			this.SWdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.SWdisplay.TextChanged += new System.EventHandler(this.SWdisplay_TextChanged);
			// 
			// SWreset
			// 
			this.SWreset.Location = new System.Drawing.Point(182, 245);
			this.SWreset.Name = "SWreset";
			this.SWreset.Size = new System.Drawing.Size(165, 34);
			this.SWreset.TabIndex = 1;
			this.SWreset.Text = "Reset";
			this.SWreset.UseVisualStyleBackColor = true;
			this.SWreset.TextChanged += new System.EventHandler(this.SWreset_TextChanged);
			this.SWreset.Click += new System.EventHandler(this.SWreset_Click);
			// 
			// SWstart
			// 
			this.SWstart.Location = new System.Drawing.Point(3, 245);
			this.SWstart.Name = "SWstart";
			this.SWstart.Size = new System.Drawing.Size(165, 34);
			this.SWstart.TabIndex = 0;
			this.SWstart.Text = "Start";
			this.SWstart.UseVisualStyleBackColor = true;
			this.SWstart.TextChanged += new System.EventHandler(this.SWstart_TextChanged);
			this.SWstart.Click += new System.EventHandler(this.SWstart_Click);
			// 
			// Countdown
			// 
			this.Countdown.Controls.Add(this.alarmOptions);
			this.Countdown.Controls.Add(this.CDresetB);
			this.Countdown.Controls.Add(this.CDprogress);
			this.Countdown.Controls.Add(this.CDstart);
			this.Countdown.Controls.Add(this.KeyPad);
			this.Countdown.Controls.Add(this.CDdisplay);
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
			// CDdisplay
			// 
			this.CDdisplay.BackColor = System.Drawing.SystemColors.ControlLight;
			this.CDdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.CDdisplay.ForeColor = System.Drawing.Color.Black;
			this.CDdisplay.Location = new System.Drawing.Point(3, 6);
			this.CDdisplay.Name = "CDdisplay";
			this.CDdisplay.ReadOnly = true;
			this.CDdisplay.Size = new System.Drawing.Size(344, 38);
			this.CDdisplay.TabIndex = 3;
			this.CDdisplay.Text = "00 : 00 : 00";
			this.CDdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.CDdisplay.BackColorChanged += new System.EventHandler(this.CDdisplay_BackColorChanged);
			this.CDdisplay.BindingContextChanged += new System.EventHandler(this.CDdisplay_BackColorChanged);
			// 
			// todo
			// 
			this.todo.Controls.Add(this.TodoList);
			this.todo.Location = new System.Drawing.Point(4, 22);
			this.todo.Name = "todo";
			this.todo.Padding = new System.Windows.Forms.Padding(3);
			this.todo.Size = new System.Drawing.Size(350, 285);
			this.todo.TabIndex = 2;
			this.todo.Text = "To-Do";
			this.todo.UseVisualStyleBackColor = true;
			// 
			// TodoList
			// 
			this.TodoList.AutoArrange = false;
			this.TodoList.CheckBoxes = true;
			this.TodoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.X,
            this.ItemName});
			this.TodoList.ContextMenuStrip = this.TodoMenu;
			this.TodoList.FullRowSelect = true;
			this.TodoList.GridLines = true;
			this.TodoList.Location = new System.Drawing.Point(3, 6);
			this.TodoList.Name = "TodoList";
			this.TodoList.RightToLeftLayout = true;
			this.TodoList.Size = new System.Drawing.Size(341, 276);
			this.TodoList.TabIndex = 2;
			this.TodoList.UseCompatibleStateImageBehavior = false;
			this.TodoList.View = System.Windows.Forms.View.Details;
			this.TodoList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TodoList_MouseDown);
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
			this.TodoMenu.Opening += new System.ComponentModel.CancelEventHandler(this.TodoMenu_Opening);
			// 
			// addItemToolStripMenuItem
			// 
			this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
			this.addItemToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.addItemToolStripMenuItem.Text = "Add Item";
			this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
			// 
			// EditItem
			// 
			this.EditItem.Name = "EditItem";
			this.EditItem.Size = new System.Drawing.Size(177, 22);
			this.EditItem.Text = "Edit Item";
			this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
			// 
			// removeItemToolStripMenuItem
			// 
			this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
			this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.removeItemToolStripMenuItem.Text = "Remove Item";
			this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
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
			this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
			// 
			// lowToolStripMenuItem
			// 
			this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
			this.lowToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.lowToolStripMenuItem.Text = "Low";
			this.lowToolStripMenuItem.Click += new System.EventHandler(this.lowToolStripMenuItem_Click);
			// 
			// mediumToolStripMenuItem
			// 
			this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
			this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.mediumToolStripMenuItem.Text = "Medium";
			this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
			// 
			// highToolStripMenuItem
			// 
			this.highToolStripMenuItem.Name = "highToolStripMenuItem";
			this.highToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.highToolStripMenuItem.Text = "High";
			this.highToolStripMenuItem.Click += new System.EventHandler(this.highToolStripMenuItem_Click);
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
			this.removeAllCompleatedItemsToolStripMenuItem.Click += new System.EventHandler(this.removeAllCompleatedItemsToolStripMenuItem_Click);
			// 
			// Calendar
			// 
			this.Calendar.Controls.Add(this.EventActions);
			this.Calendar.Controls.Add(this.BeifEventView);
			this.Calendar.Controls.Add(this.Calender1);
			this.Calendar.Location = new System.Drawing.Point(4, 22);
			this.Calendar.Name = "Calendar";
			this.Calendar.Padding = new System.Windows.Forms.Padding(3);
			this.Calendar.Size = new System.Drawing.Size(350, 285);
			this.Calendar.TabIndex = 3;
			this.Calendar.Text = "Calendar";
			this.Calendar.UseVisualStyleBackColor = true;
			// 
			// EventActions
			// 
			this.EventActions.Controls.Add(this.textBox1);
			this.EventActions.Controls.Add(this.button4);
			this.EventActions.Controls.Add(this.button3);
			this.EventActions.Controls.Add(this.button2);
			this.EventActions.Controls.Add(this.button1);
			this.EventActions.Location = new System.Drawing.Point(235, 6);
			this.EventActions.Name = "EventActions";
			this.EventActions.Size = new System.Drawing.Size(112, 158);
			this.EventActions.TabIndex = 2;
			this.EventActions.TabStop = false;
			this.EventActions.Text = "Event";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(58, 100);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(48, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(6, 129);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Details";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(58, 129);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 100);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// BeifEventView
			// 
			this.BeifEventView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Discription});
			this.BeifEventView.GridLines = true;
			this.BeifEventView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.BeifEventView.Location = new System.Drawing.Point(2, 170);
			this.BeifEventView.Name = "BeifEventView";
			this.BeifEventView.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.BeifEventView.Size = new System.Drawing.Size(342, 112);
			this.BeifEventView.TabIndex = 1;
			this.BeifEventView.UseCompatibleStateImageBehavior = false;
			this.BeifEventView.View = System.Windows.Forms.View.Details;
			// 
			// Title
			// 
			this.Title.Text = "Title";
			this.Title.Width = 76;
			// 
			// Discription
			// 
			this.Discription.Text = "Discription";
			this.Discription.Width = 259;
			// 
			// Calender1
			// 
			this.Calender1.Location = new System.Drawing.Point(2, 3);
			this.Calender1.Name = "Calender1";
			this.Calender1.TabIndex = 0;
			// 
			// TimerStats
			// 
			this.TimerStats.Icon = ((System.Drawing.Icon)(resources.GetObject("TimerStats.Icon")));
			this.TimerStats.Text = "TimerStats";
			this.TimerStats.Visible = true;
			this.TimerStats.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TimerStats_MouseClick);
			this.TimerStats.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TimerStats_MouseDoubleClick);
			// 
			// MenuStrip
			// 
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(379, 24);
			this.MenuStrip.TabIndex = 1;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
			this.toolStripMenuItem1.Text = "Open Data File";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.optionsToolStripMenuItem.Text = "Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(7, 19);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(100, 75);
			this.textBox1.TabIndex = 6;
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
			this.Text = "Timer Stuff";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
			this.Clocks.ResumeLayout(false);
			this.Stopwatch.ResumeLayout(false);
			this.Stopwatch.PerformLayout();
			this.Countdown.ResumeLayout(false);
			this.Countdown.PerformLayout();
			this.alarmOptions.ResumeLayout(false);
			this.alarmOptions.PerformLayout();
			this.KeyPad.ResumeLayout(false);
			this.todo.ResumeLayout(false);
			this.TodoMenu.ResumeLayout(false);
			this.Calendar.ResumeLayout(false);
			this.EventActions.ResumeLayout(false);
			this.EventActions.PerformLayout();
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Clocks;
        private System.Windows.Forms.TabPage Stopwatch;
        private System.Windows.Forms.TabPage Countdown;
        private System.Windows.Forms.Button SWreset;
        private System.Windows.Forms.Button SWstart;
		private System.Windows.Forms.TextBox SWdisplay;
        private System.Windows.Forms.ListView LapTimes;
        private System.Windows.Forms.ColumnHeader lap;
        private System.Windows.Forms.ColumnHeader times;
        private System.Windows.Forms.TextBox CDdisplay;
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
		private System.Windows.Forms.ListView TodoList;
		private System.Windows.Forms.ColumnHeader X;
		private System.Windows.Forms.ColumnHeader ItemName;
		private System.Windows.Forms.TabPage Calendar;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
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
		private System.Windows.Forms.MonthCalendar Calender1;
		private System.Windows.Forms.GroupBox EventActions;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListView BeifEventView;
		private System.Windows.Forms.ColumnHeader Title;
		private System.Windows.Forms.ColumnHeader Discription;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox1;

    }
}