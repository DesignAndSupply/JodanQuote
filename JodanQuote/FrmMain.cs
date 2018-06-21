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
           // grid_quote_list.Columns["Project ID"].Visible = false;

        }

        void Fill_data()
        {


            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter ada = new SqlDataAdapter(Statementsclass.select_quote_item_count, conn);
       
            ada.Fill(dt_quote);
            grid_quote_list.DataSource = dt_quote;
            ConnectionClass.Dispose_connection(conn);
        }

        void Search()
        {
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();

            if (txt_customer.Text != "" && txt_quote_id.Text != "")
            {
                dt_quote.Clear();
                SqlDataAdapter search_quote_customer = new SqlDataAdapter(Statementsclass.search_quote_customer, conn);
                search_quote_customer.SelectCommand.Parameters.AddWithValue("@customer", txt_customer.Text.ToString());
                search_quote_customer.SelectCommand.Parameters.AddWithValue("@project_id", Convert.ToInt32(txt_quote_id.Text.ToString()));
                search_quote_customer.Fill(dt_quote);
               // Format();
                return;


            }
            if (txt_customer.Text != "" && txt_quote_id.Text == "")
            {

                dt_quote.Clear();
                SqlDataAdapter search_customer = new SqlDataAdapter(Statementsclass.search_customer, conn);
                search_customer.SelectCommand.Parameters.AddWithValue("@customer", txt_customer.Text.ToString());
                search_customer.Fill(dt_quote);
               // Format();
                return;


            }
            if (txt_quote_id.Text != "" && txt_customer.Text == "")
            {

                dt_quote.Clear();
              
                SqlDataAdapter search_quote = new SqlDataAdapter(Statementsclass.search_quote, conn);
                search_quote.SelectCommand.Parameters.AddWithValue("@project_id", Convert.ToInt32(txt_quote_id.Text.ToString()));
                search_quote.Fill(dt_quote);
               // Format();
                return;

            }
            if (txt_customer.Text == "" && txt_quote_id.Text == "")
            {
                dt_quote.Clear();
                Fill_data();
                return;

            }




        }

        private void grid_quote_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == grid_quote_list.Columns["btn_open"].Index && e.RowIndex >= 0)
                {

                    int i = e.RowIndex;
                    //Valuesclass.quote_id = Convert.ToInt32(dt_quote.Rows[i]["Quote ID"].ToString());
                    Valuesclass.customer_account_ref = dt_quote.Rows[i]["Customer"].ToString();
                    Valuesclass.project_id = Convert.ToInt32(dt_quote.Rows[i]["Project ID"].ToString());
                    FrmQuote quote = new FrmQuote();
                    quote.Show();
                    this.Hide();




                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "");
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
                Valuesclass.quote_id = (Convert.ToInt32(read_max_quote_id["Quote ID"])) + 1;
                read_max_quote_id.Close();
            }
         
            ConnectionClass.Dispose_connection(conn2);
          

            FrmCustomerSelect customer = new FrmCustomerSelect();
            customer.Show();
            this.Hide();
        }

        private void txt_quote_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Search();
            }
        }


        private void txt_customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Search();
            }
           
        }

        private void pct_clear_Click(object sender, EventArgs e)
        {
            dt_quote.Clear();
            txt_customer.Text = "";
            txt_quote_id.Text = "";
            Fill_data();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fill_data();
        }
    }
}
