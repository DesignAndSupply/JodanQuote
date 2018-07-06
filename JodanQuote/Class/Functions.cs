using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Data.SqlClient;
using System.Data;
using Connection;
using values;




namespace function
{

    class Functionsclass
    {


        public static List<DateTime> listofweekdays = new List<DateTime>();
        public static List<String> Emailrecipients = new List<string>();


      //  DataSet ds_skins = new DataSet();
        public static DataTable dt_skins = new DataTable();

    }


}
