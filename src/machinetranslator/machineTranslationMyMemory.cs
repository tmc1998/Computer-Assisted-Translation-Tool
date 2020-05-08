using Newtonsoft.Json;
using src.client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.machinetranslator
{
    public class machineTranslationMyMemory : machineTranslationBase
    {
        public string name = "<Mymemory API>";
        public override string getTargetLang(string sourceText)
        {
            urlAPI.Mymemory url = new urlAPI.Mymemory();
            client.requestAPI(String.Format(url.urlTranslatorMymemory, sourceText, source, target)); 
            var contentJson = client.getContentFromResopne();
            var content = JsonConvert.DeserializeObject<Mymemory>(contentJson);
            string targetText = content.responseData.translatedText + "\n" + name;
            return targetText;
        }
    }
}
