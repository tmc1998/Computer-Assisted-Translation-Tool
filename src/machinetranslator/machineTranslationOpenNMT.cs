using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Deserializers;
using Newtonsoft.Json; 

namespace src.machinetranslator
{
    public class machineTranslationOpenNMT : machineTranslationBase
    {
        public string name = "<OpenNMT>"; 
        public override string getTargetLang(string sourceText)
        {
            urlAPI.openNMT url = new urlAPI.openNMT();
            var client = new RestClient(url.urlTranslatorOpenNMT);
            var request = new RestRequest("translate", Method.POST);
            request.RequestFormat = DataFormat.Json;
            List<openNMTPost> data = new List<openNMTPost>();
            openNMTPost post = new openNMTPost { src = sourceText, id = 0 };
            data.Add(post);
            string jsonData = JsonConvert.SerializeObject(data); 
            request.AddBody(jsonData);
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<List<List<OpenNMT>>>(response.Content);

            string targetText = null;

            foreach (var listResult in result)
            {
                foreach (var a in listResult)
                {
                    targetText = a.tgt; 
                }
            }

            return targetText + "\n" + this.name;  
        }
    }
}
