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

namespace PingProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            string IP = (string)cbHost.SelectedItem;
            string pingText = "Ping : ";

            try
            {
                decimal ping = 9999;
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(IP, 1000);
                if (reply != null)
                {
                   ping = reply.RoundtripTime;
                    pingText += $"{ping}ms"; 
                } else
                {
                    pingText = "No Reply";
                }
            } catch (Exception)
            {
                pingText = "Timeout";
            }

            lblPing.Text = pingText;
        }
    }
}
