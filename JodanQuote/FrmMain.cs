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
            grid_quote_list.Columns["Project ID"].FillWeight = 52;
            grid_quote_list.Columns["Project ID"].HeaderText = "  Project    ID";
            grid_quote_list.Columns["Number Of Items"].FillWeight = 53;
            grid_quote_list.Columns["Total Value"].FillWeight = 40;
            grid_quote_list.Columns["Total Value"].DefaultCellStyle.NullValue = "£0";
            grid_quote_list.Columns["Project Reference"].FillWeight = 68;
            grid_quote_list.Columns["Date Created"].FillWeight = 53;
            grid_quote_list.Columns["Customer Name"].FillWeight = 110;
            grid_quote_list.Columns["Date Created"].DefaultCellStyle.Format = "d";
            grid_quote_list.Columns["Total Value"].DefaultCellStyle.Format = "C2";
            foreach (DataGridViewColumn col in grid_quote_list.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if(loginclass.Login.globalSuperUser == true)
            {

                btn_settings.Visible = true;

            }
        }

        void Fill_data()
        {


            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter ada = new SqlDataAdapter(Statementsclass.select_quote_item_count, conn);
            ada.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
            ada.Fill(dt_quote);
            grid_quote_list.DataSource = dt_quote;
            ConnectionClass.Dispose_connection(conn);
        }

        void Search()
        {
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            DateTime d =  DateTime.Today;
            String today = d.ToShortDateString();

            if (txt_customer.Text != "" && txt_quote_id.Text != "" && txt_reference.Text == "" && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {
                dt_quote.Clear();
                SqlDataAdapter search_quote_customer = new SqlDataAdapter(Statementsclass.search_quote_customer, conn);
                search_quote_customer.SelectCommand.Parameters.AddWithValue("@customer", txt_customer.Text.ToString());
                search_quote_customer.SelectCommand.Parameters.AddWithValue("@project_id", Convert.ToInt32(txt_quote_id.Text.ToString()));
                search_quote_customer.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_quote_customer.Fill(dt_quote);
               // Format();
                return;


            }
            if (txt_customer.Text != "" && txt_quote_id.Text == "" && txt_reference.Text == "" && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {

                dt_quote.Clear();
                SqlDataAdapter search_customer = new SqlDataAdapter(Statementsclass.search_customer, conn);
                search_customer.SelectCommand.Parameters.AddWithValue("@customer", txt_customer.Text.ToString());
                search_customer.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_customer.Fill(dt_quote);
               // Format();
                return;


            }
            if (txt_quote_id.Text != "" && txt_customer.Text == "" && txt_reference.Text == "" && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {

                dt_quote.Clear();
              
                SqlDataAdapter search_quote = new SqlDataAdapter(Statementsclass.search_quote, conn);
                search_quote.SelectCommand.Parameters.AddWithValue("@project_id", Convert.ToInt32(txt_quote_id.Text.ToString()));
                search_quote.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_quote.Fill(dt_quote);
               // Format();
                return;

            }
            if (txt_quote_id.Text != "" && txt_customer.Text != "" && txt_reference.Text != "" && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {

                dt_quote.Clear();

                SqlDataAdapter search_quote_customer_reference = new SqlDataAdapter(Statementsclass.search_quote_customer_reference, conn);
                search_quote_customer_reference.SelectCommand.Parameters.AddWithValue("@project_id", Convert.ToInt32(txt_quote_id.Text.ToString()));
                search_quote_customer_reference.SelectCommand.Parameters.AddWithValue("@customer", txt_customer.Text.ToString());
                search_quote_customer_reference.SelectCommand.Parameters.AddWithValue("@reference", txt_reference.Text.ToString());
                search_quote_customer_reference.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);

                search_quote_customer_reference.Fill(dt_quote);
                 Format();
                return;

            }

            if (txt_quote_id.Text == "" && txt_customer.Text == "" && txt_reference.Text != "" && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {

                dt_quote.Clear();

                SqlDataAdapter search_reference = new SqlDataAdapter(Statementsclass.search_reference, conn);
                search_reference.SelectCommand.Parameters.AddWithValue("@reference", txt_reference.Text.ToString());
                search_reference.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);

                search_reference.Fill(dt_quote);
                Format();
                return;

            }
            if (txt_quote_id.Text != "" && txt_customer.Text == "" && txt_reference.Text != "" && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {

                dt_quote.Clear();

                SqlDataAdapter search_quote_reference = new SqlDataAdapter(Statementsclass.search_quote_reference, conn);
                search_quote_reference.SelectCommand.Parameters.AddWithValue("@reference", txt_reference.Text.ToString());
                search_quote_reference.SelectCommand.Parameters.AddWithValue("@project_id", Convert.ToInt32(txt_quote_id.Text.ToString()));
                search_quote_reference.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_quote_reference.Fill(dt_quote);
                Format();
                return;

            }
            if (txt_quote_id.Text == "" && txt_customer.Text != "" && txt_reference.Text != "" && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {

                dt_quote.Clear();

                SqlDataAdapter search_customer_reference = new SqlDataAdapter(Statementsclass.search_customer_reference, conn);
                search_customer_reference.SelectCommand.Parameters.AddWithValue("@customer", txt_customer.Text.ToString());
                search_customer_reference.SelectCommand.Parameters.AddWithValue("@reference", txt_reference.Text.ToString());
                search_customer_reference.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_customer_reference.Fill(dt_quote);
                Format();
                return;

            }
            if (txt_customer.Text == "" && txt_quote_id.Text == "" && txt_reference.Text == "" && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
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
                    Valuesclass.customer_name = grid_quote_list.Rows[i].Cells["Customer Name"].Value.ToString();
                    Valuesclass.project_id = Convert.ToInt32(grid_quote_list.Rows[i].Cells["Project ID"].Value);
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


            Valuesclass.customer_account_ref = "JODAN CONTRACTS LTD                                         ";
            Valuesclass.customer_name = "JODAN CONTRACTS LTD                                         ";
            SqlCommand insert_new_project = new SqlCommand(Statementsclass.insert_new_project, conn2);
            insert_new_project.Parameters.AddWithValue("@customer_id", Valuesclass.customer_account_ref);
            insert_new_project.Parameters.AddWithValue("@quote_date", DateTime.Now);
            insert_new_project.Parameters.AddWithValue("@created_by", loginclass.Login.globalFullName.ToString());
            insert_new_project.ExecuteNonQuery();
            ConnectionClass.Dispose_connection(conn2);
            this.Hide();
            FrmQuote project = new FrmQuote();
            project.Show();
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
            txt_reference.Text = "";
            date_start.Text = DateTime.Now.ToShortDateString();
            date_end.Text = DateTime.Now.ToShortDateString();
            Fill_data();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fill_data();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            dt_quote.Clear();
            if(Valuesclass.jodan_y_n == 0)
            {
                Valuesclass.jodan_y_n = 1;
                btn_filter.Text = "        Filter            Jodan";
                pct_logo.Image = JodanQuote.Properties.Resources.Logo;
                pct_logo.Location = new Point(20, 28);
         
            }
            else
            {
                Valuesclass.jodan_y_n = 0;
                btn_filter.Text = "        Filter            Others";
                pct_logo.Image = JodanQuote.Properties.Resources.Jodan;
                pct_logo.Location = new Point(5, 8);

            }

            Fill_data();
            Format();
        }

        private void txt_reference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Search();
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.ShowDialog();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
