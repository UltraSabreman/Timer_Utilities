namespace Timer_Utils {
	partial class AddEventDialouge {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Title = new System.Windows.Forms.TextBox();
			this.RepatOptions = new System.Windows.Forms.GroupBox();
			this.RepeatIntervalBox = new System.Windows.Forms.NumericUpDown();
			this.CheckSun = new System.Windows.Forms.CheckBox();
			this.CheckSat = new System.Windows.Forms.CheckBox();
			this.CheckThu = new System.Windows.Forms.CheckBox();
			this.CheckWed = new System.Windows.Forms.CheckBox();
			this.CheckFri = new System.Windows.Forms.CheckBox();
			this.CheckTue = new System.Windows.Forms.CheckBox();
			this.CheckMon = new System.Windows.Forms.CheckBox();
			this.RepeatTypeBox = new System.Windows.Forms.ComboBox();
			this.EndOn = new System.Windows.Forms.GroupBox();
			this.EndNever = new System.Windows.Forms.RadioButton();
			this.EndDateBox = new System.Windows.Forms.DateTimePicker();
			this.EndTimesBox = new System.Windows.Forms.NumericUpDown();
			this.EndDate = new System.Windows.Forms.RadioButton();
			this.EndTimes = new System.Windows.Forms.RadioButton();
			this.Discription = new System.Windows.Forms.RichTextBox();
			this.StartDate = new System.Windows.Forms.MonthCalendar();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Days = new System.Windows.Forms.GroupBox();
			this.Ok = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.RepatOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RepeatIntervalBox)).BeginInit();
			this.EndOn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.EndTimesBox)).BeginInit();
			this.Days.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.Cancel);
			this.groupBox1.Controls.Add(this.Ok);
			this.groupBox1.Controls.Add(this.Title);
			this.groupBox1.Controls.Add(this.RepatOptions);
			this.groupBox1.Controls.Add(this.Discription);
			this.groupBox1.Controls.Add(this.StartDate);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(474, 413);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// Title
			// 
			this.Title.Location = new System.Drawing.Point(6, 186);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(227, 20);
			this.Title.TabIndex = 1;
			this.Title.Text = "Title";
			this.Title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// RepatOptions
			// 
			this.RepatOptions.Controls.Add(this.Days);
			this.RepatOptions.Controls.Add(this.RepeatTypeBox);
			this.RepatOptions.Controls.Add(this.EndOn);
			this.RepatOptions.Location = new System.Drawing.Point(245, 7);
			this.RepatOptions.Name = "RepatOptions";
			this.RepatOptions.Size = new System.Drawing.Size(221, 199);
			this.RepatOptions.TabIndex = 3;
			this.RepatOptions.TabStop = false;
			this.RepatOptions.Text = "Repat Options";
			// 
			// RepeatIntervalBox
			// 
			this.RepeatIntervalBox.Location = new System.Drawing.Point(155, 31);
			this.RepeatIntervalBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.RepeatIntervalBox.Name = "RepeatIntervalBox";
			this.RepeatIntervalBox.Size = new System.Drawing.Size(49, 20);
			this.RepeatIntervalBox.TabIndex = 7;
			this.toolTip1.SetToolTip(this.RepeatIntervalBox, "Repeate Every X Days/Weeks/Months/Years");
			this.RepeatIntervalBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// CheckSun
			// 
			this.CheckSun.AutoSize = true;
			this.CheckSun.Location = new System.Drawing.Point(100, 34);
			this.CheckSun.Name = "CheckSun";
			this.CheckSun.Size = new System.Drawing.Size(45, 17);
			this.CheckSun.TabIndex = 6;
			this.CheckSun.Text = "Sun";
			this.CheckSun.UseVisualStyleBackColor = true;
			// 
			// CheckSat
			// 
			this.CheckSat.AutoSize = true;
			this.CheckSat.Location = new System.Drawing.Point(53, 34);
			this.CheckSat.Name = "CheckSat";
			this.CheckSat.Size = new System.Drawing.Size(42, 17);
			this.CheckSat.TabIndex = 5;
			this.CheckSat.Text = "Sat";
			this.CheckSat.UseVisualStyleBackColor = true;
			// 
			// CheckThu
			// 
			this.CheckThu.AutoSize = true;
			this.CheckThu.Location = new System.Drawing.Point(155, 11);
			this.CheckThu.Name = "CheckThu";
			this.CheckThu.Size = new System.Drawing.Size(45, 17);
			this.CheckThu.TabIndex = 3;
			this.CheckThu.Text = "Thu";
			this.CheckThu.UseVisualStyleBackColor = true;
			// 
			// CheckWed
			// 
			this.CheckWed.AutoSize = true;
			this.CheckWed.Location = new System.Drawing.Point(100, 11);
			this.CheckWed.Name = "CheckWed";
			this.CheckWed.Size = new System.Drawing.Size(49, 17);
			this.CheckWed.TabIndex = 2;
			this.CheckWed.Text = "Wed";
			this.CheckWed.UseVisualStyleBackColor = true;
			// 
			// CheckFri
			// 
			this.CheckFri.AutoSize = true;
			this.CheckFri.Location = new System.Drawing.Point(6, 34);
			this.CheckFri.Name = "CheckFri";
			this.CheckFri.Size = new System.Drawing.Size(37, 17);
			this.CheckFri.TabIndex = 4;
			this.CheckFri.Text = "Fri";
			this.CheckFri.UseVisualStyleBackColor = true;
			// 
			// CheckTue
			// 
			this.CheckTue.AutoSize = true;
			this.CheckTue.Location = new System.Drawing.Point(53, 11);
			this.CheckTue.Name = "CheckTue";
			this.CheckTue.Size = new System.Drawing.Size(45, 17);
			this.CheckTue.TabIndex = 1;
			this.CheckTue.Text = "Tue";
			this.CheckTue.UseVisualStyleBackColor = true;
			// 
			// CheckMon
			// 
			this.CheckMon.AutoSize = true;
			this.CheckMon.Location = new System.Drawing.Point(6, 11);
			this.CheckMon.Name = "CheckMon";
			this.CheckMon.Size = new System.Drawing.Size(47, 17);
			this.CheckMon.TabIndex = 0;
			this.CheckMon.Text = "Mon";
			this.CheckMon.UseVisualStyleBackColor = true;
			// 
			// RepeatTypeBox
			// 
			this.RepeatTypeBox.FormattingEnabled = true;
			this.RepeatTypeBox.Items.AddRange(new object[] {
            "None",
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
			this.RepeatTypeBox.Location = new System.Drawing.Point(6, 19);
			this.RepeatTypeBox.Name = "RepeatTypeBox";
			this.RepeatTypeBox.Size = new System.Drawing.Size(208, 21);
			this.RepeatTypeBox.TabIndex = 0;
			this.RepeatTypeBox.Text = "Please Select";
			this.RepeatTypeBox.SelectedIndexChanged += new System.EventHandler(this.RepeatTypeBox_SelectedIndexChanged);
			// 
			// EndOn
			// 
			this.EndOn.Controls.Add(this.EndNever);
			this.EndOn.Controls.Add(this.EndDateBox);
			this.EndOn.Controls.Add(this.EndTimesBox);
			this.EndOn.Controls.Add(this.EndDate);
			this.EndOn.Controls.Add(this.EndTimes);
			this.EndOn.Location = new System.Drawing.Point(6, 104);
			this.EndOn.Name = "EndOn";
			this.EndOn.Size = new System.Drawing.Size(208, 89);
			this.EndOn.TabIndex = 2;
			this.EndOn.TabStop = false;
			this.EndOn.Text = "End On";
			// 
			// EndNever
			// 
			this.EndNever.AutoSize = true;
			this.EndNever.Checked = true;
			this.EndNever.Location = new System.Drawing.Point(6, 19);
			this.EndNever.Name = "EndNever";
			this.EndNever.Size = new System.Drawing.Size(54, 17);
			this.EndNever.TabIndex = 0;
			this.EndNever.TabStop = true;
			this.EndNever.Text = "Never";
			this.EndNever.UseVisualStyleBackColor = true;
			this.EndNever.CheckedChanged += new System.EventHandler(this.EndNever_CheckedChanged);
			// 
			// EndDateBox
			// 
			this.EndDateBox.Enabled = false;
			this.EndDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.EndDateBox.Location = new System.Drawing.Point(100, 62);
			this.EndDateBox.Name = "EndDateBox";
			this.EndDateBox.Size = new System.Drawing.Size(102, 20);
			this.EndDateBox.TabIndex = 4;
			// 
			// EndTimesBox
			// 
			this.EndTimesBox.Enabled = false;
			this.EndTimesBox.Location = new System.Drawing.Point(100, 39);
			this.EndTimesBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.EndTimesBox.Name = "EndTimesBox";
			this.EndTimesBox.Size = new System.Drawing.Size(102, 20);
			this.EndTimesBox.TabIndex = 2;
			this.EndTimesBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// EndDate
			// 
			this.EndDate.AutoSize = true;
			this.EndDate.Location = new System.Drawing.Point(6, 65);
			this.EndDate.Name = "EndDate";
			this.EndDate.Size = new System.Drawing.Size(65, 17);
			this.EndDate.TabIndex = 3;
			this.EndDate.Text = "On Date";
			this.EndDate.UseVisualStyleBackColor = true;
			this.EndDate.CheckedChanged += new System.EventHandler(this.EndDate_CheckedChanged);
			// 
			// EndTimes
			// 
			this.EndTimes.AutoSize = true;
			this.EndTimes.Location = new System.Drawing.Point(6, 42);
			this.EndTimes.Name = "EndTimes";
			this.EndTimes.Size = new System.Drawing.Size(88, 17);
			this.EndTimes.TabIndex = 1;
			this.EndTimes.Text = "After X Times";
			this.EndTimes.UseVisualStyleBackColor = true;
			this.EndTimes.CheckedChanged += new System.EventHandler(this.EndTimes_CheckedChanged);
			// 
			// Discription
			// 
			this.Discription.AutoWordSelection = true;
			this.Discription.HideSelection = false;
			this.Discription.Location = new System.Drawing.Point(6, 218);
			this.Discription.Name = "Discription";
			this.Discription.Size = new System.Drawing.Size(460, 160);
			this.Discription.TabIndex = 2;
			this.Discription.Text = "Discription";
			// 
			// StartDate
			// 
			this.StartDate.BackColor = System.Drawing.SystemColors.Window;
			this.StartDate.Location = new System.Drawing.Point(6, 12);
			this.StartDate.MaxSelectionCount = 1;
			this.StartDate.Name = "StartDate";
			this.StartDate.TabIndex = 0;
			this.StartDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
			// 
			// Days
			// 
			this.Days.BackColor = System.Drawing.Color.Transparent;
			this.Days.Controls.Add(this.RepeatIntervalBox);
			this.Days.Controls.Add(this.CheckWed);
			this.Days.Controls.Add(this.CheckThu);
			this.Days.Controls.Add(this.CheckSun);
			this.Days.Controls.Add(this.CheckTue);
			this.Days.Controls.Add(this.CheckMon);
			this.Days.Controls.Add(this.CheckSat);
			this.Days.Controls.Add(this.CheckFri);
			this.Days.Location = new System.Drawing.Point(6, 43);
			this.Days.Name = "Days";
			this.Days.Size = new System.Drawing.Size(208, 58);
			this.Days.TabIndex = 1;
			this.Days.TabStop = false;
			// 
			// Ok
			// 
			this.Ok.Location = new System.Drawing.Point(393, 384);
			this.Ok.Name = "Ok";
			this.Ok.Size = new System.Drawing.Size(75, 23);
			this.Ok.TabIndex = 5;
			this.Ok.Text = "Ok";
			this.Ok.UseVisualStyleBackColor = true;
			// 
			// Cancel
			// 
			this.Cancel.Location = new System.Drawing.Point(312, 384);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 4;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			// 
			// ToDoDialouge
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 436);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ToDoDialouge";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Add a To-Do Item";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.RepatOptions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.RepeatIntervalBox)).EndInit();
			this.EndOn.ResumeLayout(false);
			this.EndOn.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.EndTimesBox)).EndInit();
			this.Days.ResumeLayout(false);
			this.Days.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox Discription;
		private System.Windows.Forms.MonthCalendar StartDate;
		private System.Windows.Forms.GroupBox RepatOptions;
		private System.Windows.Forms.TextBox Title;
		private System.Windows.Forms.GroupBox EndOn;
		private System.Windows.Forms.RadioButton EndNever;
		private System.Windows.Forms.DateTimePicker EndDateBox;
		private System.Windows.Forms.NumericUpDown EndTimesBox;
		private System.Windows.Forms.RadioButton EndDate;
		private System.Windows.Forms.RadioButton EndTimes;
		private System.Windows.Forms.CheckBox CheckSun;
		private System.Windows.Forms.CheckBox CheckSat;
		private System.Windows.Forms.CheckBox CheckThu;
		private System.Windows.Forms.CheckBox CheckWed;
		private System.Windows.Forms.CheckBox CheckFri;
		private System.Windows.Forms.CheckBox CheckTue;
		private System.Windows.Forms.CheckBox CheckMon;
		private System.Windows.Forms.ComboBox RepeatTypeBox;
		private System.Windows.Forms.NumericUpDown RepeatIntervalBox;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.GroupBox Days;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Ok;
	}
}