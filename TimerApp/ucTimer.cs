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

namespace MultiTool
{
    public partial class ucTimer : UserControl
    {
        public ucTimer()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer;
        long time = 0;

        private string GetTimeString()
        {
            TimeSpan t = TimeSpan.FromSeconds(time);
            return string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
        }

        private void SetTime(long time)
        {
            this.time = time;
            lblTime.Text = GetTimeString();
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

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            if (time > 0)
            {
                time--;
                SetTime(time);


            }
            else
            {
                SetStartButton("Start");
                timer.Stop();
                if (cbCustomText.Checked)
                {
                    notifyIcon1.BalloonTipText = txtCustomText.Text;
                }
                else
                {
                    notifyIcon1.BalloonTipText = "Time is up!";
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

        private void ucTimer_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                timer = new System.Timers.Timer();
                timer.Interval = 1 * 1000;
                timer.Elapsed += OnTimeEvent;
            }
        }
    }
}
