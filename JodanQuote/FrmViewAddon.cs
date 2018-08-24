using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using values;

namespace JodanQuote
{
    public partial class FrmViewAddon : Form
    {
        public FrmViewAddon()
        {
            InitializeComponent();
            this.c_View_Item_Add_OnTableAdapter.Fill(this.dT_Item_Add_On.C_View_Item_Add_On, Valuesclass.quote_id);
            grid_addon.EnableHeadersVisualStyles = false;
            grid_addon.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_addon.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_addon.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_addon.DefaultCellStyle.BackColor = Color.AliceBlue;
          
        }

        private void FrmViewAddon_Shown(object sender, EventArgs e)
        {
            int i = grid_addon.Rows.Count * 20;


            grid_addon.Height = i + 58;

            this.Size = new Size(1087, grid_addon.Height+55);
        }
    }
}
