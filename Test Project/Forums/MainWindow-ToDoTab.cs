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
using System.IO;

namespace Timer_Utils {
	public partial class MainWindow  {
		private List<TodoItem> listItems = new List<TodoItem>();

		////////////////////////
		// There is almost certantly an oo way of dpoing this
		// but for now i Rreally couldn't care less.
		private void readInTodo() {
			if (File.Exists("data.txt")) {
				StreamReader fs = new StreamReader("data.txt");
				
				string curLine = "";
				
				while (!fs.EndOfStream) {
					curLine = fs.ReadLine();
					if (curLine == "---") break;

					TodoItem temp = new TodoItem(curLine);
					listItems.Add(temp);
					TodoList.Items.Add(temp.ToListItem());
				}
				fs.Close();
			}
		}

		private void dumpTodo() {
			StreamWriter fs = new StreamWriter("data.txt", false);

			foreach (TodoItem I in listItems) {
				fs.WriteLine(I.ToString());
			}

			fs.WriteLine("---");
			fs.Close();
		}
		////////////////////////

		private void TDtabInit() {
			readInTodo();
		}

		private void addItem(string text) {
			ListViewItem temp = new ListViewItem();
			temp.SubItems.Add(text);
			TodoList.Items.Add(temp);
		}

		private void editItem(string text) {
			TodoList.SelectedItems[0].SubItems[1].Text = text;
		}

		private void addItemToolStripMenuItem_Click(object sender, EventArgs e) {
			TodolistAddDiag temp = new TodolistAddDiag();
			temp.OnClose += new TodolistAddDiag.onClose(addItem);
			temp.Show();
		}

		private void removeItemToolStripMenuItem_Click(object sender, EventArgs e) {
			ListView.SelectedListViewItemCollection Items = TodoList.SelectedItems;

			foreach (ListViewItem i in Items)
				i.Remove();//.SubItems[0].ForeColor = System.Drawing.Color.Red;
			
		}
		private void removeAllCompleatedItemsToolStripMenuItem_Click(object sender, EventArgs e) {
			ListView.ListViewItemCollection Items = TodoList.Items;

			foreach (ListViewItem i in Items) {
				if (i.Checked)
					i.Remove();
			}
		}

		private void noneToolStripMenuItem_Click(object sender, EventArgs e) {
			ListView.SelectedListViewItemCollection Items = TodoList.SelectedItems;

			foreach (ListViewItem i in Items)
				i.SubItems[0].ForeColor = System.Drawing.Color.Black;
		}

		private void lowToolStripMenuItem_Click(object sender, EventArgs e) {
			ListView.SelectedListViewItemCollection Items = TodoList.SelectedItems;

			foreach (ListViewItem i in Items)
				i.SubItems[0].ForeColor = System.Drawing.Color.Green;
		}

		private void mediumToolStripMenuItem_Click(object sender, EventArgs e) {
			ListView.SelectedListViewItemCollection Items = TodoList.SelectedItems;

			foreach (ListViewItem i in Items)
				i.SubItems[0].ForeColor = System.Drawing.Color.Orange;
		}

		private void highToolStripMenuItem_Click(object sender, EventArgs e) {
			ListView.SelectedListViewItemCollection Items = TodoList.SelectedItems;

			foreach (ListViewItem i in Items)
				i.SubItems[0].ForeColor = System.Drawing.Color.Red;
		}

		private void TodoList_MouseDown(object sender, MouseEventArgs e) {
			if (e.Clicks == 2)
				TodoList_MouseDoublClick(sender, e);
		}

		private void EditItem_Click(object sender, EventArgs e) {
			if (TodoList.SelectedItems.Count <= 0) return;

			TodolistAddDiag temp = new TodolistAddDiag(TodoList.SelectedItems[0].SubItems[1].Text);
			temp.OnClose += new TodolistAddDiag.onClose(editItem);
			temp.Show();
		}

		private void TodoList_MouseDoublClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left && TodoList.SelectedItems.Count == 0) {
				TodolistAddDiag temp = new TodolistAddDiag();
				temp.OnClose += new TodolistAddDiag.onClose(addItem);
				temp.Show();
			}
		}

	}
}