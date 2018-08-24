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
using Connection;
using values;
using Statements;


namespace JodanQuote
{
    public partial class FrmAddOnSelect : Form
    {
        public FrmAddOnSelect()
        {
            InitializeComponent();
            Fill_Data();
        }

       void Fill_Data()
        {
            this.c_View_Add_On_MaterialTableAdapter.Fill(this.dT_Item_Add_On.C_View_Add_On_Material);
            dT_Material_Thickness.EnforceConstraints = false;
            ada_material_thickness.Fill(dT_Material_Thickness._DT_Material_Thickness, 5);
            cmb_material_thickness_edit.DataBindings.Clear();
            cmb_material_thickness_edit.DataSource = dT_Material_Thickness._DT_Material_Thickness;
            cmb_material_thickness_edit.DisplayMember = "thickness";
            cmb_material_thickness_edit.Text = "1.5";
            this.ada_materials.Fill(dT_Material.DT_materials);
             c_View_AddonsTableAdapter.Fill(dT_Item_Add_On.C_View_Addons, 1);
            cmb_add_on_type.DataBindings.Clear();
            cmb_add_on_type.DataSource = dT_Item_Add_On.C_View_Addons;
            cmb_add_on_type.DisplayMember = "description";

        }

        private void cmb_material_edit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_material_edit.Visible == true && cmb_material_edit.SelectedItem != null == true)
            {

                Int16 id = Convert.ToInt16(((DataRowView)cmb_material_edit.SelectedItem)["id"]);
                dT_Material_Thickness.EnforceConstraints = false;
                ada_material_thickness.Fill(dT_Material_Thickness._DT_Material_Thickness, id);
                cmb_material_thickness_edit.DataBindings.Clear();
                cmb_material_thickness_edit.DataSource = dT_Material_Thickness._DT_Material_Thickness;
                cmb_material_thickness_edit.DisplayMember = "thickness";
                cmb_material_thickness_edit.Text = "1.5";


            }
        }

        private void btn_add_on_Click(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(txt_height.Text);
            int width = Convert.ToInt32(txt_width.Text);
            if (height < 30 || height > 3000)
            {

                MessageBox.Show("Height Must Be Between 30 And 3000", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (width < 30 || width > 3000)
            {

                MessageBox.Show("Width Must Be Between 30 And 3000", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int removable = 0;
            int powder_coating = 0;
            String sql = "C_Insert_Addon";
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand command = new SqlCommand(sql, conn);
            if(chk_removable.Checked == true)
            {
                removable = 1;
                

            }
            if (chk_coating.Checked == true)
            {
                powder_coating = 1;


            }

            int addon_id =Convert.ToInt32(cmb_addon_material_type.SelectedValue);
            SqlCommand insert_hardware = new SqlCommand(Statementsclass.insert_add_on, conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@item_id", Valuesclass.quote_id);
            command.Parameters.AddWithValue("@add_on_id", cmb_add_on_type.SelectedValue);
            command.Parameters.AddWithValue("@add_on_width", width);
            command.Parameters.AddWithValue("@add_on_height", height);
            command.Parameters.AddWithValue("@material_id", cmb_material_edit.SelectedValue);
            command.Parameters.AddWithValue("@material_description", cmb_material_edit.Text);
            command.Parameters.AddWithValue("@material_thickness", cmb_material_thickness_edit.Text);
            command.Parameters.AddWithValue("@add_on_material_id",cmb_addon_material_type.SelectedValue );
            command.Parameters.AddWithValue("@defualt_powder_coat_cost",Convert.ToInt32(dT_Item_Add_On.C_View_Addons.Rows[0]["default_powder_coat_cost"]));
            command.Parameters.AddWithValue("@labour_hours_factor", Convert.ToInt32(dT_Item_Add_On.C_View_Addons.Rows[0]["labour_hours_factor"]));
            command.Parameters.AddWithValue("@material_factor", Convert.ToInt32(dT_Item_Add_On.C_View_Addons.Rows[0]["material_area_factor"]));
            command.Parameters.AddWithValue("@removable", removable);
            command.Parameters.AddWithValue("@powder_coated",powder_coating );
            command.Parameters.AddWithValue("@qty",txt_qty.Text );
            command.Parameters.AddWithValue("@position", txt_position.Text);
            command.ExecuteNonQuery();
            ConnectionClass.Dispose_connection(conn);
            MessageBox.Show("Addon Added To Item", "  Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmb_addon_material_type_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_addon_material_type.Visible == true && cmb_addon_material_type.SelectedItem != null == true)
            {

                Int16 material_id = Convert.ToInt16(((DataRowView)cmb_addon_material_type.SelectedItem)["id"]);
             
                c_View_AddonsTableAdapter.Fill(dT_Item_Add_On.C_View_Addons, material_id);
                cmb_add_on_type.DataBindings.Clear();
                cmb_add_on_type.DataSource = dT_Item_Add_On.C_View_Addons;
                cmb_add_on_type.DisplayMember = "description";
          


            }
          
        }

        private void cmb_add_on_type_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_add_on_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_position.Text = "";
            txt_qty.Text = "";
            txt_height.Text="";
            txt_width.Text = "";
            
        }

        private void btn_structure_width_Click(object sender, EventArgs e)
        {
            txt_width.Text = Valuesclass.structual_op_width.ToString();
            this.ActiveControl = txt_height;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_width_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                this.ActiveControl = txt_height;

            }
               
        }

        private void txt_height_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                this.ActiveControl = txt_qty;

            }
               
        }

        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                this.ActiveControl = txt_position;

            }
               
        }
    }
}
