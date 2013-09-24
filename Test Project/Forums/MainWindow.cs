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
using Microsoft.Win32;

namespace Time_Utils {
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
		private PermOptions options = new PermOptions();
		private AsyncGlobalShortcuts KeyHook = new AsyncGlobalShortcuts();
		private bool keysEnabled = true;
		private Overlay overlay;
		private Timer overlayUpdate = new Timer();

		private List<HotKey> numpadKeys = new List<HotKey>();
		
		public MainWindow(string path = "settings.txt") {
			optionsPath = path;
			InitializeComponent();

			dataReader tempReader = new dataReader();

			tempReader.deserialize();
			todoItems = tempReader.todoItems;
			options = tempReader.options;


			KeyHook.RegisterHotKey(options.ActivateOverlay);
			KeyHook.RegisterHotKey(options.CycleOverlayTabs);
			KeyHook.RegisterHotKey(options.OverlayKey1);
			KeyHook.RegisterHotKey(options.OverlayKey2);
			KeyHook.RegisterHotKey(options.OverlayKey3);

			KeyHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(GB_KeyPressed);

			SWinitTab();
			CDinitTab();
			TDinitTab();

			TDupdate();

			Clocks.SelectedIndex = (int)options.defaultTab;
			ShowInTaskbar = !options.hideTaskbarIcon;

			overlay = new Overlay(options);

			overlayUpdate.Tick += new EventHandler(renderOverlay);
			overlayUpdate.Interval = 40;
			overlayUpdate.Start();
		}

		private void GB_KeyPressed(object sender, KeyPressedEventArgs e) {
			if (!keysEnabled) return;

			if (e.Key == options.CycleOverlayTabs) {
				overlay.CurTab = (Overlay.Tabs)(((uint)overlay.CurTab + 1) % 3); //lul
			}

			if (overlay.Visible && overlay.CurTab == Overlay.Tabs.Clock) {

			} else if (overlay.Visible && overlay.CurTab == Overlay.Tabs.Stopwatch) {
				if (e.Key == options.OverlayKey1)
					SWstart();
				else if (e.Key == options.OverlayKey2)
					SWreset();

			} else if (overlay.Visible && overlay.CurTab == Overlay.Tabs.Countdown) {
				//All hardocded keays in this function are used for numerical entery,
				// therefore they cannot be changed

				if (e.Key == options.OverlayKey3) {
					CD_EnterMode = !CD_EnterMode;
					if (CD_EnterMode) {
						for (uint i = (uint)Keys.NumPad0, l = (uint)Keys.D0; i <= (uint)Keys.NumPad9; i++, l++) {
							numpadKeys.Add(KeyHook.RegisterHotKey((Keys)i));
							numpadKeys.Add(KeyHook.RegisterHotKey((Keys)l));
						}

						numpadKeys.Add(KeyHook.RegisterHotKey(Keys.Enter));
						numpadKeys.Add(KeyHook.RegisterHotKey(Keys.Back));
						//I would register the delete key aswell, but that would lock you out
						//of ctrl+alt+del if something screws up.
					} else {
						UnregNumberKeys();
					}
				} else if (e.Key == options.OverlayKey1) {
					CDtoggle();
				} else if (e.Key == options.OverlayKey2) {
					if (!CDclock.Running) CDreset(true);
				} else if (e.Key.First() == Keys.Enter) {
					UnregNumberKeys();

					CD_EnterMode = false;
					CDtoggle();
				} else {
					switch (e.Key.First()) {
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
					CDdisplay.Text = timeThing.getUnproccesdString();
				}
			}
		}

		private void UnregNumberKeys() {
			foreach (HotKey k in numpadKeys) {
				KeyHook.UnregisterHotKey(k);
			}

			numpadKeys.Clear();
		}

		public void applyOptions(PermOptions po) {
			options = po;

			//run on startup or not.
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (options.startOnStartup)
				registryKey.SetValue("TimeUtilities", Application.ExecutablePath);
			else if (!options.startOnStartup && registryKey.GetValue("TimeUtilities") != null)
				registryKey.DeleteValue("TimeUtilities");

			ShowInTaskbar = !options.hideTaskbarIcon;
			overlay.UpdateSettings(options);
			this.Show();

			dumpOptions();
			
			//TODO doMore stuff Here
		}

		private void Form1_SizeChanged(object sender, EventArgs e) {
			if (!options.hideTaskbarIcon) return;

			if (WindowState == FormWindowState.Minimized) {
				// Do some stuff
				if (!warned) {
					TimerStats.ShowBalloonTip(1000, "Time Utilities", "Time Utilities has been minimzed to the tray. \n Double-Click icon to open", ToolTipIcon.Info);
					warned = true;
				}
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			onClose();
		}

		private void TimerStats_MouseClick(object sender, MouseEventArgs e) {
			
		}

		private void TimerStats_MouseDoubleClick(object sender, MouseEventArgs e) {
			WindowState = FormWindowState.Normal;
			this.Show();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			onClose();
			this.Dispose();
		}

		private void HelpButton_Click(object sender, EventArgs e) {
			HelpDiag temp = new HelpDiag();
			temp.Show();
		}

		private void AboutDiag_Click(object sender, EventArgs e) {
			AboutDiag temp = new AboutDiag();
			temp.Show();
		}

		private void OpenDataFile_Click(object sender, EventArgs e) {
			Process test  = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo test2 = new System.Diagnostics.ProcessStartInfo("data.json");

			test2.UseShellExecute = true;
			test2.WindowStyle = ProcessWindowStyle.Normal;
			test.StartInfo = test2;
			test.Start();
		}

		private void OptionsDiag_Click(object sender, EventArgs e) {
			OptionsDiag temp = new OptionsDiag(options);
			temp.Apply += new OptionsDiag.onApply(applyOptions); //I prob have to clean that up;
			temp.Show();
		}

		private void ReloadData_Click(object sender, EventArgs e) {
			dataReader tempReader = new dataReader();

			tempReader.deserialize();
			todoItems = tempReader.todoItems;
			options = tempReader.options;

			SWinitTab();
			CDinitTab();
			TDinitTab();

			TDupdate();

			ShowInTaskbar = !options.hideTaskbarIcon;
		}

		void onClose() {
			TimerStats.Visible = false;

			KeyHook.Dispose();
			dumpOptions();
		}

		void dumpOptions() {
			dataReader tempReader = new dataReader();
			tempReader.todoItems = todoItems;
			tempReader.options = options;

			tempReader.serialize();
		}

		private void TrayCntOpenTimer_Click(object sender, EventArgs e) {
			WindowState = FormWindowState.Normal;
			this.Show();
		}

		private void TrayCntQuickView_Click(object sender, EventArgs e) {
			string title = "Timer Stuff";
			string tip = "";

			if (!SWclock.Running && !CDclock.Running) {
				tip = "Nothing is running.";
			}

			if (SWclock.Running)
				tip += "SW: " + SWclock.TimeString + "\n";

			if (CDclock.Running)
				tip += "CD: " + CDclock.TimeString + "\n";


			TimerStats.ShowBalloonTip(1000, title, tip, ToolTipIcon.None);
		}

		private void TrayCntOptions_Click(object sender, EventArgs e) {
			OptionsDiag temp = new OptionsDiag(options);
			temp.Apply += new OptionsDiag.onApply(applyOptions); //I prob have to clean that up;
			temp.Show();
		}

		private void TrayCntExit_Click(object sender, EventArgs e) {
			onClose();
			this.Dispose();
		}



		private void renderOverlay(object source, EventArgs e) {
			overlay.Render();
		}
	}

}
