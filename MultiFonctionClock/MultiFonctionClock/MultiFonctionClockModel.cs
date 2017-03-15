using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFonctionClock {
    public class MultiFonctionClockModel {

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

            MainDigitalClock = new DigitalClock(new Point(125, 150), MyMainView);
            MainClock = new Clock(new Point(215, 250), 100);
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
            if (IsAlarmConfigured && MainAlarm.HoursHand.ActualTick == DateTime.Now.Hour && MainAlarm.MinutesHand.ActualTick == DateTime.Now.Minute && MainAlarm.SecondsHand.ActualTick == DateTime.Now.Second) {
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
                if (IsAlarmConfigured) {
                    MainAlarm.Paint(e);
                }
                MainClock.CenterPoint = new Point(0, 0);
                MainClock.Paint(e);
            }

            if (!MainDigitalClock.IsHide) {
                //MainDigitalClock.Position = new Point(e.ClipRectangle.Width / 2, e.ClipRectangle.Height / 2);
                //MainDigitalClock.Position = new Point(0, 0);
                MainDigitalClock.Show();
                MainDigitalClock.Paint(e);
            }
        }
    }
}
