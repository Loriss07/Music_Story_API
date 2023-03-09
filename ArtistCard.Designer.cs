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
            this.circleAvatar1 = new MusicStory.CircleAvatar();
            this.Info = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ArtistName = new System.Windows.Forms.Label();
            this.Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleAvatar1)).BeginInit();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.White;
            this.Card.BorderRadius = 40;
            this.Card.Controls.Add(this.circleAvatar1);
            this.Card.Controls.Add(this.Info);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.ForeColor = System.Drawing.Color.Black;
            this.Card.GradientAngle = 60F;
            this.Card.GradientBottomColor = System.Drawing.Color.LightBlue;
            this.Card.GradientTopColor = System.Drawing.Color.MidnightBlue;
            this.Card.Location = new System.Drawing.Point(5, 5);
            this.Card.Margin = new System.Windows.Forms.Padding(5);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(390, 90);
            this.Card.TabIndex = 0;
            // 
            // circleAvatar1
            // 
            this.circleAvatar1.BorderGradientBottom = System.Drawing.Color.Azure;
            this.circleAvatar1.BorderGradientTop = System.Drawing.Color.DodgerBlue;
            this.circleAvatar1.BorderRadius = 40;
            this.circleAvatar1.BorderSize = 2;
            this.circleAvatar1.GradientAngle = 90F;
            this.circleAvatar1.Location = new System.Drawing.Point(3, 3);
            this.circleAvatar1.Name = "circleAvatar1";
            this.circleAvatar1.Size = new System.Drawing.Size(84, 84);
            this.circleAvatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circleAvatar1.TabIndex = 1;
            this.circleAvatar1.TabStop = false;
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Info.Controls.Add(this.label1);
            this.Info.Controls.Add(this.ArtistName);
            this.Info.Dock = System.Windows.Forms.DockStyle.Right;
            this.Info.Location = new System.Drawing.Point(87, 0);
            this.Info.Margin = new System.Windows.Forms.Padding(0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(303, 90);
            this.Info.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genere";
            // 
            // ArtistName
            // 
            this.ArtistName.AutoSize = true;
            this.ArtistName.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistName.Location = new System.Drawing.Point(36, 16);
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
            this.Size = new System.Drawing.Size(400, 100);
            this.Card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circleAvatar1)).EndInit();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Info;
        private System.Windows.Forms.Label label1;
        public CardComponents Card;
        private CircleAvatar circleAvatar1;
        public System.Windows.Forms.Label ArtistName;
    }
}
