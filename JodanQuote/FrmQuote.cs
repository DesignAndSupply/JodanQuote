using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Connection;
using Statements;
using values;

namespace JodanQuote
{
    public partial class FrmQuote : Form
    {
        public static DataTable dt_quote = new DataTable();



        public FrmQuote()
        {
            InitializeComponent();
            Fill_data();
        }
        void Fill_data()
        {

            SqlConnection conn = ConnectionClass.GetConnection_dsl_flood_quote();
            SqlDataAdapter select_quote = new SqlDataAdapter(Statementsclass.select_quote, conn);
            select_quote.SelectCommand.Parameters.AddWithValue("@quote_id", Valuesclass.project_id);
            select_quote.Fill(dt_quote);
            grid_quote_list.DataSource = dt_quote;

        }

        
    }
}
