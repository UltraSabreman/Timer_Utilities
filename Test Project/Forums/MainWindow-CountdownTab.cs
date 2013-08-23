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
using System.Text.RegularExpressions;

namespace Time_Utils {
	public partial class MainWindow {
		////////////////////////////////////
		// Public Members

		////////////////////////////////////
		// Private Members
		private CountDown CDclock = new CountDown(100);
		private superPopup popup = new superPopup();
		private SoundPlayer speaker = new SoundPlayer();
		private CD_StartTime_Maker timeThing = new CD_StartTime_Maker();

		private bool CD_EnterMode = false;
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
			CDclock.StartTime = timeThing.getTime();
			SoundPath = "C:\\Windows\\Media\\Windows Unlock.wav";

			CDclock.Tick += new CountDown.onTick(CDtick);
			CDclock.TriggerOnce += new CountDown.onTriggerOnce(CDonAlarm);

			popup.stop += new superPopup.stopDelegate(CDtoggle);
		}

		private void CDunregNumberKeys() {
			for (uint i = (uint)Keys.NumPad0, l = (uint)Keys.D0; i <= (uint)Keys.NumPad9; i++, l++) {
				globalKeyboardHook.UnregisterHotKey(ModKeys.None, (Keys)i);
				globalKeyboardHook.UnregisterHotKey(ModKeys.None, (Keys)l);
			}

			globalKeyboardHook.UnregisterHotKey(ModKeys.None, Keys.Enter);
			globalKeyboardHook.UnregisterHotKey(ModKeys.None, Keys.Back);
		}

		private void CDtick(TimeSpan span) {
			if (!CDclock.Ready)
				CDdisplay.Text = CDclock.TimeString;
			else
				CDdisplay.Text = timeThing.getUnproccesdString();

			if (CD_EnterMode)
				overlay.CDtime = "! " + Regex.Replace(CDdisplay.Text, "\\s*", "") + " !";
			else
				overlay.CDtime = Regex.Replace(CDdisplay.Text, "\\s*", "");


			try {
				CDprogress.Value = CDclock.Progress;
			} catch (System.ArgumentOutOfRangeException) {
				CDprogress.Value = 0;
			}

			overlay.CDprogress = CDprogress.Value;
		}

		private void CDonAlarm() {

			if (CDclock.ContinueAfterTrigger)
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
				CDclock.Tick += new CountDown.onTick(popup.time);
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
			if (CDclock.Running) {
				CDclock.Stop();
				speaker.Stop();

				if (CDclock.Triggered) {
					CDreset();
				} else {
					CDstart.Text = "Continue";
					CDresetB.Enabled = true;
					alarmOptions.Enabled = true;
				}
				CDclock.Tick -= new CountDown.onTick(popup.time);
			} else {
				CDclock.StartTime = timeThing.getTime();
				if (!CDclock.Start()) return;

				CDdisplay.BackColor = System.Drawing.SystemColors.Control;
				CDdisplay.ForeColor = System.Drawing.Color.Black;
				CDstart.Text = "Pause";
				CDresetB.Enabled = false;
				KeyPad.Enabled = false;
				alarmOptions.Enabled = false;
				CDstart.Update();
			}
		}


		private void CDreset(bool hard = false) {
			CDclock.Reset();

			KeyPad.Enabled = true;
			alarmOptions.Enabled = true;
			CDresetB.Enabled = true;
			CDprogress.Value = 0;
			CDdisplay.BackColor = System.Drawing.SystemColors.ControlLight;
			CDdisplay.ForeColor = System.Drawing.Color.Black;
			CDdisplay.Update();
			CDstart.Text = "Start";
			if (!hard) {
				CDclock.StartTime = timeThing.getTime();
				CDdisplay.Text = timeThing.getUnproccesdString();
			}  else
				timeThing.reset();
		}

		private void CDresetB_Click(object sender, EventArgs e) {
			if (!CDclock.Running) CDreset(true);
		}

		private void CDstart_Click(object sender, EventArgs e) {
			CDtoggle();
		}
				
		private void KeyPad0_Click(object sender, EventArgs e) {
			timeThing.pushNumber(0);
			CDdisplay.Text = timeThing.getUnproccesdString();
		}

		private void KeyPadDel_Click(object sender, EventArgs e) {
			timeThing.popNumber();
			CDdisplay.Text = timeThing.getUnproccesdString();
		}

		private void KeyPad1_Click(object sender, EventArgs e) {
			timeThing.pushNumber(1);
			CDdisplay.Text = timeThing.getUnproccesdString();
		}

		private void KeyPad2_Click(object sender, EventArgs e) {
			timeThing.pushNumber(2);
			CDdisplay.Text = timeThing.getUnproccesdString();
		}

		private void KeyPad3_Click(object sender, EventArgs e) {
			timeThing.pushNumber(3);
			CDdisplay.Text = timeThing.getUnproccesdString();
		}

		private void KeyPad6_Click(object sender, EventArgs e) {
			timeThing.pushNumber(6);
			CDdisplay.Text = timeThing.getUnproccesdString();
		}

		private void KeyPad5_Click(object sender, EventArgs e) {
			timeThing.pushNumber(5);
			CDdisplay.Text = timeThing.getUnproccesdString();
		}

		private void KeyPad4_Click(object sender, EventArgs e) {
			timeThing.pushNumber(4);
			CDdisplay.Text = timeThing.getUnproccesdString();
		}

		private void KeyPad9_Click(object sender, EventArgs e) {
			timeThing.pushNumber(9);
			CDdisplay.Text = timeThing.getUnproccesdString();
		}

		private void KeyPad8_Click(object sender, EventArgs e) {
			timeThing.pushNumber(8);
			CDdisplay.Text = timeThing.getUnproccesdString();
		}

		private void KeyPad7_Click(object sender, EventArgs e) {
			timeThing.pushNumber(7);
			CDdisplay.Text = timeThing.getUnproccesdString();
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

		private void CDdisplay_DoubleClick(object sender, EventArgs e) {

		}
	}
}
