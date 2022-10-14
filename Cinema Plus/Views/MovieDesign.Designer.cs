namespace Cinema_Plus
{
    partial class MovieDesign
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MovieNameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema_Plus.Properties.Resources.cpluslogo;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag =this.MovieNameLbl;
            this.pictureBox1.Click += new System.EventHandler(this.MovieDesign_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.MovieDesign_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.MovieDesign_MouseLeave);
            // 
            // MovieNameLbl
            // 
            this.MovieNameLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MovieNameLbl.Location = new System.Drawing.Point(39, 0);
            this.MovieNameLbl.Name = "MovieNameLbl";
            this.MovieNameLbl.Size = new System.Drawing.Size(194, 61);
            this.MovieNameLbl.TabIndex = 1;
            this.MovieNameLbl.Tag = MovieNameLbl;
            this.MovieNameLbl.Text = "MovieName";
            this.MovieNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MovieNameLbl.Click += new System.EventHandler(this.MovieDesign_Click);
            this.MovieNameLbl.MouseEnter += new System.EventHandler(this.MovieDesign_MouseEnter);
            this.MovieNameLbl.MouseLeave += new System.EventHandler(this.MovieDesign_MouseLeave);
            // 
            // MovieDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.MovieNameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MovieDesign";
            this.Size = new System.Drawing.Size(263, 433);
            this.Tag = MovieNameLbl;
            this.Click += new System.EventHandler(this.MovieDesign_Click);
            this.MouseEnter += new System.EventHandler(this.MovieDesign_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MovieDesign_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public PictureBox pictureBox1;
        public Label MovieNameLbl;
    }
}
