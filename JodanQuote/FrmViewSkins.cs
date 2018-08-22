using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JodanQuote
{
    public partial class FrmViewSkins : Form
    {
        public FrmViewSkins()
        {
            InitializeComponent();
            try
            {
                grid_skins.DataSource = function.Functionsclass.dt_skins;
                grid_skins.EnableHeadersVisualStyles = false;
                grid_skins.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
                grid_skins.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
                grid_skins.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
                grid_skins.DefaultCellStyle.BackColor = Color.AliceBlue;
                grid_skins.Columns["single_double"].HeaderText = "Door Type";
                grid_skins.Columns["material_type"].HeaderText = "Material Type";
                grid_skins.Columns["skin_1_cost"].HeaderText = "Skin 1 Cost";
                grid_skins.Columns["skin_1_cost"].DefaultCellStyle.Format = "C2";
                grid_skins.Columns["skin_2_cost"].HeaderText = "Skin 2 Cost";
                grid_skins.Columns["skin_2_cost"].DefaultCellStyle.Format = "C2";
                grid_skins.Columns["skin_3_cost"].HeaderText = "Skin 3 Cost";
                grid_skins.Columns["skin_3_cost"].DefaultCellStyle.Format = "C2";
                grid_skins.Columns["skin_4_cost"].HeaderText = "Skin 4 Cost";
                grid_skins.Columns["skin_4_cost"].DefaultCellStyle.Format = "C2";
                grid_skins.Columns["infill_cost"].DefaultCellStyle.Format = "C2";
                grid_skins.Columns["infill_cost"].HeaderText = "Infill Cost";
                grid_skins.Columns["paint_cost"].HeaderText = "Paint Cost";
                grid_skins.Columns["paint_cost"].DefaultCellStyle.Format = "C2";
                grid_skins.Columns["fire_cost"].HeaderText = "Fire Cost";
                grid_skins.Columns["fire_cost"].DefaultCellStyle.Format = "C2";
                grid_skins.Columns["security_cost"].HeaderText = "Security Cost";
                grid_skins.Columns["security_cost"].DefaultCellStyle.Format = "C2";
                grid_skins.Columns["jamb_cost"].HeaderText = "Jamb Cost";
                grid_skins.Columns["jamb_cost"].DefaultCellStyle.Format = "C2";
                grid_skins.Columns["labour_hours"].HeaderText = "Labour Hours";
                grid_skins.Columns["hinge_quantity"].HeaderText = "Hinge Quantity";

            }
            catch
            {

            }
        }
    }
}
