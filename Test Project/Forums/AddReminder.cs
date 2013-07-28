using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_Utils {
	public partial class AddReminder : Form {
		public delegate void addRem(reminder t);
		public event addRem OnClose;

		private reminder ret = new reminder();

		public AddReminder(reminder t = null) {
			InitializeComponent();

			Type.SelectedIndex = 0;
			Delay.Value = ret.Delay = 10; // this is nesseasary ebcause the change event doest fire.
			DelayType.SelectedIndex = 0;

			if (t != null) {
				Type.SelectedIndex = (int)t.Type;
				Delay.Value = t.Delay;
				DelayType.SelectedIndex = (int)t.DelayType;
			}
		}

		private void IntervalType_SelectedIndexChanged(object sender, EventArgs e) {
			ret.DelayType = (reminder.delayIntervalType)DelayType.SelectedIndex;
		}

		private void Type_SelectedIndexChanged(object sender, EventArgs e) {
			ret.Type = (reminder.reminderType)Type.SelectedIndex;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
			ret.Delay = (int)Delay.Value;
		}

		private void Cancel_Click(object sender, EventArgs e) {
			Dispose();
		}

		private void Ok_Click(object sender, EventArgs e) {
			if (OnClose != null)
				OnClose(ret);
			Dispose();
		}
	}
}
