using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startedSign.MouseEnter += getStarted_MouseEnter;
            startedSign.MouseLeave += getStarted_MouseLeave;
            exitSign.MouseEnter += exitSign_MouseEnter;
            exitPanel.MouseEnter += exitSign_MouseLeave;


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       

        private void LOGO_Click(object sender, EventArgs e)
        {
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void exitSign_MouseEnter(object sender, EventArgs e)
        {
            exitSign.ForeColor = Color.White;
           
            exitPanel.BackColor = Color.Red;
            
        }
        private void exitSign_MouseLeave(object sender, EventArgs e)
        {
            exitSign.ForeColor = Color.Gray;
            
            exitPanel.BackColor = Color.Transparent;
           
        }
        private void getStarted_MouseEnter(object sender, EventArgs e)
        {
            startedSign.Font = new Font(startedSign.Font, FontStyle.Underline);
        }

        private void getStarted_MouseLeave(object sender, EventArgs e)
        {
           
            startedSign.Font = new Font(startedSign.Font, FontStyle.Regular);
        }

        private void startedSign_Click(object sender, EventArgs e)
        {
            SignUp log = new SignUp();
            this.Hide();
            log.Show();
        }
    }
}
