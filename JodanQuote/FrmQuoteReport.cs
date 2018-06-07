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
using Outlook = Microsoft.Office.Interop.Outlook;
using Connection;
using Statements;
using function;
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
            ConnectionClass.Dispose_connection(conn);
            crystalReportViewer1.ReportSource = CrRptQuote1;
            crystalReportViewer1.Refresh();

        }

        public static void Send_quote()
        {


            string recipients = string.Join("", Functionsclass.Emailrecipients);
            Outlook.Application app = new Outlook.Application();
            Outlook.MailItem mailItem = app.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = "Quote Number: " + Valuesclass.project_id;
            mailItem.To = recipients;
            mailItem.Body = "Test";
          //  mailItem.Attachments.Add(CrRptQuote1);
            mailItem.Importance = Outlook.OlImportance.olImportanceHigh;
            mailItem.Display(false);




        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            Save_PDF();
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            FrmMailQuote mail = new FrmMailQuote();
            mail.Show();
            //Save_PDF();
        }
        void Save_PDF()
        {

            var folderPath = Statementsclass.quote_pdf_path;

            CrRptQuote1.ExportToDisk(ExportFormatType.RPTR, @"\\designsvr1\apps\Design and Supply CSharp\Documents\Jodan Quote\Saved\" + Valuesclass.project_id + ".PDF");
            MessageBox.Show("  Quotation Save Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
       



    }
}
