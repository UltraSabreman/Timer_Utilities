using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_Utils {
	public partial class AddEventDialouge : Form {
		public delegate void addCal(CalendarItem c);
		public delegate void editCal(ref CalendarItem c, bool shoulSeperate);
		public event addCal OnClose;
		public event editCal OnCloseEdit;

		private List<reminder> reminders = new List<reminder>();
		private List<CheckBox> repeatDays = new List<CheckBox>();

		private CalendarItem item  = new CalendarItem();
		private bool editMode = false;
		private DateTime skipDate = new DateTime();

		public AddEventDialouge(MonthCalendar cal = null) {
			InitializeComponent();

			RepeatTypeBox.SelectedIndex = 0;

			repeatDays.Add(CheckMon);
			repeatDays.Add(CheckTue);
			repeatDays.Add(CheckWed);
			repeatDays.Add(CheckThu);
			repeatDays.Add(CheckFri);
			repeatDays.Add(CheckSat);
			repeatDays.Add(CheckSun);

			if (cal == null) {
				StartDate.SelectionStart = System.DateTime.Today;
				StartDate.SelectionEnd = System.DateTime.Today;
			} else {
				StartDate.SelectionRange = cal.SelectionRange;
			}

			startTime.Value = System.DateTime.Now;
			EndDateBox.Value = System.DateTime.Today.AddDays(1);
		}

		public AddEventDialouge(ref CalendarItem newCal, MonthCalendar cal = null) {
			InitializeComponent();

			item = newCal; //?
			skipDate = cal.SelectionStart;
			editMode = true;

			repeatDays.Add(CheckMon);
			repeatDays.Add(CheckTue);
			repeatDays.Add(CheckWed);
			repeatDays.Add(CheckThu);
			repeatDays.Add(CheckFri);
			repeatDays.Add(CheckSat);
			repeatDays.Add(CheckSun);

			int i = 0;


			if (cal == null) {
				StartDate.SelectionStart = item.StartDate;
				StartDate.SelectionEnd = item.StartDate;
			} else {
				StartDate.SelectionRange = cal.SelectionRange;
			}

			startTime.Value = item.StartDate;


			AllDay.Checked = item.AllDay;
			Title.Text = item.Title;
			Discription.Text = item.Discritpion;

			if (!item.DoRepeat) {
				EndNever.Checked = true;
				EndDateBox.Value = item.StartDate.AddDays(1);
				RepeatIntervalBox.Value = 1;
				RepeatTypeBox.SelectedIndex = (int)repeatData.repeatType.None;
				RadioDay.Checked = true;
			} else {
				if (item.Repeat.NumOfRepeats != -1) {
					EndTimesBox.Value = item.Repeat.NumOfRepeats;
					EndTimes.Checked = true;
				} else
					EndDate.Checked = true;

				EndDateBox.Value = item.Repeat.EndDate;
				if (item.Repeat.WeekDays.Count != 0) {
					foreach (CheckBox c in repeatDays)
						c.Checked = item.Repeat.WeekDays[i++];
				}
				RepeatIntervalBox.Value = item.Repeat.Spacing;
				RepeatTypeBox.SelectedIndex = (int)item.Repeat.WhenToRepeat;
				if (item.Repeat.MonthlyType == repeatData.monthRepType.DayBased)
					RadioDay.Checked = true;
				else
					RadioWeek.Checked = false;
			}
			
			updateReminderList();
		}

		public void AddRem(reminder t) {
			item.Reminders.Add(t);
			updateReminderList();
		}

		public void EditRem(reminder t) {
			item.Reminders[reminderList.SelectedIndices[0]] = t;
			updateReminderList();
		}

		private void updateReminderList() {
			reminderList.SelectedItems.Clear();
			reminderList.Items.Clear();

			foreach (reminder r in item.Reminders)
				reminderList.Items.Add(r.ToListItem());
		}		

		private void RepeatTypeBox_SelectedIndexChanged(object sender, EventArgs e) {
			if (RepeatTypeBox.SelectedIndex == 2) {
				item.DoRepeat = true;
				Days.Enabled = true;
				EndOn.Enabled = true;
				RadioDay.Enabled = false;
				RadioWeek.Enabled = false;

				foreach (CheckBox c in repeatDays)
					c.Enabled = true;
			} else {
				foreach (CheckBox c in repeatDays)
					c.Enabled = false;
				

				if (RepeatTypeBox.SelectedIndex == 0) {
					item.DoRepeat = false;
					Days.Enabled = false;
					EndOn.Enabled = false;
				} else {
					item.DoRepeat = true;
					Days.Enabled = true;
					EndOn.Enabled = true;
					if (RepeatTypeBox.SelectedIndex == 3) {
						RadioDay.Enabled = true;
						RadioWeek.Enabled = true;
					} else {
						RadioDay.Enabled = false;
						RadioWeek.Enabled = false;
					}
				}
			}

			item.Repeat.WhenToRepeat = (repeatData.repeatType)RepeatTypeBox.SelectedIndex;
		}

		private void EndNever_CheckedChanged(object sender, EventArgs e) {
			if (EndNever.Checked)
				item.Repeat.End = false;
		}

		private void EndTimes_CheckedChanged(object sender, EventArgs e) {
			if (EndTimes.Checked) {
				EndTimesBox.Enabled = true;
				item.Repeat.End = true;
			} else
				EndTimesBox.Enabled = false;
		}


		private void EndDate_CheckedChanged(object sender, EventArgs e) {
			if (EndDate.Checked) {
				EndDateBox.Enabled = true;
				item.Repeat.End = true;
			} else
				EndDateBox.Enabled = false;
		}


		private void Cancel_Click(object sender, EventArgs e) {
			Dispose();
		}

		private void Ok_Click(object sender, EventArgs e) {
			item.Repeat.WeekDays.Clear();
			foreach (CheckBox c in repeatDays) {
				item.Repeat.WeekDays.Add(c.Checked);
			}

			if (!EndTimes.Checked)
				item.Repeat.NumOfRepeats = -1;

			if (!editMode && OnClose != null)
				OnClose(item);
			else if (editMode && OnCloseEdit != null) {
				bool seperate = false;

				System.Windows.Forms.DialogResult t = MessageBox.Show("Apply these changes to only this event?", "", MessageBoxButtons.YesNoCancel);
				if (t == System.Windows.Forms.DialogResult.Yes)
					seperate = true;
				if (t == System.Windows.Forms.DialogResult.Cancel)
					return;

				OnCloseEdit(ref item, seperate);
			}
			Dispose();
		}

		private void AllDay_CheckedChanged(object sender, EventArgs e) {
			startTime.Enabled = !AllDay.Checked;
			item.AllDay = AllDay.Checked;
			if (!item.AllDay)
				item.StartDate = StartDate.SelectionStart.Date;
			else
				item.StartDate = StartDate.SelectionStart.Date.AddSeconds(startTime.Value.TimeOfDay.TotalSeconds);
		}


		private void AddToolStripMenuItem_Click(object sender, EventArgs e) {
			AddReminder t = new AddReminder();
			t.OnClose += new AddReminder.addRem(AddRem);
			t.Show();
		}

		private void EditToolStripMenuItem_Click(object sender, EventArgs e) {
			AddReminder t = new AddReminder(item.Reminders[reminderList.SelectedIndices[0]]);
			t.OnClose += new AddReminder.addRem(EditRem);
			t.Show();
		}

		private void RemoveToolStripMenuItem_Click(object sender, EventArgs e) {
			if (reminderList.SelectedIndices.Count == 0) return;

			item.Reminders.RemoveAt(reminderList.SelectedIndices[0]);
			reminderList.SelectedIndices.Remove(0); //wtf consistency
			reminderList.SelectedItems[0].Remove();

			updateReminderList();
		}

		private void RemindersContext_Opening(object sender, CancelEventArgs e) {
			if (reminderList.SelectedItems.Count == 0) {
				EditToolStripMenuItem.Enabled = false;
				RemoveToolStripMenuItem.Enabled = false;
			} else {
				EditToolStripMenuItem.Enabled = true;
				RemoveToolStripMenuItem.Enabled = true;
			}
		}

		private void Title_TextChanged(object sender, EventArgs e) {
			item.Title = Title.Text;
		}

		private void Discription_TextChanged(object sender, EventArgs e) {
			item.Discritpion = Discription.Text;
		}

		private void RepeatIntervalBox_ValueChanged(object sender, EventArgs e) {
			item.Repeat.Spacing = (int)RepeatIntervalBox.Value;
		}

		private void EndTimesBox_ValueChanged(object sender, EventArgs e) {
			item.Repeat.NumOfRepeats = (int)EndTimesBox.Value;
		}
		private void EndDateBox_ValueChanged(object sender, EventArgs e) {
			if (EndDateBox.Value.CompareTo(item.StartDate) <= 0) {
				MessageBox.Show("The end date can't be sooner or equal to the start date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			item.Repeat.EndDate = EndDateBox.Value;
		}

		private void StartDate_DateChanged(object sender, DateRangeEventArgs e) {
			if (!item.AllDay)
				item.StartDate = StartDate.SelectionStart.Date;
			else
				item.StartDate = StartDate.SelectionStart.Date.AddSeconds(startTime.Value.TimeOfDay.TotalSeconds);
		}

		private void startTime_ValueChanged(object sender, EventArgs e) {
			item.StartDate = StartDate.SelectionStart.Date.AddSeconds(startTime.Value.TimeOfDay.TotalSeconds);
		}

		private void radioDay_CheckedChanged(object sender, EventArgs e) {
			item.Repeat.MonthlyType = repeatData.monthRepType.DayBased;
		}

		private void RadioWeek_CheckedChanged(object sender, EventArgs e) {
			item.Repeat.MonthlyType = repeatData.monthRepType.WeekBased;
		}
	}
}
