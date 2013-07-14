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
	public partial class MainWindow {		
		////////////////////////////////////
		// Private Members
		private StopWatch stopw = new StopWatch();

		////////////////////////////////////
		// Private Methods
		private void SWinitTab() {
			stopw.Tick += new StopWatch.onTick(SWtick);
		}

		private void SWtick(TimeSpan span) {
			SWdisplay.Text = stopw.TimeString;
		}

		private void SWstart_Click(object sender, EventArgs e) {
			if (stopw.Running) {
				stopw.Stop();
				SWstart.Text = "Start";
				SWreset.Text = "Reset";
			} else {
				stopw.Start();
				SWstart.Text = "Stop";
				SWreset.Text = "Lap";
			}
			SWstart.Update();
			SWreset.Update();
		}

		private void SWreset_Click(object sender, EventArgs e) {
			if (stopw.Running) {
				stopw.Lap();

				ListViewItem item = new ListViewItem(stopw.Laps.ToString(), 0);
				item.SubItems.Add(stopw.TopLap);

				LapTimes.Items.Add(item);

			} else {
				stopw.reset();
				LapTimes.Items.Clear();
			}
		}

		private void SWdisplay_TextChanged(object sender, EventArgs e) {
			SWdisplay.Update();
		}

		private void SWstart_TextChanged(object sender, EventArgs e) {
			SWstart.Update();
		}

		private void SWreset_TextChanged(object sender, EventArgs e) {
			SWreset.Update();
		}

		private void LapTimes_SelectedIndexChanged(object sender, EventArgs e) {
			try {
				Clipboard.SetText(LapTimes.SelectedItems[0].SubItems[1].Text);
			} catch (System.ArgumentOutOfRangeException) {
				Debug.Write("Out Of Bounds");
			}
		}
	}
}
