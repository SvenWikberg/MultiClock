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
        int _displayMode; // 0=normal / 1=skyclock / 2=pointClock

        public Clock(Point centerPoint, int radius) {
            CenterPoint = centerPoint;
            Radius = radius;

            Seconds = new ClockHand(centerPoint, 60, (int)(0.9 * Radius), Pens.Red);
            Minutes = new ClockHand(centerPoint, 60, (int)(0.8 * Radius), Pens.Black);
            Hours = new ClockHand(centerPoint, 12, (int)(0.6 * Radius), Pens.Black);
            Dial = new ClockFace(centerPoint, Radius, true);
            IsHide = true;
            DisplayMode = 0;
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

        public int DisplayMode {
            get {
                return _displayMode;
            }

            set {
                _displayMode = value;
            }
        }
        #endregion

        public void Paint(PaintEventArgs e) {
            Seconds.Axis = CenterPoint;
            Minutes.Axis = CenterPoint;
            Hours.Axis = CenterPoint;
            Dial.CenterPoint = CenterPoint;

            if (DisplayMode == 1) {
                Minutes.Axis = Hours.End;
                Seconds.Axis = Minutes.End;
            }
            else {
                Minutes.Axis = Hours.Axis;
                Seconds.Axis = Hours.Axis;
                Dial.Paint(e);
            }

            Hours.ActualTick = DateTime.Now.Hour;
            Minutes.ActualTick = DateTime.Now.Minute;
            Seconds.ActualTick = DateTime.Now.Second;

            if (DisplayMode != 2) {
                Hours.Paint(e);
                Minutes.Paint(e);
                Seconds.Paint(e);
            }

            if (DisplayMode == 1 || DisplayMode == 2) {
                e.Graphics.FillEllipse(Brushes.Black, Hours.End.X - 8, Hours.Axis.Y - 8, 16, 16);
                e.Graphics.FillEllipse(Brushes.Black, Minutes.End.X - 6, Minutes.Axis.Y - 6, 12, 12);
                e.Graphics.FillEllipse(Brushes.Red, Seconds.End.X - 4, Seconds.End.Y - 4, 8, 8);
            }
        }
    }
}
