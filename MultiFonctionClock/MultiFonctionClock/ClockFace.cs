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

        public void DisplayTicks(int nbTicks, int lenght, int thickness) {
            for (int i = 0; i < nbTicks; i++) {
                Point start = new Point();
                Point end = new Point();
                double degrees = 0;
                double angle = 0;

                double indice = Convert.ToDouble(nbTicks) / Convert.ToDouble(i);

                degrees = 360.0 / indice - 90.0;
                angle = Math.PI * degrees / 180.0; //convertion en radiants

                start.X = Convert.ToInt32(Math.Cos(angle) * Radius - lenght);
                start.Y = Convert.ToInt32(Math.Sin(angle) * Radius - lenght);

                end.X = Convert.ToInt32(Math.Cos(angle) * Radius);
                end.Y = Convert.ToInt32(Math.Sin(angle) * Radius);
            }
        }

    }
}
