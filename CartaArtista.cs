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
    public partial class CartaArtista : UserControl
    {
        private string artistID;
        private string nome;
        public CartaArtista()
        {
            InitializeComponent();
            ImgArtista.Image = Properties.Resources.music_player;
        }
        public string ArtistID { get => artistID; set => artistID = value; }
        public string Nome
        {
            get => nome; set
            {
                nome = value;
                NomeArtista.Text = nome;
            }
        }

        private void InfoCarta_Click(object sender, EventArgs e)
        {
            ArtistInfo f = new ArtistInfo(ArtistID, nome, CercaArtista.Client);
            f.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            InfoCarta_Click(sender, e);
        }

        private void ImgArtista_Click(object sender, EventArgs e)
        {
            InfoCarta_Click(sender, e);
        }
    }
}
