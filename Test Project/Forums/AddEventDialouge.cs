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
		public event addCal OnClose;

		private List<reminder> reminders = new List<reminder>();
		private List<CheckBox> repeatDays = new List<CheckBox>();

		private CalendarItem item  = new CalendarItem();

		public AddEventDialouge() {
			InitializeComponent();

			RepeatTypeBox.SelectedIndex = 0;


			repeatDays.Add(CheckMon);
			repeatDays.Add(CheckTue);
			repeatDays.Add(CheckWed);
			repeatDays.Add(CheckThu);
			repeatDays.Add(CheckFri);
			repeatDays.Add(CheckSat);
			repeatDays.Add(CheckSun);

			StartDate.SelectionStart = System.DateTime.Today;
			StartDate.SelectionEnd = System.DateTime.Today;

			startTime.Value = System.DateTime.Now;
			EndDateBox.Value = System.DateTime.Today;
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
				Days.Enabled = true;
				EndOn.Enabled = true;

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
			foreach (CheckBox c in repeatDays) {
				item.Repeat.WeekDays.Add(c.Checked);
			}

			if (OnClose != null)
				OnClose(item);
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
	}
}
