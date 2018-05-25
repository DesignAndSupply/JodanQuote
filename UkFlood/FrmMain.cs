using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkFlood
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Format();
        }
        void Format()
        {


            grid_quote_list.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_quote_list.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_quote_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_quote_list.EnableHeadersVisualStyles = false;


        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
           
            this.adapter_quote_list.Fill(this.quote_dataset.dt_quote_list);

        }

        private void grid_quote_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == grid_quote_list.Columns["btn_open"].Index && e.RowIndex >= 0)
            {








            }
        }
    }
}
