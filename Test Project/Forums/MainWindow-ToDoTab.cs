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


namespace Timer_Utils {
	public partial class MainWindow  {
		private List<TodoItem> todoItems = new List<TodoItem>();

		////////////////////////
		// read in and out the todo data
		
		////////////////////////

		//inti the tab
		private void TDinitTab() {
			TodoList.ItemChecked += new ItemCheckedEventHandler(TodoList_ItemChecked);
		}

		private void updateTodoList() {
			TodoList.Items.Clear();
			TodoList.SelectedItems.Clear();
			

			foreach (TodoItem i in todoItems)
				TodoList.Items.Add(i.ToListItem());
		}
		private void TodoList_ItemChecked(object sender, ItemCheckedEventArgs e) {
			if (e.Item != null && todoItems.Count != 0) {
				ListViewItem t = e.Item;
				int i = TodoList.Items.IndexOf(t);

				todoItems[i].Done = t.Checked;
			}
		}

		private void addItem(string text) {
			TodoItem temp = new TodoItem();
			temp.Title = text;

			todoItems.Add(temp);
			updateTodoList();
		}

		private void editItem(string text) {
			todoItems[TodoList.SelectedIndices[0]].Title = text;

			updateTodoList();
		}

		private void addItemToolStripMenuItem_Click(object sender, EventArgs e) {
			addItemBox();
		}

		private void removeItemToolStripMenuItem_Click(object sender, EventArgs e) {
			if (TodoList.SelectedIndices.Count == 0) return;

			todoItems.RemoveAt(TodoList.SelectedIndices[0]);
			TodoList.SelectedIndices.Remove(0); //wtf consistency
			TodoList.SelectedItems[0].Remove();

			updateTodoList();
		}
		private void removeAllCompleatedItemsToolStripMenuItem_Click(object sender, EventArgs e) {
			todoItems.RemoveAll(item => item.Done);
			updateTodoList();
		}

		private void noneToolStripMenuItem_Click(object sender, EventArgs e) {
			if (TodoList.SelectedIndices.Count == 0) return;
			todoItems[TodoList.SelectedIndices[0]].Urgency = 0;

			updateTodoList();
		}

		private void lowToolStripMenuItem_Click(object sender, EventArgs e) {
			if (TodoList.SelectedIndices.Count == 0) return;
			todoItems[TodoList.SelectedIndices[0]].Urgency = 1;

			updateTodoList();
		}

		private void mediumToolStripMenuItem_Click(object sender, EventArgs e) {
			if (TodoList.SelectedIndices.Count == 0) return;
			todoItems[TodoList.SelectedIndices[0]].Urgency = 2;

			updateTodoList();
		}

		private void highToolStripMenuItem_Click(object sender, EventArgs e) {
			if (TodoList.SelectedIndices.Count == 0) return;
			todoItems[TodoList.SelectedIndices[0]].Urgency = 3;

			updateTodoList();
		}

		private void TodoMenu_Opening(object sender, EventArgs e) {
			bool flag = (TodoList.SelectedItems.Count != 0);
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

		private void TodoList_MouseDown(object sender, MouseEventArgs e) {
			if (e.Clicks == 2)
				TodoList_MouseDoublClick(sender, e);
		}


		private void EditItem_Click(object sender, EventArgs e) {
			if (TodoList.SelectedItems.Count <= 0) return;

			//addItemBox(listItems[TodoList.SelectedIndices[0]].Title);
			Debug.Write(todoItems[TodoList.SelectedIndices[0]].testjson());
		}

		private void TodoList_MouseDoublClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left && TodoList.SelectedItems.Count == 0) {
				addItemBox();
			}
		}


		private void addItemBox(string s = "") {
			TodolistAddDiag temp = new TodolistAddDiag(s);
			
			if (s == "")
				temp.OnClose += new TodolistAddDiag.onClose(addItem);
			else
				temp.OnClose += new TodolistAddDiag.onClose(editItem);
			temp.Show();

			temp.Location = new Point(MousePosition.X - temp.Size.Width / 2, MousePosition.Y - temp.Size.Height / 2);
		}

	}
}