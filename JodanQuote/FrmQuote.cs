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
            dt_quote.Clear();
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter select_quote = new SqlDataAdapter(Statementsclass.select_quote, conn);
            select_quote.SelectCommand.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            select_quote.Fill(dt_quote);
            ConnectionClass.Dispose_connection(conn);
            grid_items_on_quote.DataSource = dt_quote;
            format();



        }
        void format()
        {

            grid_items_on_quote.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_items_on_quote.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_items_on_quote.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_items_on_quote.EnableHeadersVisualStyles = false;
            btn_view.DisplayIndex = grid_items_on_quote.ColumnCount - 1;

            lbl_quote_id.Text = "Quote ID: " + Valuesclass.project_id.ToString();
            txt_customer.Text = Valuesclass.customer_account_ref;

        }

        private void btn_new_item_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Add New Item To This Quotation", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            }

            else
            {
                return;
            }
        }

    

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
