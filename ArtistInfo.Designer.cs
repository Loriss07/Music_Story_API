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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Artist_Name = new System.Windows.Forms.Label();
            this.circleAvatar1 = new MusicStory.CircleAvatar();
            this.background = new MusicStory.CardComponents();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Instagram = new System.Windows.Forms.PictureBox();
            this.Twitter = new System.Windows.Forms.PictureBox();
            this.Youtube = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.picturePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleAvatar1)).BeginInit();
            this.background.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Instagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Youtube)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.background);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(461, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 572);
            this.panel3.TabIndex = 2;
            // 
            // panelAlbums
            // 
            this.panelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlbums.Location = new System.Drawing.Point(0, 0);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(461, 307);
            this.panelAlbums.TabIndex = 4;
            // 
            // picturePanel
            // 
            this.picturePanel.Controls.Add(this.Artist_Name);
            this.picturePanel.Controls.Add(this.circleAvatar1);
            this.picturePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.picturePanel.Location = new System.Drawing.Point(0, 0);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(461, 265);
            this.picturePanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panelAlbums);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 307);
            this.panel2.TabIndex = 5;
            // 
            // Artist_Name
            // 
            this.Artist_Name.AutoSize = true;
            this.Artist_Name.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Artist_Name.Location = new System.Drawing.Point(271, 115);
            this.Artist_Name.Name = "Artist_Name";
            this.Artist_Name.Size = new System.Drawing.Size(85, 34);
            this.Artist_Name.TabIndex = 1;
            this.Artist_Name.Text = "label1";
            // 
            // circleAvatar1
            // 
            this.circleAvatar1.BorderGradientBottom = System.Drawing.Color.LemonChiffon;
            this.circleAvatar1.BorderGradientTop = System.Drawing.Color.Plum;
            this.circleAvatar1.BorderRadius = 40;
            this.circleAvatar1.BorderSize = 1;
            this.circleAvatar1.GradientAngle = 120F;
            this.circleAvatar1.Location = new System.Drawing.Point(0, 0);
            this.circleAvatar1.Name = "circleAvatar1";
            this.circleAvatar1.Size = new System.Drawing.Size(265, 265);
            this.circleAvatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circleAvatar1.TabIndex = 0;
            this.circleAvatar1.TabStop = false;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.White;
            this.background.BorderRadius = 20;
            this.background.Controls.Add(this.panel1);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.ForeColor = System.Drawing.Color.Black;
            this.background.GradientAngle = 185F;
            this.background.GradientBottomColor = System.Drawing.Color.LemonChiffon;
            this.background.GradientTopColor = System.Drawing.Color.Plum;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(537, 572);
            this.background.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Instagram);
            this.panel1.Controls.Add(this.Twitter);
            this.panel1.Controls.Add(this.Youtube);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 101);
            this.panel1.TabIndex = 0;
            // 
            // Instagram
            // 
            this.Instagram.InitialImage = global::MusicStory.Properties.Resources.instagram;
            this.Instagram.Location = new System.Drawing.Point(413, 27);
            this.Instagram.Name = "Instagram";
            this.Instagram.Size = new System.Drawing.Size(100, 50);
            this.Instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Instagram.TabIndex = 2;
            this.Instagram.TabStop = false;
            // 
            // Twitter
            // 
            this.Twitter.InitialImage = global::MusicStory.Properties.Resources.twitter;
            this.Twitter.Location = new System.Drawing.Point(219, 27);
            this.Twitter.Name = "Twitter";
            this.Twitter.Size = new System.Drawing.Size(100, 50);
            this.Twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Twitter.TabIndex = 1;
            this.Twitter.TabStop = false;
            // 
            // Youtube
            // 
            this.Youtube.Location = new System.Drawing.Point(33, 27);
            this.Youtube.Name = "Youtube";
            this.Youtube.Size = new System.Drawing.Size(100, 50);
            this.Youtube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Youtube.TabIndex = 0;
            this.Youtube.TabStop = false;
            this.Youtube.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ArtistInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(998, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.panel3);
            this.Name = "ArtistInfo";
            this.Text = "ArtistInfo";
            this.panel3.ResumeLayout(false);
            this.picturePanel.ResumeLayout(false);
            this.picturePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circleAvatar1)).EndInit();
            this.background.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Instagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Youtube)).EndInit();
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
        private CircleAvatar circleAvatar1;
        private System.Windows.Forms.FlowLayoutPanel panelAlbums;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Artist_Name;
    }
}