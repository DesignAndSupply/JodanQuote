using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Connection;
using Statements;
using values;
using System.Windows.Forms;

namespace JodanQuote
{
    public partial class FrmDimensions : Form
    {
        public FrmDimensions()
        {
            InitializeComponent();
            txt_structual_height.Text =Convert.ToString(Valuesclass.dimension_height);
            txt_structual_width.Text = Convert.ToString(Valuesclass.dimension_width);
            this.ControlBox = false;
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_structual_height.Text))
            {
                MessageBox.Show(" Please Enter A Structual Height Value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txt_structual_width.Text))
            {
                MessageBox.Show(" Please Enter A Structual Width Value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand update_dimensions = new SqlCommand(Statementsclass.update_dimensions, conn);
            update_dimensions.Parameters.AddWithValue("@height", txt_structual_height.Text);
            update_dimensions.Parameters.AddWithValue("@width", txt_structual_width.Text);
            update_dimensions.Parameters.AddWithValue("@frame_height", (Convert.ToInt32(txt_structual_height.Text) - 10));
            update_dimensions.Parameters.AddWithValue("@frame_width", (Convert.ToInt32(txt_structual_width.Text) - 6));
            update_dimensions.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            update_dimensions.Parameters.AddWithValue("@item_id",Valuesclass.item_id);
            update_dimensions.ExecuteNonQuery();
            ConnectionClass.Dispose_connection(conn);

            this.Hide();
           


              

        }

        private void txt_structual_height_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btn_complete.PerformClick();
            }
        }
    }
}
