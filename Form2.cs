using PRIME3;
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
using System.Xml.Linq;


namespace PRIME_FINAL
{
    public partial class Home : Form
    {
        
        private Size formSize;
        private int borderSize = 1;

        private readonly Image sidebarAccessNormal;
        private readonly Image sidebarAccessHover;

        private int imageNum = 1;
        private readonly string[] imageNames = { "dune2Named.png", "kFPandaNamed.png", "godName.png" };

        private Size originalSize;

        private Form currentGodzillaForm;
        public static Home instance;
        public System.Windows.Forms.Panel paneldesk;
        public PictureBox addtoCartImage;

        public Home(string text)
        {
            InitializeComponent();
            CollapseMenu();
            usernameData.Text = text;
            desktopPanel.BringToFront();
            instance = this;
            paneldesk = desktopPanel;
            addtoCartImage = add2Cart;
            //addtoCartImage = add2CartText1;
            addtoCartImage.Visible = false;


            this.Padding = new Padding(borderSize); //Border Size
            this.BackColor = Color.FromArgb(3, 3, 3); //Border Color

            //Exit, Maximize and Minimize
            exitSign.MouseEnter += exitSign_MouseEnter;
            exitPanel.MouseEnter += exitSign_MouseLeave;
            miniSign.MouseEnter += miniSign_MouseEnter;
            minimizePanel.MouseEnter += miniSign_MouseLeave;
            maxiSign.MouseEnter += maxiSign_MouseEnter;
            resizePanel.MouseEnter += maxiSign_MouseLeave;

            //Sidebar Icon
            sidebarAccess.MouseEnter += sidebarAccess_MouseEnter_1;
            sidebarAccess.MouseLeave += sidebarAccess_MouseLeave;

            sidebarAccess.Text = "«";

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
            moviePicture.Click += moviePicture_Click;

            desktopPanel.Visible = false;

            mpictureGodzilla.MouseEnter += Picture_MouseEnter;
            mpictureGodzilla.MouseLeave += Picture_MouseLeave;
            mpictureGodzilla.Click += mpictureGodzilla_Click;

            mpictureKFPanda.MouseEnter += Picture_MouseEnter;
            mpictureKFPanda.MouseLeave += Picture_MouseLeave;
            mpictureKFPanda.Click += mpictureKFPanda_Click;

            mpictureWeb.MouseEnter += Picture_MouseEnter;
            mpictureWeb.MouseLeave += Picture_MouseLeave;
            mpictureWeb.Click += mpictureWeb_Click;

            mpictureHungerG.MouseEnter += Picture_MouseEnter;
            mpictureHungerG.MouseLeave += Picture_MouseLeave;
            mpictureHungerG.Click += mpictureHungerG_Click;

            mpictureOppenH.MouseEnter += Picture_MouseEnter;
            mpictureOppenH.MouseLeave += Picture_MouseLeave;
            mpictureOppenH.Click += mpictureOppenH_Click;

            mpictureSMario.MouseEnter += Picture_MouseEnter;
            mpictureSMario.MouseLeave += Picture_MouseLeave;
            mpictureSMario.Click += mpictureSMario_Click;

        }

        private void MpictureHungerG_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadNextImage()
        {
            if (imageNum >= imageNames.Length)
            {
                imageNum = 0; // Reset imageNum if it exceeds the array length
            }

            pictureBox8.ImageLocation = "Resources/" + imageNames[imageNum]; 

            imageNum++;
        }
        //Dragging 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
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
            if(m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32()==1) 
            { 
                return; 
            }    
            base.WndProc(ref m);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Home_Load(object sender, EventArgs e)
        {
            //originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            //originalPanelSize = new Rectangle(pictureBox8.Location.X, pictureBox8.Location.Y, pictureBox8.Width, pictureBox8.Height);

        }
        //Method for adjusting the Home Page Layout
        private void Home_Resize(object sender, EventArgs e)
        {
            AdjustForm();
            //resizeControl(originalPanelSize, pictureBox8);
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        //Minimize Panel
        private void miniSign_Click(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }
        //Minimize Cursor Hover Color
        private void miniSign_MouseEnter(object sender, EventArgs e)
        {

            minimizePanel.BackColor = Color.FromArgb(36, 36, 36);
        }
        private void miniSign_MouseLeave(object sender, EventArgs e)
        {

            minimizePanel.BackColor = Color.Transparent;
        }

        //Maximize Panel
        private void maxiSign_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }
        //Maximize Cursor Hover Color
        private void maxiSign_MouseEnter(object sender, EventArgs e)
        {
            resizePanel.BackColor = Color.FromArgb(36, 36, 36);
        }
        private void maxiSign_MouseLeave(object sender, EventArgs e)
        {

            resizePanel.BackColor = Color.Transparent;
        }

        //Exit Panel
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Exit Cursor Hover Color
        private void exitSign_MouseEnter(object sender, EventArgs e)
        {
            exitSign.ForeColor = Color.White;

            exitPanel.BackColor = Color.Red;

        }
        private void exitSign_MouseLeave(object sender, EventArgs e)
        {
            exitPanel.BackColor = Color.Transparent;

        }

