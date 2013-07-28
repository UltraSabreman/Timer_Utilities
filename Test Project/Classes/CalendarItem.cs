using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer_Utils {
	class CalendarItem {
		private string title = "";
		public string Title {
			set { title = value; }
			get { return title; }
		}
		private string desc = "";
		public string Desc {
			set { desc = value; }
			get { return desc; }
		}
	}
}
