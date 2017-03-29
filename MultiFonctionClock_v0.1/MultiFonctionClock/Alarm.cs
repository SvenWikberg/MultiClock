using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFonctionClock {
    public class Alarm {
        ClockHand _secondsHand;
        ClockHand _minutesHand;
        ClockHand _hoursHand;
        Point _centerPoint;
        int _radius;

        public Alarm(Point centerPoint, int radius) {
            CenterPoint = centerPoint;

            SecondsHand = new ClockHand(centerPoint, 60, (int)(0.9 * radius), Pens.LightPink);
            MinutesHand = new ClockHand(centerPoint, 60, (int)(0.8 * radius), Pens.LightGray);
            HoursHand = new ClockHand(centerPoint, 12, (int)(0.6 * radius), Pens.LightGray);
        }

        #region Properties
        public ClockHand SecondsHand {
            get {
                return _secondsHand;
            }

            set {
                _secondsHand = value;
            }
        }

        public ClockHand MinutesHand {
            get {
                return _minutesHand;
            }

            set {
                _minutesHand = value;
            }
        }

        public ClockHand HoursHand {
            get {
                return _hoursHand;
            }

            set {
                _hoursHand = value;
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
        #endregion

        public void Paint(PaintEventArgs e) {
            SecondsHand.Paint(e);
            MinutesHand.Paint(e);
            HoursHand.Paint(e);
        }
    }
}
