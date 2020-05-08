using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.machinetranslator
{
    public class Mymemory
    {
        public ResponseData responseData { get; set; }
        public string quotaFinished { get; set; }
        public string mtLangSupported { get; set; }
        public string responseDetails { get; set; }
        public string responseStatus { get; set; }
        public string responderId { get; set; }
        public string exception_code { get; set; }

        public List<Match> matches { get; set; }
        public class ResponseData
        {
            public string translatedText { get; set; }
            public string match { get; set; }

        }
        public class Match
        {
            public string id { get; set; }
            public string segment { get; set; }
            public string translation { get; set; }
            public string source { get; set; }
            public string target { get; set; }
            public string quality { get; set; }
            public string reference { get; set; }
            public string usage_count { get; set; }
            public string subject { get; set; }
            public string created_by { get; set; }
            public string last_updated_by { get; set; }
            public string create_date { get; set; }
            public string last_update_date { get; set; }
            public string match { get; set; }
        }
    }
}
