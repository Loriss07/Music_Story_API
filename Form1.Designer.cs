namespace MusicStory
{
    partial class Form1
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Warn = new System.Windows.Forms.Label();
            this.Bar = new System.Windows.Forms.Panel();
            this.Switch = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Next = new MusicStory.RJButton();
            this.Previous = new MusicStory.RJButton();
            this.Search = new MusicStory.RJButton();
            this.Bar.SuspendLayout();
            this.Switch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.SearchBar.Location = new System.Drawing.Point(145, 18);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(411, 40);
            this.SearchBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cerca Artista";
            // 
            // Warn
            // 
            this.Warn.AutoSize = true;
            this.Warn.Location = new System.Drawing.Point(145, 57);
            this.Warn.Name = "Warn";
            this.Warn.Size = new System.Drawing.Size(0, 16);
            this.Warn.TabIndex = 3;
            // 
            // Bar
            // 
            this.Bar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bar.Controls.Add(this.label1);
            this.Bar.Controls.Add(this.SearchBar);
            this.Bar.Controls.Add(this.Search);
            this.Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bar.Location = new System.Drawing.Point(0, 0);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(703, 88);
            this.Bar.TabIndex = 4;
            // 
            // Switch
            // 
            this.Switch.Controls.Add(this.Next);
            this.Switch.Controls.Add(this.Previous);
            this.Switch.Dock = System.Windows.Forms.DockStyle.Right;
            this.Switch.Location = new System.Drawing.Point(583, 0);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(120, 51);
            this.Switch.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Switch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 51);
            this.panel1.TabIndex = 6;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.Control;
            this.Next.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Next.BorderColor = System.Drawing.Color.Empty;
            this.Next.BorderRadius = 0;
            this.Next.BorderSize = 0;
            this.Next.Dock = System.Windows.Forms.DockStyle.Right;
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.Location = new System.Drawing.Point(60, 0);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(60, 51);
            this.Next.TabIndex = 1;
            this.Next.TextColor = System.Drawing.Color.White;
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.SystemColors.Control;
            this.Previous.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Previous.BorderColor = System.Drawing.Color.Empty;
            this.Previous.BorderRadius = 0;
            this.Previous.BorderSize = 0;
            this.Previous.Dock = System.Windows.Forms.DockStyle.Left;
            this.Previous.FlatAppearance.BorderSize = 0;
            this.Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous.ForeColor = System.Drawing.Color.Gainsboro;
            this.Previous.Location = new System.Drawing.Point(0, 0);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(60, 51);
            this.Previous.TabIndex = 0;
            this.Previous.TextColor = System.Drawing.Color.Gainsboro;
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Search.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Search.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.Search.BorderRadius = 8;
            this.Search.BorderSize = 1;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(570, 18);
            this.Search.Margin = new System.Windows.Forms.Padding(0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 41);
            this.Search.TabIndex = 0;
            this.Search.Text = "Vai";
            this.Search.TextColor = System.Drawing.Color.White;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.Warn);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Bar.ResumeLayout(false);
            this.Bar.PerformLayout();
            this.Switch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton Search;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Warn;
        private System.Windows.Forms.Panel Bar;
        private System.Windows.Forms.Panel Switch;
        private RJButton Next;
        private RJButton Previous;
        private System.Windows.Forms.Panel panel1;
    }
}

