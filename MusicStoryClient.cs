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
        private root ImgResponse;
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
        public async Task<root> NextPage(string artistName)
        {
            string subURL = "/artist/search?name=" + artistName + "&page=" + Convert.ToString(Response.currentPage + 1);
            if (Response != null && Response.currentPage <= Response.pageCount)
                Response = await GetResponse(subURL);

            return Response;

        }
        public async Task<root> PreviousPage(string artistName)
        {

            string subURL = "/artist/search?name=" + artistName + "&page=" + Convert.ToString(Response.currentPage - 1);
            if (Response != null && Response.currentPage <= Response.pageCount)
                Response = await GetResponse(subURL);


            return Response;
        }
        public async Task<root> GetArtist(string artistName)
        {
            
            string subURL = "/artist/search?name=" + artistName;
            Response = await GetResponse(subURL);
            
            return Response;
         
        }
        public async Task<int> GetImage(uint artist_ID,int index)
        {
            int success;
            string subURL = $"/artist/{artist_ID}/pictures";
            ImgResponse = await GetResponse(subURL);
            if (ImgResponse.data.Count() != 0)
            {
                RestRequest request = new RestRequest(ImgResponse.data[0].url, Method.Get);

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
        public async Task<root> GetAlbums(uint artist_ID)
        {
            string subURL = $"/artist/{artist_ID}/albums?format=Album"; //Serve a restituire SOLO gli Album (no singoli, no EP...)
            return new root();
        }
        public async Task<root> GetLink(uint artist_ID)
        {
            return new root();
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
