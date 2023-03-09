using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace MusicStory
{
    public partial class Form1 : Form
    {
        private HTTPClient Client;
        private List<Carta> Result_List;
        private int artistID;
        public Form1()
        {
            Result_List = new List<Carta>();
            string ConsumerKey = "a406b97e8c4536f215d8610e5aed3e36c0825cca";
            string ConsumerSecret = "d4558644cdb6e8db2287627751bfa7e9eea577ed";
            string AccessToken = "1afcbd4add8503ab72afa2068957cfab4df2bbbc";
            string TokenSecret = "4e42f541ce1a634e26ca8590ccc778d75d281b7e";
            Client = new HTTPClient("http://api.music-story.com/",ConsumerKey,ConsumerSecret,AccessToken,TokenSecret);
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
                object a = await Client.GetArtist(SearchBar.Text);
                root Risposta = a as root;
                
                MessageBox.Show(Risposta.data[0].name);
                int x = 16;
                int y = 90;
                for (int i = 0; i < Risposta.count; i++)
                {
                    Carta carta = new Carta();
                    Result_List.Add(carta);
                    carta.ArtistName.Text = Risposta.data[i].name;
                    carta.Location = new Point(x, y);
                    Controls.Add(carta);
                    
                    y += 100;
                }

            }
            else
            {
                Search.BorderColor = Color.OrangeRed;
                Search.BackColor = Color.Tomato;
                Warn.Text = "Inserire un nome";
            }
            
        }
        private void Search_Click(object sender, EventArgs e)
        {
            foreach (Carta item in Result_List)
            {
                Controls.Remove(item);
            }
            Result_List.Clear();
            Cerca();
        }
        private void Previous_Click(object sender, EventArgs e)
        {
            Client.PreviousPage();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            Avanti();
        }
        public async void Avanti()
        {
            object a = await Client.NextPage(SearchBar.Text);
            root res = a as root;
            MessageBox.Show(res.currentPage.ToString());
        }
    }
}
