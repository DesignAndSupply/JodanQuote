using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using function;
using values;
using Connection;
using Statements;


namespace JodanQuote
{
    public partial class FrmMailQuote : Form
    {
        public FrmMailQuote()
        {
            InitializeComponent();
            Fill_data();
            Format();

        }
        void Fill_data()
        {

            DataTable dt = new DataTable();
            SqlConnection conn = ConnectionClass.GetConnection_dsl_flood_quote();
            SqlDataAdapter select_quote_report = new SqlDataAdapter(Statementsclass.select_email_recipients, conn);
            select_quote_report.Fill(dt);
            grid_email_recipients.DataSource = dt;
            ConnectionClass.Dispose_connection(conn);


        }
        void Format()
        {
            grid_email_recipients.EnableHeadersVisualStyles = false;
            grid_email_recipients.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_email_recipients.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_email_recipients.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_email_recipients.DefaultCellStyle.BackColor = Color.AliceBlue;
            chk_recipient.DisplayIndex = grid_email_recipients.ColumnCount - 1;

        }

        void Send()
        {
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

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < grid_email_recipients.Rows.Count; i++)
                {
                    if (grid_email_recipients.Rows[i].Cells["chk_recipient"].Value == chk_recipient.TrueValue)
                    {


                        string recipient = grid_email_recipients.Rows[i].Cells["Email"].Value.ToString();

                        Functionsclass.Emailrecipients.Add(recipient + ";");
                        
                      


                    }
                }





                WMPLib.WindowsMediaPlayer sent = new WMPLib.WindowsMediaPlayer();
                sent.URL = @"\\designsvr1\apps\\Design and Supply CSharp\Sounds\Mail Sent.mp3";
                sent.controls.play();
                Send();

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.ToString(), "");

            }
        }

        private void grid_email_recipients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_email_recipients.Columns["chk_recipient"].Index && e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                if (grid_email_recipients.Rows[i].Cells["chk_recipient"].Value == chk_recipient.TrueValue)
                {

                    grid_email_recipients.Rows[i].Cells["chk_recipient"].Value = chk_recipient.FalseValue;


                }
                else
                {

                    grid_email_recipients.Rows[i].Cells["chk_recipient"].Value = chk_recipient.TrueValue;

                }
                
            }




            }

      



    }

}   


