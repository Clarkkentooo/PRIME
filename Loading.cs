﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIME_FINAL
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
        }
        

        private void kryptonProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void thunderProgressBar1_Click(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            startpoint += 1;
            primeProgressBar.Value = startpoint;
            if (primeProgressBar.Value == 100) 
            {
                primeProgressBar.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            primeProgressBar.Minimum = 0;
            primeProgressBar.Maximum = 100;
            timer1.Start();
        }

        private void primeProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
