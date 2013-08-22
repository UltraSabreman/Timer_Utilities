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

		public HotKey EnableKeys = new HotKey(ModKeys.Control, Keys.F12);
		public HotKey StartSW = new HotKey(ModKeys.Control, Keys.F5);
		public HotKey ResetSW = new HotKey(ModKeys.Control, Keys.F6);
		public HotKey StartCD = new HotKey(ModKeys.Control, Keys.F7);
		public HotKey ResetCD = new HotKey(ModKeys.Control, Keys.F8);
		public HotKey EnterModeCD = new HotKey(ModKeys.Control, Keys.F9);
	}
}
