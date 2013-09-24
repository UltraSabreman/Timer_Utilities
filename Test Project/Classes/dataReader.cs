using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Time_Utils {
	class dataReader {
		public List<TodoItem> todoItems = new List<TodoItem>();
		public PermOptions options = new PermOptions();

		private string filePath = "data.json";

		public dataReader(string path = "") {
			if (path == "" || path == null) return;
			if (!File.Exists(path))
				throw (new System.IO.FileNotFoundException());
			else
				filePath = path;
		}

		public void deserialize() {
			if (File.Exists(filePath)) {
				StreamReader fs = File.OpenText(filePath);
				bool success = false;
				while (!success) {
					try {
						JsonConvert.PopulateObject(fs.ReadToEnd(), this); //#yolo
						success = true;
					} catch {
						if (MessageBox.Show("Can't read data file. Hit retry to retry, \n or cancel to abort and re-generate file.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel) {
							fs.Close();
							StreamWriter rewrite = new StreamWriter(filePath);
							rewrite.Write("{}");
							rewrite.Close();
							return;
						}
					}
				}
	
				fs.Close();
			}
		}

		public void serialize() {
			if (!File.Exists(filePath)) File.CreateText(filePath);

			StreamWriter fs = null;
			while (fs == null) {
				try {
					fs = new StreamWriter(filePath);
					fs.Write(JsonConvert.SerializeObject(this, Formatting.Indented));
				} catch (System.IO.IOException) {
					if (MessageBox.Show("File is in use", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel) {
						fs.Close();
						return;
					}
				}
			}

			fs.Close();
		}
	}
}
