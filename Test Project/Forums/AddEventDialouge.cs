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

		private List<CheckBox> repeatDays = new List<CheckBox>();
		private int endType = 0; //0: never, 1: after occurances, 2: on date

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
					Days.Enabled = false;
					EndOn.Enabled = false;
				} else {
					Days.Enabled = true;
					EndOn.Enabled = true;
				}
			}
		}

		private void EndNever_CheckedChanged(object sender, EventArgs e) {
			if (EndNever.Checked)
				endType = 0;
		}

		private void EndTimes_CheckedChanged(object sender, EventArgs e) {
			if (EndTimes.Checked) {
				EndTimesBox.Enabled = true;
				endType = 1;
			} else
				EndTimesBox.Enabled = false;
		}


		private void EndDate_CheckedChanged(object sender, EventArgs e) {
			if (EndDateBox.Checked) {
				EndDateBox.Enabled = true;
				endType = 2;
			} else
				EndDateBox.Enabled = false;
		}

		private void StartDate_DateChanged(object sender, DateRangeEventArgs e) {

		}

		private void Cancel_Click(object sender, EventArgs e) {
			Dispose();
		}

		private void Ok_Click(object sender, EventArgs e) {
			//do more stuff
			Dispose();
		}

	}
}
