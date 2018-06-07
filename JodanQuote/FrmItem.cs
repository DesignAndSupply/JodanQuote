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
            Format();
        }
        void Fill_data()
        {

            lbl_quote.Text =  Valuesclass.project_id.ToString();
            lbl_item.Text =  Valuesclass.item_id.ToString();
           // lbl_revision.Text = "Revision Number:  " + Valuesclass.revision_number.ToString();

        }
        void Format()
        {

            grid_extras.EnableHeadersVisualStyles = false;
            grid_extras.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_extras.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_extras.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_extras.DefaultCellStyle.BackColor = Color.AliceBlue;

            grid_freehand_extras.EnableHeadersVisualStyles = false;
            grid_freehand_extras.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_freehand_extras.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_freehand_extras.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_freehand_extras.DefaultCellStyle.BackColor = Color.AliceBlue;

            grid_panel_info.EnableHeadersVisualStyles = false;
            grid_panel_info.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_panel_info.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_panel_info.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_panel_info.DefaultCellStyle.BackColor = Color.AliceBlue;

        }

        private void FrmItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain main = new FrmMain();
        }


      
    }
}
