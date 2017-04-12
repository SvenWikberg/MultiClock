using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFonctionClock {

    public class ClockFace {
        Point _centerPoint;
        int _radius;
        bool _circle;

        public ClockFace() { }

        public ClockFace(Point centerPoint, int radius, bool circle) {
            CenterPoint = centerPoint;
            Radius = radius;
            Circle = circle;
        }

        #region Properties
        public bool Circle {
            get {
                return _circle;
            }

            set {
                _circle = value;
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
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawEllipse(Pens.Black, CenterPoint.X - Radius, CenterPoint.Y - Radius, 2 * Radius, 2 * Radius);
        }
    }
}
