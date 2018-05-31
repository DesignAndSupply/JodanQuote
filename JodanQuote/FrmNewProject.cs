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
using Statements;
using loginclass;
using values;
using Connection;

namespace JodanQuote
{
    public partial class FrmNewProject : Form
    {
        DataTable dt_quote = new DataTable();


        public FrmNewProject()
        {
            InitializeComponent();
            Insert_item();
            Fill_data();
        }

       void Format()
       {
            lbl_username.Text = Login.globalFullName.ToString();
            txt_customer.Text = Valuesclass.customer_account_ref.ToString();
            txt_customer.TextAlign = HorizontalAlignment.Center;
            lbl_quote_id.Text = "Quote ID:  " + Valuesclass.quote_id.ToString();
            main_tab_project_additions.Appearance = TabAppearance.FlatButtons;
            main_tab_project_additions.ItemSize = new Size(0, 1);
            main_tab_project_additions.SizeMode = TabSizeMode.Fixed;
            grid_items_on_quote.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_items_on_quote.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_items_on_quote.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_items_on_quote.EnableHeadersVisualStyles = false;
            btn_view.DisplayIndex = grid_items_on_quote.ColumnCount - 1;
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
            Format();
        }
        void Insert_item()
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
            insert_new_project_quote.Parameters.AddWithValue("@item_id", Valuesclass.item_id);
            insert_new_project_quote.Parameters.AddWithValue("@quote_date", DateTime.Now);
            insert_new_project_quote.ExecuteNonQuery();
            ConnectionClass.Dispose_connection(conn);


        }

        private void btn_quote_details_Click(object sender, EventArgs e)
        {
            main_tab_project_additions.SelectedTab = tab_quote_details;
        }

        private void btn_additional_cost_Click(object sender, EventArgs e)
        {
            main_tab_project_additions.SelectedTab = tab_additonal_cost;
        }

        private void btn_notes_Click(object sender, EventArgs e)
        {
            main_tab_project_additions.SelectedTab = tab_notes;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain menu = new FrmMain();
            menu.Show();
        }

        private void btn_new_item_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Add New Item To This Quotation", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Insert_item();
                Fill_data();
                //FrmNewItem item = new FrmNewItem();
              //  item.Show();
              //  this.Hide();



            }
            else
            {
                return;
            }
        }

        private void grid_items_on_quote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_items_on_quote.Columns["btn_view"].Index && e.RowIndex >= 0)
            {

                int i = e.RowIndex;
                Valuesclass.item_id = Convert.ToInt32(dt_quote.Rows[i]["Item ID"].ToString());
                Valuesclass.revision_number = Convert.ToInt32(dt_quote.Rows[i]["Number Of Revisions"].ToString());
                FrmNewItem item = new FrmNewItem();
                item.Show();





            }
        }
    }
}
