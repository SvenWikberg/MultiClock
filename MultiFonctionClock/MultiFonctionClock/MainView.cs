using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFonctionClock {
    public partial class MainView : Form {

        MultiFonctionClockModel _myMultiFonctionClockModel;
        public MultiFonctionClockModel MyMultiFonctionClockModel {
            get {
                return _myMultiFonctionClockModel;
            }

            set {
                _myMultiFonctionClockModel = value;
            }
        }

        public MainView() {
            InitializeComponent();
            DoubleBuffered = true;

            MyMultiFonctionClockModel = new MultiFonctionClockModel(this);
        }

        private void MainView_Paint(object sender, PaintEventArgs e) {
            UpdateView();
            MyMultiFonctionClockModel.Paint(e);
        }

        private void timerInvalidate_Tick(object sender, EventArgs e) {
            Invalidate();
        }

        private void timerAlarm_Tick(object sender, EventArgs e) {
            if (MyMultiFonctionClockModel.IsAlarmTime()) {
                MessageBox.Show("ALARM !!");
            }
        }

        private void UpdateView() {
        }

        private void MainView_Load(object sender, EventArgs e) {
            MyMultiFonctionClockModel.MainClock.IsHide = false;
            MyMultiFonctionClockModel.MainDigitalClock.IsHide = true;
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e) {
            MyMultiFonctionClockModel.MainClock.IsHide = false;
            MyMultiFonctionClockModel.MainDigitalClock.IsHide = true;
            MyMultiFonctionClockModel.MainClock.IsSkyClock = false;
        }

        private void skyClockToolStripMenuItem_Click(object sender, EventArgs e) {
            MyMultiFonctionClockModel.MainClock.IsHide = false;
            MyMultiFonctionClockModel.MainDigitalClock.IsHide = true;
            MyMultiFonctionClockModel.MainClock.IsSkyClock = true;
        }

        private void decimalToolStripMenuItem_Click(object sender, EventArgs e) {
            MyMultiFonctionClockModel.MainClock.IsHide = true;
            MyMultiFonctionClockModel.MainDigitalClock.IsHide = false;
            MyMultiFonctionClockModel.MainDigitalClock.DisplayMode = 0;
        }

        private void hexadecimalToolStripMenuItem_Click(object sender, EventArgs e) {
            MyMultiFonctionClockModel.MainClock.IsHide = true;
            MyMultiFonctionClockModel.MainDigitalClock.IsHide = false;
            MyMultiFonctionClockModel.MainDigitalClock.DisplayMode = 1;
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e) {
            MyMultiFonctionClockModel.MainClock.IsHide = true;
            MyMultiFonctionClockModel.MainDigitalClock.IsHide = false;
            MyMultiFonctionClockModel.MainDigitalClock.DisplayMode = 2;
        }

        private void octalToolStripMenuItem_Click(object sender, EventArgs e) {
            MyMultiFonctionClockModel.MainClock.IsHide = true;
            MyMultiFonctionClockModel.MainDigitalClock.IsHide = false;
            MyMultiFonctionClockModel.MainDigitalClock.DisplayMode = 3;
        }

        private void setAnAlarmToolStripMenuItem_Click(object sender, EventArgs e) {
            SetAlarmView _mySetAlarmView = new SetAlarmView(MyMultiFonctionClockModel);
            _mySetAlarmView.Show();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e) {
            MyMultiFonctionClockModel.TodayDate.DisplayMode = 1;
        }

        private void ddmmyyyyToolStripMenuItem_Click(object sender, EventArgs e) {
            MyMultiFonctionClockModel.TodayDate.DisplayMode = 0;
        }

        
    }
}
