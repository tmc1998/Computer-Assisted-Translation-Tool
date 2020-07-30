using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Deserializers;
using Newtonsoft;
using Newtonsoft.Json;
using src.TM;

namespace src.semanticsimilarity
{
    class semanticSimilarityAPI
    {
        private string url = "http://127.0.0.1:3000/";
        private string restRequest = "predict"; 
        public List<semanticSimilarity> getResultPredict(List<tm> tmdata,string srcText)
        {
            if (tmdata.Count > 0)
            {
                semanticSimilarityPost posts = new semanticSimilarityPost();
                posts = processData(tmdata, srcText);
                var client = new RestClient(url);
                var request = new RestRequest(restRequest, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(posts);
                var response = client.Execute(request);
                var result = JsonConvert.DeserializeObject<List<semanticSimilarity>>(response.Content);
                return result;
            }
            else
            {
                return null;
            }
        }
        public semanticSimilarityPost processData(List<tm> tmdata, string srcText)
        {
            semanticSimilarityPost posts = new semanticSimilarityPost();
            posts.text = srcText;
            posts.data = new List<semanticSimilarityPost.segment>(); 
            foreach(tm tm in tmdata)
            {
                if (tm.Source.Trim() != srcText.Trim())
                {
                    semanticSimilarityPost.segment segment = new semanticSimilarityPost.segment()
                    {
                        src = tm.Source,
                        tag = tm.Target
                    };
                    posts.data.Add(segment);
                }
            }
            return posts; 
        }
    }
}
