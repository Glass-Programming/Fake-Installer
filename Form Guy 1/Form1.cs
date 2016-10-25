using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Guy_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState =  FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "Progress: " + progressBar1.Value.ToString();
            progressBar1.Increment(2);
            if (progressBar1.Value > 1)
            {
                button5.Text = "Installing...";
            }if(progressBar1.Value == 100)
            {
                button5.Text = "Finish!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if(progressBar1.Value == 100)
            {
                Button clickedButton = sender as Button;
                if (clickedButton == null)
                    return;
                if (clickedButton == button5)
                {
                    Close();
                }
            }
        }
    }
}
