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
    public partial class Carta : UserControl
    {
        private uint artistID;
        private string nome;
        public Carta()
        {
            InitializeComponent();
            Picture.Image = Properties.Resources.music_player;
        }

        public uint ArtistID { get => artistID; set => artistID = value; }
        public string Nome { get => nome; set {
                nome = value;
                ArtistName.Text = nome;
            }  
        }

        private void Info_Click(object sender, EventArgs e)
        {

        }
    }
}
