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
    public partial class HeaderPoster : UserControl
    {
        private Size originalSize;
        public HeaderPoster()
        {
            InitializeComponent();

            originalSize = new Size(166, 94);
            starSign.Text = "☆";

            starSign.Click += starSign_Click;
            MovieShowPoster.MouseEnter += Picture_MouseEnter;
            MovieShowPoster.MouseLeave += Picture_MouseLeave;

        }

        private void Picture_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox; //Casting the Sender to a PictureBox
            {
                Size newSize = new Size(originalSize.Width + 5, originalSize.Height + 5);   //Added Size When Hover
                pictureBox.Size = newSize;
            }
        }
        private void Picture_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                pictureBox.Size = originalSize;
            }
        }
        private void starSign_Click(object sender, EventArgs e)
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
    }
   
}
