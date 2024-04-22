using PRIME_FINAL;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIME3
{

    public partial class FunctionFormbg : Form
    {
        //private Size formSize;
        //private int borderSize = 1;
        private Form currentBookingFormGD;

        public FunctionFormbg()
        {
            InitializeComponent();
            ticketInfoPanel.Visible = false;
            sidebarAccess1.MouseEnter += sidebarAccess1_MouseEnter;
            sidebarAccess1.MouseLeave += sidebarAccess1_MouseLeave;

            add2CartText.MouseEnter += label5_MouseEnter;
            add2CartText.MouseLeave += label5_MouseLeave;
            starSign.Click += StarSign_Click;

            BookButton.Click += BookButton_Click;

        }
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            add2CartText.Font = new Font(add2CartText.Font, FontStyle.Underline);
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            add2CartText.Font = new Font(add2CartText.Font, FontStyle.Regular);
        }

        private void sidebarAccess1_MouseEnter(object sender, EventArgs e)
        {
            sidebarAccess1.ForeColor = Color.FromArgb(205, 205, 205);
        }

        private void sidebarAccess1_MouseLeave(object sender, EventArgs e)
        {
            sidebarAccess1.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void StarSign_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label; //Casting the Sender to a Label
            if (clickedLabel != null)
            {
                //Check the Text property of the clicked label.
                if (clickedLabel.Text == "☆")
                {
                    clickedLabel.Text = "★";
                    clickedLabel.ForeColor = Color.FromArgb(222, 156, 27);  //Color when clicked
                }
                else
                {
                    clickedLabel.Text = "☆";
                    clickedLabel.ForeColor = Color.FromArgb(205, 205, 205); //Default Color
                }
            }
        }


        private void sidebarAccess1_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
        }

        

        private void BookButton_Click(object sender, EventArgs e)
        {
            ticketInfoPanel.Visible = true;
        }

        private void ticketInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void FunctionFormbg_Load(object sender, EventArgs e)
        {

        }

        private void cyberButton87_Click(object sender, EventArgs e)
        {

        }
    }
}



/*[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
private extern static void ReleaseCapture();
[DllImport("user32.DLL", EntryPoint = "SendMessage")]
private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
private void panelHeaderBar_MouseDown(object sender, MouseEventArgs e)
{
ReleaseCapture();
SendMessage(this.Handle, 0x112, 0xf012, 0);
}
//Form's responsiveness through different devices
protected override void WndProc(ref Message m)
{
const int WM_NCCALCSIZE = 0x0083;
if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
{
return;
}
base.WndProc(ref m);
}*/