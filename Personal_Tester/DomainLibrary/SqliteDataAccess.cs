using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace DomainLibrary
{
    public class SqliteDataAccess
    {
        public static List<LanguageModel> GetListLanguage()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<LanguageModel>("select * from Language", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }

    public class LanguageModel
    {
        public int ID { get; set; }

        public string English { get; set; }

        public string Vietnamese { get; set; }
    }
}
