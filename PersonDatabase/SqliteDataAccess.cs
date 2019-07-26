using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace PersonDatabase
{
    public class SqliteDataAccess
    {
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection cnn =  new SQLiteConnection(LoadConnectionString())) //fail safe to make sure the database connection is closed in case of quitting or crashing //
            {
                var output = cnn.Query<PersonModel>("select * from Person", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePerson(PersonModel person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) //samesies from the same above using statement // 
            {
                cnn.Execute("insert into Person (FirstName, LastName, ImageNumber, School) values (@FirstName, @LastName, @ImageNumber, @School)", person);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
