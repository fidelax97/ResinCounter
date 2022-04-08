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
            completedTime.Text = " ";
            TrayMenuContext();
        }

        // Timer setting
        private void timer1_Tick(object sender, EventArgs e)
        {
            notiFunc();
            notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            currentTime.Text = DateTime.Now.ToString("dddd h:mm:ss tt");
            if (currentTime.Text == completedTime.Text)
            {
                notifyIcon1.Text = "Your resin is full";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Resin Counter";
                notifyIcon1.BalloonTipText = "Your resin is full";
                notifyIcon1.ShowBalloonTip(100000);
            }
            form_resize();
        }

        // Form resize func
        private void form_resize()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                Show();
                notifyIcon1.Visible = false;
            }
        }

        // Text for notifyIcon
        private void notiFunc()
        {
            if (completedTime.Text == " ")
            {
                notifyIcon1.Text = "Resin Counter\nNo alarm set yet";
            }
            else
            {
                notifyIcon1.Text = "Resin Counter\nCompleted Time: " + completedTime.Text;
            }
        }

        // Button for adding and substract resin value
        private void add40_Click(object sender, EventArgs e)
        {
            int resin = Convert.ToInt32(resinCounter.Value);
            int total = resin + 40;
            if (total >= 160)
            {
                resinCounter.Value = 160;
            }
            else
            {
                resinCounter.Value = total;
            }
        }

        private void add60_Click(object sender, EventArgs e)
        {
            int resin = Convert.ToInt32(resinCounter.Value);
            int total = resin + 60;
            if (total >= 160)
            {
                resinCounter.Value = 160;
            }
            else
            {
                resinCounter.Value = total;
            }
        }

        private void add120_Click(object sender, EventArgs e)
        {
            int resin = Convert.ToInt32(resinCounter.Value);
            int total = resin + 120;
            if (total >= 160)
            {
                resinCounter.Value = 160;
            }
            else
            {
                resinCounter.Value = total;
            }
        }

        private void add160_Click(object sender, EventArgs e)
        {
            int resin = Convert.ToInt32(resinCounter.Value);
            int total = resin + 160;
            if (total >= 160)
            {
                resinCounter.Value = 160;
            }
            else
            {
                resinCounter.Value = total;
            }
        }

        private void sub20_Click(object sender, EventArgs e)
        {
            int resin = Convert.ToInt32(resinCounter.Value);
            if (resin < 20)
            {
                resinCounter.Value = 0;
            }
            else
            {
                resinCounter.Value = resin - 20;
            }
        }
        
        private void sub40_Click(object sender, EventArgs e)
        {
            int resin = Convert.ToInt32(resinCounter.Value);
            if (resin < 40)
            {
                resinCounter.Value = 0;
            }
            else
            {
                resinCounter.Value = resin - 40;
            }
        }

        private void sub90_Click(object sender, EventArgs e)
        {
            int resin = Convert.ToInt32(resinCounter.Value);
            if (resin < 90)
            {
                resinCounter.Value = 0;
            }
            else
            {
                resinCounter.Value = resin - 90;
            };
        }

        private void sub160_Click(object sender, EventArgs e)
        {
            int resin = Convert.ToInt32(resinCounter.Value);
            if (resin < 160)
            {
                resinCounter.Value = 0;
            }
            else
            {
                resinCounter.Value = resin - 160;
            }
        }

        // Notify doubleclick func
        private void notifyIcon1_DoubleClick(object Sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.
            Show();
            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            
            // Activate the form.
            this.Activate();
        }

        // Tray menu func (when right click noti icon)
        private void TrayMenuContext()
        {
            notifyIcon1.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            notifyIcon1.ContextMenuStrip.Items.Add("Exit", null, this.exitToolStripMenuItem_Click);
        }

        // Exit func for tray menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Button for set alarm and reset
        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            int resin = Convert.ToInt32(resinCounter.Value);
            double minutes = (160 - resin) * 8;
            completedTime.Text = DateTime.Now.AddMinutes(minutes).ToString("dddd h:mm:ss tt");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resinCounter.Value = 0;
            completedTime.Text = " ";
        }
    }
}
