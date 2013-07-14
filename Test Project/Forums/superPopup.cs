using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Timer_Utils {
	public partial class superPopup : Form {
		public delegate void stopDelegate();
		public event stopDelegate stop;

		private bool toggle = false;
		private Timer ticker = new Timer();

		public superPopup() {
			InitializeComponent();

			ticker.Tick += new EventHandler(tick);
			ticker.Interval = 500;
			ticker.Enabled = true;

			done.Update();
		}

		public void time(TimeSpan span) {
			overLabel.Text = String.Format("Overdue by: {0:00} : {1:00} : {2:00}", Math.Abs(span.TotalHours), Math.Abs(span.Minutes), Math.Abs(span.Seconds));
		}

		private void dismiss_Click(object sender, EventArgs e) {
			//stop();
			//Dispose();
			if (stop != null)
				stop();

			Hide();
		}

		private void tick(object source, EventArgs e) {
			toggle = !toggle;
			if (!toggle) {
				done.ForeColor = System.Drawing.Color.Red;
				done.BackColor = System.Drawing.Color.White;
			} else {
				done.ForeColor = System.Drawing.Color.White;
				done.BackColor = System.Drawing.Color.Red;
			}
			done.Update();
		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void superPopup_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

	}
}
