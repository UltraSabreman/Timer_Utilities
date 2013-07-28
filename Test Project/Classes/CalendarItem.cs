using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_Utils {
	public class reminder {
		public enum reminderType {Popup, Alarm, Email};
		public enum delayIntervalType {Minutes, Hours, Days, Weeks};

		public reminderType Type = reminderType.Popup;
		public int Delay = 0;
		public delayIntervalType DelayType = delayIntervalType.Minutes;

		public ListViewItem ToListItem() {
			ListViewItem temp = new ListViewItem();
			string[] types = { "Popup", "Alarm", "Email" };
			string[] delayTypes = { "Minutes", "Hours", "Days", "Weeks" };
			temp.Text = types[(int)Type];
			temp.SubItems.Add(Delay.ToString() + " " + delayTypes[(int)DelayType]);
			return temp;
		}
	}

	public class repeatData {
		public enum repeatType {None, Daily, Weekly, Monthly};

		public repeatType WhenToRepeat = repeatType.None;
		public List<bool> WeekDays = new List<bool>();
		public int Spacing = 1;

		public bool End = false;
		public DateTime EndDate = new DateTime();
		public int NumOfRepeats = 0;
	}

	public class CalendarItem {
		//this might be a bad desing desition, but fuck it
		public string Title = "Title";
		public string Discritpion = "Description";
		public bool AllDay = true;
		public DateTime StartDate = new DateTime();
		public bool DoRepeat = false;
		public repeatData Repeat = new repeatData();
		public List<reminder> Reminders = new List<reminder>();

	}
}
