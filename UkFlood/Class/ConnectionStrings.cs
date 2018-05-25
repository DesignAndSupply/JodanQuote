using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Connection
{
    class ConnectionClass
    {



        public static SqlConnection GetConnection_orderdatabase()
        {
            string connection_string = "Data Source = 192.168.0.150\\SQLEXPRESS;Initial Catalog = order_database; Integrated Security = False; User ID = sa; Password=Dodid1;";
            SqlConnection order_database = new SqlConnection(connection_string);
            order_database.Open();
            return order_database;
        }

        //-- code to make sure to close connection and dispose the object
        public static void Dispose_orderdatabase(SqlConnection sqlConnection)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
            sqlConnection.Dispose();
        }
        public static SqlConnection GetConnection_userdatabase()
        {
            string connection_string = "Data Source = 192.168.0.150\\SQLEXPRESS; Initial Catalog = user_info; Integrated Security = False; User ID = sa; Password = Dodid1";
            SqlConnection user_database = new SqlConnection(connection_string);
            user_database.Open();
            return user_database;
        }

        //-- code to make sure to close connection and dispose the object
        public static void Dispose_userdatabase(SqlConnection sqlConnection)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
            sqlConnection.Dispose();
        }




    }
}
