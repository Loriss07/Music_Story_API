using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStory
{
    public partial class ArtistInfo : Form
    {
        private MusicStoryClient client;
        private FileStream ArtistImage;
        private string ID;
        internal ArtistInfo(string Artist_ID,string ArtistName, MusicStoryClient Client)
        {
            InitializeComponent();
            client = Client;
            ID = Artist_ID;
            Artist_Name.Text = ArtistName;
            LoadSocial();
            LoadBiography();
            SetImage();
            Album();
        }

        private async void LoadBiography()
        {
            root bio = await client.GetBiography(ID);
            
            for (int i = 0; i < bio.data.Count(); i++)
            {
                if (bio.data[i].lang == "EN")
                    Biography.DocumentText = bio.data[i].header;
            }
                
                
        }

        private async void LoadSocial()
        {
            Youtube.Image = Properties.Resources.social;
            Twitter.Image = Properties.Resources.twitter;
            Instagram.Image = Properties.Resources.instagram;
            Youtube.Tag = await Social("youtubechannel");
            Twitter.Tag = await Social("twitter");
            Instagram.Tag = await Social("instagram");
        }
        private async Task<string> Social(string social)
        {
            string canale = "";
            root URL = await client.GetLink(ID, social);
            if (URL.data.Count() > 0)
                canale = URL.data[0].url;

            return canale;
        }

        private void SetImage()
        {
            using(ArtistImage = System.IO.File.Open($"./img/img{ID}.png",
                System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite))
            {
                ArtistPFP.Image = new Bitmap(ArtistImage);
                ArtistImage.Close();
            }
            
        }
        private async void Album()
        {
            root Risposta = await client.GetAlbums(ID);
            if (Risposta != null)
            {
                for (int i = 0; i < Risposta.data.Count(); i++)
                {
                    CartaAlbum album = new CartaAlbum();
                    album.Album_name = Risposta.data[i].title;
                    album.Album_id = Risposta.data[i].id;

                    Albums.Controls.Add(album);
                }
                foreach (var album in Risposta.data)
                {
                    MessageBox.Show(album.title);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArtistImage.Close();
            ArtistImage.Dispose();
            ArtistPFP.Image.Dispose();
            Close();
        }

        private void Youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Youtube.Tag.ToString());
        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Twitter.Tag.ToString());
        }

        private void Instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Instagram.Tag.ToString());
        }

        private void picturePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
