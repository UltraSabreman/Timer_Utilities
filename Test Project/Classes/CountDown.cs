using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Time_Utils {
	class CountDown {
		////////////////////////////////////
		// Public Members
		public delegate void onTick(TimeSpan s);
		public delegate void onTrigger();
		public delegate void onTriggerOnce();
		public event onTick Tick;
		public event onTrigger Trigger;
		public event onTriggerOnce TriggerOnce;
		public bool Ready = true;

		////////////////////////////////////
		// Private Members
		private Stopwatch clock = new Stopwatch();
		private Timer heartBeat = new Timer();
		private string timeString;
		private TimeSpan startTime;
		private int progress = 0;
		private bool running = false;
		private bool triggered = false;
		private bool continueAfterTrigger = true;

		////////////////////////////////////
		// Properties
		public TimeSpan StartTime {
			set { startTime = value; }
			get { return startTime; }
		}

		public int Progress {
			get { return progress; }
		}

		public string TimeString {
			get { return timeString; }
		}

		public bool Running {
			get { return running; }
		}

		public bool Triggered {
			get { return triggered; }
		}

		public bool ContinueAfterTrigger {
			set { continueAfterTrigger = value; }
			get { return continueAfterTrigger; }
		}

		////////////////////////////////////
		// Public Methods
		public CountDown(int interval = 100) {
			heartBeat.Tick += new EventHandler(updateTick);
			heartBeat.Interval = interval;
			heartBeat.Start();
		}

		public bool Start() {
			if (!running && startTime.Duration().TotalSeconds != 0) {
				Ready = false;
				clock.Start();
				running = true;
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

		public bool Reset() {
			if (!running) {
				Ready = true;
				clock.Reset();
				startTime = new TimeSpan();
				triggered = false;
				running = false;
				return true;
			}
			return false;
		}


		////////////////////////////////////
		// Private Methods
		private void updateTick(object source, EventArgs e) {
			TimeSpan timeDiff = startTime.Subtract(clock.Elapsed);

			if (Tick != null)
				Tick(timeDiff);

			if (timeDiff.TotalSeconds <= 0) {
				if (running) {
					progress = 100;
					if (!triggered && TriggerOnce != null) {
						TriggerOnce();
						triggered = true;
					}
					if (Trigger != null)
						Trigger();
				} else
					progress = 0;
			} else {
				progress = (int)((clock.Elapsed.TotalSeconds / startTime.TotalSeconds) * 100);
			}
			string l = "";
			if  (timeDiff.TotalSeconds < 0 && continueAfterTrigger)
				l = "-";
			timeString = String.Format(l + "{0:00} : {1:00} : {2:00}", Math.Abs(timeDiff.TotalHours), Math.Abs(timeDiff.Minutes), Math.Abs(timeDiff.Seconds));
		}
	}
}