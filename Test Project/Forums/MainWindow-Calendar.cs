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

				if (!c.Repeat.End || c.Repeat.NumOfRepeats != -1)  //never end
					endDay = DaySelect.MaxDate;
				 else 
					endDay = c.Repeat.EndDate;

				if (c.Repeat.WhenToRepeat == repeatData.repeatType.Daily) {
					endDay = curDay.AddDays(c.Repeat.Spacing * c.Repeat.NumOfRepeats);
					while (curDay.CompareTo(endDay) <= 0) {
						DaySelect.AddBoldedDate(curDay);
						linkBoldDate(c, curDay);

						curDay = curDay.AddDays(c.Repeat.Spacing);
					}
				} else if (c.Repeat.WhenToRepeat == repeatData.repeatType.Weekly) {
					int testind = 0;
					int count = 0;
					curDay = curDay.AddDays(-(int)curDay.DayOfWeek); //this puts us on sunday of the current week (makes the cunt accurate)
					while (curDay.CompareTo(endDay) <= 0) {
						if (c.Repeat.NumOfRepeats != -1 && count >= c.Repeat.NumOfRepeats) break;
						if (curDay >= c.StartDate.Date && c.Repeat.WeekDays[(int)curDay.DayOfWeek]) {
							DaySelect.AddBoldedDate(curDay);
							linkBoldDate(c, curDay);
						}

						curDay = curDay.AddDays(1 + (testind == 6 ? 7 * (c.Repeat.Spacing - 1) : 0));
						testind = (testind == 6 ? 0 : testind + 1);
						count++;
					}
				} else if (c.Repeat.WhenToRepeat == repeatData.repeatType.Monthly) {
					if (c.Repeat.monthlyType == repeatData.monthRepType.DayBased) {
						int count = 0;
						while (curDay.CompareTo(endDay) <= 0) {
							if (c.Repeat.NumOfRepeats != -1 && count >= c.Repeat.NumOfRepeats) break;
							DaySelect.AddBoldedDate(curDay);
							linkBoldDate(c, curDay);

							curDay = curDay.AddMonths(c.Repeat.Spacing);
							count++;
						}
					} else {
						DayOfWeek curWeekDay = curDay.DayOfWeek;
						int posInMonth = 0;

						DateTime firstDay = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
						DateTime iterator = firstDay;
						DateTime endTest = curDay.Date;
						while (iterator.CompareTo(endTest) < 0) {
							if (iterator.DayOfWeek == curWeekDay)
								posInMonth++;
							iterator = iterator.AddDays(1);
						}
						posInMonth++; //because we end on the event day, it doesnt get counted.
						List<DateTime> dates = getMonthlyDates(firstDay, curWeekDay, posInMonth, c.Repeat.EndDate, c.Repeat.NumOfRepeats);

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

		public List<DateTime> getMonthlyDates(DateTime start, DayOfWeek day, int posInMonth, DateTime end, int occurances = -1) {
			List<DateTime> temp = new List<DateTime>();
			int count = 0;
			int numOfEvents = 0;
			bool doneMonth = false;
			if (occurances != -1) end = DaySelect.MaxDate;
			while (start.CompareTo(end) < 0) {
				if (!doneMonth) {
					if (start.DayOfWeek == day)
						count++;

					if (count == posInMonth) {
						temp.Add(new DateTime(start.Ticks));
						numOfEvents++;
						count = 0;
						doneMonth = true;
						if (occurances != -1 && numOfEvents >= occurances) break;
					}
				}

				start = start.AddDays(1);

				if (start.Day == 1) {
					count = 0;
					doneMonth = false;
				}
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
			AddEventDialouge t = new AddEventDialouge(DaySelect);
			t.OnClose += new AddEventDialouge.addCal(addToCalList);
			t.Show();
		}


		private void EditCalEventButton_Click(object sender, EventArgs e) {
			if (BriefEventView.SelectedIndices.Count == 0) return;

			AddEventDialouge t = new AddEventDialouge(getSelectedCal(), DaySelect);
			t.OnCloseEdit += new AddEventDialouge.editCal(editCalEvent);
			t.Show();
		}

		public void editCalEvent(CalendarItem c, DateTime d, bool all) {
			if (all) {

			} else {
				//calendarItems.
			}
			updateCalTab();
		}

		public CalendarItem getSelectedCal() {
			if (BriefEventView.SelectedIndices.Count == 0) return null;

			foreach (boldDate b in eventDates) {
				if (b.date.Date.CompareTo(DaySelect.SelectionStart.Date) == 0) {
					return b.linkedEvents[BriefEventView.SelectedIndices[0]];
				}
			}

			return null;
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
