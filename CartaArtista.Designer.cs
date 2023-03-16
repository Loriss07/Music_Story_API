namespace MusicStory
{
    partial class CartaArtista
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
            this.InfoCarta = new MusicStory.CardComponents();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NomeArtista = new System.Windows.Forms.Label();
            this.ImgArtista = new MusicStory.CircleAvatar();
            this.InfoCarta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgArtista)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoCarta
            // 
            this.InfoCarta.BackColor = System.Drawing.Color.White;
            this.InfoCarta.BorderRadius = 15;
            this.InfoCarta.Controls.Add(this.panel1);
            this.InfoCarta.Controls.Add(this.ImgArtista);
            this.InfoCarta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoCarta.ForeColor = System.Drawing.Color.Black;
            this.InfoCarta.GradientAngle = 60F;
            this.InfoCarta.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.InfoCarta.GradientTopColor = System.Drawing.Color.Lavender;
            this.InfoCarta.Location = new System.Drawing.Point(0, 0);
            this.InfoCarta.Name = "InfoCarta";
            this.InfoCarta.Size = new System.Drawing.Size(377, 123);
            this.InfoCarta.TabIndex = 0;
            this.InfoCarta.Click += new System.EventHandler(this.InfoCarta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.NomeArtista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(126, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 123);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // NomeArtista
            // 
            this.NomeArtista.AutoSize = true;
            this.NomeArtista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NomeArtista.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeArtista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.NomeArtista.Location = new System.Drawing.Point(10, 46);
            this.NomeArtista.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.NomeArtista.Name = "NomeArtista";
            this.NomeArtista.Size = new System.Drawing.Size(71, 28);
            this.NomeArtista.TabIndex = 0;
            this.NomeArtista.Text = "label1";
            // 
            // ImgArtista
            // 
            this.ImgArtista.BorderGradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.ImgArtista.BorderGradientTop = System.Drawing.Color.Transparent;
            this.ImgArtista.BorderRadius = 40;
            this.ImgArtista.BorderSize = 2;
            this.ImgArtista.GradientAngle = 90F;
            this.ImgArtista.Location = new System.Drawing.Point(0, 0);
            this.ImgArtista.Name = "ImgArtista";
            this.ImgArtista.Size = new System.Drawing.Size(120, 120);
            this.ImgArtista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgArtista.TabIndex = 0;
            this.ImgArtista.TabStop = false;
            this.ImgArtista.Click += new System.EventHandler(this.ImgArtista_Click);
            // 
            // CartaArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.InfoCarta);
            this.Name = "CartaArtista";
            this.Size = new System.Drawing.Size(377, 123);
            this.InfoCarta.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgArtista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CardComponents InfoCarta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NomeArtista;
        public CircleAvatar ImgArtista;
    }
}
