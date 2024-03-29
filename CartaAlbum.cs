﻿using System;
using System.Windows.Forms;

namespace MusicStory
{
    public partial class CartaAlbum : UserControl
    {
        private string album_name;
        private string album_id;
        private string valutazione;
        private DateTime data_Pubblicazione;

        public CartaAlbum()
        {
            InitializeComponent();
            foreach (Control c in Controls)
            {
                c.Click += (sender, e) => { OnClick(e); };
            }
        }

        public string Album_name
        {
            get => album_name; set
            {
                album_name = value;
                AlbumName.Text = value;
            }
        }

        public string Album_id { get => album_id; set { album_id = value; } }

        public string Valutazione { get => valutazione; set => valutazione = value; }
        public DateTime Data_Pubblicazione { get => data_Pubblicazione; set => data_Pubblicazione = value; }


    }
}
