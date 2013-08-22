using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Time_Utils {
	public class StopWatch {
		////////////////////////////////////
		// Public Members
		public delegate void onTick(TimeSpan t);
		public event onTick Tick;

		////////////////////////////////////
		// Private Members
		private Stopwatch clock = new Stopwatch();
		private Timer heartBeat = new Timer();
		private string timeString = "";
		private int laps = 0;
		private bool running = false;
		private List<string> lapList = new List<string>();

		////////////////////////////////////
		// Properties
		public int Laps {
			get { return laps; }
		}

		public string TopLap {
			get { return lapList.Last(); }
		}

		public bool Running {
			get { return running; }
		}

		public string TimeString {
			get { return timeString; }
		}

		public TimeSpan Time {
			get { return clock.Elapsed; }
		}

		////////////////////////////////////
		// Public Methods
		public StopWatch(int interval = 100) {
			heartBeat.Tick += new EventHandler(updateTick);
			heartBeat.Interval = interval;
			heartBeat.Start();
		}

		public bool Lap() {
			if (running) {
				laps++;
				lapList.Add(timeString);

				clock.Reset();
				clock.Start();
				return true;
			}
			return false;
		}

		public bool Stop() {
			if (running) {
				clock.Stop();
				running = false;
				return true;
			}
			return false;
		}

		public bool Start() {
			if (!running) {
				clock.Start();
				running = true;
				return true;
			}
			return false;
		}

		public bool reset() {
			if (!running) {
				clock.Reset();
				laps = 0;
				lapList.Clear();
				return true;
			}
			return false;
		}

		////////////////////////////////////
		// Private Methods
		private void updateTick(object source, EventArgs e) {
			TimeSpan temp = clock.Elapsed;
			timeString = String.Format("{0:00} : {1:00} : {2:00}.{3:000}", temp.TotalHours, temp.Minutes, temp.Seconds, temp.Milliseconds);

			if (Tick != null)
				Tick(temp);
		}

	}
}
