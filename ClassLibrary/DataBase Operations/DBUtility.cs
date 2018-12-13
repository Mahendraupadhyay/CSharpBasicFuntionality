using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ClassLibrary.DataBase_Operations
{
    class DBUtility
    {
       internal SqlConnection SqlConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
