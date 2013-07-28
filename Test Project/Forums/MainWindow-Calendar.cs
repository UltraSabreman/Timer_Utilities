using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer_Utils {
	public partial class MainWindow {
		private List<CalendarItem> calendarItems = new List<CalendarItem>();

		public void CinitTab() {

		}
		public void test(CalendarItem c) {
			calendarItems.Add(c);
		}
		private void button1_Click(object sender, EventArgs e) {
			AddEventDialouge t = new AddEventDialouge();
			t.OnClose += new AddEventDialouge.addCal(test);
			t.Show();
		}
	}
}
