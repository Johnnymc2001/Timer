using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTool
{
    public partial class ucPing : UserControl
    {
        List<decimal> pings = new List<decimal>();

        public ucPing()
        {
            InitializeComponent();
        }

        private void Ping(string hostname)
        {
            try
            {

                Ping myPing = new Ping();
                PingReply reply = myPing.Send(hostname, 1000);

                if (reply != null)
                {
                    decimal ping = reply.RoundtripTime;
                    decimal max = Math.Ceiling(pings.Max());
                    decimal min = Math.Ceiling(pings.Min());
                    decimal avg = (long)Math.Ceiling(pings.Average());
                    pings.Add(ping);


                    lblLastPing.Text = $"{ping}ms";
                    lblMax.Text = $"{max}ms";
                    lblMin.Text = $"{min}ms";
                    lblAverage.Text = $"{avg}ms";
                }
                else
                {
                    pings.Add(999);
                    lblLastPing.Text = "Timeout";
                }
            }
            catch (Exception)
            {
                lblLastPing.Text = "Timeout";
            }
        }

        private void ucPing_Load(object sender, EventArgs e)
        {

        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            string Hostname = txtHostname.Text;
            Ping(Hostname);
        }
    }
}
