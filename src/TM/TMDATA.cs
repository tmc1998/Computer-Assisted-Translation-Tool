using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.segment; 

namespace src.TM
{
    public class TMDATA
    {
        public List<tm> LoadTM(string tableTMName)
        {
            string query = string.Format("select * from '{0}'",tableTMName); 
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<tm>(query, new DynamicParameters());
                return output.ToList();
            }
        }
        public List<tablename> getTableName()
        {
            string query = "SELECT name FROM sqlite_master " +
                   "WHERE type = 'table'" +
                   "ORDER BY 1";
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<tablename>(query, new DynamicParameters());
                return output.ToList(); 
            }
        }
        public int excuteNonQuery(string query)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                using (IDbCommand cmd = new SQLiteCommand(cnn))
                {
                    cmd.CommandText = query;
                    int result = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return result;
                }
            }
        }
        public static string LoadConnectionString(string id = "TMDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
