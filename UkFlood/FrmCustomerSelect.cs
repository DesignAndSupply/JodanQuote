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
            cmb_customers.DisplayMember = "NAME";
            cmb_customers.SelectedIndex = -1;
            ConnectionClass.Dispose_connection(conn);

        }
    }
}
