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
using CrystalDecisions.CrystalReports.Engine;

using System.IO;
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
            Save_PDF();


        }
        void Fill_data()

        {
            DataSet ds = new DataSet();
            DataSet ds_item = new DataSet();
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter select_quote_report = new SqlDataAdapter(Statementsclass.select_quote_report, conn);
            SqlDataAdapter select_item_report = new SqlDataAdapter(Statementsclass.select_item_report, conn);
            select_quote_report.SelectCommand.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            select_item_report.SelectCommand.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            select_quote_report.Fill(ds);
            select_item_report.Fill(ds_item);
            CrRptQuote1.SetDataSource(ds.Tables[0]);
            CrRptQuote1.Subreports[0].SetDataSource(ds_item.Tables[0]);
            ConnectionClass.Dispose_connection(conn);
            crystalReportViewer1.ReportSource = CrRptQuote1;
            crystalReportViewer1.Refresh();

        }

         void Send_quote()
        {

            Save_PDF();
            FrmMailQuote mail = new FrmMailQuote();
            mail.ShowDialog();

            
            string path = @"\\designsvr1\apps\Design and Supply CSharp\Documents\Jodan Quote\Temp Files\Quote" + Valuesclass.project_id + ".PDF";

            string recipients = string.Join("", Functionsclass.Emailrecipients);
            Outlook.Application app = new Outlook.Application();
            Outlook.MailItem mailItem = app.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = "Quote Number: " + Valuesclass.project_id;
            mailItem.To = recipients;
            //mailItem.Body = "Test";
            mailItem.Attachments.Add(path);
            mailItem.Importance = Outlook.OlImportance.olImportanceHigh;
            mailItem.Display(false);


            
          



          
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            Save_PDF();
            System.Diagnostics.Process.Start(@"\\designsvr1\apps\Design and Supply CSharp\Documents\Jodan Quote\Temp Files\Quote" + Valuesclass.project_id + ".PDF");
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            FrmMailQuote mail = new FrmMailQuote();
            mail.Show();
            Save_PDF();
        }
         void Save_PDF()
        {

        

           if (File.Exists(@"\\designsvr1\apps\Design and Supply CSharp\Documents\Jodan Quote\Temp Files\Quote" + Valuesclass.project_id + ".PDF")) 
            {

                File.Delete(@"\\designsvr1\apps\Design and Supply CSharp\Documents\Jodan Quote\Temp Files\Quote" + Valuesclass.project_id + ".PDF");
                CrRptQuote1.ExportToDisk(ExportFormatType.PortableDocFormat, @"\\designsvr1\apps\Design and Supply CSharp\Documents\Jodan Quote\Temp Files\Quote" + Valuesclass.project_id + ".PDF");
            }
           
            else
            {

                CrRptQuote1.ExportToDisk(ExportFormatType.PortableDocFormat, @"\\designsvr1\apps\Design and Supply CSharp\Documents\Jodan Quote\Temp Files\Quote" + Valuesclass.project_id + ".PDF");


            }

                




        }

        private void FrmQuoteReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmQuote quote = new FrmQuote();
            quote.Show();
        }

        private void FrmQuoteReport_MaximumSizeChanged(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
            panel2.Height = this.Height;
        }

       
    }
}
