namespace Cinema_Plus.Views
{
    partial class MovieDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PosterBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CountryTb = new System.Windows.Forms.TextBox();
            this.DirectorTb = new System.Windows.Forms.TextBox();
            this.ActorsTb = new System.Windows.Forms.TextBox();
            this.GenreTb = new System.Windows.Forms.TextBox();
            this.RatingTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PlotTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PosterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(308, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(308, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Director:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(308, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Actors:";
            // 
            // PosterBox
            // 
            this.PosterBox.Image = global::Cinema_Plus.Properties.Resources.cpluslogo;
            this.PosterBox.Location = new System.Drawing.Point(12, 28);
            this.PosterBox.Name = "PosterBox";
            this.PosterBox.Size = new System.Drawing.Size(281, 370);
            this.PosterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PosterBox.TabIndex = 5;
            this.PosterBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(308, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(308, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rating:";
            // 
            // CountryTb
            // 
            this.CountryTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.CountryTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountryTb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountryTb.ForeColor = System.Drawing.Color.Snow;
            this.CountryTb.Location = new System.Drawing.Point(406, 70);
            this.CountryTb.Name = "CountryTb";
            this.CountryTb.ReadOnly = true;
            this.CountryTb.Size = new System.Drawing.Size(496, 20);
            this.CountryTb.TabIndex = 8;
            // 
            // DirectorTb
            // 
            this.DirectorTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.DirectorTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DirectorTb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DirectorTb.ForeColor = System.Drawing.Color.Snow;
            this.DirectorTb.Location = new System.Drawing.Point(406, 106);
            this.DirectorTb.Name = "DirectorTb";
            this.DirectorTb.ReadOnly = true;
            this.DirectorTb.Size = new System.Drawing.Size(496, 20);
            this.DirectorTb.TabIndex = 9;
            // 
            // ActorsTb
            // 
            this.ActorsTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.ActorsTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActorsTb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActorsTb.ForeColor = System.Drawing.Color.Snow;
            this.ActorsTb.Location = new System.Drawing.Point(406, 142);
            this.ActorsTb.Name = "ActorsTb";
            this.ActorsTb.ReadOnly = true;
            this.ActorsTb.Size = new System.Drawing.Size(496, 20);
            this.ActorsTb.TabIndex = 10;
            // 
            // GenreTb
            // 
            this.GenreTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.GenreTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenreTb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenreTb.ForeColor = System.Drawing.Color.Snow;
            this.GenreTb.Location = new System.Drawing.Point(406, 175);
            this.GenreTb.Name = "GenreTb";
            this.GenreTb.ReadOnly = true;
            this.GenreTb.Size = new System.Drawing.Size(496, 20);
            this.GenreTb.TabIndex = 11;
            // 
            // RatingTb
            // 
            this.RatingTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.RatingTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RatingTb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RatingTb.ForeColor = System.Drawing.Color.Snow;
            this.RatingTb.Location = new System.Drawing.Point(406, 209);
            this.RatingTb.Name = "RatingTb";
            this.RatingTb.ReadOnly = true;
            this.RatingTb.Size = new System.Drawing.Size(496, 20);
            this.RatingTb.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(308, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name: ";
            // 
            // NameTb
            // 
            this.NameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.NameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameTb.ForeColor = System.Drawing.Color.Snow;
            this.NameTb.Location = new System.Drawing.Point(406, 35);
            this.NameTb.Name = "NameTb";
            this.NameTb.ReadOnly = true;
            this.NameTb.Size = new System.Drawing.Size(496, 20);
            this.NameTb.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(308, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Description:";
            // 
            // PlotTb
            // 
            this.PlotTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.PlotTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlotTb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlotTb.ForeColor = System.Drawing.Color.Snow;
            this.PlotTb.Location = new System.Drawing.Point(406, 248);
            this.PlotTb.Multiline = true;
            this.PlotTb.Name = "PlotTb";
            this.PlotTb.ReadOnly = true;
            this.PlotTb.Size = new System.Drawing.Size(496, 153);
            this.PlotTb.TabIndex = 16;
            // 
            // MovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(914, 406);
            this.Controls.Add(this.PlotTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RatingTb);
            this.Controls.Add(this.GenreTb);
            this.Controls.Add(this.ActorsTb);
            this.Controls.Add(this.DirectorTb);
            this.Controls.Add(this.CountryTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PosterBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MovieDetails";
            this.Text = "MovieDetails";
            this.Load += new System.EventHandler(this.MovieDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PosterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public PictureBox PosterBox;
        private Label label4;
        private Label label5;
        private TextBox CountryTb;
        private TextBox DirectorTb;
        private TextBox ActorsTb;
        private TextBox GenreTb;
        private TextBox RatingTb;
        private Label label6;
        private TextBox NameTb;
        private Label label7;
        private TextBox DescriptionTb;
        private TextBox PlotTb;
    }
}