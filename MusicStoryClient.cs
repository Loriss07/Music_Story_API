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
    public class MusicStoryClient
    {
        static RestClient http;
        private string URL { get; set; }
        private root Response;
        private root ImgResponse;
        private root AlbumResponse;
        private root LinkResponse;
        private root BioResponse;
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
        public async Task<root> NextArtists(string artistName)
        {
            string subURL = "/artist/search?name=" + artistName + "&page=" + Convert.ToString(Response.currentPage + 1);
            if (Response != null && Response.currentPage <= Response.pageCount)
                Response = await GetResponse(subURL);

            return Response;

        }
        public async Task<root> PreviousArtists(string artistName)
        {

            string subURL = "/artist/search?name=" + artistName + "&page=" + Convert.ToString(Response.currentPage - 1);
            if (Response != null && Response.currentPage > 0)
                Response = await GetResponse(subURL);


            return Response;
        }
        public async Task<root> NextAlbum(string ID_Album)
        {
            string subURL = $"/artist/{ID_Album}/albums?format=Album&page={Convert.ToString(Response.currentPage + 1)}";
            if (Response != null && Response.currentPage <= Response.pageCount)
                Response = await GetResponse(subURL);

            return Response;

        }
        public async Task<root> PreviousAlbum(string ID_Album)
        {

            string subURL = $"/artist/{ID_Album}/albums?format=Album&page={Convert.ToString(Response.currentPage - 1)}";
            if (Response != null && Response.currentPage > 0)
                Response = await GetResponse(subURL);


            return Response;
        }
        public async Task<root> GetArtist(string artistName)
        {
            
            string subURL = "/artist/search?name=" + artistName;
            Response = await GetResponse(subURL);
            return Response;
        }
        public async Task<int> GetImage(string artist_ID)
        {
            int success;
            string subURL = $"/artist/{artist_ID}/pictures";
            ImgResponse = await GetResponse(subURL);
            if (ImgResponse.data.Count() != 0)
            {
                RestRequest request = new RestRequest(ImgResponse.data[0].url, Method.Get);

                using (var file = File.Create($"./img/img{artist_ID}.png"))
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
        public async Task<root> GetAlbums(string artist_ID)
        {
            string subURL = $"/artist/{artist_ID}/albums?format=Album"; //Serve a restituire SOLO gli Album (no singoli, no EP...)
            AlbumResponse = await GetResponse(subURL);

            return AlbumResponse;
        }
        public async Task<root> GetLink(string artist_ID,string social)
        {
            string subURL = $"/artist/{artist_ID}/{social}"; //Serve a restituire SOLO gli Album (no singoli, no EP...)
            LinkResponse = await GetResponse(subURL);

            return LinkResponse;
        }
        public async Task<root> GetBiography(string artistID)
        {
            string subURL = $"artist/{artistID}/biographies";
            BioResponse = await GetResponse(subURL);
            return BioResponse;
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
