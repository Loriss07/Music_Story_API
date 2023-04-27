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
            this.Title = new MusicStory.CardComponents();
            this.AlbumName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAlbum)).BeginInit();
            this.Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgAlbum
            // 
            this.ImgAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgAlbum.Location = new System.Drawing.Point(0, 0);
            this.ImgAlbum.Name = "ImgAlbum";
            this.ImgAlbum.Size = new System.Drawing.Size(142, 190);
            this.ImgAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgAlbum.TabIndex = 0;
            this.ImgAlbum.TabStop = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.White;
            this.Title.BorderRadius = 0;
            this.Title.Controls.Add(this.AlbumName);
            this.Title.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.GradientAngle = 90F;
            this.Title.GradientBottomColor = System.Drawing.Color.Plum;
            this.Title.GradientTopColor = System.Drawing.Color.Transparent;
            this.Title.Location = new System.Drawing.Point(0, 135);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(142, 55);
            this.Title.TabIndex = 1;
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
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ImgAlbum);
            this.Name = "CartaAlbum";
            this.Size = new System.Drawing.Size(142, 190);
            ((System.ComponentModel.ISupportInitialize)(this.ImgAlbum)).EndInit();
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label AlbumName;
        public System.Windows.Forms.PictureBox ImgAlbum;
        public CardComponents Title;
    }
}
