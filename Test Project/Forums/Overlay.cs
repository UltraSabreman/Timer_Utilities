using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Time_Utils {
	public partial class Overlay : Form {
		////////////////////////////////////
		// Punblic Members
		public Bitmap Image {
			get { return (Bitmap)Display.Image; }
			set { Display.Image = value; }
		}

		public string SWtime = "00:00:00.000";
		public string SWlap1 = "Lap 1: 00:00:00.000";
		public string SWlap2 = "Lap 2: 00:00:00.000";
		public string SWlaps = "0";

		public string CDtime = "00:00:00";
		public int CDprogress = 0; //0-100;

		public enum Tabs { Clock, Stopwatch, Countdown };
		public Tabs CurTab = Tabs.Clock;

		////////////////////////////////////
		// Private Members
		private Font HugerFont = new Font("Arial", 18, FontStyle.Bold);
		private Font HugeFont = new Font("Arial", 15, FontStyle.Bold);
		private Font MediumFont = new Font("Arial", 12, FontStyle.Bold);
		private Font SmallFont = new Font("Arial", 10, FontStyle.Regular);
		private Font SmallBold = new Font("Arial", 10, FontStyle.Bold);
		private Font TinyFont = new Font("Arial", 8, FontStyle.Regular);

		private SolidBrush MainBrush = null;
		private Pen MainPen = null;

		private Color BackColor;
		private Color ForeColor;

		private bool hidden = false;

		private Tabs DefaultTab = Tabs.Clock;


		public Overlay(PermOptions op = null) {
			InitializeComponent();

			Display.Image = new Bitmap(this.Width, this.Height);

			UpdateSettings(op != null ? op : new PermOptions());
			CurTab = DefaultTab;

			this.Activate(hidden);
		}

		public void Activate(bool shouldHide) {
			if (shouldHide) {
				hidden = true;
				this.Hide();
			} else {
				hidden = false;
				this.Show();
				CurTab = DefaultTab;
			}
		}

		public void Toggle() {
			Activate(!hidden);
		}

		public void UpdateSettings(PermOptions op) {
			BackColor = op.OverlayBackColor;
			ForeColor = op.OverlayForeColor;

			MainBrush = new SolidBrush(ForeColor);
			MainPen = new Pen(ForeColor, 1);
			Opacity = op.OverlayOptacy;

			DefaultTab = ((int)op.defaultTab <= 1 ? (Overlay.Tabs)op.defaultTab + 1 : Overlay.Tabs.Clock);
		}

		public void Render() {
			if (hidden) return;
			int DispW = Width;
			int DispH = Height;

			Graphics g = Graphics.FromImage(Display.Image);
			g.Clear(BackColor);

			//border
			g.DrawRectangle(MainPen, 0, 0, DispW - 1, DispH - 1);

			//left border/tab indicator
			g.DrawRectangle(MainPen, 0, 0, 5, DispH - 1);
			g.DrawLine(MainPen, 0, (DispH / 3) * 1, 5, (DispH / 3) * 1);
			g.DrawLine(MainPen, 0, (DispH / 3) * 2, 5, (DispH / 3) * 2);
			g.FillRectangle(MainBrush, 2, ((DispH / 3) * (int)CurTab) + 2, 2, (DispH / 3) - 3);

			//Right border/Progress indicator
			g.DrawRectangle(MainPen, DispW - 6, 0, 5, DispH);			
			g.FillRectangle(MainBrush, DispW - 4, 2, 2, (DispH - 4) * ((float)CDprogress / 100));

			if (CurTab == Tabs.Clock) {		
				g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;

				string time = DateTime.Now.ToString("hh:mm:ss tt").ToLower();
				string date = DateTime.Now.ToString("D");
				SizeF TimeSize = TextRenderer.MeasureText(time, HugeFont);
				SizeF DateSize = TextRenderer.MeasureText(date, TinyFont);

				g.DrawString(time, HugeFont, MainBrush, DispW / 2 - TimeSize.Width / 2, 0);
				g.DrawString(date, TinyFont, MainBrush, DispW / 2 - DateSize.Width / 2, TimeSize.Height);
			} else if (CurTab == Tabs.Stopwatch) {
				SizeF TimeSize = TextRenderer.MeasureText(SWtime, MediumFont);
				SizeF Lap1Size = TextRenderer.MeasureText(SWlap1, TinyFont);
				SizeF Lap2Size = TextRenderer.MeasureText(SWlap1, TinyFont);
				SizeF LapsSize = TextRenderer.MeasureText(SWlaps, SmallBold);

				g.DrawLine(MainPen, new Point(5, 16), new Point(Width - 6, 16));
				g.DrawLine(MainPen, new Point(110, 16), new Point(110, Height));

				g.DrawString(SWtime, MediumFont, MainBrush, DispW / 2 - TimeSize.Width / 2, 0);
				g.DrawString(SWlap1, TinyFont, MainBrush, 8F, TimeSize.Height - 3);
				g.DrawString(SWlap2, TinyFont, MainBrush, 8F, TimeSize.Height + Lap1Size.Height - 7);
				g.DrawString(SWlaps, SmallBold, MainBrush, DispW - LapsSize.Width/2 - 25, TimeSize.Height + Lap1Size.Height - 12);
			} else {
				SizeF TimeSize = TextRenderer.MeasureText(CDtime, HugerFont);

				g.DrawString(CDtime, HugerFont, MainBrush, DispW / 2 - TimeSize.Width / 2, DispH / 2 - TimeSize.Height / 2);
			}
			
			Display.Refresh();
			g.Dispose();
		}

		public Bitmap invertBitmap(Bitmap bin) {
			Bitmap temp = new Bitmap(bin);
			Graphics g = Graphics.FromImage(temp);
				g.Clear(BackColor);

			for (int x = 0; x < temp.Width; x++)
				for (int y = 0; y < temp.Height; y++) {
					if (bin.GetPixel(x, y) == BackColor)
						temp.SetPixel(x, y, ForeColor);
					else
						temp.SetPixel(x, y, BackColor);
				}

			return temp;
		}


		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void Display_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			} else if (e.Button == MouseButtons.Right) {
				if (CurTab == Tabs.Clock)
					CurTab = Tabs.Stopwatch;
				else if (CurTab == Tabs.Stopwatch)
					CurTab = Tabs.Countdown;
				else
					CurTab = Tabs.Clock;
			}

		}

		private void Overlay_FormClosing(object sender, FormClosingEventArgs e) {
			Display.Dispose();

			HugerFont.Dispose();
			HugeFont.Dispose();
			MediumFont.Dispose();
			SmallFont.Dispose();
			SmallBold.Dispose();
			TinyFont.Dispose();

			MainBrush.Dispose();
			MainPen.Dispose();
		}

	}
}
