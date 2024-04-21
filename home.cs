using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIME_FINAL
{
    public partial class HomeVer2 : UserControl
    {
        private int imageNum = 1;
        private readonly string[] imageNames = { "dune2Named.png", "kFPandaNamed.png", "godName.png" };

        private Size originalSize;
        public HomeVer2()
        {
            InitializeComponent();

            starSign.Text = "☆";
            starSign_kFPanda.Text = "☆";
            starSign_Godzilla.Text = "☆";

            starSign.Click += StarSign_Click;
            starSign_kFPanda.Click += StarSign_Click;
            starSign_Godzilla.Click += StarSign_Click;

            mpictureWeb.Click += StarSign_Click;
            starSign_HungerG.Click += StarSign_Click;
            starSign_OppenH.Click += StarSign_Click;
            starSign_SMario.Click += StarSign_Click;


            originalSize = new Size(166, 94); // Size of Movie Panels

            //Hover Event for Movie Posters in panel
            moviePicture.MouseEnter += Picture_MouseEnter;
            moviePicture.MouseLeave += Picture_MouseLeave;

            mpictureGodzilla.MouseEnter += Picture_MouseEnter;
            mpictureGodzilla.MouseLeave += Picture_MouseLeave;

            mpictureKFPanda.MouseEnter += Picture_MouseEnter;
            mpictureKFPanda.MouseLeave += Picture_MouseLeave;

            mpictureWeb.MouseEnter += Picture_MouseEnter;
            mpictureWeb.MouseLeave += Picture_MouseLeave;

            mpictureHungerG.MouseEnter += Picture_MouseEnter;
            mpictureHungerG.MouseLeave += Picture_MouseLeave;

            mpictureOppenH.MouseEnter += Picture_MouseEnter;
            mpictureOppenH.MouseLeave += Picture_MouseLeave;

            mpictureSMario.MouseEnter += Picture_MouseEnter;
            mpictureSMario.MouseLeave += Picture_MouseLeave;
        }
        private void LoadNextImage()
        {
            if (imageNum >= imageNames.Length)
            {
                imageNum = 0; // Reset imageNum if it exceeds the array length
            }

            pictureBox2.ImageLocation = "Resources/" + imageNames[imageNum]; // Assuming the images are located in a folder named "HeaderImage"

            imageNum++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
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

        //Method When Star Sign is Click
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
    }
}
