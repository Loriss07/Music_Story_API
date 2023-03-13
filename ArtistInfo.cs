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
    public partial class ArtistInfo : Form
    {
        private MusicStoryClient client;
        private Image ArtistImage;
        private string ArtistName;
        private uint ID;
        internal ArtistInfo(uint Artist_ID, ref MusicStoryClient Client)
        {
            InitializeComponent();
            Youtube.Image = Properties.Resources.social;
            Twitter.Image = Properties.Resources.twitter;
            Instagram.Image = Properties.Resources.instagram;
            client = Client;
            ID = Artist_ID;
        }

        private void SetImage(string path)
        {
            System.IO.File.Open(path,System.IO.FileMode.Open,System.IO.FileAccess.Read,System.IO.FileShare.Read);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


    }
}
