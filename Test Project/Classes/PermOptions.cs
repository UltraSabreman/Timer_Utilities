using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Timer_Utils {
	public class PermOptions {
		public enum tabName { StopWatch, CountDown, TodoList };
		
		public bool startOnStartup = false;
		public bool hideTaskbarIcon = true;

		public tabName defaultTab = tabName.StopWatch;

		public System.Drawing.Color OverlayForeColor = System.Drawing.Color.Black;
		public System.Drawing.Color OverlayBackColor = System.Drawing.Color.White;
		public double OverlayOptacy = 0.5;
	}
}
