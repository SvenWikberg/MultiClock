using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFonctionClock {

    public class ClockHand {
        Point _axis;
        int _maxTicks;
        int _actualTick;
        int _length;
        Pen _penColor;

        public ClockHand() { }

        public ClockHand(Point axis, int maxTicks, int lenght, Pen penColor) {
            Axis = axis;
            MaxTicks = maxTicks;
            Length = lenght;
            PenColor = penColor;
            ActualTick = 0;
        }

        #region Properties
        public Point Axis {
            get {
                return _axis;
            }

            set {
                _axis = value;
            }
        }

        public int MaxTicks {
            get {
                return _maxTicks;
            }

            set {
                _maxTicks = value;
            }
        }

        public int Length {
            get {
                return _length;
            }

            set {
                _length = value;
            }
        }

        public Pen PenColor {
            get {
                return _penColor;
            }

            set {
                _penColor = value;
            }
        }

        public int ActualTick {
            get {
                return _actualTick;
            }

            set {
                if (value > MaxTicks * 2) {
                    _actualTick = value % MaxTicks;
                }
                else {
                    if (value >= 0) {
                        _actualTick = value;
                    }
                }
            }
        }

        public double Angle {
            get {
                double degrees = 0;
                double angle = 0;

                double indice = Convert.ToDouble(MaxTicks) / Convert.ToDouble(ActualTick);

                degrees = 360.0 / indice - 90.0;
                angle = Math.PI * degrees / 180.0; //convertion en radiants

                return angle;
            }
        }

        public Point End {
            get {
                double adjacent = 0;
                double oppose = 0;
                Point tmpEnd = new Point(0, 0);

                adjacent = Math.Cos(Angle) * Length;
                oppose = Math.Sin(Angle) * Length;

                tmpEnd.X = Axis.X + Convert.ToInt32(adjacent);
                tmpEnd.Y = Axis.Y + Convert.ToInt32(oppose);

                return tmpEnd;
            }
        }
        #endregion

        public void Paint(PaintEventArgs e) {

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(new Pen(PenColor.Color, 3), Axis, this.End);
            //e.Graphics.DrawEllipse(Pens.Black, Axis.X - Length, Axis.Y - Length, 2 * Length, 2 * Length);
        }
    }
}
