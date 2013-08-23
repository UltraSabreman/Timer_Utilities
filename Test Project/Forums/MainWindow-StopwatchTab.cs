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
using System.Text.RegularExpressions;

namespace Time_Utils {
	public partial class MainWindow {		
		////////////////////////////////////
		// Private Members
		private StopWatch SWclock = new StopWatch();


		////////////////////////////////////
		// Private Methods
		private void SWinitTab() {
			SWclock.Tick += new StopWatch.onTick(SWtick);
		}

		private void SWtick(TimeSpan span) {
			SWdisplay.Text = SWclock.TimeString;
			overlay.SWtime = Regex.Replace(SWdisplay.Text, "\\s*", "");
		}

		private void SWstartButton_Click(object sender, EventArgs e) {
			SWstart();
		}

		private void SWresetButton_Click(object sender, EventArgs e) {
			SWreset();
		}

		private void SWlapTimes_DoubleClick(object sender, EventArgs e) {
			try {
				Clipboard.SetText(SWLapTimes.SelectedItems[0].SubItems[1].Text);
			} catch (System.ArgumentOutOfRangeException) {
				Debug.Write("Out Of Bounds");
			}
		}

		private void SWdisplay_DoubleClick(object sender, EventArgs e) {
			overlay.Toggle();
		}

		////////////////////////////////////
		// Public Methods
		public void SWstart() {
			if (SWclock.Running) {
				SWclock.Stop();
				SWstartButton.Text = "Start";
				SWresetButton.Text = "Reset";
			} else {
				SWclock.Start();
				SWstartButton.Text = "Stop";
				SWresetButton.Text = "Lap";
			}
			SWstartButton.Update();
			SWresetButton.Update();
		}

		public void SWreset() {
			if (SWclock.Running) {
				overlay.SWlap2 = "Lap 2: " + Regex.Replace(SWclock.TopLap.ToString(), "\\s*", "");

				SWclock.Lap();

				overlay.SWlaps = SWclock.Laps.ToString();
				overlay.SWlap1 = "Lap 1: " + Regex.Replace(SWclock.TopLap.ToString(), "\\s*", "");

				ListViewItem item = new ListViewItem(SWclock.Laps.ToString(), 0);
				item.SubItems.Add(SWclock.TopLap);

				SWLapTimes.Items.Add(item);
			} else {
				SWclock.reset();
				SWLapTimes.Items.Clear();

				overlay.SWlap1 = "Lap 1: 00:00:00.000";
				overlay.SWlap2 = "Lap 2: 00:00:00.000";
				overlay.SWlaps = "0";
			}
		}
	}
}
