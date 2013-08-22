namespace Time_Utils {
	partial class CountDownOverlay {
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
			this.TimeDisp = new System.Windows.Forms.Label();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.AlarmFlash = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// TimeDisp
			// 
			this.TimeDisp.BackColor = System.Drawing.Color.White;
			this.TimeDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimeDisp.Location = new System.Drawing.Point(1, 1);
			this.TimeDisp.Name = "TimeDisp";
			this.TimeDisp.Size = new System.Drawing.Size(118, 25);
			this.TimeDisp.TabIndex = 7;
			this.TimeDisp.Text = "00:00:00";
			this.TimeDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TimeDisp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
			this.shapeContainer1.Size = new System.Drawing.Size(120, 27);
			this.shapeContainer1.TabIndex = 8;
			this.shapeContainer1.TabStop = false;
			// 
			// rectangleShape1
			// 
			this.rectangleShape1.BackColor = System.Drawing.Color.White;
			this.rectangleShape1.FillColor = System.Drawing.Color.White;
			this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
			this.rectangleShape1.Location = new System.Drawing.Point(0, 0);
			this.rectangleShape1.Name = "rectangleShape1";
			this.rectangleShape1.Size = new System.Drawing.Size(119, 26);
			this.rectangleShape1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
			// 
			// AlarmFlash
			// 
			this.AlarmFlash.Interval = 500;
			// 
			// CountDownOverlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(120, 27);
			this.Controls.Add(this.TimeDisp);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CountDownOverlay";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CountDownOverlay_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label TimeDisp;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
		private System.Windows.Forms.Timer AlarmFlash;
	}
}