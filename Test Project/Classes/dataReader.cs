using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace Timer_Utils {
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
				JsonConvert.PopulateObject(fs.ReadToEnd(), this); //#yolo
	
				fs.Close();
			}
		}

		public void serialize() {
			if (!File.Exists(filePath)) File.CreateText(filePath);

			StreamWriter fs = new StreamWriter(filePath);
			fs.Write(JsonConvert.SerializeObject(this, Formatting.Indented));

			fs.Close();
		}
	}
}
