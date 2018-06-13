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

namespace JodanQuote
{
    public partial class FrmHardwareSelect : Form
    {
        

        public FrmHardwareSelect()
        {
            InitializeComponent();
            Fill_data();
        }

        void Fill_data()
        {


            DataTable dt_stock = new DataTable();
            SqlConnection conn = ConnectionClass.GetConnection_orderdatabase();
            SqlDataAdapter select_stock_category = new SqlDataAdapter(Statementsclass.select_stock_category, conn);
            select_stock_category.Fill(dt_stock);
            cmb_type.DataSource = dt_stock;
            cmb_type.DisplayMember = "description";
            cmb_type.ValueMember = "ID";
            cmb_type.SelectedIndex = -1;
            ConnectionClass.Dispose_connection(conn);

            this.c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);
            for (int i = 0; i < grid_hardware.Rows.Count; ++i)
            {

                grid_hardware.Rows[i].Cells["Quantity"].Value = 0;
               
                grid_hardware.Rows[i].Cells["Total"].Value = 0;

            }
        }
       
        private void grid_hardware_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            Total_cost(sender,e);
        }

        void Total_cost(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_hardware.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                double cost = Convert.ToDouble(grid_hardware.Rows[i].Cells["Cost"].Value);
                double quantity = Convert.ToInt32(grid_hardware.Rows[i].Cells["Quantity"].Value);
                double row_total = cost * quantity;
                if(row_total>0)
                {
                    grid_hardware.Rows[i].Cells["Total"].Value = row_total;

                }
            

            }

        }

        private void grid_hardware_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Total_cost(sender, e);
        }

        private void cmb_type_TextChanged(object sender, EventArgs e)
        {
            if(cmb_type.SelectedIndex > 0)
            {
                if(txt_description.Text == null )
                {
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.CommandText = Statementsclass.Search_stock_category;
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@category", cmb_type.SelectedValue);
                    c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);
                    grid_hardware.DataSource = dT_hardware.c_view_hardware;

                }
                else
                {
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.CommandText = Statementsclass.Search_stock_category_description;
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@category", cmb_type.SelectedValue);
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text);
                    c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);
                    grid_hardware.DataSource = dT_hardware.c_view_hardware;
                    



                }
               
               


            }
        }

        private void pct_clear_Click(object sender, EventArgs e)
        {
            txt_description.Text = "";
            cmb_type.SelectedIndex = -1;
           
            c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            c_view_hardwareTableAdapter.Adapter.SelectCommand.CommandText = "SELECT LEFT(Description, 20) AS Description, Cost FROM c_view_hardware";
            this.c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);
            grid_hardware.DataSource = dT_hardware.c_view_hardware;
        }

        private void txt_description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                if (cmb_type.SelectedIndex < 0)
                {
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.CommandText = Statementsclass.Search_stock_description;
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text);
                    c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);
                    grid_hardware.DataSource = dT_hardware.c_view_hardware;

                }
                else
                {
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.CommandText = Statementsclass.Search_stock_category_description;
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@category", cmb_type.SelectedValue);
                    c_view_hardwareTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text);
                    c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);
                    grid_hardware.DataSource = dT_hardware.c_view_hardware;




                }

            }
        }
    }
}
