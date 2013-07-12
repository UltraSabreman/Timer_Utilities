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
		private StopWatch stopw = new StopWatch();
		private CountDown countd = new CountDown(100);

		private bool doNotification = true;
		private bool doPopup = false;
		private bool doForeground = false;
		private bool runSomething = false;
		private string runPath = "";
		private bool didAlarm = false;


		public MainWindow() {
			InitializeComponent();
			GlobalUpdate.Start();
		}

		public void updateSoundFile(string l) {
			if (l != "") {
				countd.Sound = l;
				countd.PlaySound = true;
			} else {
				countd.PlaySound = false;
			}
		}

		public void updateRunFile(string l) {
			if (l != "")
				runPath = l;
		}

		public void stopAlarm() {
			if (countd.Running && countd.Alarming) {
				countd.toggle();
				resetCD();
			}
		}

		private void SWstart_Click(object sender, EventArgs e) {
			//listBox1.DataSource =
			stopw.toggle();
			if (stopw.Running) {
				SWstart.Text = "Stop";
				SWreset.Text = "Lap";
			} else {
				SWstart.Text = "Start";
				SWreset.Text = "Reset";
			}
			SWstart.Update();
			SWreset.Update();
		}

		private void SWreset_Click(object sender, EventArgs e) {
			if (stopw.Running) {
				stopw.lap();

				ListViewItem item = new ListViewItem(stopw.TopLap.ToString(), 0);
				item.SubItems.Add(stopw.TopLap.ToString());

				LapTimes.Items.Add(item);

			} else {
				stopw.reset();
				LapTimes.Items.Clear();
			}
		}

		private void SWdisplay_TextChanged(object sender, EventArgs e) {
			SWdisplay.Update();
		}


		private void GlobalUpdate_Tick(object sender, EventArgs e) {
			SWdisplay.Text = stopw.TimeString;
			CDdisplay.Text = countd.TimeString;

			if (countd.Alarming && !didAlarm) {
				if (doNotification) {
					TimerStats.Visible = true;
					TimerStats.ShowBalloonTip(3000, "Alarm!", "The countdown is done.", ToolTipIcon.Info);
				}
				if (doPopup) {
					superPopup temp = new superPopup(stopAlarm);
					temp.Show();
				}
				if (doForeground) {
					WindowState = FormWindowState.Normal;
					ShowInTaskbar = true;
					Activate();
				}
				if (runSomething) {
					try {
						System.Diagnostics.Process.Start(runPath);
					} catch (System.IO.IOException) {
					}
				}

				CDstart.Text = "Stop";

				didAlarm = true;
			}

			try {
				CDprogress.Value = (countd.Alarming ? 100 : countd.Progress);
			} catch (System.ArgumentOutOfRangeException) {
				CDprogress.Value = 0;
			}
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

		private void CDdisplay_TextChanged(object sender, EventArgs e) {
			CDdisplay.Update();
		}

		private void CDstart_Click(object sender, EventArgs e) {
			if (!countd.toggle()) {
				return;
			}
			if (countd.Running) {
				CDdisplay.ForeColor = System.Drawing.Color.Black;
				CDstart.Text = "Pause";
				CDreset.Enabled = false;
				KeyPad.Enabled = false;
				alarmOptions.Enabled = false;
			} else {
				if (countd.Alarming) 
					resetCD();
				else {
					CDstart.Text = "Continue";
					CDreset.Enabled = true;
					alarmOptions.Enabled = true;
				}
			}

			CDstart.Update();
		}

		private void resetCD() {
			KeyPad.Enabled = true;
			alarmOptions.Enabled = true;
			CDreset.Enabled = true;
			countd.reset();
			CDprogress.Value = 0;
			CDdisplay.ForeColor = System.Drawing.Color.Red;
			didAlarm = false;
			CDstart.Text = "Start";

			TimerStats.Visible = false;
		}

		private void CDreset_Click(object sender, EventArgs e) {
			resetCD();
		}

		private void CDstar_TextChanged(object sender, EventArgs e) {
			CDstart.Update();
		}

		private void KeyPad0_Click(object sender, EventArgs e) {
			countd.pushNumber(0);
		}

		private void KeyPadDel_Click(object sender, EventArgs e) {
			countd.popNumber();
		}

		private void KeyPad1_Click(object sender, EventArgs e) {
			countd.pushNumber(1);
		}

		private void KeyPad2_Click(object sender, EventArgs e) {
			countd.pushNumber(2);
		}

		private void KeyPad3_Click(object sender, EventArgs e) {
			countd.pushNumber(3);
		}

		private void KeyPad6_Click(object sender, EventArgs e) {
			countd.pushNumber(6);
		}

		private void KeyPad5_Click(object sender, EventArgs e) {
			countd.pushNumber(5);
		}

		private void KeyPad4_Click(object sender, EventArgs e) {
			countd.pushNumber(4);
		}

		private void KeyPad9_Click(object sender, EventArgs e) {
			countd.pushNumber(9);
		}

		private void KeyPad8_Click(object sender, EventArgs e) {
			countd.pushNumber(8);
		}

		private void KeyPad7_Click(object sender, EventArgs e) {
			countd.pushNumber(7);
		}

		private void CDdisplay_ForeColorChanged(object sender, EventArgs e) {
			CDdisplay.Update();
		}

		private void Form1_SizeChanged(object sender, EventArgs e) {
			if (WindowState == FormWindowState.Minimized) {
				// Do some stuff
				TimerStats.ShowBalloonTip(5000, "Timer Stuff", "Timer Stuff has been minimzed to the tray.", ToolTipIcon.Info);
				TimerStats.Visible = true;
				this.ShowInTaskbar = false;
			} else {
				TimerStats.Visible = false;
				this.ShowInTaskbar = true;
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			TimerStats.Visible = false;
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

		private void chkTrayNot_CheckedChanged(object sender, EventArgs e) {
			doNotification = chkTrayNot.Checked;
		}

		private void chkPopUp_CheckedChanged(object sender, EventArgs e) {
			doPopup = chkTrayNot.Checked;
		}

		private void chkForeg_CheckedChanged(object sender, EventArgs e) {
			doForeground = chkTrayNot.Checked;
		}

		private void chkPlys_CheckedChanged(object sender, EventArgs e) {
			if (chkPlys.Checked) {
				FileDialog temp = new FileDialog(updateSoundFile, countd.Sound);
				temp.Text = "Sound Path";
				temp.Show();
			} else {
				countd.PlaySound = false;
			}
		}

		private void chkRun_CheckedChanged(object sender, EventArgs e) {
			if (chkRun.Checked) {
				FileDialog temp = new FileDialog(updateRunFile, runPath);
				temp.Text = "File Path";
				temp.Show();
				runSomething = true;
			} else
				runSomething = false;
		}

	}

}
