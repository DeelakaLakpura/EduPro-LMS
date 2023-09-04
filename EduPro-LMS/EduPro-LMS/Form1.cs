using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduPro_LMS
{
    public partial class Form1 : Form
    {
        private int progressBarValue = 0;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBarValue++;
            if(progressBarValue <=guna2ProgressBar1.Maximum)
            {
                guna2ProgressBar1.Value = progressBarValue;
                label3.Text = $"Loading {progressBarValue}%";
                
           
            }else
            {
                timer.Stop();
                this.Hide();
                Login log = new Login();
                log.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
