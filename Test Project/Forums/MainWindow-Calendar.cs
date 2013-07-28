using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_Utils {
	public partial class MainWindow {
		private List<CalendarItem> calendarItems = new List<CalendarItem>();
		private List<boldDate> eventDates = new List<boldDate>();

		public void CinitTab() {

		}

		public void updateCalTab() {
			BriefEventView.SelectedItems.Clear();
			BriefEventView.Items.Clear();

			//DaySelect.RemoveAllBoldedDates();

			foreach (CalendarItem c in calendarItems)
				proccessCalEvent(c);
		}

		public void proccessCalEvent(CalendarItem c) {
			DaySelect.AddBoldedDate(c.StartDate);
			linkBoldDate(c, c.StartDate);

			if (c.DoRepeat) {
				DateTime curDay = c.StartDate;
				DateTime endDay = new DateTime();

				if (!c.Repeat.End) { //never end
					endDay = DaySelect.MaxDate;
				} else {
					if (c.Repeat.NumOfRepeats == -1) //use date as terminator
						endDay = c.Repeat.EndDate;
					else
						endDay = curDay.AddDays(c.Repeat.Spacing * c.Repeat.NumOfRepeats);

				}

				if (c.Repeat.WhenToRepeat == repeatData.repeatType.Daily) {
					while (curDay.CompareTo(endDay) <= 0) {
						DaySelect.AddBoldedDate(curDay);
						linkBoldDate(c, curDay);

						curDay = curDay.AddDays(c.Repeat.Spacing);
					}
				} else if (c.Repeat.WhenToRepeat == repeatData.repeatType.Weekly) {
					//why the flying fucking fuck will this not fucing work
					int testind = 0;
					curDay = curDay.AddDays(-(int)curDay.DayOfWeek);
					while (curDay.CompareTo(endDay) <= 0) {
						if (curDay >= DateTime.Today && c.Repeat.WeekDays[(int)curDay.DayOfWeek]) {
							DaySelect.AddBoldedDate(curDay);
							linkBoldDate(c, curDay);
						}

						curDay = curDay.AddDays((testind == 6 ? 7 * c.Repeat.Spacing : 1));
						testind = (testind == 6 ? 0 : testind + 1);
					}
				} else if (c.Repeat.WhenToRepeat == repeatData.repeatType.Monthly) {
					if (c.Repeat.monthlyType == repeatData.monthRepType.DayBased) {
						while (curDay.CompareTo(endDay) <= 0) {
							DaySelect.AddBoldedDate(curDay);
							linkBoldDate(c, curDay);

							curDay = curDay.AddMonths(c.Repeat.Spacing);
						}
					} else {
						DayOfWeek temp = curDay.DayOfWeek;
						int count = 0;

						DateTime test = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
						DateTime endTest = new DateTime(curDay.Year, curDay.Month, curDay.Day);
						while (test.CompareTo(endTest) < 0) {
							if (test.DayOfWeek == temp)
								count++;
							test.AddDays(1);
						}

						List<DateTime> dates = getMonthlyDates(curDay, temp, count);

						if (!c.DoRepeat) {
							foreach (DateTime d in dates) {
								DaySelect.AddBoldedDate(d);
								linkBoldDate(c, d);
							}
						} else {
							if (c.Repeat.NumOfRepeats == -1) {
								foreach (DateTime d in dates) {
									if (d.CompareTo(c.Repeat.EndDate) >= 0) break;
									DaySelect.AddBoldedDate(d);
									linkBoldDate(c, d);
								}
							} else {
								int numOfEvents = 0;
								foreach (DateTime d in dates) {
									if (numOfEvents >= c.Repeat.NumOfRepeats) break;
									DaySelect.AddBoldedDate(d);
									linkBoldDate(c, d);

									numOfEvents++;
								}
							}
						}
					}
				}
			}

		}

		public List<DateTime> getMonthlyDates(DateTime start, DayOfWeek day, int posInMonth) {
			List<DateTime> temp = new List<DateTime>();
			int count = 0;
			while (start.CompareTo(DaySelect.MaxDate) < 0) {
				if (start.DayOfWeek == day) 
					count++;

				if (count == posInMonth)
					temp.Add(new DateTime(start.Ticks));

				if (start.Day == 1)
					count = 0;

				start = start.AddDays(1);		
			}

			return temp;

		}

		public void linkBoldDate(CalendarItem inCal, DateTime inDate) {
			bool found = false;
			foreach (boldDate b in eventDates) {
				if (b.date.Equals(inDate)) {
					found = true;
					if (b.linkedEvents.IndexOf(inCal) == -1)
						b.linkedEvents.Add(inCal);
				}					
			}
			if (!found) {
				boldDate temp = new boldDate();
				temp.date = inDate;
				temp.linkedEvents.Add(inCal);
				eventDates.Add(temp);
			}
		}

		public void addToCalList(CalendarItem c) {
			calendarItems.Add(c);
			updateCalTab();
		}


		private void button1_Click(object sender, EventArgs e) {
			AddEventDialouge t = new AddEventDialouge();
			t.OnClose += new AddEventDialouge.addCal(addToCalList);
			t.Show();
		}

		private void DaySelect_DateChanged(object sender, DateRangeEventArgs e) {
			BriefEventView.Items.Clear();
			foreach (boldDate b in eventDates) {
				if (b.date.Date.CompareTo(DaySelect.SelectionStart.Date) == 0) {
					foreach (CalendarItem c in b.linkedEvents)
						BriefEventView.Items.Add(c.ToListItem());
				}
			}
		}
	}
}
