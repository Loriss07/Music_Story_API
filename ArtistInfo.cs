using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStory
{
    public partial class ArtistInfo : Form
    {
        private MusicStoryClient Client;
        private FileStream ArtistImage;
        private string ID;
        internal ArtistInfo(string Artist_ID, string ArtistName, MusicStoryClient Client)
        {
            InitializeComponent();
            this.Client = Client;
            ID = Artist_ID;
            Artist_Name.Text = ArtistName;
            AlbumInfo.Hide();
            //LoadSocial();
            //LoadBiography();
            SetImage();
            LoadAlbum();
        }

        private async void LoadBiography()
        {
            root bio = await Client.GetBiography(ID);

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
            Genre.Text = await Client.GetGenre(ID);
        }
        private async Task<string> Social(string social)
        {
            string canale = "";
            root URL = await Client.GetLink(ID, social);
            if (URL.data.Count() > 0)
                canale = URL.data[0].url;

            return canale;
        }
        private async void LoadAlbum()
        {
            root Risposta = await Client.GetAlbums(ID);
            Album(Risposta);
            LoadAlbumImages();
        }

        private void SetImage()
        {
            using (ArtistImage = System.IO.File.Open($"./img/artist/img{ID}.png",
                System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite))
                {
                    ArtistPFP.Image = new Bitmap(ArtistImage);
                    ArtistImage.Close();
                }

        }
        private void Album(root Risposta)
        {
            
            if (Risposta != null)
            {
                for (int i = 0; i < Risposta.data.Count(); i++)
                {
                    CartaAlbum album = new CartaAlbum();
                    album.Album_name = Risposta.data[i].title;
                    album.Album_id = Risposta.data[i].id;
                    album.Data_Pubblicazione = DateTime.Parse(Risposta.data[i].release_date);
                    album.Click += Album_Click;
                    Albums.Controls.Add(album);

                }
            }
        }

        private void Album_Click(object sender, EventArgs e)
        {
            AlbumInfo.Show();
            CartaAlbum album = sender as CartaAlbum;
            Titolo.Text = album.Album_name;
            Data.Text = album.Data_Pubblicazione.ToShortDateString();
            valVoto.Text = album.Valutazione + '\u2B50';

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

        private async void LoadAlbumImages()
        {
            foreach (CartaAlbum control in Albums.Controls)
            {
                string recording_ID = await Client.GetRelease(control.Album_id);
                int img = await Client.GetImage(recording_ID, "release");
                if (img == 1)
                {
                    await Client.DownloadImages(control.Album_id, "release");
                    using (FileStream image = File.Open($"./img/release/img{control.Album_id}.png", FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        control.ImgAlbum.Image = new Bitmap(image);
                        image.Close();
                    }
                }

            }
        }

    }
}
