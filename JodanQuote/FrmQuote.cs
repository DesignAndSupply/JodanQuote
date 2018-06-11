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
            Select_data();
        }
        void Fill_data()
        {



            dt_quote.Clear();
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter select_quote_items = new SqlDataAdapter(Statementsclass.select_quote_items, conn);
            select_quote_items.SelectCommand.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            select_quote_items.Fill(dt_quote);
            ConnectionClass.Dispose_connection(conn);
            grid_items_on_quote.DataSource = dt_quote;
            Format();



        }
        

        void Select_data()
        {

            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand select_quote_details = new SqlCommand(Statementsclass.select_quote_details,conn);
            select_quote_details.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            SqlDataReader reader = select_quote_details.ExecuteReader();

            if (reader.Read())
            {

                Valuesclass.project_ref = reader["project_ref"].ToString();
                Valuesclass.quote_status = reader["quote_status"].ToString();


                ConnectionClass.Dispose_connection(conn);
            

            }

            txt_project_ref.Text= Valuesclass.project_ref;
            cmb_quote_status.Text = Valuesclass.quote_status;

        }
        
        void Format()
        {
            main_tab_project_additions.Appearance = TabAppearance.FlatButtons;
            main_tab_project_additions.ItemSize = new Size(0, 1);
            main_tab_project_additions.SizeMode = TabSizeMode.Fixed;
            grid_items_on_quote.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_items_on_quote.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_items_on_quote.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_items_on_quote.EnableHeadersVisualStyles = false;
            btn_view.DisplayIndex = grid_items_on_quote.ColumnCount - 1;
            btn_delete_item.DisplayIndex = grid_items_on_quote.ColumnCount - 1;
            lbl_quote_id.Text = "Project ID: " + Valuesclass.project_id.ToString();
            txt_customer.Text = Valuesclass.customer_account_ref;
             
            grid_items_on_quote.Columns["Item Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grid_items_on_quote.Columns["Item Date"].Width = 140;
        }

        private void btn_new_item_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Add New Item To This Quotation?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                SqlCommand select_max_item_id = new SqlCommand(Statementsclass.select_max_item_id, conn);
                select_max_item_id.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
                var check_item = select_max_item_id.ExecuteScalar();
                if (string.IsNullOrWhiteSpace(check_item.ToString()))
                {
                    Valuesclass.max_item_id = 1;


                }
                else
                {
                    Valuesclass.max_item_id = Convert.ToInt32(check_item)+1;

                }

                SqlCommand insert_new_project_quote = new SqlCommand(Statementsclass.insert_new_project_quote, conn);
                insert_new_project_quote.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
                insert_new_project_quote.Parameters.AddWithValue("@item_id", Valuesclass.max_item_id);
                insert_new_project_quote.Parameters.AddWithValue("@quote_date", DateTime.Now);
                insert_new_project_quote.ExecuteNonQuery();
                ConnectionClass.Dispose_connection(conn);
                Fill_data();

                FrmNewitem item = new FrmNewitem();
                item.Show();
            }

            else
            {
                return;
            }
        }
            
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain main = new FrmMain();
            main.Show();
        }

        private void btn_print_project_Click(object sender, EventArgs e)
        {
            FrmQuoteReport report = new FrmQuoteReport();
            report.Show();
            this.Hide();

        }

        private void grid_items_on_quote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == grid_items_on_quote.Columns["btn_view"].Index && e.RowIndex >= 0)
                {

                    int i = e.RowIndex;
                    //Valuesclass.qu = Convert.ToInt32(dt_quote.Rows[i]["Quote Id"].ToString());
                    Valuesclass.item_id = Convert.ToInt32(dt_quote.Rows[i]["Item ID"].ToString());
                    //Valuesclass.revision_number = Convert.ToInt32(dt_quote.Rows[i]["Number Of Revisions"].ToString());
                    FrmItem item = new FrmItem();
                    item.Show();
                    this.Hide();




                }
                if (e.ColumnIndex == grid_items_on_quote.Columns["btn_delete_item"].Index && e.RowIndex >= 0)
                {

                    int i = e.RowIndex;
                    DialogResult delete = MessageBox.Show("Delete Item From Project?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if(delete == DialogResult.Yes)
                    {
                        int item_id = Convert.ToInt32(grid_items_on_quote.Rows[i].Cells["Item ID"].Value.ToString());
                        SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                        SqlCommand delete_quote_item = new SqlCommand(Statementsclass.delete_quote_item, conn);
                        delete_quote_item.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
                        delete_quote_item.Parameters.AddWithValue("@item_id", item_id);
                        delete_quote_item.ExecuteNonQuery();
                        Fill_data();
                        

                    }


                }


            }
            catch
            {

            }
           
        }

        private void FrmQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
        }

        private void btn_quote_details_Click(object sender, EventArgs e)
        {
            maintab_doors_on_quote.SelectedTab = tab_quote_details;
        }

        private void btn_additional_cost_Click(object sender, EventArgs e)
        {
            maintab_doors_on_quote.SelectedTab = tab_additonal_cost;
        }

        private void btn_notes_Click(object sender, EventArgs e)
        {
            maintab_doors_on_quote.SelectedTab = tab_notes;
        }

        private void btn_email_project_Click(object sender, EventArgs e)
        {
            FrmMailQuote mail = new FrmMailQuote();
            mail.Show();
        }
    }
}
