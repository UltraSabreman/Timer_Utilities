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

			DaySelect.RemoveAllBoldedDates();

			foreach (boldDate b in eventDates) {
				DaySelect.AddBoldedDate(b.date);
			}

			DaySelect.Update();
			DaySelect.UpdateBoldedDates();
		}

		public void hardUpdateCalTab() {
			eventDates.Clear();

			foreach (CalendarItem c in calendarItems)
				proccessCalEvent(c);

			updateCalTab();
		}

		/// <summary>
		/// This generates a list of dates for the repeated caledar event
		/// This list can then be used by generateRepeatEvents to create the 
		/// appropriate events later.
		/// </summary>
		/// <param name="c">The calendar we're on</param>
		public void proccessCalEvent(CalendarItem c) {
			List<DateTime> listOfeventDates = new List<DateTime>();

			if (c.DoRepeat) {
				DateTime curDay = c.StartDate;
				DateTime endDay = new DateTime();

				if (!c.Repeat.End || c.Repeat.NumOfRepeats != -1)  //never end
					endDay = DaySelect.MaxDate;
				else
					endDay = c.Repeat.EndDate;

				if (c.Repeat.WhenToRepeat == repeatData.repeatType.Daily) {
					if (c.Repeat.NumOfRepeats != -1)
						endDay = curDay.AddDays(c.Repeat.Spacing * c.Repeat.NumOfRepeats);
					while (curDay.CompareTo(endDay) <= 0) {
						listOfeventDates.Add(curDay);
						curDay = curDay.AddDays(c.Repeat.Spacing);
					}
				} else if (c.Repeat.WhenToRepeat == repeatData.repeatType.Weekly) {
					int testind = 0;
					int count = 0;
					curDay = curDay.AddDays(-(int)curDay.DayOfWeek); //this puts us on sunday of the current week (makes the cunt accurate)
					while (curDay.CompareTo(endDay) <= 0) {
						if (c.Repeat.NumOfRepeats != -1 && count >= c.Repeat.NumOfRepeats) break;
						if (curDay >= c.StartDate.Date && c.Repeat.WeekDays[(int)curDay.DayOfWeek]) {
							listOfeventDates.Add(curDay);
						}

						curDay = curDay.AddDays(1 + (testind == 6 ? 7 * (c.Repeat.Spacing - 1) : 0));
						testind = (testind == 6 ? 0 : testind + 1);
						count++;
					}
				} else if (c.Repeat.WhenToRepeat == repeatData.repeatType.Monthly) {
					if (c.Repeat.MonthlyType == repeatData.monthRepType.DayBased) {
						int count = 0;
						while (curDay.CompareTo(endDay) <= 0) {
							if (c.Repeat.NumOfRepeats != -1 && count >= c.Repeat.NumOfRepeats) break;
							listOfeventDates.Add(curDay);

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
						listOfeventDates = getMonthlyDates(firstDay, curWeekDay, posInMonth, c.Repeat.EndDate, c.Repeat.NumOfRepeats);
					}
				} else if (c.Repeat.WhenToRepeat == repeatData.repeatType.Yearly) {
					if (c.Repeat.NumOfRepeats != -1)
						endDay = curDay.AddYears(c.Repeat.Spacing * c.Repeat.NumOfRepeats);
					while (curDay.CompareTo(endDay) <= 0) {
						listOfeventDates.Add(curDay);
						curDay = curDay.AddYears(c.Repeat.Spacing);
					}
				}
			} else {
				c.Repeat = new repeatData(); //make it perdy
				listOfeventDates.Add(c.StartDate);
			}

			generateRepeatEvents(c, listOfeventDates);
		}

		/// <summary>
		/// This creates a linked list of NON REPEATING cal events based on the pased in list
		/// The head will keep it's repeat data (so you can re-generate the list) but the children
		/// act like singular events
		/// </summary>
		/// <param name="c">The head of the list</param>
		/// <param name="listOfeventDates">list of dates to use</param>
		public void generateRepeatEvents(CalendarItem c, List<DateTime> listOfeventDates) {
			CalendarItem current = c;
			linkBoldDate(c, c, c.StartDate.Date);
			List<DateTime> test = listOfeventDates.GetRange(1,listOfeventDates.Count - 1); //make sure we dont include the first date twice.

			foreach (DateTime d in test) {
				if (c.isDateExcluded(d)) continue;

				CalendarItem temp = new CalendarItem(c);
				temp.StartDate = d;

				linkBoldDate(temp, c, d);

				current.nextCal = temp;
				current = current.nextCal;
			}
		}

		/// <summary>
		/// Generates a list of dates for a event that occures monthly. 
		/// This was ratehr complicated so it's split off fromt he main generatiopn function
		/// </summary>
		/// <param name="start">The start date of the event</param>
		/// <param name="day">The start dates day of the week</param>
		/// <param name="posInMonth">The numerical position in teh month (ie 2nd sunday)</param>
		/// <param name="end">the end date, if aplicable</param>
		/// <param name="occurances">the number of times to repeat</param>
		/// <returns>A list of dates when the event will occur</returns>
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

		/// <summary>
		/// Crteates a "link" between the bolded days on the calenda (and the listview members) and the actual
		/// physical events
		/// </summary>
		/// <param name="inCal">the event to link</param>
		/// <param name="inDate">the date to link to</param>
		/// <param name="head">the head of the ll, lets us save with json</param>
		public void linkBoldDate(CalendarItem inCal, CalendarItem head, DateTime inDate) {
			bool found = false;
			foreach (boldDate b in eventDates) {
				if (b.date.Equals(inDate)) {
					found = true;
					if (b.linkedEvents.IndexOf(inCal) == -1) {
						b.linkedEvents.Add(inCal);
						b.linkedHeads.Add(head);
					}
				}					
			}
			if (!found) {
				boldDate temp = new boldDate();
				temp.date = inDate;
				temp.linkedEvents.Add(inCal);
				temp.linkedHeads.Add(head);
				eventDates.Add(temp);
			}
		}


		public void addToCalList(CalendarItem c) {
			calendarItems.Add(c);
			proccessCalEvent(c);
			updateCalTab();
		}


		private void button1_Click(object sender, EventArgs e) {
			AddEventDialouge t = new AddEventDialouge(DaySelect);
			t.OnClose += new AddEventDialouge.addCal(addToCalList);
			t.Show();
		}


		private void EditCalEventButton_Click(object sender, EventArgs e) {
			if (BriefEventView.SelectedIndices.Count == 0) return;
			CalendarItem test = getSelectedCal();
			AddEventDialouge t = new AddEventDialouge(ref test, DaySelect);
			t.OnCloseEdit += new AddEventDialouge.editCal(editCalEvent);
			t.Show();
		}

		/// <summary>
		/// Executed by the addevent dialog when you edit an event.
		/// </summary>
		/// <param name="c">the returned caledar</param>
		/// <param name="seperate">weather or not to apply tis change to the entire sirius or not</param>
		public void editCalEvent(ref CalendarItem c, bool seperate) {
			if (seperate) {
				foreach (boldDate b in eventDates) {
					if (b.date.Date.CompareTo(c.StartDate.Date) == 0) {
						int i = b.linkedEvents.IndexOf(c);
						CalendarItem head = b.linkedHeads[i];
						CalendarItem current = head;
						CalendarItem prev = head;

						//edge case, only one node in list
						//if this happens, everything stays the same.
						if (head.nextCal != null) { 
							while (current != null) {
								if (current.StartDate.Date.CompareTo(b.date.Date) == 0) {
									if (current == head) { //edge case, were editing the head
										CalendarItem temp = head.nextCal;
										head.nextCal = null;
										calendarItems.Add(temp);
									} else {
										//remove the current event form the linked list.
										CalendarItem temp = current;
										prev.nextCal = temp.nextCal;

										head.excludeDates.Add(current.StartDate);
										b.linkedHeads[i] = temp;
										calendarItems.Add(temp);
									}
									break;
								}

								prev = current;
								current = current.nextCal;
							}
						}
						break;
					}
				}

			} else {
				foreach (boldDate b in eventDates) {
					if (b.date.Date.CompareTo(c.StartDate.Date) == 0) {
						int i = b.linkedEvents.IndexOf(c);
						b.linkedHeads[i] = new CalendarItem(c);
						break;
					}
				}
			}

			hardUpdateCalTab();
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
