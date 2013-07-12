using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Timer_Utils {
	public class StopWatch {
		//Private Members
		private Stopwatch ticker = new Stopwatch();
		private Timer updater = new Timer();
		private string timeString = "";
		private int laps = 0;
		private bool running = false;
		private List<string> lapList = new List<string>();

		//Accesors
		public int TopLap {
			get { return laps; }
		}

		public bool Running {
			get { return running; }
		}

		public string TimeString {
			get { return timeString; }
		}

		public TimeSpan Time {
			get { return ticker.Elapsed; }
		}

		//Methods
		public StopWatch(int interval = 100) {
			updater.Tick += new EventHandler(tick);
			updater.Interval = interval;
			updater.Start();
		}

		// <summary>
		// Does the tick action for the class, called by the system watch.
		// </summary>
		// <param name="object source">The event source</param>
		// <param name=" EventArgs e">The event args</param>
		// <returns>VOID</returns>
		private void tick(object source, EventArgs e) {
			TimeSpan temp = ticker.Elapsed;
			timeString = String.Format("{0:00} : {1:00} : {2:00}.{3:000}", temp.TotalHours, temp.Minutes, temp.Seconds, temp.Milliseconds);
		}

		public void lap() {
			laps++;
			lapList.Add(timeString);

			ticker.Reset();
			ticker.Start();
		}

		public void toggle() {
			running = !running;

			if (running)
				ticker.Start();
			else
				ticker.Stop();
		}

		public void reset() {
			ticker.Reset();
			laps = 0;
			lapList.Clear();
		}

	}
}
