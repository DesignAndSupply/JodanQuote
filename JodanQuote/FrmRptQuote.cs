using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using Connection;
using values;


using System.Windows.Forms;

namespace JodanQuote
{
    public partial class FrmRptQuote : Form
    {

        DataTable dt = new DataTable();
        public FrmRptQuote()
        {
            InitializeComponent();
        }

        private void FrmRptQuote_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

           
        }
    }
}
