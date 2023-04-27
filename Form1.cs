using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace MusicStory
{
    public partial class CercaArtista : Form
    {
        public static MusicStoryClient Client;
        private List<CartaArtista> Result_List;
        private string nome;
        public CercaArtista()
        {
            Result_List = new List<CartaArtista>();
            string ConsumerKey = "a7a0cce7e59cd89b7f3bdb9a55a4f39dd860ef1c";
            string ConsumerSecret = "4cc900156089ae4480dfc7ed9ed719cb49556fa2";
            string AccessToken = "b11315d5cb40933ecb5c4cc695c92b03608ddf03";
            string TokenSecret = "44b16e03e31980d855f03179e2f0f4627377477c";
            Client = new MusicStoryClient("http://api.music-story.com/", ConsumerKey, ConsumerSecret, AccessToken, TokenSecret);
            Bitmap Back = new Bitmap(Properties.Resources.left_arrow, new Size(32, 32));
            Bitmap Forth = new Bitmap(Properties.Resources.right_arrow, new Size(32, 32));

            InitializeComponent();
            Previous.Image = Back;
            Next.Image = Forth;

        }
        public async void Cerca()
        {
            if (SearchBar.Text.Length != 0)
            {
                Search.BorderColor = Color.CornflowerBlue;
                Search.BackColor = Color.LightSteelBlue;

                try
                {
                    UTF8Encoding encoding = new UTF8Encoding();
                    
                    root Risposta = await Client.GetArtist(SearchBar.Text);
                    Mostra(Risposta);
                    LoadImages();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore!...\n" + ex.Message);
                }
            }
            else
            {
                Search.BorderColor = Color.OrangeRed;
                Search.BackColor = Color.Tomato;
                Warn.Text = "Inserire un nome";
            }

        }

        private void Pulisci()
        {
            if (Result_List.Count != 0)
            {

                Results.Controls.Clear();
                foreach (CartaArtista item in Result_List)
                {
                    item.ImgArtista.Image.Dispose();
                }
                DeleteFiles();
                Result_List.Clear();
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            nome = SearchBar.Text;
            Pulisci();
            Cerca();
        }
        private void Previous_Click(object sender, EventArgs e)
        {
            Indietro();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            Avanti();
        }
        public async void Avanti()
        {

            object a = await Client.NextArtists(nome);
            root res = a as root;
            Pulisci();
            Mostra(res);
        }
        public async void Indietro()
        {
            root res = await Client.PreviousArtists(nome);
            Pulisci();
            Mostra(res);
        }

        private void DeleteFiles()
        {

            DirectoryInfo di = new DirectoryInfo("./img");
            Result_List.Clear();
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        private void Mostra(root Risposta)
        {
            
            for (int i = 0; i < Risposta.data.Length; i++)
            {

                CartaArtista carta = new CartaArtista();
                Result_List.Add(carta);
                carta.Nome = Risposta.data[i].name;
                carta.ArtistID = Risposta.data[i].id;
                Page.Text = Convert.ToString(Risposta.currentPage);
                Results.Controls.Add(carta);
            }
            Page.Text = $"Pagina {Risposta.currentPage} di {Risposta.pageCount}; {Risposta.count} risultati trovati";
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteFiles();
        }

        private async void LoadImages()
        {
            foreach (CartaArtista control in Results.Controls)
            {
                int img = await Client.GetImage(control.ArtistID, "artist");
                if (img == 1)
                {
                    await Client.DownloadImages(control.ArtistID, "artist");
                    using (FileStream image = File.Open($"./img/artist/img{control.ArtistID}.png", FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        control.ImgArtista.Image = new Bitmap(image);
                        image.Close();
                    }
                }
                
            }
        }
    }
}
