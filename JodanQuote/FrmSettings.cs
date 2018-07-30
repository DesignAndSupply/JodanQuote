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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
           
            InitializeComponent();
          
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();

            SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost  FROM c_view_hardware WHERE(jodan_stock IS NULL)", conn);
            DataTable dt = new DataTable();
            hardware.Fill(dt);
            grid_stock.DataSource = dt;
            this.ada_setting.Fill(this.dT_Settings.DT_Setting);
            Format();

        }

        void Format()
        {

            grid_settings.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            grid_settings.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            grid_settings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_settings.EnableHeadersVisualStyles = false;
            grid_stock.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            grid_stock.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            grid_stock.DefaultCellStyle.ForeColor = Color.AliceBlue;
            grid_stock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_stock.EnableHeadersVisualStyles = false;
            grid_stock.Columns["id"].Visible = false;
            grid_stock.Columns["Cost"].DefaultCellStyle.Format = "C2";
            grid_stock.Columns["chk_jodan"].DefaultCellStyle.Format = "C2";
            grid_stock.Columns["chk_jodan"].DisplayIndex = grid_stock.ColumnCount - 1;
            

        }

        void Fill_Data()
        {
            if(btn_filter.Text == "           View                Non-Jodan        ")
            {

                SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();

                SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost  FROM c_view_hardware WHERE(jodan_stock IS NULL)", conn);
                DataTable dt = new DataTable();
                hardware.Fill(dt);
                grid_stock.DataSource = dt;
                this.ada_setting.Fill(this.dT_Settings.DT_Setting);
                btn_filter.Text = "           View                  Jodan        ";


            }
            else
            {



                SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();

                SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost  FROM c_view_hardware WHERE(jodan_stock =1)", conn);
                DataTable dt = new DataTable();
                hardware.Fill(dt);
                grid_stock.DataSource = dt;
                this.ada_setting.Fill(this.dT_Settings.DT_Setting);
                btn_filter.Text = "           View                Non-Jodan        ";
           
            }

            Format();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlConnection conn2 = ConnectionClass.GetConnection_orderdatabase();
            if (btn_filter.Text== "           View                  Jodan        ")
            {

                for (int i = 0; i < grid_stock.Rows.Count; i++)
                {
                    if (grid_stock.Rows[i].Cells["chk_jodan"].Value == chk_jodan.TrueValue)
                    {

                        SqlCommand update_stock = new SqlCommand(Statementsclass.update_stock, conn2);
                        update_stock.Parameters.AddWithValue("@id", grid_stock.Rows[i].Cells["ID"].Value);
                        update_stock.ExecuteNonQuery();


                    }
                }


            }
            else
            {


                for (int i = 0; i < grid_stock.Rows.Count; i++)
                {
                    if (grid_stock.Rows[i].Cells["chk_jodan"].Value == chk_jodan.TrueValue)
                    {

                        SqlCommand update_stock_null = new SqlCommand(Statementsclass.update_stock_null, conn2);
                        update_stock_null.Parameters.AddWithValue("@id", grid_stock.Rows[i].Cells["ID"].Value);
                        update_stock_null.ExecuteNonQuery();


                    }
                }



            }
           
            SqlCommand update_settings = new SqlCommand(Statementsclass.update_settings, conn);
            update_settings.Parameters.AddWithValue("@markup_hardware", Convert.ToDouble(grid_settings.Rows[0].Cells["markup_hardware"].Value));
            update_settings.Parameters.AddWithValue("@markup_material", grid_settings.Rows[0].Cells["markup_material"].Value);
            update_settings.Parameters.AddWithValue("@labour_rate",Convert.ToDouble(grid_settings.Rows[0].Cells["labour_rate"].Value));
            update_settings.Parameters.AddWithValue("@single_extra", Convert.ToDouble( grid_settings.Rows[0].Cells["single_extra"].Value));
            update_settings.Parameters.AddWithValue("@double_extra", Convert.ToDouble( grid_settings.Rows[0].Cells["double_extra"].Value));
            update_settings.Parameters.AddWithValue("@single_flood_extra", Convert.ToDouble(grid_settings.Rows[0].Cells["single_flood_extra"].Value));
            update_settings.Parameters.AddWithValue("@double_flood_extra", Convert.ToDouble(grid_settings.Rows[0].Cells["double_flood_extra"].Value));
            update_settings.Parameters.AddWithValue("@date_modified",DateTime.Now);
            update_settings.ExecuteNonQuery();
            ConnectionClass.Dispose_connection(conn);
            ConnectionClass.Dispose_connection(conn2);


            MessageBox.Show("   Settings Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            Fill_Data();
        }

       
    }
}
