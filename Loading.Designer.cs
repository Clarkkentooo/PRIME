namespace PRIME_FINAL
{
    partial class Loading
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.poisonProgressBar1 = new ReaLTaiizor.Controls.PoisonProgressBar();
            this.poisonProgressBar2 = new ReaLTaiizor.Controls.PoisonProgressBar();
            this.primeProgressBar = new ReaLTaiizor.Controls.AloneProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PRIME3.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(141, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // poisonProgressBar1
            // 
            this.poisonProgressBar1.Location = new System.Drawing.Point(1386, 559);
            this.poisonProgressBar1.Name = "poisonProgressBar1";
            this.poisonProgressBar1.Size = new System.Drawing.Size(183, 22);
            this.poisonProgressBar1.TabIndex = 3;
            // 
            // poisonProgressBar2
            // 
            this.poisonProgressBar2.Location = new System.Drawing.Point(1380, 518);
            this.poisonProgressBar2.Name = "poisonProgressBar2";
            this.poisonProgressBar2.Size = new System.Drawing.Size(263, 36);
            this.poisonProgressBar2.TabIndex = 5;
            // 
            // primeProgressBar
            // 
            this.primeProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.primeProgressBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(12)))), ((int)(((byte)(96)))));
            this.primeProgressBar.BaseColor = System.Drawing.Color.Transparent;
            this.primeProgressBar.BorderColor = System.Drawing.Color.Transparent;
            this.primeProgressBar.ForeColor = System.Drawing.Color.Transparent;
            this.primeProgressBar.Location = new System.Drawing.Point(-9, 343);
            this.primeProgressBar.Maximum = 100;
            this.primeProgressBar.Minimum = 0;
            this.primeProgressBar.Name = "primeProgressBar";
            this.primeProgressBar.Size = new System.Drawing.Size(561, 7);
            this.primeProgressBar.Stripes = System.Drawing.Color.Transparent;
            this.primeProgressBar.TabIndex = 4;
            this.primeProgressBar.Text = "aloneProgressBar1";
            this.primeProgressBar.Value = 50;
            this.primeProgressBar.Click += new System.EventHandler(this.primeProgressBar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.BackgroundImage = global::PRIME3.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(547, 349);
            this.Controls.Add(this.poisonProgressBar2);
            this.Controls.Add(this.primeProgressBar);
            this.Controls.Add(this.poisonProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.PoisonProgressBar poisonProgressBar1;
        private ReaLTaiizor.Controls.PoisonProgressBar poisonProgressBar2;
        private ReaLTaiizor.Controls.AloneProgressBar primeProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}