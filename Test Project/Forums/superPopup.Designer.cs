namespace Time_Utils {
	partial class superPopup {
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
			this.dismiss = new System.Windows.Forms.Button();
			this.done = new System.Windows.Forms.Label();
			this.overLabel = new System.Windows.Forms.Label();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.SuspendLayout();
			// 
			// dismiss
			// 
			this.dismiss.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.dismiss.Location = new System.Drawing.Point(205, 47);
			this.dismiss.Name = "dismiss";
			this.dismiss.Size = new System.Drawing.Size(59, 22);
			this.dismiss.TabIndex = 1;
			this.dismiss.Text = "Dissmiss";
			this.dismiss.UseVisualStyleBackColor = true;
			this.dismiss.Click += new System.EventHandler(this.dismiss_Click);
			// 
			// done
			// 
			this.done.AutoSize = true;
			this.done.BackColor = System.Drawing.Color.White;
			this.done.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.done.ForeColor = System.Drawing.Color.Red;
			this.done.Location = new System.Drawing.Point(10, 9);
			this.done.Name = "done";
			this.done.Size = new System.Drawing.Size(254, 35);
			this.done.TabIndex = 2;
			this.done.Text = "Countdown Done";
			this.done.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.done.MouseDown += new System.Windows.Forms.MouseEventHandler(this.superPopup_MouseDown);
			// 
			// overLabel
			// 
			this.overLabel.AutoSize = true;
			this.overLabel.BackColor = System.Drawing.Color.White;
			this.overLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.overLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.overLabel.Location = new System.Drawing.Point(10, 48);
			this.overLabel.Name = "overLabel";
			this.overLabel.Size = new System.Drawing.Size(189, 20);
			this.overLabel.TabIndex = 3;
			this.overLabel.Text = "Overdue by: 00 : 00 : 00";
			this.overLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.overLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.superPopup_MouseDown);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
			this.shapeContainer1.Size = new System.Drawing.Size(276, 80);
			this.shapeContainer1.TabIndex = 4;
			this.shapeContainer1.TabStop = false;
			// 
			// rectangleShape1
			// 
			this.rectangleShape1.Location = new System.Drawing.Point(0, 0);
			this.rectangleShape1.Name = "rectangleShape1";
			this.rectangleShape1.Size = new System.Drawing.Size(275, 79);
			// 
			// superPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 80);
			this.ControlBox = false;
			this.Controls.Add(this.overLabel);
			this.Controls.Add(this.done);
			this.Controls.Add(this.dismiss);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "superPopup";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "superPopup";
			this.TopMost = true;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.superPopup_MouseDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button dismiss;
		private System.Windows.Forms.Label done;
		private System.Windows.Forms.Label overLabel;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
	}
}