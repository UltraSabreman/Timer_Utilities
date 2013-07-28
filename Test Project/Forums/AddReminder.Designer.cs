namespace Timer_Utils {
	partial class AddReminder {
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
			this.Type = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Delay = new System.Windows.Forms.NumericUpDown();
			this.DelayType = new System.Windows.Forms.ComboBox();
			this.Ok = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Delay)).BeginInit();
			this.SuspendLayout();
			// 
			// Type
			// 
			this.Type.FormattingEnabled = true;
			this.Type.Items.AddRange(new object[] {
            "Popup",
            "Alarm",
            "Email"});
			this.Type.Location = new System.Drawing.Point(7, 11);
			this.Type.Name = "Type";
			this.Type.Size = new System.Drawing.Size(61, 21);
			this.Type.TabIndex = 0;
			this.Type.Text = "Email";
			this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Delay);
			this.groupBox1.Controls.Add(this.DelayType);
			this.groupBox1.Controls.Add(this.Type);
			this.groupBox1.Location = new System.Drawing.Point(5, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(223, 39);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// Delay
			// 
			this.Delay.Location = new System.Drawing.Point(74, 12);
			this.Delay.Name = "Delay";
			this.Delay.Size = new System.Drawing.Size(57, 20);
			this.Delay.TabIndex = 4;
			this.Delay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.Delay.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// DelayType
			// 
			this.DelayType.FormattingEnabled = true;
			this.DelayType.Items.AddRange(new object[] {
            "Minutes",
            "Hours",
            "Days",
            "Weeks"});
			this.DelayType.Location = new System.Drawing.Point(137, 11);
			this.DelayType.Name = "DelayType";
			this.DelayType.Size = new System.Drawing.Size(78, 21);
			this.DelayType.TabIndex = 3;
			this.DelayType.Text = "Minutes";
			this.DelayType.SelectedIndexChanged += new System.EventHandler(this.IntervalType_SelectedIndexChanged);
			// 
			// Ok
			// 
			this.Ok.Location = new System.Drawing.Point(153, 47);
			this.Ok.Name = "Ok";
			this.Ok.Size = new System.Drawing.Size(75, 23);
			this.Ok.TabIndex = 3;
			this.Ok.Text = "Ok";
			this.Ok.UseVisualStyleBackColor = true;
			this.Ok.Click += new System.EventHandler(this.Ok_Click);
			// 
			// Cancel
			// 
			this.Cancel.Location = new System.Drawing.Point(72, 47);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 4;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// AddReminder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 75);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Ok);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AddReminder";
			this.Text = "Add A Reminder";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Delay)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox Type;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown Delay;
		private System.Windows.Forms.ComboBox DelayType;
		private System.Windows.Forms.Button Ok;
		private System.Windows.Forms.Button Cancel;
	}
}