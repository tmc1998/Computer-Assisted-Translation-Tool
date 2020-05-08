using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.language; 

namespace src.language
{
    public class LanguageList
    {
        private List<Language> languageList;
        public LanguageList()
        {
            languageList = new List<Language>()
            {
                new Language(){ name = "vi"},
                new Language() { name = "en"}
            };
        }
        public List<Language> getListLanguage()
        {
            return languageList; 
        }
    }
}
