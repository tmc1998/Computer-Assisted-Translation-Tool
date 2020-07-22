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
        public string name = "Mymemory API";
        public string fail = "Mymemory không hoạt động hãy xem lại kết nối mạng";
        public string limited = "Đã quá 5 trăm từ";
        public override machineTranslationResult getTargetLang(string sourceText)
        {
            urlAPI.Mymemory url = new urlAPI.Mymemory();
            client.requestAPI(String.Format(url.urlTranslatorMymemory, sourceText, source, target)); 
            var contentJson = client.getContentFromResopne();
            var content = JsonConvert.DeserializeObject<Mymemory>(contentJson);
            machineTranslationResult Result = new machineTranslationResult();
            if (sourceText.Length >= 500)
            {
                Result.fail = true;
                Result.failText = fail;
            }
            else
            {
                if (content != null)
                {
                    Result.src = sourceText;
                    Result.tag = content.responseData.translatedText;
                    Result.type = name;
                    Result.fail = false;
                    Result.score = float.Parse(content.responseData.match) * 100;
                }
                else
                {
                    Result.fail = true;
                    Result.failText = fail;
                }
            }
            return Result;
        }
    }
}
