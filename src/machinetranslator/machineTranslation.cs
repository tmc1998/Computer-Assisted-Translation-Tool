using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.client; 

namespace src.machinetranslator
{
    public abstract class machineTranslationBase
    {
        public string url;
        public string key;
        public string source;
        public string target;
        public Client client = new Client();
        public bool isActive = false; 
        public void setKey(string Key)
        {
            key = Key;  
        }
        public abstract machineTranslationResult getTargetLang(string sourceText); 
    }
}
