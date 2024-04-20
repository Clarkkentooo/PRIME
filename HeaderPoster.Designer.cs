namespace PRIME_FINAL
{
    partial class HeaderPoster
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.releaseDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.starSign = new System.Windows.Forms.Label();
            this.TitleMovie = new System.Windows.Forms.Label();
            this.MovieShowPoster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieShowPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // releaseDate
            // 
            this.releaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.releaseDate.AutoSize = true;
            this.releaseDate.BackColor = System.Drawing.Color.Transparent;
            this.releaseDate.Font = new System.Drawing.Font("SF Pro Text", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.releaseDate.Location = new System.Drawing.Point(26, 125);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(63, 10);
            this.releaseDate.TabIndex = 13;
            this.releaseDate.Text = "March 14, 2024";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PRIME3.Properties.Resources.video;
            this.pictureBox2.Location = new System.Drawing.Point(4, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.starSign);
            this.panel2.Controls.Add(this.TitleMovie);
            this.panel2.Location = new System.Drawing.Point(3, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 18);
            this.panel2.TabIndex = 11;
            // 
            // starSign
            // 
            this.starSign.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.starSign.AutoSize = true;
            this.starSign.BackColor = System.Drawing.Color.Transparent;
            this.starSign.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.starSign.Location = new System.Drawing.Point(137, 0);
            this.starSign.Name = "starSign";
            this.starSign.Size = new System.Drawing.Size(20, 16);
            this.starSign.TabIndex = 3;
            this.starSign.Text = "☆";
            this.starSign.Click += new System.EventHandler(this.starSign_Click);
            // 
            // TitleMovie
            // 
            this.TitleMovie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitleMovie.AutoSize = true;
            this.TitleMovie.BackColor = System.Drawing.Color.Transparent;
            this.TitleMovie.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.TitleMovie.Location = new System.Drawing.Point(0, 0);
            this.TitleMovie.Name = "TitleMovie";
            this.TitleMovie.Size = new System.Drawing.Size(82, 16);
            this.TitleMovie.TabIndex = 0;
            this.TitleMovie.Text = "Dune: Part ll";
            // 
            // MovieShowPoster
            // 
            this.MovieShowPoster.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MovieShowPoster.BackColor = System.Drawing.Color.Transparent;
            this.MovieShowPoster.Image = global::PRIME3.Properties.Resources.dune1;
            this.MovieShowPoster.Location = new System.Drawing.Point(0, 0);
            this.MovieShowPoster.Name = "MovieShowPoster";
            this.MovieShowPoster.Size = new System.Drawing.Size(159, 94);
            this.MovieShowPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MovieShowPoster.TabIndex = 9;
            this.MovieShowPoster.TabStop = false;  
            // 
            // HeaderPoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.Controls.Add(this.MovieShowPoster);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Name = "HeaderPoster";
            this.Size = new System.Drawing.Size(159, 140);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieShowPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label releaseDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label starSign;
        private System.Windows.Forms.Label TitleMovie;
        private System.Windows.Forms.PictureBox MovieShowPoster;
    }
}
