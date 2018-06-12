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
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand update_dimensions = new SqlCommand(Statementsclass.update_dimensions, conn);
            update_dimensions.Parameters.AddWithValue("@height", txt_structual_height.Text);
            update_dimensions.Parameters.AddWithValue("@width", txt_structual_width.Text);
            update_dimensions.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            update_dimensions.Parameters.AddWithValue("@item_id",Valuesclass.item_id);
            update_dimensions.ExecuteNonQuery();
            ConnectionClass.Dispose_connection(conn);

            this.Hide();
            if (Valuesclass.new_item_identifier == 1)
            {


                FrmNewitem newitem = new FrmNewitem();
               newitem.Show();

            }
            else 
            {


                FrmItem item = new FrmItem();
                item.Show();

            }
        }
    }
}
