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
    public partial class FrmNewItem : Form
    {
        public FrmNewItem()
        {
            InitializeComponent();
        }
        void Fill_data()
        {

            lbl_quote.Text = "Quote ID:  " + Valuesclass.quote_id.ToString();
            lbl_item.Text = "Item ID:  " + Valuesclass.item_id.ToString();
            lbl_revision.Text = "Revision Number:  " + Valuesclass.revision_number.ToString();

        }

       
    }
}
