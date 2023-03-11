using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using RestSharp;
using RestSharp.Extensions;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth;
using RestSharp.Serializers.Xml;

namespace MusicStory
{
    internal class MusicStoryClient
    {
        static RestClient http;
        private string URL { get; set; }
        private root Response;
        public MusicStoryClient()
        {
            URL = "";
            http = new RestClient(URL);
        }
        public MusicStoryClient(string destURL)
        {
            URL = destURL;
            http = new RestClient(URL);
        }
        public MusicStoryClient(string destURL,string consumerKey, string consumerSecret, string accessToken, string tokenSecret)
        {
            URL = destURL;
            http = new RestClient(URL);
            http.Authenticator = OAuth1Authenticator.ForAccessToken(consumerKey, consumerSecret, accessToken, 
                            tokenSecret, OAuthSignatureMethod.HmacSha1);
        }
        
        public async Task<object> GetArtist(string artistName)
        {
            
            string subURL = "/artist/search?name=" + artistName;
            Response = await GetResponse(subURL);
            /*
            var Deserializer = new DotNetXmlDeserializer();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            RestRequest request = new RestRequest(subURL, Method.Get);
            RestResponse response = await http.GetAsync(request);
            
            try
            {
                root result = Deserializer.Deserialize<root>(response);
                Response = result;
                return result;
            }
            catch (Exception ex)
            {
                byte a = Convert.ToByte("C'è stato un errore :" + ex.Message);
                return a;
            }*/
            return Response;
         
        }
        public async Task<object> NextPage(string artistName)
        {
            string subURL = "/artist/search?name=" + artistName + "&page=" + Convert.ToString(Response.currentPage + 1);
            if (Response != null && Response.currentPage <= Response.pageCount)
                Response = await GetResponse(subURL);

            return Response;
                
        }
        public async Task<object> PreviousPage()
        {
            return new object();
        }

        public async Task<int> GetImage(uint artist_ID,int index)
        {
            int success;
            string subURL = $"/artist/{artist_ID}/pictures";
            Response = await GetResponse(subURL);
            if (Response.data.Count() != 0)
            {
                RestRequest request = new RestRequest(Response.data[0].url, Method.Get);

                using (var file = File.Create($"./img/img{index}.png"))
                using (BinaryWriter image = new BinaryWriter(file))
                {
                    image.Write(http.DownloadData(request));
                }
                success = 1;
            }
            else
                success = -1;
            return success; 
        }
        private async Task<root> GetResponse(string subURL)
        {
            var Deserializer = new DotNetXmlDeserializer();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            RestRequest request = new RestRequest(subURL, Method.Get);
            RestResponse response = await http.GetAsync(request);
            root result;
            try
            {
                result = Deserializer.Deserialize<root>(response);
                Response = result;
                return result;
            }
            catch (Exception ex)
            {
                result = null;
                
            }

            return result;
        }
    }
}
