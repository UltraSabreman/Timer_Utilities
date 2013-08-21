namespace Timer_Utils {
	partial class AboutDiag {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDiag));
			this.Ok = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.Sourcelink = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// Ok
			// 
			this.Ok.Location = new System.Drawing.Point(199, 104);
			this.Ok.Name = "Ok";
			this.Ok.Size = new System.Drawing.Size(75, 23);
			this.Ok.TabIndex = 0;
			this.Ok.Text = "Ok";
			this.Ok.UseVisualStyleBackColor = true;
			this.Ok.Click += new System.EventHandler(this.Ok_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Enabled = false;
			this.richTextBox1.Location = new System.Drawing.Point(13, 13);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(261, 85);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "This program was desinged to help me learn C# \nand Windows Form Progrmaing. It\'s " +
    "been a nice\nchallange and I hope that you find it as usefull \nas I have.\n\n- Sabr" +
    "eman";
			// 
			// Sourcelink
			// 
			this.Sourcelink.AutoSize = true;
			this.Sourcelink.Location = new System.Drawing.Point(13, 105);
			this.Sourcelink.Name = "Sourcelink";
			this.Sourcelink.Size = new System.Drawing.Size(68, 13);
			this.Sourcelink.TabIndex = 2;
			this.Sourcelink.TabStop = true;
			this.Sourcelink.Text = "Source code";
			this.Sourcelink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Sourcelink_LinkClicked);
			// 
			// AboutDiag
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 137);
			this.Controls.Add(this.Sourcelink);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.Ok);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDiag";
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Ok;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.LinkLabel Sourcelink;
	}
}