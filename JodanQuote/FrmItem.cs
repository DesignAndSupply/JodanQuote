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
using Statements;

namespace JodanQuote
{
    public partial class FrmItem : Form
    {
        public FrmItem()
        {
            InitializeComponent();
            Fill_data();
        }
        void Fill_data()
        {

            lbl_quote.Text =  Valuesclass.quote_id.ToString();
            lbl_item.Text =  Valuesclass.item_id.ToString();
           // lbl_revision.Text = "Revision Number:  " + Valuesclass.revision_number.ToString();

        }

        private void FrmItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain main = new FrmMain();
        }

       
    }
}
