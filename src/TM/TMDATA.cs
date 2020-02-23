using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.TM
{
    public class TMDATA
    {
        public List<tm> LoadTM()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<tm>("select * from TM", new DynamicParameters());
                return output.ToList();
            }
        }
        public static string LoadConnectionString(string id = "TMDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
