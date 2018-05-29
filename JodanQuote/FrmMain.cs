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
using values;
using Connection;
using Statements;

namespace JodanQuote
{
    public partial class FrmMain : Form
    {
        DataTable dt_quote = new DataTable();
        public FrmMain()
        {
            InitializeComponent();
            Fill_data();
            Format();
          
        }
        void Format()
        {


            grid_quote_list.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_quote_list.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_quote_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_quote_list.EnableHeadersVisualStyles = false;
            btn_open.DisplayIndex = grid_quote_list.ColumnCount - 1;

        }

        void Fill_data()
        {


            SqlConnection conn = ConnectionClass.GetConnection_dsl_flood_quote();
            SqlDataAdapter ada = new SqlDataAdapter(Statementsclass.view_quote_list, conn);
       
            ada.Fill(dt_quote);
            grid_quote_list.DataSource = dt_quote;
            ConnectionClass.Dispose_connection(conn);
        }
    

        private void grid_quote_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == grid_quote_list.Columns["btn_open"].Index && e.RowIndex >= 0)
            {

                int i = e.RowIndex;
              //  Valuesclass.quote_id = dt_quote.Rows[i][0].ToString();
                FrmQuote quote = new FrmQuote();
                quote.Show();





            }
        }

        private void btn_new_project_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand select_max_id = new SqlCommand(Statementsclass.select_max_id, conn);
            object max_id = (Int32)select_max_id.ExecuteScalar();
            if (max_id != null)
            {
                 Valuesclass.project_id = (Convert.ToInt32(max_id))+1;
            }
            FrmCustomerSelect customer = new FrmCustomerSelect();
            customer.Show();
        }
    }
}
