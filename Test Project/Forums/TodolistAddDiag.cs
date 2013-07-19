using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_Utils {
	public partial class TodolistAddDiag : Form {
		public delegate void onClose(string s);
		public event onClose OnClose;

		private string text = "";

		public TodolistAddDiag(string s = null) {
			InitializeComponent();

			if (s != null) {
				NewItem.Text = s;
				NewItem.Update();
				text = s;
				Text = "Edit Item";
				Update();
			}
		}

		private void Ok_Click(object sender, EventArgs e) {
			if (OnClose != null)
				OnClose(text);
			Dispose();
		}

		private void Cancel_Click(object sender, EventArgs e) {
			Dispose();
		}

		private void NewItem_TextChanged(object sender, EventArgs e) {
			NewItem.Update();
			text = NewItem.Text;
		}

		private void TodolistAddDiag_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				if (OnClose != null)
					OnClose(text);
				Dispose();
			}
		}
	}
}
