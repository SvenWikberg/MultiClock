using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFonctionClock {

    public class DigitalClock {

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

        public DigitalClock() { }

        public DigitalClock(Point position, MainView view) {
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

        /// <summary>
        /// displayMode : 0 = decimal / 1 = hexa / 2 = binaire / 3 = octal / 4 = roman
        /// </summary>
        public void Paint(PaintEventArgs e) {
            string tmpHour;
            string tmpMin;
            string tmpSec;

            int x = Display.Parent.Width;

            switch (DisplayMode) {
                case 0:
                    Display.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    Display.Font = new Font("Arial", 30);
                    Display.Location = Position;
                    Debug.Print(x.ToString());
                    //Display.Location = new Point(100, 250);
                    break;
                case 1:
                    Display.Text = String.Format("{0:X2}:{1:X2}:{2:X2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    Display.Font = new Font("Lucida Console", 30);
                    Display.Location = Position;
                    break;
                case 2:
                    tmpHour = Convert.ToString(DateTime.Now.Hour, 2);
                    tmpMin = Convert.ToString(DateTime.Now.Minute, 2);
                    tmpSec = Convert.ToString(DateTime.Now.Second, 2);


                    for (int i = 8 - tmpHour.Length; i > 0; i--) {
                        tmpHour = '0' + tmpHour;
                    }
                    for (int i = 8 - tmpMin.Length; i > 0; i--) {
                        tmpMin = '0' + tmpMin;
                    }
                    for (int i = 8 - tmpSec.Length; i > 0; i--) {
                        tmpSec = '0' + tmpSec;
                    }


                    Display.Text = String.Format("{0}:{1}:{2}", tmpHour, tmpMin, tmpSec);
                    Display.Font = new Font("Lucida Console", 15);
                    Display.Location = Position;
                    break;
                case 3:
                    tmpHour = Convert.ToString(DateTime.Now.Hour, 8);
                    tmpMin = Convert.ToString(DateTime.Now.Minute, 8);
                    tmpSec = Convert.ToString(DateTime.Now.Second, 8);

                    for (int i = 2 - tmpHour.Length; i > 0; i--) {
                        tmpHour = '0' + tmpHour;
                    }
                    for (int i = 2 - tmpMin.Length; i > 0; i--) {
                        tmpMin = '0' + tmpMin;
                    }
                    for (int i = 2 - tmpSec.Length; i > 0; i--) {
                        tmpSec = '0' + tmpSec;
                    }

                    Display.Text = String.Format("{0}:{1}:{2}", tmpHour, tmpMin, tmpSec);
                    Display.Font = new Font("Lucida Console", 30);
                    Display.Location = Position;
                    break;
                case 4: // DEBUGUER (8 devrait etre 08)
                    Display.Text = String.Format("{0}:{1}:{2}", IntToRoman(DateTime.Now.Hour), IntToRoman(DateTime.Now.Minute), IntToRoman(DateTime.Now.Second));
                    Display.Font = new Font("Lucida Console", 30);
                    Display.Location = Position;
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">Min = 0 / Max = 99</param>
        /// <returns></returns>
        private string IntToRoman(int value) {
            string tmp = "";
            string tmpValue = value < 10 ? '0' + value.ToString() : value.ToString();

            switch (tmpValue[0]) {
                case '1':
                case '2':
                case '3':
                    for (int i = 0; i < Convert.ToInt32(tmpValue[0].ToString()); i++) {
                        tmp += 'X';
                    }
                    break;
                case '4':
                    tmp += "XL";
                    break;
                case '5':
                case '6':
                case '7':
                case '8':
                    tmp += 'L';
                    for (int i = 0; i < (Convert.ToInt32(tmpValue[0].ToString()) - 5); i++) {
                        tmp += 'X';
                    }
                    break;
                case '9':
                    tmp += "XC";
                    break;
                default:
                    break;
            }

            switch (tmpValue[1]) {
                case '1':
                case '2':
                case '3':
                    for (int i = 0; i < Convert.ToInt32(tmpValue[1].ToString()); i++) {
                        tmp += 'I';
                    }
                    break;
                case '4':
                    tmp += "IV";
                    break;
                case '5':
                case '6':
                case '7':
                case '8':
                    tmp += 'V';
                    for (int i = 0; i < (Convert.ToInt32(tmpValue[1].ToString()) - 5); i++) {
                        tmp += 'I';
                    }
                    break;
                case '9':
                    tmp += "IX";
                    break;
                default:
                    break;
            }

            if (value == 0) {
                return "nulla";
            }
            else {
                return tmp;
            }
        }
    }
}