        //Open & Closing of Sidebar
        private void sidebarAccess_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) 
            {
                panelMenu.Width = 72;                                                   //Panel's width when close
                pictureBox1.Visible = false;                                            //Logo Visibility
                sidebarAccess1.Dock = DockStyle.Top;
                foreach(Button menuButton in panelMenu.Controls.OfType<Button>())       //Hide Texts
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);

                }
            }
            else
            {
                panelMenu.Width = 237;                                                  //Panel's width when open
                pictureBox1.Visible = true;
                sidebarAccess1.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text ="  " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10,0,0,0);

                }
            }
        }

        //Sidebar Open & Close Arrow Icon
        private void sidebarAccess_MouseEnter(object sender, EventArgs e)
        {
            sidebarAccess1.Image = sidebarAccessHover;
        }

        private void sidebarAccess_MouseEnter_1(object sender, EventArgs e)
        {
            sidebarAccess.ForeColor = Color.FromArgb(205,205,205);
        }

        private void sidebarAccess_MouseLeave(object sender, EventArgs e)
        {
            sidebarAccess.ForeColor = Color.FromArgb(84,84,84);
        }

        private void sidebarAccess_Click_1(object sender, EventArgs e)
        {
            CollapseMenu();

            if (sidebarAccess.Text == "«")
            {
                sidebarAccess.Text = "»";
            }
            else
            {
                sidebarAccess.Text = "«";
            }
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

        private void mpictureGodzilla_Click(object sender, EventArgs e)
        {
            // Open FunctionFormbg
            OpenGodzillaForm(new FunctionFormbg());

            // Show desktopPanel again after FunctionFormbg is closed
            desktopPanel.Visible = true;
        }
        private void OpenGodzillaForm(Form godzillaForm)
        {
            if(currentGodzillaForm != null)
            {
                currentGodzillaForm.Close();
            }
            currentGodzillaForm = godzillaForm;
            godzillaForm.TopLevel = false;
            godzillaForm.FormBorderStyle = FormBorderStyle.None;
            godzillaForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(godzillaForm);
            desktopPanel.Tag = godzillaForm;
            godzillaForm.BringToFront();
            godzillaForm.Show();
        }
        private void moviePicture_Click(object sender, EventArgs e)
        {
            OpenDuneForm(new FunctionFormDune());

            desktopPanel.Visible = true;
        }
        private void OpenDuneForm(Form duneForm)
        {
            if (currentGodzillaForm != null)
            {
                currentGodzillaForm.Close();
            }
            currentGodzillaForm = duneForm;
            duneForm.TopLevel = false;
            duneForm.FormBorderStyle = FormBorderStyle.None;
            duneForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(duneForm);
            desktopPanel.Tag = duneForm;
            duneForm.BringToFront();
            duneForm.Show();
        }
        private void mpictureKFPanda_Click(object sender, EventArgs e)
        {
            OpenKFPandaForm(new FunctionFormKfPanda());

            desktopPanel.Visible = true;
        }
        private void OpenKFPandaForm(Form kfPandaForm)
        {
            if (currentGodzillaForm != null)
            {
                currentGodzillaForm.Close();
            }
            currentGodzillaForm = kfPandaForm;
            kfPandaForm.TopLevel = false;
            kfPandaForm.FormBorderStyle = FormBorderStyle.None;
            kfPandaForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(kfPandaForm);
            desktopPanel.Tag = kfPandaForm;
            kfPandaForm.BringToFront();
            kfPandaForm.Show();
        }
        private void mpictureWeb_Click(object sender, EventArgs e)
        {
            OpenMWebForm(new FunctionFormMWebb());

            desktopPanel.Visible = true;
        }
        private void OpenMWebForm(Form mwebbForm)
        {
            if (currentGodzillaForm != null)
            {
                currentGodzillaForm.Close();
            }
            currentGodzillaForm = mwebbForm;
            mwebbForm.TopLevel = false;
            mwebbForm.FormBorderStyle = FormBorderStyle.None;
            mwebbForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(mwebbForm);
            desktopPanel.Tag = mwebbForm;
            mwebbForm.BringToFront();
            mwebbForm.Show();
        }
        private void mpictureHungerG_Click(object sender, EventArgs e)
        {
            OpenHGamesForm(new FunctionFormHGames());

            desktopPanel.Visible = true;
        }
        private void OpenHGamesForm(Form hungerGForm)
        {
            if (currentGodzillaForm != null)
            {
                currentGodzillaForm.Close();
            }
            currentGodzillaForm = hungerGForm;
            hungerGForm.TopLevel = false;
            hungerGForm.FormBorderStyle = FormBorderStyle.None;
            hungerGForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(hungerGForm);
            desktopPanel.Tag = hungerGForm;
            hungerGForm.BringToFront();
            hungerGForm.Show();
        }
        private void mpictureOppenH_Click(object sender, EventArgs e)
        {
            OpenOppenheimerForm(new FunctionFormOpp());

            desktopPanel.Visible = true;
        }
        private void OpenOppenheimerForm(Form oppenheimerForm)
        {
            if (currentGodzillaForm != null)
            {
                currentGodzillaForm.Close();
            }
            currentGodzillaForm = oppenheimerForm;
            oppenheimerForm.TopLevel = false;
            oppenheimerForm.FormBorderStyle = FormBorderStyle.None;
            oppenheimerForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(oppenheimerForm);
            desktopPanel.Tag = oppenheimerForm;
            oppenheimerForm.BringToFront();
            oppenheimerForm.Show();
        }
        private void mpictureSMario_Click(object sender, EventArgs e)
        {
            OpenSuperMarioForm(new FunctionFormSMario());

            desktopPanel.Visible = true;
        }
        private void OpenSuperMarioForm(Form superMForm)
        {
            if (currentGodzillaForm != null)
            {
                currentGodzillaForm.Close();
            }
            currentGodzillaForm = superMForm;
            superMForm.TopLevel = false;
            superMForm.FormBorderStyle = FormBorderStyle.None;
            superMForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(superMForm);
            desktopPanel.Tag = superMForm;
            superMForm.BringToFront();
            superMForm.Show();
        }
    }
}
