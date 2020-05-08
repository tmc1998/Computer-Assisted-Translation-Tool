using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp; 
namespace src.client
{
    public class Client
    {
        public RestClient client;
        public RestRequest request;
        public IRestResponse response; 
        public Method methodGet = Method.GET; 

        public Client()
        {
            client = new RestClient
            {
            };
            request = new RestRequest()
            {
                Method = methodGet
            }; 
        }
        public void requestAPI(string url)
        {
            client.BaseUrl = new Uri(url); 
            response = client.Execute(request);
        }

        public string getContentFromResopne()
        {
            return response.Content; 
        }

    }
}
