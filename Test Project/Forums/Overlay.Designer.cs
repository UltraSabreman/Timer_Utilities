namespace Time_Utils {
	partial class Overlay {
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
			this.Display = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
			this.SuspendLayout();
			// 
			// Display
			// 
			this.Display.BackColor = System.Drawing.Color.Transparent;
			this.Display.ErrorImage = null;
			this.Display.InitialImage = null;
			this.Display.Location = new System.Drawing.Point(0, 0);
			this.Display.Name = "Display";
			this.Display.Size = new System.Drawing.Size(160, 43);
			this.Display.TabIndex = 0;
			this.Display.TabStop = false;
			this.Display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Display_MouseDown);
			// 
			// Overlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(160, 43);
			this.ControlBox = false;
			this.Controls.Add(this.Display);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Overlay";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Overlay";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Overlay_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Display;
	}
}