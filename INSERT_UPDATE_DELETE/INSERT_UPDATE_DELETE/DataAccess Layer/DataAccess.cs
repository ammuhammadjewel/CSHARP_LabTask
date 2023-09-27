using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using INSERT_UPDATE_DELETE.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace INSERT_UPDATE_DELETE.DataAccess_Layer
{
    internal class DataAccess : IDisposable
    {
        protected SqlConnection connection;
        protected SqlCommand command;

        public DataAccess()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings[""].ConnectionString);
            connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteReader();

        }

        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
