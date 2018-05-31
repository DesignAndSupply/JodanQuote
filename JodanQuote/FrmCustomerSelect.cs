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
using Connection;
using values;


namespace JodanQuote
{
    public partial class FrmCustomerSelect : Form
    {
        public FrmCustomerSelect()
        {
            InitializeComponent();
            Fill_data();
        }


        void Fill_data()

        {
            DataTable dt_customer = new DataTable();
            SqlConnection conn = ConnectionClass.GetConnection_dsl_fitting();
            SqlDataAdapter select_customer = new SqlDataAdapter(Statementsclass.select_customer, conn);
            select_customer.Fill(dt_customer);
            cmb_customers.DataSource = dt_customer;
            cmb_customers.DisplayMember = "Name";
            cmb_customers.ValueMember = "account_ref";
            cmb_customers.SelectedIndex = -1;
            cmb_customers.MaxDropDownItems = 5;
 
            ConnectionClass.Dispose_connection(conn);

        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            if (cmb_customers.SelectedValue == null)
            {

                MessageBox.Show("Please Select A Customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Valuesclass.customer_account_ref =  cmb_customers.SelectedValue.ToString();
            Valuesclass.customer_name = cmb_customers.Text.ToString();
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand insert_new_project = new SqlCommand(Statementsclass.insert_new_project, conn);
            insert_new_project.Parameters.AddWithValue("@customer_id", Valuesclass.customer_account_ref);
            insert_new_project.Parameters.AddWithValue("@quote_date", DateTime.Now);
            insert_new_project.Parameters.AddWithValue("@created_by", loginclass.Login.globalFullName.ToString());
            insert_new_project.ExecuteNonQuery();
            ConnectionClass.Dispose_connection(conn);
            this.Hide();
            FrmNewProject project = new FrmNewProject();
            project.Show();
        }
    }
}
