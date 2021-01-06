using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.Linq;

namespace DataAccessLibrary.Internal.DataAccess
{
    internal class SqlDataAccess
    {
        public static String ConnectionStringName { get; set; } = "GymDB";

        public List<T> LoadData<T, U>(String sql, U parameters)
        {
            String connectionString = Helper.CnnVal(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var data = connection.Query<T>(sql, parameters);
                return data.ToList();
            }
        }

        public void SaveData<T>(String sql, T parameters)
        {
            string connectionString = Helper.CnnVal(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sql, parameters);
            }
        }
    }
}
