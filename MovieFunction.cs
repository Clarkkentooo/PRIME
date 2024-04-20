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
    public partial class MovieFunction : UserControl
    {
        public MovieFunction()
        {
            InitializeComponent();

            //Sidebar Icon
            sidebarAccess1.MouseEnter += sidebarAccess_MouseEnter;
            sidebarAccess1.MouseLeave += sidebarAccess_MouseLeave;

            add2CartText.MouseEnter += label5_MouseEnter;
            add2CartText.MouseLeave += label5_MouseLeave;
        }
        public Image header { get => headerImage.Image; set => headerImage.Image = value; }
        public string title { get => movieTitle.Text; set => movieTitle.Text = value; }
        public string releaseDate { get => showingDate.Text; set => showingDate.Text = value; }
        public string director { get => directorName.Text; set => directorName.Text = value; }
        public string synopsis { get => movieSynopsis.Text; set => movieSynopsis.Text = value; }

        
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            add2CartText.Font = new Font(add2CartText.Font, FontStyle.Underline);
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            add2CartText.Font = new Font(add2CartText.Font, FontStyle.Regular);
        }

        private void sidebarAccess_MouseEnter(object sender, EventArgs e)
        {
            sidebarAccess1.ForeColor = Color.FromArgb(205, 205, 205);
        }

        private void sidebarAccess_MouseLeave(object sender, EventArgs e)
        {
            sidebarAccess1.ForeColor = Color.FromArgb(84, 84, 84);
        }
    }
}
