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
		public delayIntervalType DelayType = delayIntervalType.Minutes;
		public int Delay = 0;

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
		public enum repeatType {None, Daily, Weekly, Monthly, Yearly};
		public enum monthRepType {DayBased, WeekBased};

		public repeatType WhenToRepeat = repeatType.None;
		public monthRepType MonthlyType = monthRepType.DayBased;

		public int Spacing = 1;
		public int NumOfRepeats = 0;
		public bool End = false;

		public List<bool> WeekDays = new List<bool>();	
		public DateTime EndDate = new DateTime();

		public repeatData() { }
		public repeatData(repeatData src) {
			WhenToRepeat = src.WhenToRepeat;
			MonthlyType = src.MonthlyType;
			Spacing = src.Spacing;
			NumOfRepeats = src.NumOfRepeats;
			End = src.End;
			EndDate = src.EndDate;

			foreach (bool b in src.WeekDays) 
				WeekDays.Add(b);
		}
	}

	public class boldDate {
		public DateTime date = new DateTime();
		public List<CalendarItem> linkedEvents = new List<CalendarItem>();
		public List<CalendarItem> linkedHeads = new List<CalendarItem>();
	}

	public class CalendarItem {
		public string Title = "Title";
		public string Discritpion = "Description";

		public bool AllDay = true;
		public bool DoRepeat = false;

		public DateTime StartDate = new DateTime();
		public repeatData Repeat = new repeatData();

		public List<reminder> Reminders = new List<reminder>();
		public List<DateTime> excludeDates = new List<DateTime>();

		public CalendarItem nextCal = null;

		public CalendarItem() {
		}

		public CalendarItem(CalendarItem src) {
			Title = src.Title;
			Discritpion = src.Discritpion;
			AllDay = src.AllDay;
			DoRepeat = src.DoRepeat;

			StartDate = src.StartDate;
			Repeat = new repeatData(src.Repeat);

			Reminders = src.Reminders;
		}

		public bool isDateExcluded(DateTime day) {
			foreach (DateTime d in excludeDates)
				if (d.Date.CompareTo(day.Date) == 0)
					return true;
			
			return false;
		}

		public ListViewItem ToListItem() {
			ListViewItem temp = new ListViewItem();
			temp.Text = Title;
			temp.SubItems.Add(Discritpion);

			return temp;
		}
	}
}
