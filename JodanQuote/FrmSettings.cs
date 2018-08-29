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
            SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost, sec_rating_level  FROM c_view_hardware WHERE(jodan_stock IS NULL)", conn);
            DataTable dt = new DataTable();
            hardware.Fill(dt);
            grid_stock.DataSource = dt;
            this.ada_setting.Fill(this.dT_Settings.DT_Setting);
            DataTable dt_stock = new DataTable();
            SqlConnection conn2 = ConnectionClass.GetConnection_orderdatabase();
            SqlDataAdapter select_stock_category = new SqlDataAdapter(Statementsclass.select_stock_category, conn2);
            select_stock_category.Fill(dt_stock);
            cmb_type.DataSource = dt_stock;
            cmb_type.DisplayMember = "description";
            cmb_type.ValueMember = "ID";
            cmb_type.SelectedIndex = -1;
            ConnectionClass.Dispose_connection(conn2);
            Format();

        }

        void Format()
        {

            grid_settings.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            grid_settings.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            grid_settings.DefaultCellStyle.ForeColor = Color.AliceBlue;
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
            grid_stock.Columns["sec_rating_level"].DisplayIndex = grid_stock.ColumnCount - 2;
            grid_stock.Columns["chk_jodan"].DisplayIndex = grid_stock.ColumnCount - 1;
            grid_stock.Columns["sec_rating_level"].HeaderText = "Security Rating";
          

        }

        void Fill_Data()
        {
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            DataTable dt = new DataTable();

            if (btn_filter.Text == "           View                Non-Jodan        ")
            {
                if (cmb_type.Text == "" && txt_description.Text == "")

                {
                    SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost , sec_rating_level FROM c_view_hardware WHERE(jodan_stock IS NULL) ORDER BY Description", conn);
                    hardware.Fill(dt);
                    grid_stock.DataSource = dt;
                    this.ada_setting.Fill(this.dT_Settings.DT_Setting);
             

                }
                if (cmb_type.Text != "" && txt_description.Text == "")

                {
                    SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost , sec_rating_level FROM c_view_hardware  WHERE(jodan_stock IS NULL) AND category = @category ORDER BY Description", conn);
                    int category = Convert.ToInt16(((DataRowView)cmb_type.SelectedItem)["id"]);
                    hardware.SelectCommand.Parameters.AddWithValue("@category", category);
                    hardware.Fill(dt);
                    grid_stock.DataSource = dt;
                    this.ada_setting.Fill(this.dT_Settings.DT_Setting);
              

                }
                if (cmb_type.Text == "" && txt_description.Text != "")

                {
                    SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost , sec_rating_level FROM c_view_hardware WHERE(jodan_stock IS NULL) AND Description LIKE '%' + @description + '%'  ORDER BY Description", conn);
                    hardware.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text);
                    hardware.Fill(dt);
                    grid_stock.DataSource = dt;
                    this.ada_setting.Fill(this.dT_Settings.DT_Setting);
              

                }
                if (cmb_type.Text != "" && txt_description.Text != "")

                {
                    SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost , sec_rating_level FROM c_view_hardware WHERE(jodan_stock IS NULL) AND category = @category AND  Description LIKE '%' + @description + '%' ORDER BY Description", conn);
                    int category = Convert.ToInt16(((DataRowView)cmb_type.SelectedItem)["id"]);
                    hardware.SelectCommand.Parameters.AddWithValue("@category", category);
                    hardware.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text);
                    hardware.Fill(dt);
                    grid_stock.DataSource = dt;
                    this.ada_setting.Fill(this.dT_Settings.DT_Setting);
                  

                }

                btn_filter.Text = "           View                  Jodan        ";


            }

            else
            {

                if (cmb_type.Text == "" && txt_description.Text == "")

                {
                    SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost , sec_rating_level FROM c_view_hardware WHERE(jodan_stock = 1) ORDER BY Description", conn);
                    hardware.Fill(dt);
                    grid_stock.DataSource = dt;
                    this.ada_setting.Fill(this.dT_Settings.DT_Setting);
                

                }
                if (cmb_type.Text != "" && txt_description.Text == "")

                {
                    SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost , sec_rating_level FROM c_view_hardware WHERE(jodan_stock = 1) AND category = @category ORDER BY Description", conn);
                    int category = Convert.ToInt16(((DataRowView)cmb_type.SelectedItem)["id"]);
                    hardware.SelectCommand.Parameters.AddWithValue("@category", category);
                    hardware.Fill(dt);
                    grid_stock.DataSource = dt;
                    this.ada_setting.Fill(this.dT_Settings.DT_Setting);
                   

                }
                if (cmb_type.Text == "" && txt_description.Text != "")

                {
                    SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost  , sec_rating_level FROM c_view_hardware WHERE(jodan_stock =1) AND Description LIKE '%' + @description + '%'  ORDER BY Description", conn);
                    hardware.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text);
                    hardware.Fill(dt);
                    grid_stock.DataSource = dt;
                    this.ada_setting.Fill(this.dT_Settings.DT_Setting);
                   

                }
                if (cmb_type.Text != "" && txt_description.Text != "")

                {
                    SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost , sec_rating_level  FROM c_view_hardware WHERE(jodan_stock =1) AND category = @category AND  Description LIKE '%' + @description + '%' ORDER BY Description", conn);
                    int category = Convert.ToInt16(((DataRowView)cmb_type.SelectedItem)["id"]);
                    hardware.SelectCommand.Parameters.AddWithValue("@category", category);
                    hardware.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text);
                    hardware.Fill(dt);
                    grid_stock.DataSource = dt;
                    this.ada_setting.Fill(this.dT_Settings.DT_Setting);
                  

                }

                btn_filter.Text = "           View                Non-Jodan        ";



            }

            Format();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlConnection conn2 = ConnectionClass.GetConnection_orderdatabase();
            if (btn_filter.Text == "           View                  Jodan        ")
            {

                for (int i = 0; i < grid_stock.Rows.Count; i++)
                {
                    if (grid_stock.Rows[i].Cells["chk_jodan"].Value == chk_jodan.TrueValue)
                    {

                        SqlCommand update_stock = new SqlCommand(Statementsclass.update_stock, conn2);
                        update_stock.Parameters.AddWithValue("@id", grid_stock.Rows[i].Cells["ID"].Value);
                        update_stock.Parameters.AddWithValue("@security_rating", grid_stock.Rows[i].Cells["sec_rating_level"].Value);
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
                        update_stock_null.Parameters.AddWithValue("@security_rating", grid_stock.Rows[i].Cells["sec_rating_level"].Value);
                        
                        update_stock_null.ExecuteNonQuery();


                    }
                }



            }

            SqlCommand update_settings = new SqlCommand(Statementsclass.update_settings, conn);
            update_settings.Parameters.AddWithValue("@markup_hardware", Convert.ToDouble(grid_settings.Rows[0].Cells["markup_hardware"].Value));
            update_settings.Parameters.AddWithValue("@markup_material", grid_settings.Rows[0].Cells["markup_material"].Value);
            update_settings.Parameters.AddWithValue("@labour_rate", Convert.ToDouble(grid_settings.Rows[0].Cells["labour_rate"].Value));
            update_settings.Parameters.AddWithValue("@single_extra", Convert.ToDouble(grid_settings.Rows[0].Cells["single_extra"].Value));
            update_settings.Parameters.AddWithValue("@double_extra", Convert.ToDouble(grid_settings.Rows[0].Cells["double_extra"].Value));
            update_settings.Parameters.AddWithValue("@single_flood_extra", Convert.ToDouble(grid_settings.Rows[0].Cells["single_flood_extra"].Value));
            update_settings.Parameters.AddWithValue("@double_flood_extra", Convert.ToDouble(grid_settings.Rows[0].Cells["double_flood_extra"].Value));
            update_settings.Parameters.AddWithValue("@date_modified", DateTime.Now);
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

        private void txt_description_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Fill_Data();
            }
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill_Data();
        }

        private void pct_clear_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            txt_description.Text = "";
            cmb_type.SelectedIndex = -1;
            SqlDataAdapter hardware = new SqlDataAdapter("SELECT id, LEFT(Description, 25) AS Description, Cost  FROM c_view_hardware WHERE(jodan_stock IS NULL)", conn);
            DataTable dt = new DataTable();
            hardware.Fill(dt);
            grid_stock.DataSource = dt;
        }

        private void btn_select_all_Click(object sender, EventArgs e)
        {

            if (btn_select_all.Text == "   Select All")
            {
                for (int i = 0; i < grid_stock.Rows.Count; i++)
                {
                    if (grid_stock.Rows[i].Cells["chk_jodan"].Value == chk_jodan.FalseValue)
                    {


                        grid_stock.Rows[i].Cells["chk_jodan"].Value = chk_jodan.TrueValue;

                    }
                }
                btn_select_all.Text = "         Clear            Selection";
                btn_select_all.Image = Properties.Resources.clear;
                
            }
            else
            {
                for (int i = 0; i < grid_stock.Rows.Count; i++)
                {
                    if (grid_stock.Rows[i].Cells["chk_jodan"].Value == chk_jodan.TrueValue)
                    {


                        grid_stock.Rows[i].Cells["chk_jodan"].Value = chk_jodan.FalseValue;

                    }
                }
                btn_select_all.Text = "   Select All";
                btn_select_all.Image = Properties.Resources.tick2;
            }
        }
    }
}
