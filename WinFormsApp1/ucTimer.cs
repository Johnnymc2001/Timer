using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MainProgram
{
    public partial class ucTimer : UserControl
    {
        public ucTimer()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer;
        double time = 0;

        private (string, string) GetTimeString()
        {
            TimeSpan t = TimeSpan.FromMilliseconds(time * 1000);
            string hms = string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
            string ms = string.Format("{0:D2}", t.Milliseconds).Substring(0,2);
            return (hms, ms);
        }

        private void SetTime(double time)
        {
            this.time = time;
            (string, string) timeStr = GetTimeString();
            lblTime.Text = timeStr.Item1;
            lblMilisec.Text = timeStr.Item2;
        }

        private void SetStartButton(string str)
        {
            switch (str)
            {
                case "Start":
                    {
                        btnStart.Text = "Start";
                        btnStart.BackColor = Color.Lime;
                        break;
                    }
                case "Stop":
                    {
                        btnStart.Text = "Stop";
                        btnStart.BackColor = Color.Red;
                        break;
                    }
            }

        }

        // =======================================================================================================
        private void ucTimer_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                timer = new System.Timers.Timer();
                timer.Interval = 1 * 100;
                timer.Elapsed += OnTimeEvent;
            }
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            if (time > 0)
            {
                time = time - 0.1;
                SetTime(time);
            }
            else
            {
                SetTime(0);
                SetStartButton("Start");
                timer.Stop();

                if (cbCustomText.Checked)
                {
                    if (cbMessageBox.Checked)
                    {
                        MessageBox.Show(txtCustomText.Text);
                    }

                    if (cbNotification.Checked)
                    {
                        notifyIcon1.BalloonTipText = txtCustomText.Text;
                    }

                }
                else
                {
                    if (cbMessageBox.Checked)
                    {
                        MessageBox.Show("Timer is up!");
                    }

                    if (cbNotification.Checked)
                    {
                        notifyIcon1.BalloonTipText = "Timer is up!";
                    }
                }

                notifyIcon1.ShowBalloonTip(5);

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (btnStart.Text == "Start")
            {
                timer.Start();
                SetStartButton("Stop");
            }
            else if (btnStart.Text == "Stop")
            {
                timer.Stop();
                SetStartButton("Start");
            }

            //btnStart.Enabled = false;
            //btnStop.Enabled = true;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            SetTime((long)(nudHour.Value * 3600 + nudMinute.Value * 60 + nudSecond.Value));

        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            SetTime(3600);
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            SetTime(3600 * 3);

        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            SetTime(3600 * 24 - 0.001);
        }

        private void btnHalf_Click(object sender, EventArgs e)
        {
            SetTime(3600 * 12);
        }

        private void cbCustomText_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCustomText.Checked)
            {
                txtCustomText.Enabled = true;
            }
            else
            {
                txtCustomText.Enabled = false;
            }
        }

        private void btnReset_click(object sender, EventArgs e)
        {
            timer.Stop();
            SetStartButton("Start");
            time = 0;
            SetTime(time);
        }
    }
}
