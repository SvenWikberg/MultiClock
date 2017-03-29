using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFonctionClock {
    public class MultiFonctionClockModel {
        const int CLOCK_PADDING = 25;

        DigitalClock _mainDigitalClock;
        public DigitalClock MainDigitalClock {
            get {
                return _mainDigitalClock;
            }

            set {
                _mainDigitalClock = value;
            }
        }

        Clock _mainClock;
        public Clock MainClock {
            get {
                return _mainClock;
            }
            set {
                _mainClock = value;
            }
        }

        Today _todayDate;
        public Today TodayDate {
            get {
                return _todayDate;
            }

            set {
                _todayDate = value;
            }
        }

        Alarm _mainAlarm;
        public Alarm MainAlarm {
            get {
                return _mainAlarm;
            }

            set {
                _mainAlarm = value;
            }
        }

        bool _isAlarmConfigured;
        public bool IsAlarmConfigured {
            get {
                return _isAlarmConfigured;
            }

            set {
                _isAlarmConfigured = value;
            }
        }

        MainView _myMainView;
        public MainView MyMainView {
            get {
                return _myMainView;
            }

            set {
                _myMainView = value;
            }
        }

        public MultiFonctionClockModel(MainView myMainView) {
            MyMainView = myMainView;

            MainDigitalClock = new DigitalClock(new Point(120, 60), MyMainView);
            MainClock = new Clock(new Point(120, 180), 100);
            MainAlarm = new Alarm(MainClock.CenterPoint, 100);
            IsAlarmConfigured = false;
            TodayDate = new Today(new Point(10, 25), MyMainView);
        }

        public void ConfigureNewAlarm(DateTime alarm) {
            MainAlarm.HoursHand.ActualTick = alarm.Hour;
            MainAlarm.MinutesHand.ActualTick = alarm.Minute;
            MainAlarm.SecondsHand.ActualTick = alarm.Second;
            IsAlarmConfigured = true;
        }

        public bool IsAlarmTime() {
            if (IsAlarmConfigured &&
                MainAlarm.HoursHand.ActualTick == DateTime.Now.Hour &&
                MainAlarm.MinutesHand.ActualTick == DateTime.Now.Minute &&
                MainAlarm.SecondsHand.ActualTick == DateTime.Now.Second) {
                IsAlarmConfigured = false;
                return true;
            }
            else {
                return false;
            }
        }

        public void Paint(PaintEventArgs e) {
            //MainDigitalClock.Hide();

            TodayDate.Paint();

            if (!MainClock.IsHide) {
                if (MainClock.DisplayMode == 1) {
                    MyMainView.Size = new Size(
                        (MainClock.Hours.Length + MainClock.Minutes.Length) * 2 + CLOCK_PADDING * 2 + MyMainView.ExtraWidth,
                        (MainClock.Hours.Length + MainClock.Minutes.Length) * 2 + CLOCK_PADDING * 2 + TodayDate.Display.Height + MyMainView.ExtraHeight);
                }
                else {
                    MyMainView.Size = new Size(
                        MainClock.Radius * 2 + CLOCK_PADDING * 2 + MyMainView.ExtraWidth,
                        MainClock.Radius * 2 + CLOCK_PADDING * 2 + TodayDate.Display.Height + MyMainView.ExtraHeight);
                }

                MainClock.CenterPoint = new Point(MyMainView.ClientRectangle.Width / 2, (MyMainView.ClientRectangle.Height / 2) + TodayDate.Display.Height);


                if (IsAlarmConfigured) {
                    MainAlarm.Paint(e);
                }
                MainClock.Paint(e);
            }

            if (!MainDigitalClock.IsHide) {
                MyMainView.Size = new Size(
                    MainDigitalClock.Display.Width + MyMainView.ExtraWidth + CLOCK_PADDING * 2,
                    MainDigitalClock.Display.Height * 2 + MyMainView.ExtraHeight + TodayDate.Display.Height + CLOCK_PADDING * 2);

                MainDigitalClock.Position = new Point(
                    (MyMainView.Width - MyMainView.ExtraWidth) / 2 - MainDigitalClock.Display.Width / 2,
                    ((MyMainView.Height - MyMainView.ExtraHeight) / 2 - MainDigitalClock.Display.Height / 2) + TodayDate.Display.Height);

                MainDigitalClock.Show();
                MainDigitalClock.Paint(e);
            }
            else {
                MainDigitalClock.Hide();
            }
        }
    }
}
