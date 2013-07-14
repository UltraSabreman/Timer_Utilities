using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Utils {
	public partial class FileDialog : Form {
		////////////////////////////////////
		// Private Members
		public delegate void fileDelgate(string s);

		////////////////////////////////////
		// Public Members
		private fileDelgate test;
		private string file;
		private bool badFile;

		////////////////////////////////////
		// Properties

		////////////////////////////////////
		// Public Methods
		public FileDialog(fileDelgate f, string filepath = "") {
			InitializeComponent();

			test = new fileDelgate(f);

			file = filepath;
			filePathBox.Text = filepath;
		}

		////////////////////////////////////
		// Private Methods
		private void browse_Click(object sender, EventArgs e) {
			try {
				sysFileDialog.ShowDialog();
			} catch (System.IndexOutOfRangeException) {
			}
		}

		private void cancel_Click(object sender, EventArgs e) {
			this.Dispose();
		}

		private void ok_Click(object sender, EventArgs e) {
			openFile();

			if (badFile)
				test("");
			else
				test(file);

			this.Dispose();
		}

		private void openFile() {
			try {
				sysFileDialog.FileName = filePathBox.Text;
				sysFileDialog.OpenFile();
				badFile = false;
			} catch (System.IndexOutOfRangeException) {
				MessageBox.Show("Bad sdfs");
				badFile = true;
			} catch (System.IO.DirectoryNotFoundException) {
				MessageBox.Show("Bad Filepath");
				badFile = true;
			} catch (System.IO.FileNotFoundException) {
				MessageBox.Show("Bad Filepath");
				badFile = true;
			}

			if (!badFile) {
				file = sysFileDialog.FileName;
			}
		}

		private void filePathBox_TextChanged(object sender, EventArgs e) {
			filePathBox.Update();
		}

		private void sysFileDialog_FileOk(object sender, CancelEventArgs e) {
			filePathBox.Text = sysFileDialog.FileName;
			filePathBox.Update();
		}
	}
}
