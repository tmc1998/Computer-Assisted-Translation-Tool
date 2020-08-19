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
        public string name = "OpenNMT";
        public string fail = "OpenNMT không hoạt động hãy xem lại kết nối mạng"; 
        public override machineTranslationResult getTargetLang(string sourceText)
        {
            urlAPI.openNMT url = new urlAPI.openNMT();
            var client = new RestClient(url.urlTranslatorOpenNMT);
            var request = new RestRequest("translate", Method.POST);
            request.RequestFormat = DataFormat.Json;
            List<openNMTPost> data = new List<openNMTPost>();
            openNMTPost post = null;
            if (source == "vi" && target == "en")
            {
                post = new openNMTPost { src = sourceText, id = 1 };
            }
            if (source == "en" && target == "vi")
            {
                post = new openNMTPost { src = sourceText, id = 0 };
            }
            data.Add(post);
            string jsonData = JsonConvert.SerializeObject(data); 
            request.AddBody(jsonData);
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<List<List<OpenNMT>>>(response.Content);
            machineTranslationResult Result = new machineTranslationResult();
            if (result != null)
            {
                foreach (var listResult in result)
                {
                    foreach (var a in listResult)
                    {
                        Result.src = a.src;
                        Result.tag = a.tgt;
                        Result.fail = false;
                        Result.score = float.Parse(a.pred_score);
                        Result.type = name; 
                    }
                }
            }
            else
            {
                Result.fail = true;
                Result.failText = fail; 
            }
            return Result;
        }
    }
}
