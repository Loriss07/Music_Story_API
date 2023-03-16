namespace MusicStory
{
    partial class ArtistInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistInfo));
            this.panel3 = new System.Windows.Forms.Panel();
            this.background = new MusicStory.CardComponents();
            this.Biography = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Instagram = new System.Windows.Forms.PictureBox();
            this.Twitter = new System.Windows.Forms.PictureBox();
            this.Youtube = new System.Windows.Forms.PictureBox();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Artist_Name = new System.Windows.Forms.Label();
            this.ArtistPFP = new MusicStory.CircleAvatar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Albums = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3.SuspendLayout();
            this.background.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Instagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Youtube)).BeginInit();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistPFP)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.background);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(482, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 609);
            this.panel3.TabIndex = 2;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.White;
            this.background.BorderRadius = 0;
            this.background.Controls.Add(this.Biography);
            this.background.Controls.Add(this.panel1);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.ForeColor = System.Drawing.Color.Black;
            this.background.GradientAngle = 185F;
            this.background.GradientBottomColor = System.Drawing.Color.LemonChiffon;
            this.background.GradientTopColor = System.Drawing.Color.Plum;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(520, 609);
            this.background.TabIndex = 0;
            // 
            // Biography
            // 
            this.Biography.AllowNavigation = false;
            this.Biography.Location = new System.Drawing.Point(33, 32);
            this.Biography.Margin = new System.Windows.Forms.Padding(20);
            this.Biography.MinimumSize = new System.Drawing.Size(20, 20);
            this.Biography.Name = "Biography";
            this.Biography.Size = new System.Drawing.Size(458, 443);
            this.Biography.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Instagram);
            this.panel1.Controls.Add(this.Twitter);
            this.panel1.Controls.Add(this.Youtube);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 111);
            this.panel1.TabIndex = 0;
            // 
            // Instagram
            // 
            this.Instagram.InitialImage = global::MusicStory.Properties.Resources.instagram;
            this.Instagram.Location = new System.Drawing.Point(408, 29);
            this.Instagram.Name = "Instagram";
            this.Instagram.Size = new System.Drawing.Size(100, 53);
            this.Instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Instagram.TabIndex = 2;
            this.Instagram.TabStop = false;
            this.Instagram.Click += new System.EventHandler(this.Instagram_Click);
            // 
            // Twitter
            // 
            this.Twitter.InitialImage = global::MusicStory.Properties.Resources.twitter;
            this.Twitter.Location = new System.Drawing.Point(219, 29);
            this.Twitter.Name = "Twitter";
            this.Twitter.Size = new System.Drawing.Size(100, 53);
            this.Twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Twitter.TabIndex = 1;
            this.Twitter.TabStop = false;
            this.Twitter.Click += new System.EventHandler(this.Twitter_Click);
            // 
            // Youtube
            // 
            this.Youtube.Location = new System.Drawing.Point(33, 29);
            this.Youtube.Name = "Youtube";
            this.Youtube.Size = new System.Drawing.Size(100, 53);
            this.Youtube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Youtube.TabIndex = 0;
            this.Youtube.TabStop = false;
            this.Youtube.Click += new System.EventHandler(this.Youtube_Click);
            // 
            // picturePanel
            // 
            this.picturePanel.BackColor = System.Drawing.Color.Transparent;
            this.picturePanel.Controls.Add(this.label1);
            this.picturePanel.Controls.Add(this.Artist_Name);
            this.picturePanel.Controls.Add(this.ArtistPFP);
            this.picturePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.picturePanel.Location = new System.Drawing.Point(0, 0);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(482, 282);
            this.picturePanel.TabIndex = 3;
            this.picturePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.picturePanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(273, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Artist_Name
            // 
            this.Artist_Name.AutoSize = true;
            this.Artist_Name.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist_Name.ForeColor = System.Drawing.Color.Azure;
            this.Artist_Name.Location = new System.Drawing.Point(271, 37);
            this.Artist_Name.Name = "Artist_Name";
            this.Artist_Name.Size = new System.Drawing.Size(85, 34);
            this.Artist_Name.TabIndex = 1;
            this.Artist_Name.Text = "label1";
            // 
            // ArtistPFP
            // 
            this.ArtistPFP.BorderGradientBottom = System.Drawing.Color.LemonChiffon;
            this.ArtistPFP.BorderGradientTop = System.Drawing.Color.Plum;
            this.ArtistPFP.BorderRadius = 40;
            this.ArtistPFP.BorderSize = 1;
            this.ArtistPFP.GradientAngle = 120F;
            this.ArtistPFP.Location = new System.Drawing.Point(0, 0);
            this.ArtistPFP.Name = "ArtistPFP";
            this.ArtistPFP.Size = new System.Drawing.Size(265, 265);
            this.ArtistPFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArtistPFP.TabIndex = 0;
            this.ArtistPFP.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Back);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 274);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 53);
            this.panel4.TabIndex = 5;
            // 
            // Back
            // 
            this.Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Image = global::MusicStory.Properties.Resources.left_arrow;
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(482, 53);
            this.Back.TabIndex = 3;
            this.Back.Text = "Indietro";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 327);
            this.panel2.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.Albums);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(482, 274);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 216);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(482, 58);
            this.panel6.TabIndex = 1;
            // 
            // Albums
            // 
            this.Albums.Dock = System.Windows.Forms.DockStyle.Top;
            this.Albums.Location = new System.Drawing.Point(0, 0);
            this.Albums.Name = "Albums";
            this.Albums.Size = new System.Drawing.Size(482, 216);
            this.Albums.TabIndex = 0;
            // 
            // ArtistInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1002, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArtistInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ArtistInfo";
            this.panel3.ResumeLayout(false);
            this.background.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Instagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Youtube)).EndInit();
            this.picturePanel.ResumeLayout(false);
            this.picturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistPFP)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private CardComponents background;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Instagram;
        private System.Windows.Forms.PictureBox Twitter;
        private System.Windows.Forms.PictureBox Youtube;
        private CircleAvatar ArtistPFP;
        private System.Windows.Forms.Label Artist_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.WebBrowser Biography;
        public System.Windows.Forms.FlowLayoutPanel Albums;
    }
}