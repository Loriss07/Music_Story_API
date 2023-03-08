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
        public Form1()
        {
            string ConsumerKey = "a406b97e8c4536f215d8610e5aed3e36c0825cca";
            string ConsumerSecret = "d4558644cdb6e8db2287627751bfa7e9eea577ed";
            string AccessToken = "1afcbd4add8503ab72afa2068957cfab4df2bbbc";
            string TokenSecret = "4e42f541ce1a634e26ca8590ccc778d75d281b7e";
            Client = new HTTPClient("http://api.music-story.com/",ConsumerKey,ConsumerSecret,AccessToken,TokenSecret);
            InitializeComponent();

            Cerca();
        }
        public async void Cerca()
        {
            object a = await Client.GetArtist(SearchBar.Text);
            root res = a as root;
            MessageBox.Show(res.data+"");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Cerca();
        }
    }
}
