using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStory
{
    public partial class CartaAlbum : UserControl
    {
        private string album_name;
        private string genere;
        private string album_id;
        private int valutazione;
        public CartaAlbum()
        {
            InitializeComponent();
        }

        public string Album_name { get => album_name; set => album_name = value; }
        public string Genere { get => genere; set => genere = value; }
        public string Album_id { get => album_id; set => album_id = value; }
        public int Valutazione { get => valutazione; set => valutazione = value; }
    }
}
