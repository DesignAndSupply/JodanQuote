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

            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter select_quote = new SqlDataAdapter(Statementsclass.select_quote, conn);
            select_quote.SelectCommand.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            select_quote.Fill(dt_quote);
            ConnectionClass.Dispose_connection(conn);
            grid_quote_list.DataSource = dt_quote;

        }

        private void btn_new_item_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand select_max_item_id = new SqlCommand(Statementsclass.select_max_item_id, conn);
            select_max_item_id.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            object check_item = (Int32)select_max_item_id.ExecuteScalar();

            if(check_item != null)
            {
                Valuesclass.item_id = Convert.ToInt32(check_item);


            }
            else
            {
                Valuesclass.item_id = 1;

            }

            SqlCommand insert_new_project_quote = new SqlCommand(Statementsclass.insert_new_project_quote, conn);
            insert_new_project_quote.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            insert_new_project_quote.Parameters.AddWithValue("@item_id", Valuesclass.item_id);
            insert_new_project_quote.Parameters.AddWithValue("@customer_id", Valuesclass.customer_id);
            insert_new_project_quote.Parameters.AddWithValue("@quote_date", DateTime.Now);
            ConnectionClass.Dispose_connection(conn);
            Fill_data();
        }
    }
}
