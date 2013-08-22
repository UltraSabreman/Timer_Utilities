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
	public partial class StopWatchOverlay : Form {
		private int laps = 0;


		public StopWatchOverlay(PermOptions op = null) {
			InitializeComponent();

			updateOptions(op != null ? op : new PermOptions());

		}

		public void updateOptions(PermOptions op) {
			this.Opacity = op.OverlayOptacy;

			TimeDisp.ForeColor = op.OverlayForeColor;
			TimeDisp.BackColor = op.OverlayBackColor;

			Lap1.ForeColor = op.OverlayForeColor;
			Lap1.BackColor = op.OverlayBackColor;

			Lap2.ForeColor = op.OverlayForeColor;
			Lap2.BackColor = op.OverlayBackColor;

			Lapz.ForeColor = op.OverlayForeColor;
			Lapz.BackColor = op.OverlayBackColor;

			lineShape1.BorderColor = op.OverlayForeColor;

			lineShape2.BorderColor = op.OverlayForeColor;

			lineShape3.BorderColor = op.OverlayForeColor;

			rectangleShape1.BorderColor = op.OverlayForeColor;
			rectangleShape1.FillColor = op.OverlayBackColor;

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

		public void tick(string time) {
			TimeDisp.Text = Regex.Replace(time, "\\s*", String.Empty);
		}

		public void lap() {
			Lap2.Text = "Lap 2:" + Regex.Replace(Lap1.Text, "Lap 1:", String.Empty);
			Lap1.Text = "Lap 1:" + TimeDisp.Text;
			Lapz.Text = (++laps).ToString();
		}

		public void reset() {
			TimeDisp.Text = " 00:00:00.000 ";
			Lap1.Text = "Lap 1: 00:00:00.000";
			Lap2.Text = "Lap 2: 00:00:00.000";
			Lapz.Text = "0";
		}
	}
}
