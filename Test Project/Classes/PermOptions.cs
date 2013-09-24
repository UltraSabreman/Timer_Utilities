using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Time_Utils {
	public class PermOptions {
		public enum tabName { StopWatch, CountDown, TodoList };
		
		public bool startOnStartup = false;
		public bool hideTaskbarIcon = true;

		public tabName defaultTab = tabName.StopWatch;

		public System.Drawing.Color OverlayForeColor = System.Drawing.Color.Black;
		public System.Drawing.Color OverlayBackColor = System.Drawing.Color.White;
		public double OverlayOptacy = 0.5;

		public HotKey ActivateOverlay = new HotKey(Keys.F8, Keys.LControlKey);
		public HotKey CycleOverlayTabs = new HotKey(Keys.F12, Keys.LControlKey);
		public HotKey OverlayKey1 = new HotKey(Keys.F9, Keys.LControlKey);
		public HotKey OverlayKey2 = new HotKey(Keys.F10, Keys.LControlKey);
		public HotKey OverlayKey3 = new HotKey(Keys.F11, Keys.LControlKey);
	}
}
