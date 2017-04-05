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
    public partial class SetAlarmView : Form {
        MultiFonctionClockModel _myMultiFonctionClockModel;
        public MultiFonctionClockModel MyMultiFonctionClockModel {
            get {
                return _myMultiFonctionClockModel;
            }

            set {
                _myMultiFonctionClockModel = value;
            }
        }

        public SetAlarmView(MultiFonctionClockModel myMultiFonctionClockModel) {
            InitializeComponent();

            MyMultiFonctionClockModel = myMultiFonctionClockModel;

            if (MyMultiFonctionClockModel.IsAlarmConfigured) {
                nudHour.Value = MyMultiFonctionClockModel.MainAlarm.HoursHand.ActualTick;
                nudMin.Value = MyMultiFonctionClockModel.MainAlarm.MinutesHand.ActualTick;
                nudSec.Value = MyMultiFonctionClockModel.MainAlarm.SecondsHand.ActualTick;
            } else {
                nudHour.Value = DateTime.Now.Hour;
                nudMin.Value = DateTime.Now.Minute;
                nudSec.Value = DateTime.Now.Second;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            MyMultiFonctionClockModel.ConfigureNewAlarm(new DateTime(1, 1, 1, (int)nudHour.Value, (int)nudMin.Value, (int)nudSec.Value));
            this.Close();
        }

        private void nudHour_ValueChanged(object sender, EventArgs e) {
            if (nudHour.Value == 24) {
                nudHour.Value = 0;
            }
        }

        private void nudMin_ValueChanged(object sender, EventArgs e) {
            if (nudMin.Value == 60) {
                nudMin.Value = 0;
            }
        }

        private void nudSec_ValueChanged(object sender, EventArgs e) {
            if (nudSec.Value == 60) {
                nudSec.Value = 0;
            }
        }
    }
}
