namespace Cinema_Plus;

partial class CinemaPlus
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.NavigationBar2 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.CineBonusBtn = new System.Windows.Forms.Button();
            this.TariffsBtn = new System.Windows.Forms.Button();
            this.ActionsBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.NavigationBar1 = new System.Windows.Forms.Panel();
            this.PlatinumBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RuBtn = new System.Windows.Forms.Button();
            this.EnBtn = new System.Windows.Forms.Button();
            this.AzBtn = new System.Windows.Forms.Button();
            this.AboutUsBtn = new System.Windows.Forms.Button();
            this.ServicesBtn = new System.Windows.Forms.Button();
            this.DolbyAtmosBtn = new System.Windows.Forms.Button();
            this.MainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.NavigationBar2.SuspendLayout();
            this.NavigationBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.LogoPanel.Controls.Add(this.Logo);
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(540, 110);
            this.LogoPanel.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Image = global::Cinema_Plus.Properties.Resources.cpluslogo;
            this.Logo.Location = new System.Drawing.Point(190, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(241, 93);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // NavigationBar2
            // 
            this.NavigationBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(236)))));
            this.NavigationBar2.Controls.Add(this.SearchBtn);
            this.NavigationBar2.Controls.Add(this.SearchBox);
            this.NavigationBar2.Controls.Add(this.CineBonusBtn);
            this.NavigationBar2.Controls.Add(this.TariffsBtn);
            this.NavigationBar2.Controls.Add(this.ActionsBtn);
            this.NavigationBar2.Controls.Add(this.HomeBtn);
            this.NavigationBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationBar2.Location = new System.Drawing.Point(0, 56);
            this.NavigationBar2.Name = "NavigationBar2";
            this.NavigationBar2.Size = new System.Drawing.Size(1356, 54);
            this.NavigationBar2.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = global::Cinema_Plus.Properties.Resources.searchIcon;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBtn.Location = new System.Drawing.Point(1306, 16);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(28, 29);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Tag = this.SearchBox;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBox.Location = new System.Drawing.Point(1116, 16);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PlaceholderText = "Search";
            this.SearchBox.Size = new System.Drawing.Size(184, 29);
            this.SearchBox.TabIndex = 4;
            // 
            // CineBonusBtn
            // 
            this.CineBonusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CineBonusBtn.FlatAppearance.BorderSize = 0;
            this.CineBonusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.CineBonusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.CineBonusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CineBonusBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CineBonusBtn.ForeColor = System.Drawing.Color.Snow;
            this.CineBonusBtn.Location = new System.Drawing.Point(970, 0);
            this.CineBonusBtn.Name = "CineBonusBtn";
            this.CineBonusBtn.Size = new System.Drawing.Size(140, 56);
            this.CineBonusBtn.TabIndex = 3;
            this.CineBonusBtn.Text = "CineBonus";
            this.CineBonusBtn.UseVisualStyleBackColor = true;
            // 
            // TariffsBtn
            // 
            this.TariffsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TariffsBtn.FlatAppearance.BorderSize = 0;
            this.TariffsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.TariffsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.TariffsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TariffsBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TariffsBtn.ForeColor = System.Drawing.Color.Snow;
            this.TariffsBtn.Location = new System.Drawing.Point(843, 0);
            this.TariffsBtn.Name = "TariffsBtn";
            this.TariffsBtn.Size = new System.Drawing.Size(121, 56);
            this.TariffsBtn.TabIndex = 2;
            this.TariffsBtn.Text = "Tariflər";
            this.TariffsBtn.UseVisualStyleBackColor = true;
            // 
            // ActionsBtn
            // 
            this.ActionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionsBtn.FlatAppearance.BorderSize = 0;
            this.ActionsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.ActionsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.ActionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionsBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActionsBtn.ForeColor = System.Drawing.Color.Snow;
            this.ActionsBtn.Location = new System.Drawing.Point(696, 0);
            this.ActionsBtn.Name = "ActionsBtn";
            this.ActionsBtn.Size = new System.Drawing.Size(141, 56);
            this.ActionsBtn.TabIndex = 1;
            this.ActionsBtn.Text = "Aksiyalar";
            this.ActionsBtn.UseVisualStyleBackColor = true;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeBtn.ForeColor = System.Drawing.Color.Snow;
            this.HomeBtn.Location = new System.Drawing.Point(540, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(150, 56);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Ana Səhifə";
            this.HomeBtn.UseVisualStyleBackColor = true;
            // 
            // NavigationBar1
            // 
            this.NavigationBar1.BackColor = System.Drawing.Color.Snow;
            this.NavigationBar1.Controls.Add(this.PlatinumBtn);
            this.NavigationBar1.Controls.Add(this.pictureBox2);
            this.NavigationBar1.Controls.Add(this.pictureBox1);
            this.NavigationBar1.Controls.Add(this.RuBtn);
            this.NavigationBar1.Controls.Add(this.EnBtn);
            this.NavigationBar1.Controls.Add(this.AzBtn);
            this.NavigationBar1.Controls.Add(this.AboutUsBtn);
            this.NavigationBar1.Controls.Add(this.ServicesBtn);
            this.NavigationBar1.Controls.Add(this.DolbyAtmosBtn);
            this.NavigationBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationBar1.Location = new System.Drawing.Point(0, 0);
            this.NavigationBar1.Name = "NavigationBar1";
            this.NavigationBar1.Size = new System.Drawing.Size(1356, 56);
            this.NavigationBar1.TabIndex = 2;
            // 
            // PlatinumBtn
            // 
            this.PlatinumBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlatinumBtn.FlatAppearance.BorderSize = 0;
            this.PlatinumBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.PlatinumBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.PlatinumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlatinumBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlatinumBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.PlatinumBtn.Location = new System.Drawing.Point(539, 0);
            this.PlatinumBtn.Name = "PlatinumBtn";
            this.PlatinumBtn.Size = new System.Drawing.Size(150, 55);
            this.PlatinumBtn.TabIndex = 0;
            this.PlatinumBtn.Text = "Platinum";
            this.PlatinumBtn.UseVisualStyleBackColor = true;
            this.PlatinumBtn.MouseLeave += new System.EventHandler(this.PlatinumBtn_MouseLeave);
            this.PlatinumBtn.MouseHover += new System.EventHandler(this.PlatinumBtn_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Cinema_Plus.Properties.Resources.android;
            this.pictureBox2.Location = new System.Drawing.Point(1296, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Cinema_Plus.Properties.Resources.ios;
            this.pictureBox1.Location = new System.Drawing.Point(1267, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // RuBtn
            // 
            this.RuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RuBtn.FlatAppearance.BorderSize = 0;
            this.RuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.RuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.RuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RuBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RuBtn.Location = new System.Drawing.Point(1221, 1);
            this.RuBtn.Name = "RuBtn";
            this.RuBtn.Size = new System.Drawing.Size(40, 55);
            this.RuBtn.TabIndex = 6;
            this.RuBtn.Text = "RU";
            this.RuBtn.UseVisualStyleBackColor = true;
            // 
            // EnBtn
            // 
            this.EnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnBtn.FlatAppearance.BorderSize = 0;
            this.EnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.EnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.EnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnBtn.Location = new System.Drawing.Point(1175, 1);
            this.EnBtn.Name = "EnBtn";
            this.EnBtn.Size = new System.Drawing.Size(40, 55);
            this.EnBtn.TabIndex = 5;
            this.EnBtn.Text = "EN";
            this.EnBtn.UseVisualStyleBackColor = true;
            // 
            // AzBtn
            // 
            this.AzBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AzBtn.FlatAppearance.BorderSize = 0;
            this.AzBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.AzBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.AzBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AzBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AzBtn.Location = new System.Drawing.Point(1129, 1);
            this.AzBtn.Name = "AzBtn";
            this.AzBtn.Size = new System.Drawing.Size(40, 55);
            this.AzBtn.TabIndex = 4;
            this.AzBtn.Text = "AZ";
            this.AzBtn.UseVisualStyleBackColor = true;
            // 
            // AboutUsBtn
            // 
            this.AboutUsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutUsBtn.FlatAppearance.BorderSize = 0;
            this.AboutUsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.AboutUsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.AboutUsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutUsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AboutUsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.AboutUsBtn.Location = new System.Drawing.Point(969, 0);
            this.AboutUsBtn.Name = "AboutUsBtn";
            this.AboutUsBtn.Size = new System.Drawing.Size(140, 55);
            this.AboutUsBtn.TabIndex = 3;
            this.AboutUsBtn.Text = "Haqqımızda";
            this.AboutUsBtn.UseVisualStyleBackColor = true;
            this.AboutUsBtn.MouseLeave += new System.EventHandler(this.PlatinumBtn_MouseLeave);
            this.AboutUsBtn.MouseHover += new System.EventHandler(this.PlatinumBtn_MouseHover);
            // 
            // ServicesBtn
            // 
            this.ServicesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServicesBtn.FlatAppearance.BorderSize = 0;
            this.ServicesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.ServicesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.ServicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ServicesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.ServicesBtn.Location = new System.Drawing.Point(842, 0);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(121, 55);
            this.ServicesBtn.TabIndex = 2;
            this.ServicesBtn.Text = "Xidmətlər";
            this.ServicesBtn.UseVisualStyleBackColor = true;
            this.ServicesBtn.MouseLeave += new System.EventHandler(this.PlatinumBtn_MouseLeave);
            this.ServicesBtn.MouseHover += new System.EventHandler(this.PlatinumBtn_MouseHover);
            // 
            // DolbyAtmosBtn
            // 
            this.DolbyAtmosBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DolbyAtmosBtn.FlatAppearance.BorderSize = 0;
            this.DolbyAtmosBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.DolbyAtmosBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.DolbyAtmosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DolbyAtmosBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DolbyAtmosBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.DolbyAtmosBtn.Location = new System.Drawing.Point(695, 0);
            this.DolbyAtmosBtn.Name = "DolbyAtmosBtn";
            this.DolbyAtmosBtn.Size = new System.Drawing.Size(141, 55);
            this.DolbyAtmosBtn.TabIndex = 1;
            this.DolbyAtmosBtn.Text = "Dolby Atmos";
            this.DolbyAtmosBtn.UseVisualStyleBackColor = true;
            this.DolbyAtmosBtn.MouseLeave += new System.EventHandler(this.PlatinumBtn_MouseLeave);
            this.DolbyAtmosBtn.MouseHover += new System.EventHandler(this.PlatinumBtn_MouseHover);
            // 
            // MainLayout
            // 
            this.MainLayout.AutoScroll = true;
            this.MainLayout.BackColor = System.Drawing.Color.Snow;
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 110);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Size = new System.Drawing.Size(1356, 495);
            this.MainLayout.TabIndex = 3;
            // 
            // CinemaPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 605);
            this.Controls.Add(this.MainLayout);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.NavigationBar2);
            this.Controls.Add(this.NavigationBar1);
            this.MinimumSize = new System.Drawing.Size(1364, 644);
            this.Name = "CinemaPlus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = this.SearchBox;
            this.Text = "Cinema Plus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CinemaPlus_LoadAsync);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.NavigationBar2.ResumeLayout(false);
            this.NavigationBar2.PerformLayout();
            this.NavigationBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private Panel LogoPanel;
    private PictureBox Logo;
    private Panel NavigationBar2;
    private Button HomeBtn;
    private Panel NavigationBar1;
    private Button ActionsBtn;
    private Button CineBonusBtn;
    private Button TariffsBtn;
    private Button PlatinumBtn;
    private Button AboutUsBtn;
    private Button ServicesBtn;
    private Button DolbyAtmosBtn;
    private PictureBox pictureBox2;
    private PictureBox pictureBox1;
    private Button RuBtn;
    private Button EnBtn;
    private Button AzBtn;
    private FlowLayoutPanel MainLayout;
    private Button SearchBtn;
    private TextBox SearchBox;
}