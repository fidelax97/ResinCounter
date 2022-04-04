using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Resin_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            notifyIcon1.Text = "Resin Counter";
            notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);

            currentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if(currentTime.Text  == completedTime.Text)
            {
                notifyIcon1.Text = "Your resin is full";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Resin Counter";
                notifyIcon1.BalloonTipText = "Your resin is full";
                notifyIcon1.ShowBalloonTip(100000); 
            }

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int resin = Convert.ToInt32(resinCounter.Value);
            double minutes = (160-resin) * 8;
            completedTime.Text = DateTime.Now.AddMinutes(minutes).ToString("HH:mm:ss");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            resinCounter.Value = 0;
            completedTime.Text = " ";
        }

        private void notifyIcon1_DoubleClick(object Sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.

            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();
        }
    }
}
