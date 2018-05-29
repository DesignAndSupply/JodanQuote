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

       
        public static SqlConnection GetConnection_userdatabase()
        {
            string connection_string = "Data Source = 192.168.0.150\\SQLEXPRESS; Initial Catalog = user_info; Integrated Security = False; User ID = sa; Password = Dodid1";
            SqlConnection user_database = new SqlConnection(connection_string);
            user_database.Open();
            return user_database;
        }

        
        public static SqlConnection GetConnection_dsl_flood_quote()
        {
            string connection_string = "Data Source = 192.168.0.150\\SQLEXPRESS; Initial Catalog = dsl_flood_quote; Integrated Security = False; User ID = sa; Password = Dodid1";
            SqlConnection dsl_flood_quote = new SqlConnection(connection_string);
            dsl_flood_quote.Open();
            return dsl_flood_quote;
        }
              
     

        public static SqlConnection GetConnection_dsl_fitting()
        {
            string connection_string = "Data Source = 192.168.0.150\\SQLEXPRESS; Initial Catalog = dsl_fitting; Integrated Security = False; User ID = sa; Password = Dodid1";
            SqlConnection dsl_fitting = new SqlConnection(connection_string);
            dsl_fitting.Open();
            return dsl_fitting;
        }

       
       
        public static SqlConnection GetConnection_jodan_quote()
        {
            string connection_string = "Data Source = 192.168.0.150\\SQLEXPRESS; Initial Catalog = jodan_quote; Integrated Security = False; User ID = sa; Password = Dodid1";
            SqlConnection jodan_quote = new SqlConnection(connection_string);
            jodan_quote.Open();
            return jodan_quote;
        }
        //-- code to make sure to close connection and dispose the object
        public static void Dispose_connection(SqlConnection sqlConnection)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
            sqlConnection.Dispose();
        }

    }
    

}
