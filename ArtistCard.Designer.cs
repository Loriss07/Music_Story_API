namespace MusicStory
{
    partial class Carta
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Card = new MusicStory.CardComponents();
            this.Picture = new MusicStory.CircleAvatar();
            this.Info = new System.Windows.Forms.Panel();
            this.ArtistName = new System.Windows.Forms.Label();
            this.Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.White;
            this.Card.BorderRadius = 40;
            this.Card.Controls.Add(this.Picture);
            this.Card.Controls.Add(this.Info);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.ForeColor = System.Drawing.Color.Black;
            this.Card.GradientAngle = 60F;
            this.Card.GradientBottomColor = System.Drawing.Color.LightBlue;
            this.Card.GradientTopColor = System.Drawing.Color.MidnightBlue;
            this.Card.Location = new System.Drawing.Point(5, 5);
            this.Card.Margin = new System.Windows.Forms.Padding(5);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(390, 70);
            this.Card.TabIndex = 0;
            // 
            // Picture
            // 
            this.Picture.BackgroundImage = global::MusicStory.Properties.Resources.music_player;
            this.Picture.BorderGradientBottom = System.Drawing.Color.Azure;
            this.Picture.BorderGradientTop = System.Drawing.Color.DodgerBlue;
            this.Picture.BorderRadius = 40;
            this.Picture.BorderSize = 2;
            this.Picture.GradientAngle = 90F;
            this.Picture.InitialImage = global::MusicStory.Properties.Resources.music_player;
            this.Picture.Location = new System.Drawing.Point(9, 3);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(68, 68);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Info.Controls.Add(this.ArtistName);
            this.Info.Dock = System.Windows.Forms.DockStyle.Right;
            this.Info.Location = new System.Drawing.Point(87, 0);
            this.Info.Margin = new System.Windows.Forms.Padding(0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(303, 70);
            this.Info.TabIndex = 0;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // ArtistName
            // 
            this.ArtistName.AutoSize = true;
            this.ArtistName.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistName.Location = new System.Drawing.Point(10, 19);
            this.ArtistName.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ArtistName.Size = new System.Drawing.Size(204, 36);
            this.ArtistName.TabIndex = 0;
            this.ArtistName.Text = "Nome Artista";
            // 
            // Carta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.Card);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Carta";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(400, 80);
            this.Card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Info;
        public CardComponents Card;
        private System.Windows.Forms.Label ArtistName;
        public CircleAvatar Picture;
    }
}
