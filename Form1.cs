using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MusicStory
{
    public partial class CercaArtista : Form
    {
        public static MusicStoryClient Client;
        private List<CartaArtista> Result_List;
        private string nome;
        private int pagina;
        private int risultati;
        public CercaArtista()
        {
            Result_List = new List<CartaArtista>();
            string ConsumerKey = "a406b97e8c4536f215d8610e5aed3e36c0825cca";
            string ConsumerSecret = "d4558644cdb6e8db2287627751bfa7e9eea577ed";
            string AccessToken = "1afcbd4add8503ab72afa2068957cfab4df2bbbc";
            string TokenSecret = "4e42f541ce1a634e26ca8590ccc778d75d281b7e";
            Client = new MusicStoryClient("http://api.music-story.com/",ConsumerKey,ConsumerSecret,AccessToken,TokenSecret);
            Bitmap Back = new Bitmap (Properties.Resources.left_arrow, new Size(32,32));
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

                    root Risposta = await Client.GetArtist(SearchBar.Text);
                    Mostra(Risposta);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Errore! Magari non sei connesso ad Internet...\n" + ex.Message);
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
            pagina = (int)res.currentPage;
            Pulisci();
            Mostra(res);
        }
        public async void Indietro()
        {
            root res = await Client.PreviousArtists(nome);
            pagina = (int)res.currentPage;
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
        private async void Mostra(root Risposta)
        {
            
            for (int i = 0; i < Risposta.data.Length; i++)
            {
                
                CartaArtista carta = new CartaArtista();
                Result_List.Add(carta);
                carta.Nome = Risposta.data[i].name;
                carta.ArtistID = Risposta.data[i].id;
                Page.Text = Convert.ToString(Risposta.currentPage);
                int img = await Client.GetImage(carta.ArtistID,"artist");
                if (img == 1)
                {
                    using (FileStream image = File.Open($"./img/artist/img{carta.ArtistID}.png", FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        carta.ImgArtista.Image = new Bitmap(image);
                        image.Close();
                    }
                } 
                Results.Controls.Add(carta);
            }
            Page.Text = $"Pagina {Risposta.currentPage} di {Risposta.pageCount}; {Risposta.count} risultati trovati";
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteFiles();
        }

    }
}
