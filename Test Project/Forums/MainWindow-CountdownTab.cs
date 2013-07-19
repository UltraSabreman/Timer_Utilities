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
using System.Media;

namespace Timer_Utils {
	public partial class MainWindow {
		////////////////////////////////////
		// Public Members

		////////////////////////////////////
		// Private Members
		private CountDown countd = new CountDown(100);
		private superPopup popup = new superPopup();
		private SoundPlayer speaker = new SoundPlayer();
		private CD_StartTime_Maker timeThing = new CD_StartTime_Maker();
		
		private bool doNotification = true;
		private bool doPopup = false;
		private bool doForeground = false;
		private bool doSound = true;
		private bool doRun = false;
		private string runPath = "";

		////////////////////////////////////
		// Properties
		public string SoundPath {
			set {
				if (value != "") {
					try {
						this.speaker.SoundLocation = value;
						this.speaker.LoadAsync();
					} catch (Exception ex) {
						MessageBox.Show(ex.Message, "Error loading sound");
					}
				}
			}

			get { return speaker.SoundLocation; }
		}

		public string RunPath {
			set {
				if (value != "")
					runPath = value;
			}
			get { return runPath; }
		}

		////////////////////////////////////
		// Private Methods
		private void CDinitTab() {
			countd.StartTime = timeThing.getTime();
			SoundPath = "C:\\Windows\\Media\\Windows Unlock.wav";

			countd.Tick += new CountDown.onTick(CDtick);
			countd.TriggerOnce += new CountDown.onTriggerOnce(CDonAlarm);

			popup.stop += new superPopup.stopDelegate(CDtoggle);
		}

		private void CDtick(TimeSpan span) {
			CDdisplay.Text = countd.TimeString;

			try {
				CDprogress.Value = countd.Progress;
			} catch (System.ArgumentOutOfRangeException) {
				CDprogress.Value = 0;
			}
		}

		private void CDonAlarm() {
			if (countd.ContinueAfterTrigger)
				CDdisplay.ForeColor = System.Drawing.Color.Red;

			if (doSound && speaker.IsLoadCompleted) {
				try {
					speaker.PlayLooping();
				} catch (Exception ex) {
					MessageBox.Show(ex.Message, "Error playing sound");
				}
			}

			if (doNotification) {
				TimerStats.ShowBalloonTip(3000, "Alarm!", "The countdown is done.", ToolTipIcon.Info);
			}

			if (doPopup) {
				popup.Show();
				popup.Activate();
				countd.Tick += new CountDown.onTick(popup.time);
			}

			if (doForeground) {
				WindowState = FormWindowState.Normal;
				ShowInTaskbar = true;
				Activate();
			}

			if (doRun) {
				try {
					System.Diagnostics.Process.Start(runPath);
				} catch (System.IO.IOException) {
				}
			}

			CDstart.Text = "Stop";
		}

		private void CDtoggle() {
			if (countd.Running) {
				countd.Stop();
				speaker.Stop();

				if (countd.Triggered) {
					CDreset();
				} else {
					CDstart.Text = "Continue";
					CDresetB.Enabled = true;
					alarmOptions.Enabled = true;
				}
				countd.Tick -= new CountDown.onTick(popup.time);
			} else {
				if (!countd.Start()) return;

				CDdisplay.BackColor = System.Drawing.SystemColors.Control;
				CDdisplay.ForeColor = System.Drawing.Color.Black;
				CDstart.Text = "Pause";
				CDresetB.Enabled = false;
				KeyPad.Enabled = false;
				alarmOptions.Enabled = false;
				CDstart.Update();
			}
		}


		private void CDreset() {
			countd.Reset();

			KeyPad.Enabled = true;
			alarmOptions.Enabled = true;
			CDresetB.Enabled = true;
			CDprogress.Value = 0;
			CDdisplay.BackColor = System.Drawing.SystemColors.ControlLight;
			CDdisplay.ForeColor = System.Drawing.Color.Black;
			CDdisplay.Update();
			CDstart.Text = "Start";
			timeThing.reset();
		}

		private void CDresetB_Click(object sender, EventArgs e) {
			if (!countd.Running) CDreset();
		}

		private void CDstart_Click(object sender, EventArgs e) {
			CDtoggle();
		}
				
		private void KeyPad0_Click(object sender, EventArgs e) {
			timeThing.pushNumber(0);
			countd.StartTime = timeThing.getTime();
		}

		private void KeyPadDel_Click(object sender, EventArgs e) {
			timeThing.popNumber();
			countd.StartTime = timeThing.getTime();
		}

		private void KeyPad1_Click(object sender, EventArgs e) {
			timeThing.pushNumber(1);
			countd.StartTime = timeThing.getTime();
		}

		private void KeyPad2_Click(object sender, EventArgs e) {
			timeThing.pushNumber(2);
			countd.StartTime = timeThing.getTime();
		}

		private void KeyPad3_Click(object sender, EventArgs e) {
			timeThing.pushNumber(3);
			countd.StartTime = timeThing.getTime();
		}

		private void KeyPad6_Click(object sender, EventArgs e) {
			timeThing.pushNumber(6);
			countd.StartTime = timeThing.getTime();
		}

		private void KeyPad5_Click(object sender, EventArgs e) {
			timeThing.pushNumber(5);
			countd.StartTime = timeThing.getTime();
		}

		private void KeyPad4_Click(object sender, EventArgs e) {
			timeThing.pushNumber(4);
			countd.StartTime = timeThing.getTime();
		}

		private void KeyPad9_Click(object sender, EventArgs e) {
			timeThing.pushNumber(9);
			countd.StartTime = timeThing.getTime();
		}

		private void KeyPad8_Click(object sender, EventArgs e) {
			timeThing.pushNumber(8);
			countd.StartTime = timeThing.getTime();
		}

		private void KeyPad7_Click(object sender, EventArgs e) {
			timeThing.pushNumber(7);
			countd.StartTime = timeThing.getTime();
		}


		private void CDdisplay_BackColorChanged(object sender, EventArgs e) {
			CDdisplay.Update();
		}

		private void chkTrayNot_CheckedChanged(object sender, EventArgs e) {
			doNotification = chkTrayNot.Checked;
		}

		private void chkPopUp_CheckedChanged(object sender, EventArgs e) {
			doPopup = chkPopUp.Checked;
		}

		private void chkForeg_CheckedChanged(object sender, EventArgs e) {
			doForeground = chkForeg.Checked;
		}


		private void CDsoundPathWrap(string s) { SoundPath = s; }
		private void chkPlys_CheckedChanged(object sender, EventArgs e) {
			if (chkPlys.Checked) {
				FileDialog temp = new FileDialog(CDsoundPathWrap, SoundPath);
				temp.Text = "Sound Path";
				temp.Show();
				doSound = true;
			} else {
				doSound = false;
			}
		}

		private void CDrunPathWrap(string s) { RunPath = s; }
		private void chkRun_CheckedChanged(object sender, EventArgs e) {
			if (chkRun.Checked) {
				FileDialog temp = new FileDialog(CDrunPathWrap, RunPath);
				temp.Text = "File Path";
				temp.Show();
				doRun = true;
			} else
				doRun = false;
		}

	}
}
