using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_Utils {
	class TodoItem {
		private string title = "";
		private bool done = false;
		private int urgency = 0;

		public string Title {
			set { title = value; }
			get { return title; }
		}

		public bool Done {
			set { done = value; }
			get { return done; }
		}

		/// <summary>
		/// 0 = Normal
		/// 1 = Low
		/// 2 = Medium
		/// 3 = High
		/// </summary>
		public int Urgency {
			set { urgency = (value >= 0 && value <= 3 ? value : urgency); }
			get { return urgency; }
		}

		public TodoItem(string s = "") {
			if (s != "")
				FromString(s);
		}

		public string ToString() {
			string temp = "";
			if (done) temp += "1"; else temp += "0";

			temp += ("," + urgency.ToString() + "," + Title);

			return temp;
		}

		public void FromString(string str) {
			string[] delim = { "," };
			string[] data = str.Split(delim, 3, StringSplitOptions.None);

			if (data[0] == "1")
				Done = true;

			urgency = int.Parse(data[1]);

			title = data[2];
		}

		public ListViewItem ToListItem() {
			ListViewItem temp = new ListViewItem();
			temp.SubItems.Add(title);
			temp.Checked = done;

			switch (urgency) {
				case 1: temp.ForeColor = System.Drawing.Color.Green;	break;
				case 2: temp.ForeColor = System.Drawing.Color.Orange;	break;
				case 3: temp.ForeColor = System.Drawing.Color.Red;		break;
				case 0: temp.ForeColor = System.Drawing.Color.Black;	break;
			}

			return temp;
		}

	}
}
