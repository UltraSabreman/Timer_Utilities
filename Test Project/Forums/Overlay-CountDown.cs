using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Time_Utils {
	public partial class CountDownOverlay : Form {
		private bool toggle = false;
		private Color foreCol;
		private Color backCol;

		public CountDownOverlay(PermOptions op = null) {
			InitializeComponent();

			AlarmFlash.Tick += new EventHandler(alarmTick);

			updateOptions(op != null ? op : new PermOptions());
			this.MinimumSize = new System.Drawing.Size(120, 27);
			this.Size = new System.Drawing.Size(120, 27);
		}

		public void updateOptions(PermOptions op) {
			this.Opacity = op.OverlayOptacy;

			foreCol = op.OverlayForeColor;
			backCol = op.OverlayBackColor;

			TimeDisp.ForeColor = foreCol;
			TimeDisp.BackColor = backCol;

			rectangleShape1.BorderColor = foreCol;
			rectangleShape1.FillColor = backCol;
		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void Overlay_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
			if (e.Button == MouseButtons.Middle) {
				this.Dispose();
			}
		}

		public void setTime(string time) {
			TimeDisp.Text = Regex.Replace(time, "\\s*", String.Empty); ;
		}

		public void alarm() {
			AlarmFlash.Start();
		}

		public void alarmTick(object source, EventArgs e) {
			toggle = !toggle;
			updateColors(toggle);
		}

		public void updateColors(bool invert) {
			if (invert) {
				TimeDisp.ForeColor = backCol;
				TimeDisp.BackColor = foreCol;

				rectangleShape1.BorderColor = backCol;
				rectangleShape1.FillColor = foreCol;
			} else {
				TimeDisp.ForeColor = foreCol;
				TimeDisp.BackColor = backCol;

				rectangleShape1.BorderColor = foreCol;
				rectangleShape1.FillColor = backCol;
			}
		}

		public void reset() {
			TimeDisp.Text = "00:00:00";
			AlarmFlash.Stop();

			if (toggle) {
				updateColors(toggle = false);
			}

		}
		private void CountDownOverlay_FormClosing(object sender, FormClosingEventArgs e) {
			AlarmFlash.Tick -= new EventHandler(alarmTick);
		}

	}
}
