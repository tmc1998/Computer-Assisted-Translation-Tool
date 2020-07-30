using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace src.TM
{
    public class tmonlinedata
    {
        public List<resultTMOnline> getResults(string src)
        {
            tmonlineURL url = new tmonlineURL(); 
            var client = new RestClient();
            var request = new RestRequest(String.Format(url.url, src));
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
            var content = JsonConvert.DeserializeObject<tmonline>(response.Content);
            return content.result;
        }
    }
}
