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
            this.ada_setting.Fill(this.dT_Settings.DT_Setting);
            Format();
        }

   
        void Format()
        {

            grid_settings.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_settings.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_settings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_settings.EnableHeadersVisualStyles = false;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
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


            MessageBox.Show("   Settings Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dT_hardware.c_view_hardware' table. You can move, or remove it, as needed.
            this.c_view_hardwareTableAdapter.Fill(this.dT_hardware.c_view_hardware);

        }
    }
}
