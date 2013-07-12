namespace Timer_Utils {
	partial class FileDialog {
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
			this.filePathBox = new System.Windows.Forms.TextBox();
			this.ok = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.browse = new System.Windows.Forms.Button();
			this.sysFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// filePathBox
			// 
			this.filePathBox.Location = new System.Drawing.Point(12, 12);
			this.filePathBox.Name = "filePathBox";
			this.filePathBox.Size = new System.Drawing.Size(112, 20);
			this.filePathBox.TabIndex = 0;
			this.filePathBox.TextChanged += new System.EventHandler(this.filePathBox_TextChanged);
			// 
			// ok
			// 
			this.ok.Location = new System.Drawing.Point(93, 38);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(75, 23);
			this.ok.TabIndex = 1;
			this.ok.Text = "Ok";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(12, 38);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 2;
			this.cancel.Text = "Cancel";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// browse
			// 
			this.browse.Location = new System.Drawing.Point(130, 12);
			this.browse.Name = "browse";
			this.browse.Size = new System.Drawing.Size(38, 20);
			this.browse.TabIndex = 3;
			this.browse.Text = "...";
			this.browse.UseVisualStyleBackColor = true;
			this.browse.Click += new System.EventHandler(this.browse_Click);
			// 
			// sysFileDialog
			// 
			this.sysFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.sysFileDialog_FileOk);
			// 
			// FileDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(179, 68);
			this.Controls.Add(this.browse);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.filePathBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FileDialog";
			this.Text = "Enter Filename";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox filePathBox;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Button browse;
		private System.Windows.Forms.OpenFileDialog sysFileDialog;
	}
}