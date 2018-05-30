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


            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
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
                Valuesclass.project_id =Convert.ToInt32(dt_quote.Rows[i]["Id"].ToString());
               // Valuesclass.quote_id = Convert.ToInt32(dt_quote.Rows[i]["Quote ID"].ToString());
                FrmQuote quote = new FrmQuote();
                quote.Show();





            }
        }

        private void btn_new_project_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();

            SqlCommand select_max_project = new SqlCommand(Statementsclass.select_max_project_id, conn);
            SqlDataReader read_max_project_id = select_max_project.ExecuteReader();
            
      
            if (read_max_project_id.Read())
            {
                Valuesclass.project_id = (Convert.ToInt32(read_max_project_id["Project ID"])) + 1;
                read_max_project_id.Close();
            }
            ConnectionClass.Dispose_connection(conn);


            SqlConnection conn2 = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand select_max_quote_id = new SqlCommand(Statementsclass.select_max_quote_id, conn2);
            SqlDataReader read_max_quote_id = select_max_quote_id.ExecuteReader();

            if (read_max_quote_id.Read())
            {
                Valuesclass.quote_id = (Convert.ToInt32(read_max_project_id["Quote ID"])) + 1;
                read_max_quote_id.Close();
            }
         
            ConnectionClass.Dispose_connection(conn2);
          

            FrmCustomerSelect customer = new FrmCustomerSelect();
            customer.Show();
        }
    }
}
