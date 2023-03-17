namespace MusicStory
{
    partial class CartaAlbum
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
            this.ImgAlbum = new System.Windows.Forms.PictureBox();
            this.cardComponents1 = new MusicStory.CardComponents();
            this.AlbumName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAlbum)).BeginInit();
            this.cardComponents1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgAlbum
            // 
            this.ImgAlbum.Location = new System.Drawing.Point(0, 0);
            this.ImgAlbum.Name = "ImgAlbum";
            this.ImgAlbum.Size = new System.Drawing.Size(125, 125);
            this.ImgAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgAlbum.TabIndex = 0;
            this.ImgAlbum.TabStop = false;
            // 
            // cardComponents1
            // 
            this.cardComponents1.BackColor = System.Drawing.Color.White;
            this.cardComponents1.BorderRadius = 20;
            this.cardComponents1.Controls.Add(this.AlbumName);
            this.cardComponents1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardComponents1.ForeColor = System.Drawing.Color.Black;
            this.cardComponents1.GradientAngle = 90F;
            this.cardComponents1.GradientBottomColor = System.Drawing.Color.LemonChiffon;
            this.cardComponents1.GradientTopColor = System.Drawing.Color.Transparent;
            this.cardComponents1.Location = new System.Drawing.Point(0, 124);
            this.cardComponents1.Name = "cardComponents1";
            this.cardComponents1.Size = new System.Drawing.Size(128, 55);
            this.cardComponents1.TabIndex = 1;
            // 
            // AlbumName
            // 
            this.AlbumName.AutoSize = true;
            this.AlbumName.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumName.Location = new System.Drawing.Point(3, 0);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(56, 22);
            this.AlbumName.TabIndex = 0;
            this.AlbumName.Text = "label1";
            // 
            // CartaAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cardComponents1);
            this.Controls.Add(this.ImgAlbum);
            this.Name = "CartaAlbum";
            this.Size = new System.Drawing.Size(128, 179);
            ((System.ComponentModel.ISupportInitialize)(this.ImgAlbum)).EndInit();
            this.cardComponents1.ResumeLayout(false);
            this.cardComponents1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CardComponents cardComponents1;
        private System.Windows.Forms.Label AlbumName;
        public System.Windows.Forms.PictureBox ImgAlbum;
    }
}
