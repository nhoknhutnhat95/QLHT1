using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinalProject
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        double x = 0;
        Login a = new Login();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x==0)
            {
                Thread.Sleep(2000);
            }
            x = x + 1.0/10;
            a.Opacity = x;
            this.Hide();
            a.Show();
            if (x>1)
            {
                timer1.Stop();
            }
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Start();
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
