using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFonctionClock {
    public class Clock {
        ClockHand _seconds;
        ClockHand _minutes;
        ClockHand _hours;
        ClockFace _dial;
        Point _centerPoint;
        int _radius;
        bool _isHide;
        bool _isSkyClock;

        public Clock(Point centerPoint, int radius) {
            CenterPoint = centerPoint;

            Seconds = new ClockHand(centerPoint, 60, (int)(0.9 * radius), Pens.Red);
            Minutes = new ClockHand(centerPoint, 60, (int)(0.8 * radius), Pens.Black);
            Hours = new ClockHand(centerPoint, 12, (int)(0.6 * radius), Pens.Black);
            Dial = new ClockFace(centerPoint, radius, true);
            IsHide = true;
            IsSkyClock = false;
        }

        #region Properties
        public ClockHand Seconds {
            get {
                return _seconds;
            }

            set {
                _seconds = value;
            }
        }

        public ClockHand Minutes {
            get {
                return _minutes;
            }

            set {
                _minutes = value;
            }
        }

        public ClockHand Hours {
            get {
                return _hours;
            }

            set {
                _hours = value;
            }
        }

        public ClockFace Dial {
            get {
                return _dial;
            }

            set {
                _dial = value;
            }
        }

        public int Radius {
            get {
                return _radius;
            }

            set {
                _radius = value;
            }
        }

        public Point CenterPoint {
            get {
                return _centerPoint;
            }

            set {
                _centerPoint = value;
            }
        }

        public bool IsHide {
            get {
                return _isHide;
            }

            set {
                _isHide = value;
            }
        }

        public bool IsSkyClock {
            get {
                return _isSkyClock;
            }

            set {
                _isSkyClock = value;
            }
        }
        #endregion

        public void Paint(PaintEventArgs e) {
            if (IsSkyClock) {
                Minutes.Axis = Hours.End;
                Seconds.Axis = Minutes.End;
            }
            else {
                Minutes.Axis = Hours.Axis;
                Seconds.Axis = Hours.Axis;
                Dial.Paint(e);
            }


            Hours.ActualTick = DateTime.Now.Hour;
            Hours.Paint(e);
            Minutes.ActualTick = DateTime.Now.Minute;
            Minutes.Paint(e);
            Seconds.ActualTick = DateTime.Now.Second;
            Seconds.Paint(e);

            if (IsSkyClock) {
                e.Graphics.FillEllipse(Brushes.Black, Hours.Axis.X - 8, Hours.Axis.Y - 8, 16, 16);
                e.Graphics.FillEllipse(Brushes.Black, Minutes.Axis.X - 6, Minutes.Axis.Y - 6, 12, 12);
                e.Graphics.FillEllipse(Brushes.Black, Seconds.Axis.X - 6, Seconds.Axis.Y - 6, 12, 12);
                e.Graphics.FillEllipse(Brushes.Red, Seconds.End.X - 4, Seconds.End.Y - 4, 8, 8);
            }
        }
    }
}
