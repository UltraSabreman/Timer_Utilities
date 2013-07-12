using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Media;

namespace Timer_Utils {
	class CountDown {
		//Private Members
		private const int maxMembers = 5;

		private SoundPlayer Player = new SoundPlayer();
		private Stopwatch ticker = new Stopwatch();
		private Timer updater = new Timer();
		private string timeString;
		private TimeSpan startTime;
		private List<int> rawTime = new List<int>();
		private int progress = 0;
		private int ind = 0;

		private bool enterMode = true;
		private bool running = false;
		private bool soundAlarm = false;
		private bool playSound = true;

		//Accesors
		public bool PlaySound {
			set { playSound = value; }
			get { return playSound; }
		}

		public string Sound {
			set {
				try {
					this.Player.SoundLocation = value;
					this.Player.LoadAsync();
				} catch (Exception ex) {
					MessageBox.Show(ex.Message, "Error loading sound");
				}
			}

			get { return Player.SoundLocation; }
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

		public bool Alarming {
			get { return soundAlarm; }
		}

		//Public Methods
		public CountDown(int interval = 100, string soundPath = "C:\\Windows\\Media\\Windows Unlock.wav") {
			// Player.LoadCompleted += new AsyncCompletedEventHandler(soundLoaded);
			Sound = soundPath;

			updater.Tick += new EventHandler(tick);
			updater.Interval = interval;
			updater.Start();

			updater.Start();
			int[] emtpytimes = { 0, 0, 0, 0, 0, 0 };
			rawTime.AddRange(emtpytimes);
		}

		public bool toggle() {
			startTime = getTimeFromList();
			if (startTime.Duration().TotalSeconds == 0) return false;

			running = !running;

			if (running) {
				ticker.Start();
				enterMode = false;
			} else 
				ticker.Stop();
			

			return true;
		}

		public void reset() {
			ticker.Reset();
			startTime = new TimeSpan();
			enterMode = true;
			soundAlarm = false;
			ind = 0;

			rawTime.Clear();
			int[] emtpytimes = { 0, 0, 0, 0, 0, 0 };
			rawTime.AddRange(emtpytimes);
		}

		public void alarm() {
			if (Player.IsLoadCompleted) {
				try {
					Player.PlayLooping();
				} catch (Exception ex) {
					MessageBox.Show(ex.Message, "Error playing sound");
				}
			}
		}

		public void pushNumber(int num) {
			if ((ind == 0 && num == 0) || ind >= maxMembers) return;

			for (int i = rawTime.Count - 1; i >= 0; i--) {
				if (i == 0)
					rawTime[i] = num;
				else
					rawTime[i] = rawTime[i - 1];
			}

			ind += (ind + 1 <= maxMembers ? 1 : 0);
		}

		public void popNumber() {
			ind -= (ind - 1 >= 0 ? 1 : 0);

			for (int i = 0; i < rawTime.Count; i++) {
				if (i == rawTime.Count - 1)
					rawTime[i] = 0;
				else
					rawTime[i] = rawTime[i + 1];
			}
		}

		//Private Methods
		private void tick(object source, EventArgs e) {
			TimeSpan span = startTime.Subtract(ticker.Elapsed);

			progress = (int)((ticker.Elapsed.TotalSeconds / startTime.TotalSeconds) * 100);

			if (span.TotalSeconds < 0) {
				ticker.Stop();
				if (!soundAlarm && running) {
					if (playSound)
						alarm();
					soundAlarm = true;
				}

			} else {
				timeString = "";
				if (enterMode)
					for (int i = rawTime.Count - 1; i >= 0; i--) {
						timeString += (((i + 1) % 2 == 0 && (i + 1) != rawTime.Count ? " : " : "") + rawTime[i].ToString());
					} else
					timeString = String.Format("{0:00} : {1:00} : {2:00}", span.TotalHours, span.Minutes, span.Seconds);
			}


			if (!running)
				Player.Stop();
		}

		private TimeSpan getTimeFromList() {
			int totalSeconds = 0;
			for (int i = maxMembers, t = 0; i >= 0; i--) {
				int mul = 1;
				if (i % 2 != 0)
					mul = 10;

				totalSeconds += (rawTime[i] * mul * (t == 0 ? 3600 : (t == 1 ? 60 : 1)));

				if (i % 2 == 0)
					t++;
			}

			TimeSpan test = TimeSpan.FromSeconds(totalSeconds);
			return test;
		}
	}
}