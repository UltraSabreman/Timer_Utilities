using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Time_Utils {
	public partial class MainWindow  {
		////////////////////////////////////
		// Private Members
		private List<TodoItem> todoItems = new List<TodoItem>();

		////////////////////////////////////
		// Private Methods
		private void TDinitTab() {
			TDtodoList.ItemChecked += new ItemCheckedEventHandler(TDtodoList_ItemChecked);
		}

		private void TDupdate() {
			TDtodoList.Items.Clear();
			TDtodoList.SelectedItems.Clear();
			

			foreach (TodoItem i in todoItems)
				TDtodoList.Items.Add(i.ToListItem());
		}
		private void TDtodoList_ItemChecked(object sender, ItemCheckedEventArgs e) {
			if (e.Item != null && todoItems.Count != 0) {
				ListViewItem t = e.Item;
				int i = TDtodoList.Items.IndexOf(t);

				todoItems[i].Done = t.Checked;
			}
		}

		private void TDaddItem(string text) {
			TodoItem temp = new TodoItem();
			temp.Title = text;

			todoItems.Add(temp);
			TDupdate();
		}

		private void TDeditItem(string text) {
			todoItems[TDtodoList.SelectedIndices[0]].Title = text;

			TDupdate();
		}

		private void TDaddItemToolStripMenuItem_Click(object sender, EventArgs e) {
			TDaddItemBox();
		}

		private void TDremoveItemToolStripMenuItem_Click(object sender, EventArgs e) {
			if (TDtodoList.SelectedIndices.Count == 0) return;

			todoItems.RemoveAt(TDtodoList.SelectedIndices[0]);
			TDtodoList.SelectedIndices.Remove(0); //wtf consistency
			TDtodoList.SelectedItems[0].Remove();

			TDupdate();
		}
		private void TDremoveAllCompleatedItemsToolStripMenuItem_Click(object sender, EventArgs e) {
			todoItems.RemoveAll(item => item.Done);
			TDupdate();
		}

		private void TDnoneToolStripMenuItem_Click(object sender, EventArgs e) {
			if (TDtodoList.SelectedIndices.Count == 0) return;
			todoItems[TDtodoList.SelectedIndices[0]].Urgency = 0;

			TDupdate();
		}

		private void TDlowToolStripMenuItem_Click(object sender, EventArgs e) {
			if (TDtodoList.SelectedIndices.Count == 0) return;
			todoItems[TDtodoList.SelectedIndices[0]].Urgency = 1;

			TDupdate();
		}

		private void TDmediumToolStripMenuItem_Click(object sender, EventArgs e) {
			if (TDtodoList.SelectedIndices.Count == 0) return;
			todoItems[TDtodoList.SelectedIndices[0]].Urgency = 2;

			TDupdate();
		}

		private void TDhighToolStripMenuItem_Click(object sender, EventArgs e) {
			if (TDtodoList.SelectedIndices.Count == 0) return;
			todoItems[TDtodoList.SelectedIndices[0]].Urgency = 3;

			TDupdate();
		}

		private void TDtodoMenu_Opening(object sender, EventArgs e) {
			bool flag = (TDtodoList.SelectedItems.Count != 0);
			priority.Enabled = flag;
			EditItem.Enabled = flag;
			removeItemToolStripMenuItem.Enabled = flag;

			bool someDone = false;
			foreach (TodoItem i in todoItems)
				if (i.Done) {
					someDone = true;
					break;
				}

			removeAllCompleatedItemsToolStripMenuItem.Enabled = someDone;
		}

		private void TDtodoList_MouseDown(object sender, MouseEventArgs e) {
			if (e.Clicks == 2)
				TDtodoList_MouseDoublClick(sender, e);
		}


		private void TDeditItem_Click(object sender, EventArgs e) {
			if (TDtodoList.SelectedItems.Count <= 0) return;

			TDaddItemBox(todoItems[TDtodoList.SelectedIndices[0]].Title);
		}

		private void TDtodoList_MouseDoublClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				if (TDtodoList.SelectedItems.Count == 0)
					TDaddItemBox(); 
				else
					TDaddItemBox(todoItems[TDtodoList.SelectedIndices[0]].Title);
			}
		}

		private void TDaddItemBox(string s = "") {
			TodolistAddDiag temp = new TodolistAddDiag(s);
			
			if (s == "")
				temp.OnClose += new TodolistAddDiag.onClose(TDaddItem);
			else
				temp.OnClose += new TodolistAddDiag.onClose(TDeditItem);
			temp.Show();

			temp.Location = new Point(MousePosition.X - temp.Size.Width / 2, MousePosition.Y - temp.Size.Height / 2);
		}

	}
}