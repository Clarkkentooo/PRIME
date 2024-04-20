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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

            exitSign.MouseEnter += exitSign_MouseEnter;
            exitPanel.MouseEnter += exitSign_MouseLeave;

            
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            

        }

        private void exitSign_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        

        private void crownTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
           Home log =  new Home();
           this.Hide();
           log.Show();
        }
    }
    
}
