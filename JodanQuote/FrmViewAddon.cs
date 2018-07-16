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
    }
}
