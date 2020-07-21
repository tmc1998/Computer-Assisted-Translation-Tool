using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace src.TB
{
    public class wikimedia
    {
        public string lang { get; set; }
        public string getResult(string text)
        {
            wikiUrl urlWiki = new wikiUrl();
            string url = null;
            var client = new RestClient();
            var request = new RestRequest(String.Format(urlWiki.wikiURL,lang,text), Method.GET);
            var response = client.Execute(request).Content;
            JArray jArray = JArray.Parse(response);
            var a = jArray[3].ToArray();
            if(a.Count() > 0)
            {
                url = a[0].ToString();
            }
            if(url != null)
            {
                return url;
            }
            return null;
        }
    }
}
