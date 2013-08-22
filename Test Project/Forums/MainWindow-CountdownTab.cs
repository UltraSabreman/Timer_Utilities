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

namespace Time_Utils {
	public partial class MainWindow {
		////////////////////////////////////
		// Public Members

		////////////////////////////////////
		// Private Members
		private CountDown countd = new CountDown(100);
		private superPopup popup = new superPopup();
		private SoundPlayer speaker = new SoundPlayer();
		private CD_StartTime_Maker timeThing = new CD_StartTime_Maker();
		private CountDownOverlay CDOverlay;

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
			countd.StartTime = timeThing.getTime();
			SoundPath = "C:\\Windows\\Media\\Windows Unlock.wav";

			countd.Tick += new CountDown.onTick(CDtick);
			countd.TriggerOnce += new CountDown.onTriggerOnce(CDonAlarm);

			popup.stop += new superPopup.stopDelegate(CDtoggle);


			globalKeyboardHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(CD_KeyPressed);
		}

		private void CD_KeyPressed(object sender, KeyPressedEventArgs e) {
			//All hardocded keays in this function are used for numerical entery,
			// therefore they cannot be changed

			if (e.Key == options.EnterModeCD.KeyCode && e.Modifier == options.EnterModeCD.Modifier) {
				CD_EnterMode = !CD_EnterMode;
				if (CD_EnterMode) {
					if (CDOverlay != null) CDOverlay.updateColors(true);

					for (uint i = (uint)Keys.NumPad0, l = (uint)Keys.D0; i <= (uint)Keys.NumPad9; i++, l++) {
						globalKeyboardHook.RegisterHotKey(ModKeys.None, (Keys)i);
						globalKeyboardHook.RegisterHotKey(ModKeys.None, (Keys)l);
					}
				
					globalKeyboardHook.RegisterHotKey(ModKeys.None, Keys.Enter);
					globalKeyboardHook.RegisterHotKey(ModKeys.None, Keys.Back);
					//I would register the delete key aswell, but that would lock you out
					//of ctrl+alt+del if something screwes up.
				} else {
					if (CDOverlay != null) CDOverlay.updateColors(false);

					unregNumberKeys();
				}
			} else if (e.Key == options.StartCD.KeyCode && e.Modifier == options.StartCD.Modifier) {
				CDtoggle();
			} else if (e.Key == options.ResetCD.KeyCode && e.Modifier == options.ResetCD.Modifier) {
				if (!countd.Running) CDreset(true);
			} else if (e.Key == Keys.Enter) {
				unregNumberKeys();

				CD_EnterMode = false;
				CDtoggle();
			} else {
				switch (e.Key) {
					case Keys.D0: case Keys.NumPad0: timeThing.pushNumber(0); break;
					case Keys.D1: case Keys.NumPad1: timeThing.pushNumber(1); break;
					case Keys.D2: case Keys.NumPad2: timeThing.pushNumber(2); break;
					case Keys.D3: case Keys.NumPad3: timeThing.pushNumber(3); break;
					case Keys.D4: case Keys.NumPad4: timeThing.pushNumber(4); break;
					case Keys.D5: case Keys.NumPad5: timeThing.pushNumber(5); break;
					case Keys.D6: case Keys.NumPad6: timeThing.pushNumber(6); break;
					case Keys.D7: case Keys.NumPad7: timeThing.pushNumber(7); break;
					case Keys.D8: case Keys.NumPad8: timeThing.pushNumber(8); break;
					case Keys.D9: case Keys.NumPad9: timeThing.pushNumber(9); break;
					case Keys.Back: timeThing.popNumber(); break;
				}
				countd.StartTime = timeThing.getTime();
			}
			
		}

		private void unregNumberKeys() {
			for (uint i = (uint)Keys.NumPad0, l = (uint)Keys.D0; i <= (uint)Keys.NumPad9; i++, l++) {
				globalKeyboardHook.UnregisterHotKey(ModKeys.None, (Keys)i);
				globalKeyboardHook.UnregisterHotKey(ModKeys.None, (Keys)l);
			}

			globalKeyboardHook.UnregisterHotKey(ModKeys.None, Keys.Enter);
			globalKeyboardHook.UnregisterHotKey(ModKeys.None, Keys.Back);
		}

		private void CDtick(TimeSpan span) {
			CDdisplay.Text = countd.TimeString;
			if (CDOverlay != null)
				CDOverlay.setTime(countd.TimeString);

			try {
				CDprogress.Value = countd.Progress;
			} catch (System.ArgumentOutOfRangeException) {
				CDprogress.Value = 0;
			}
		}

		private void CDonAlarm() {
			CDOverlay.alarm();

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

			if (CDOverlay != null) CDOverlay.updateColors(false); //resets colors to normal

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


		private void CDreset(bool hard = false) {
			countd.Reset();

			KeyPad.Enabled = true;
			alarmOptions.Enabled = true;
			CDresetB.Enabled = true;
			CDprogress.Value = 0;
			CDdisplay.BackColor = System.Drawing.SystemColors.ControlLight;
			CDdisplay.ForeColor = System.Drawing.Color.Black;
			CDdisplay.Update();
			CDstart.Text = "Start";
			if (!hard)
				countd.StartTime = timeThing.getTime();
			else 
				timeThing.reset();

			if (CDOverlay != null) {
				CDOverlay.reset();
			}
		}

		private void CDresetB_Click(object sender, EventArgs e) {
			if (!countd.Running) CDreset(true);
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



		private void CDdisplay_DoubleClick(object sender, EventArgs e) {
			CDOverlay = new CountDownOverlay(options);
			CDOverlay.Show();
		}
	}
}
