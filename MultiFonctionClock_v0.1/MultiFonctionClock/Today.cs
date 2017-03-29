using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFonctionClock {
    public class Today {
        MainView _view;
        public MainView View {
            get {
                return _view;
            }

            set {
                _view = value;
            }
        }

        Label _display;
        public Label Display {
            get {
                return _display;
            }

            set {
                _display = value;
            }
        }

        Point _position;
        public Point Position {
            get {
                return _position;
            }

            set {
                _position = value;
            }
        }

        int _displayMode;
        public int DisplayMode {
            get {
                return _displayMode;
            }

            set {
                _displayMode = value;
            }
        }

        bool isHide;
        public bool IsHide {
            get {
                return isHide;
            }

            set {
                isHide = value;
            }
        }

        public Today(Point position, MainView view) {
            Position = position;
            DisplayMode = 0;
            Display = new Label();
            Display.AutoSize = true;
            Display.Location = Position;
            Display.Name = "lblDigitalClock";
            Display.Parent = view;
            IsHide = true;
        }

        public void Show() {
            Display.Show();
        }

        public void Hide() {
            Display.Hide();
        }

        public void Paint() {
            string tmpSuffix;

            switch (DisplayMode) {
                case 0:
                    Display.Text = String.Format("{0:D2}/{1:D2}/{2:D2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                    Display.Font = new Font("Arial", 15);
                    break;
                case 1:
                    switch (DateTime.Now.Day.ToString()[DateTime.Now.Day.ToString().Length - 1]) {
                        case '1':
                            tmpSuffix = "st";
                            break;
                        case '2':
                            tmpSuffix = "nd";
                            break;
                        case '3':
                            tmpSuffix = "rd";
                            break;
                        default:
                            tmpSuffix = "th";
                            break;
                    }


                    Display.Text = String.Format("{0}, {1} the {2}{3}", DateTime.Now.DayOfWeek.ToString(), DateTime.Now.ToString("MMMM", new CultureInfo("en-US")), DateTime.Now.Day, tmpSuffix);
                    Display.Font = new Font("Arial", 15);
                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
        }
    }
}
