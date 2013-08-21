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
		private StopWatchOverlay SWoverlay = null;


		////////////////////////////////////
		// Private Methods
		private void SWinitTab() {
			stopw.Tick += new StopWatch.onTick(SWtick);

			// register the event that is fired after the key press.
			hook.KeyPressed +=	new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
			
			// register the control + alt + F12 combination as hot key.
			hook.RegisterHotKey(0, Keys.F8);
			hook.RegisterHotKey(0, Keys.F9);
		}
		void hook_KeyPressed(object sender, KeyPressedEventArgs e)
		{
			if (e.Key == Keys.F8)
				start();
			if (e.Key == Keys.F9)
				reset();
		}
		private void SWtick(TimeSpan span) {
			SWdisplay.Text = stopw.TimeString;
			if (SWoverlay != null) {
				SWoverlay.tick(stopw.TimeString);
			}
		}

		private void SWstart_Click(object sender, EventArgs e) {
			start();
		}

		public void start() {
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
		public void reset() {
			if (stopw.Running) {
				stopw.Lap();

				ListViewItem item = new ListViewItem(stopw.Laps.ToString(), 0);
				item.SubItems.Add(stopw.TopLap);

				LapTimes.Items.Add(item);

				if (SWoverlay != null) {
					SWoverlay.lap();
				}

			} else {
				stopw.reset();
				LapTimes.Items.Clear();
				if (SWoverlay != null)
					SWoverlay.reset();
			}
		}

		private void SWreset_Click(object sender, EventArgs e) {
			reset();
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

		private void SWDisplay_doubleClick(object sender, EventArgs e) {
			SWoverlay = new StopWatchOverlay(options);
			SWoverlay.Show();
		}
	}
}
