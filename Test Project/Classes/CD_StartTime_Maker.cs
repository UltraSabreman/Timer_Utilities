using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Time_Utils {
	class CD_StartTime_Maker {
		////////////////////////////////////
		// Public Members

		////////////////////////////////////
		// Private Members
		private TimeSpan startTime;
		private List<int> rawTime = new List<int>();
		private int index = 0;
		private int maxDigits = 0;

		////////////////////////////////////
		// Properties

		////////////////////////////////////
		// Public Methods
		public CD_StartTime_Maker(int digits = 6) {
			maxDigits = digits;

			reset();
		}

		public void reset() {
			int[] temp = new int[maxDigits];
			for (int i = 0; i < maxDigits; i++)
				temp[i] = 0;

			rawTime.Clear();
			rawTime.AddRange(temp);
		}

		public void pushNumber(int num) {
			if ((index == 0 && num == 0) || index >= maxDigits) return;

			for (int i = rawTime.Count - 1; i >= 0; i--) {
				if (i == 0)
					rawTime[i] = num;
				else
					rawTime[i] = rawTime[i - 1];
			}

			index += (index + 1 <= rawTime.Count ? 1 : 0);
		}

		public void popNumber() {
			index -= (index - 1 >= 0 ? 1 : 0);

			for (int i = 0; i < rawTime.Count; i++) {
				if (i == rawTime.Count - 1)
					rawTime[i] = 0;
				else
					rawTime[i] = rawTime[i + 1];
			}
		}

		public TimeSpan getTime() {
			int totalSeconds = 0;
			for (int i = rawTime.Count - 1, t = 0; i >= 0; i--) {
				int mul = 1;
				if (i % 2 != 0)
					mul = 10;

				totalSeconds += (rawTime[i] * mul * (t == 0 ? 3600 : (t == 1 ? 60 : 1)));

				if (i % 2 == 0)
					t++;
			}

			startTime = TimeSpan.FromSeconds(totalSeconds);
			return startTime;
		}

		public string getUnproccesdString() {
			string temp = "";
			int index = 0;
			foreach (int i in rawTime) {
				if (index == 4 || index  == 2)
					temp = " : " + temp;
				temp = i.ToString() + temp;
				index++;
			}

			return temp;
		}

		
		////////////////////////////////////
		// Private Methods
	}
}
