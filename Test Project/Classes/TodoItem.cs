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
