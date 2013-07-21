using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Timer_Utils {
	public partial class MainWindow : Form {
		////////////////////////////////////
		// Private Members

		////////////////////////////////////
		// Public Members

		////////////////////////////////////
		// Properties

		////////////////////////////////////
		// Private Methods

		////////////////////////////////////
		// Public Methods
		private bool warned = false;
		private string optionsPath = "";
		
		public MainWindow(string path = "settings.txt") {
			optionsPath = path;
			InitializeComponent();
			SWinitTab();
			CDinitTab();
			TDtabInit();
		}

		private void Form1_SizeChanged(object sender, EventArgs e) {
			if (WindowState == FormWindowState.Minimized) {
				// Do some stuff
				if (!warned) {
					TimerStats.ShowBalloonTip(1000, "Timer Stuff", "Timer Stuff has been minimzed to the tray. \n Double-Click icon to open, right click to check status.", ToolTipIcon.Info);
					warned = true;
				}
				this.ShowInTaskbar = false;
			} else {
				this.ShowInTaskbar = true;
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			TimerStats.Visible = false;
			dumpTodo();
		}

		private void TimerStats_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button != MouseButtons.Right) return;
			
			string title = "Timer Stuff";
			string tip = "";

			if (!stopw.Running && !countd.Running) {
				tip = "Nothing is running.";
			}

			if (stopw.Running)
				tip += "SW: " + stopw.TimeString + "\n";

			if (countd.Running)
				tip += "CD: " + countd.TimeString + "\n";


			TimerStats.ShowBalloonTip(1000, title, tip, ToolTipIcon.None);
		}

		private void TimerStats_MouseDoubleClick(object sender, MouseEventArgs e) {
			WindowState = FormWindowState.Normal;
			ShowInTaskbar = true;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			//Do cLeanup here.
			Dispose();
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {

		}

		private void Clocks_SelectedIndexChanged(object sender, EventArgs e) {

		}

	}

}
