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
		private KeyboardHook globalKeyboardHook = new KeyboardHook();
		private bool keysEnabled = false;
		
		public MainWindow(string path = "settings.txt") {
			optionsPath = path;
			InitializeComponent();

			dataReader tempReader = new dataReader();

			tempReader.deserialize();
			todoItems = tempReader.todoItems;
			options = tempReader.options;

			globalKeyboardHook.RegisterHotKey(options.EnableKeys);
			globalKeyboardHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(GB_KeyPressed);

			SWinitTab();
			CDinitTab();
			TDinitTab();

			updateTodoList();

			Clocks.SelectedIndex = (int)options.defaultTab;
			ShowInTaskbar = !options.hideTaskbarIcon;
		}

		private void GB_KeyPressed(object sender, KeyPressedEventArgs e) {
			if (e.Key == options.EnableKeys.KeyCode && e.Modifier == options.EnableKeys.Modifier) {
				keysEnabled = !keysEnabled;
				if (keysEnabled) {
					//Stopwatch Stuff
					globalKeyboardHook.RegisterHotKey(options.StartSW);
					globalKeyboardHook.RegisterHotKey(options.ResetSW);

					//countDown Stuff
					globalKeyboardHook.RegisterHotKey(options.StartCD);
					globalKeyboardHook.RegisterHotKey(options.ResetCD);
					globalKeyboardHook.RegisterHotKey(options.EnterModeCD);
				} else {
					//Stopwatch Stuff
					globalKeyboardHook.UnregisterHotKey(options.StartSW);
					globalKeyboardHook.UnregisterHotKey(options.ResetSW);

					//countDown Stuff
					globalKeyboardHook.UnregisterHotKey(options.StartCD);
					globalKeyboardHook.UnregisterHotKey(options.ResetCD);
					globalKeyboardHook.UnregisterHotKey(options.EnterModeCD);

					if (CD_EnterMode) {
						unregNumberKeys();
						if (CDOverlay != null)
							CDOverlay.updateColors(false);
					}
				}
			}
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

			this.Show();
			
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

			updateTodoList();

			ShowInTaskbar = !options.hideTaskbarIcon;
		}

		void onClose() {
			TimerStats.Visible = false;

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

			if (!stopw.Running && !countd.Running) {
				tip = "Nothing is running.";
			}

			if (stopw.Running)
				tip += "SW: " + stopw.TimeString + "\n";

			if (countd.Running)
				tip += "CD: " + countd.TimeString + "\n";


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

	}

}
