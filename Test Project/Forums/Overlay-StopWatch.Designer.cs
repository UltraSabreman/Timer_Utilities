namespace Time_Utils {
	partial class StopWatchOverlay {
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
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.TimeDisp = new System.Windows.Forms.Label();
			this.Lap2 = new System.Windows.Forms.Label();
			this.Lap1 = new System.Windows.Forms.Label();
			this.Lapz = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1,
            this.rectangleShape1});
			this.shapeContainer1.Size = new System.Drawing.Size(166, 56);
			this.shapeContainer1.TabIndex = 8;
			this.shapeContainer1.TabStop = false;
			this.shapeContainer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
			// 
			// lineShape3
			// 
			this.lineShape3.Name = "lineShape3";
			this.lineShape3.X1 = 8;
			this.lineShape3.X2 = 83;
			this.lineShape3.Y1 = 8;
			this.lineShape3.Y2 = 31;
			// 
			// lineShape2
			// 
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 105;
			this.lineShape2.X2 = 105;
			this.lineShape2.Y1 = 26;
			this.lineShape2.Y2 = 55;
			this.lineShape2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
			// 
			// lineShape1
			// 
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 1;
			this.lineShape1.X2 = 165;
			this.lineShape1.Y1 = 26;
			this.lineShape1.Y2 = 26;
			this.lineShape1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
			// 
			// rectangleShape1
			// 
			this.rectangleShape1.FillColor = System.Drawing.Color.White;
			this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
			this.rectangleShape1.Location = new System.Drawing.Point(0, 0);
			this.rectangleShape1.Name = "rectangleShape1";
			this.rectangleShape1.Size = new System.Drawing.Size(165, 55);
			this.rectangleShape1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
			// 
			// TimeDisp
			// 
			this.TimeDisp.BackColor = System.Drawing.Color.White;
			this.TimeDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimeDisp.Location = new System.Drawing.Point(1, 1);
			this.TimeDisp.Name = "TimeDisp";
			this.TimeDisp.Size = new System.Drawing.Size(164, 25);
			this.TimeDisp.TabIndex = 6;
			this.TimeDisp.Text = "00:00:00.000";
			this.TimeDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TimeDisp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
			// 
			// Lap2
			// 
			this.Lap2.BackColor = System.Drawing.Color.White;
			this.Lap2.Location = new System.Drawing.Point(1, 40);
			this.Lap2.Name = "Lap2";
			this.Lap2.Size = new System.Drawing.Size(103, 13);
			this.Lap2.TabIndex = 4;
			this.Lap2.Text = "Lap 2: 00:00:00.000";
			this.Lap2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
			// 
			// Lap1
			// 
			this.Lap1.BackColor = System.Drawing.Color.White;
			this.Lap1.Location = new System.Drawing.Point(1, 27);
			this.Lap1.Name = "Lap1";
			this.Lap1.Size = new System.Drawing.Size(103, 13);
			this.Lap1.TabIndex = 3;
			this.Lap1.Text = "Lap 1: 00:00:00.000";
			this.Lap1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
			// 
			// Lapz
			// 
			this.Lapz.BackColor = System.Drawing.Color.White;
			this.Lapz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lapz.ForeColor = System.Drawing.Color.Black;
			this.Lapz.Location = new System.Drawing.Point(108, 30);
			this.Lapz.Name = "Lapz";
			this.Lapz.Size = new System.Drawing.Size(55, 18);
			this.Lapz.TabIndex = 9;
			this.Lapz.Text = "0";
			this.Lapz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StopWatchOverlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(166, 56);
			this.Controls.Add(this.Lapz);
			this.Controls.Add(this.TimeDisp);
			this.Controls.Add(this.Lap2);
			this.Controls.Add(this.Lap1);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StopWatchOverlay";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Overlay";
			this.TopMost = true;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
		private System.Windows.Forms.Label TimeDisp;
		private System.Windows.Forms.Label Lap2;
		private System.Windows.Forms.Label Lap1;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
		private System.Windows.Forms.Label Lapz;
	}
}