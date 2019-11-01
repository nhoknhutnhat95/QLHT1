using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Loadding : Form
    {
        public Loadding()
        {
            InitializeComponent();
        }
        private void Load_Tick(object sender, EventArgs e)
        {
            ProBar.Value += 1;
            
            if (ProBar.Value==100)
            {
                timer1.Stop();
                Form1 a1 = new Form1();
                this.Close();
                a1.Show();         
            }
        }

        private void Loadding_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
