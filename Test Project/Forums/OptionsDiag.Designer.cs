namespace Time_Utils {
	partial class OptionsDiag {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDiag));
			this.chkStartup = new System.Windows.Forms.CheckBox();
			this.Applybutton = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.ok = new System.Windows.Forms.Button();
			this.chkHideTaskbarIcon = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.DefaultTab = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.OverlayForeCol = new System.Windows.Forms.Button();
			this.OverlayForeColor = new System.Windows.Forms.Label();
			this.OverlayBckCol = new System.Windows.Forms.Label();
			this.OverlayBackCol = new System.Windows.Forms.Button();
			this.OptacySlider = new System.Windows.Forms.TrackBar();
			this.OptacyLabl = new System.Windows.Forms.Label();
			this.SetKey = new System.Windows.Forms.TextBox();
			this.StartSW = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.OptacySlider)).BeginInit();
			this.SuspendLayout();
			// 
			// chkStartup
			// 
			this.chkStartup.AutoSize = true;
			this.chkStartup.Location = new System.Drawing.Point(6, 19);
			this.chkStartup.Name = "chkStartup";
			this.chkStartup.Size = new System.Drawing.Size(100, 17);
			this.chkStartup.TabIndex = 0;
			this.chkStartup.Text = "Start on Startup";
			this.chkStartup.UseVisualStyleBackColor = true;
			this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
			// 
			// Applybutton
			// 
			this.Applybutton.Location = new System.Drawing.Point(322, 252);
			this.Applybutton.Name = "Applybutton";
			this.Applybutton.Size = new System.Drawing.Size(75, 23);
			this.Applybutton.TabIndex = 1;
			this.Applybutton.Text = "Apply";
			this.Applybutton.UseVisualStyleBackColor = true;
			this.Applybutton.Click += new System.EventHandler(this.Apply_Click);
			// 
			// Cancel
			// 
			this.Cancel.Location = new System.Drawing.Point(184, 308);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 2;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// ok
			// 
			this.ok.Location = new System.Drawing.Point(195, 213);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(75, 23);
			this.ok.TabIndex = 3;
			this.ok.Text = "Ok";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// chkHideTaskbarIcon
			// 
			this.chkHideTaskbarIcon.AutoSize = true;
			this.chkHideTaskbarIcon.Location = new System.Drawing.Point(6, 42);
			this.chkHideTaskbarIcon.Name = "chkHideTaskbarIcon";
			this.chkHideTaskbarIcon.Size = new System.Drawing.Size(114, 17);
			this.chkHideTaskbarIcon.TabIndex = 5;
			this.chkHideTaskbarIcon.Text = "Hide Taskbar Icon";
			this.chkHideTaskbarIcon.UseVisualStyleBackColor = true;
			this.chkHideTaskbarIcon.CheckedChanged += new System.EventHandler(this.chkHideTaskbarIcon_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkStartup);
			this.groupBox1.Controls.Add(this.chkHideTaskbarIcon);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(146, 137);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// DefaultTab
			// 
			this.DefaultTab.FormattingEnabled = true;
			this.DefaultTab.Items.AddRange(new object[] {
            "Stop Watch",
            "Count Down",
            "To-Do List"});
			this.DefaultTab.Location = new System.Drawing.Point(12, 268);
			this.DefaultTab.Name = "DefaultTab";
			this.DefaultTab.Size = new System.Drawing.Size(146, 21);
			this.DefaultTab.TabIndex = 7;
			this.DefaultTab.SelectedIndexChanged += new System.EventHandler(this.DefaultTab_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 223);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Default Tab:";
			// 
			// colorDialog1
			// 
			this.colorDialog1.FullOpen = true;
			// 
			// OverlayForeCol
			// 
			this.OverlayForeCol.Location = new System.Drawing.Point(207, 12);
			this.OverlayForeCol.Name = "OverlayForeCol";
			this.OverlayForeCol.Size = new System.Drawing.Size(159, 23);
			this.OverlayForeCol.TabIndex = 9;
			this.OverlayForeCol.Text = "Set Overlay Foreground Color";
			this.OverlayForeCol.UseVisualStyleBackColor = true;
			this.OverlayForeCol.Click += new System.EventHandler(this.button1_Click);
			// 
			// OverlayForeColor
			// 
			this.OverlayForeColor.AutoSize = true;
			this.OverlayForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OverlayForeColor.Location = new System.Drawing.Point(184, 20);
			this.OverlayForeColor.Name = "OverlayForeColor";
			this.OverlayForeColor.Size = new System.Drawing.Size(15, 15);
			this.OverlayForeColor.TabIndex = 10;
			this.OverlayForeColor.Text = "  ";
			// 
			// OverlayBckCol
			// 
			this.OverlayBckCol.AutoSize = true;
			this.OverlayBckCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OverlayBckCol.Location = new System.Drawing.Point(184, 54);
			this.OverlayBckCol.Name = "OverlayBckCol";
			this.OverlayBckCol.Size = new System.Drawing.Size(15, 15);
			this.OverlayBckCol.TabIndex = 11;
			this.OverlayBckCol.Text = "  ";
			// 
			// OverlayBackCol
			// 
			this.OverlayBackCol.Location = new System.Drawing.Point(207, 46);
			this.OverlayBackCol.Name = "OverlayBackCol";
			this.OverlayBackCol.Size = new System.Drawing.Size(159, 23);
			this.OverlayBackCol.TabIndex = 12;
			this.OverlayBackCol.Text = "Set Overlay Background Color";
			this.OverlayBackCol.UseVisualStyleBackColor = true;
			this.OverlayBackCol.Click += new System.EventHandler(this.OverlayBackCol_Click);
			// 
			// OptacySlider
			// 
			this.OptacySlider.LargeChange = 10;
			this.OptacySlider.Location = new System.Drawing.Point(184, 104);
			this.OptacySlider.Maximum = 100;
			this.OptacySlider.Name = "OptacySlider";
			this.OptacySlider.Size = new System.Drawing.Size(104, 45);
			this.OptacySlider.TabIndex = 13;
			this.OptacySlider.TickFrequency = 10;
			this.OptacySlider.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// OptacyLabl
			// 
			this.OptacyLabl.AutoSize = true;
			this.OptacyLabl.Location = new System.Drawing.Point(192, 88);
			this.OptacyLabl.Name = "OptacyLabl";
			this.OptacyLabl.Size = new System.Drawing.Size(73, 13);
			this.OptacyLabl.TabIndex = 14;
			this.OptacyLabl.Text = "Optacy: 100%";
			this.OptacyLabl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// SetKey
			// 
			this.SetKey.Enabled = false;
			this.SetKey.Location = new System.Drawing.Point(335, 104);
			this.SetKey.Name = "SetKey";
			this.SetKey.ReadOnly = true;
			this.SetKey.Size = new System.Drawing.Size(100, 20);
			this.SetKey.TabIndex = 15;
			this.SetKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetKey_KeyDown);
			this.SetKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SetKey_KeyUp);
			// 
			// StartSW
			// 
			this.StartSW.Location = new System.Drawing.Point(441, 104);
			this.StartSW.Name = "StartSW";
			this.StartSW.Size = new System.Drawing.Size(75, 23);
			this.StartSW.TabIndex = 16;
			this.StartSW.Text = "Start SW";
			this.StartSW.UseVisualStyleBackColor = true;
			this.StartSW.Click += new System.EventHandler(this.StartSW_Click);
			// 
			// OptionsDiag
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 343);
			this.Controls.Add(this.StartSW);
			this.Controls.Add(this.SetKey);
			this.Controls.Add(this.OptacyLabl);
			this.Controls.Add(this.OptacySlider);
			this.Controls.Add(this.OverlayBackCol);
			this.Controls.Add(this.OverlayBckCol);
			this.Controls.Add(this.OverlayForeColor);
			this.Controls.Add(this.OverlayForeCol);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DefaultTab);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Applybutton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionsDiag";
			this.Text = "Options";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.OptacySlider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkStartup;
		private System.Windows.Forms.Button Applybutton;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.CheckBox chkHideTaskbarIcon;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox DefaultTab;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button OverlayForeCol;
		private System.Windows.Forms.Label OverlayForeColor;
		private System.Windows.Forms.Label OverlayBckCol;
		private System.Windows.Forms.Button OverlayBackCol;
		private System.Windows.Forms.TrackBar OptacySlider;
		private System.Windows.Forms.Label OptacyLabl;
		private System.Windows.Forms.TextBox SetKey;
		private System.Windows.Forms.Button StartSW;
	}
}