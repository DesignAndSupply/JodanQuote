using CrystalDecisions.Shared;
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
using CrystalDecisions.CrystalReports.Engine;
using Connection;
using Statements;
using values;


namespace JodanQuote
{
    public partial class FrmQuoteReport : Form
    {
        public FrmQuoteReport()
        {
            InitializeComponent();
            Fill_data();
        }
        void Fill_data()

        {
            DataSet ds = new DataSet();
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter select_quote_report = new SqlDataAdapter(Statementsclass.select_quote_report, conn);
            select_quote_report.SelectCommand.Parameters.AddWithValue("@project", Valuesclass.project_id);
            select_quote_report.Fill(ds);
            CrRptQuote1.SetDataSource(ds.Tables[0]);

            crystalReportViewer1.ReportSource = CrRptQuote1;
            crystalReportViewer1.Refresh();




        }
    }
}
