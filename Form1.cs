using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;

namespace MusicStory
{
    public partial class Form1 : Form
    {
        private MusicStoryClient Client;
        private List<Carta> Result_List;
        private string nome;
        private uint artistID;
        public Form1()
        {
            Result_List = new List<Carta>();
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
            /*ArtistInfo f = new ArtistInfo(artistID, ref Client);
            f.Show();*/
        }
        public async void Cerca()
        {
            if (SearchBar.Text.Length != 0)
            {
                Search.BorderColor = Color.CornflowerBlue;
                Search.BackColor = Color.LightSteelBlue;
                
                object a = await Client.GetArtist(SearchBar.Text);
                root Risposta = a as root;
                Mostra(Risposta);
                //MessageBox.Show(Risposta.data[0].name);
                
                
            }
            else
            {
                Search.BorderColor = Color.OrangeRed;
                Search.BackColor = Color.Tomato;
                Warn.Text = "Inserire un nome";
            }
            
        }

        private void Carta_Click(object sender, EventArgs e)
        {
            
            Carta artist = sender as Carta;
            artistID = artist.ArtistID;
            throw new NotImplementedException();
            
        }
        private void Pulisci()
        {
            if (Result_List.Count != 0)
            {


                foreach (Carta item in Result_List)
                {
                    item.Picture.Image.Dispose();
                    Results.Controls.Remove(item);

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

            object a = await Client.NextPage(nome);
            root res = a as root;
            Pulisci();
            Mostra(res);
        }
        public async void Indietro()
        {

            object a = await Client.PreviousPage(nome);
            root res = a as root;
            Pulisci();
            Mostra(res);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) { DeleteFiles();}
        private void DeleteFiles()
        {
            DirectoryInfo di = new DirectoryInfo("./img");
            foreach (Carta item in Result_List)
                item.Picture.Image.Dispose();

            Result_List.Clear();

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        private async void Mostra(root Risposta)
        {
            
            for (int i = 0; i < Risposta.data.Length; i++)
            {
                Carta carta = new Carta();
                Result_List.Add(carta);
                carta.Nome = Risposta.data[i].name;
                carta.ArtistID = Risposta.data[i].id;
                carta.Click += new EventHandler(Carta_Click);
                Page.Text = Convert.ToString(Risposta.currentPage);
                int img = await Client.GetImage(carta.ArtistID, i);

                if (img == 1)
                    carta.Picture.Image = new Bitmap($"./img/img{i}.png");

                Results.Controls.Add(carta);

            }
        }
    }
}
