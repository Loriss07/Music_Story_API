using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Net;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth;
using RestSharp.Serializers.Xml;

namespace MusicStory
{
    internal class HTTPClient
    {
        static RestClient http;
        private string URL { get; set; }
        public HTTPClient()
        {
            URL = "";
            http = new RestClient(URL);
        }
        public HTTPClient(string destURL)
        {
            URL = destURL;
            http = new RestClient(URL);
        }
        public HTTPClient(string destURL,string consumerKey, string consumerSecret, string accessToken, string tokenSecret)
        {
            URL = destURL;
            http = new RestClient(URL);
            http.Authenticator = OAuth1Authenticator.ForAccessToken(consumerKey, consumerSecret, accessToken, 
                            tokenSecret, OAuthSignatureMethod.HmacSha1);
        }
        public async Task<object> GetArtist(string artistName)
        {
            string subURL = "/artist/search?name=" + artistName;
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
                byte a = Convert.ToByte("C'è stato un errore :" + ex.Message);
                return a;
            }

          
        }
    }
}
