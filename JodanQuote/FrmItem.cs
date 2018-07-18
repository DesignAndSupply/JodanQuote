using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;
using values;
using Statements;
using Connection;

namespace JodanQuote
{
    public partial class FrmItem : Form
    {
        public FrmItem()
        {
            InitializeComponent();
            Fill_data();
            Calculate_Cost();
            Format();
            if (Valuesclass.new_item_identifier == 1)
            {
                Valuesclass.locked_identifiter = 1;

            }
            lock_controls();
        }

        private void FrmItem_Shown(object sender, EventArgs e)
        {
            
            Fill_data();
            Calculate_Cost();
            Format();
         
        }

        void Fill_data()
        {
            this.dT_Material.DT_materials.Clear();
            dt_Hardware_Item.EnforceConstraints = false;
            this.ada_Hardware_Item.Fill(dt_Hardware_Item.DT_Hardware_Item, Valuesclass.quote_id);
            this.sALES_LEDGERTableAdapter.Fill(dT_customer.SALES_LEDGER, Valuesclass.customer_name);
            this.ada_Item_Details.Fill(dT_Item_Details._DT_Item_Details, Valuesclass.project_id, Valuesclass.item_id, Valuesclass.revision_number);
            this.c_View_Item_Add_OnTableAdapter.Fill(this.dT_Item_Add_On.C_View_Item_Add_On,Valuesclass.quote_id);
            dT_Door_Type.Clear();
          
            
            double total = 0;
            double addon_total = 0;
            for (int i = 0; i < grid_hardware_on_item.Rows.Count; ++i)
            {

                total += Convert.ToDouble(grid_hardware_on_item.Rows[i].Cells["hardware_cost_total"].Value);


            }
            for (int i = 0; i < grid_addon.Rows.Count; ++i)
            {

                addon_total += Convert.ToDouble(grid_addon.Rows[i].Cells["addon_total_cost"].Value);


            }
            txt_hardware_cost.Text = "£" + total.ToString();
            txt_addon.Text = "£" + addon_total.ToString();
            Calculate_Cost();
          

            if (Valuesclass.new_item_identifier == 1)
            {

                Edit_Items();



            }
           

           
        }

        void Refresh_Data()
        {
            if(panel_total.Enabled == true)
            {


                double total = 0;
                double addon_total = 0;
                for (int i = 0; i < grid_hardware_on_item.Rows.Count; ++i)
                {

                    total += Convert.ToDouble(grid_hardware_on_item.Rows[i].Cells["hardware_cost_total"].Value);


                }
                for (int i = 0; i < grid_addon.Rows.Count; ++i)
                {

                    addon_total += Convert.ToDouble(grid_addon.Rows[i].Cells["addon_total_cost"].Value);


                }
                txt_hardware_cost.Text = "£" + total.ToString();
                txt_addon.Text = "£" + addon_total.ToString();


                txt_project.Text = Valuesclass.project_id.ToString();
                txt_item.Text = Valuesclass.item_id.ToString();
                txt_revision.Text = Valuesclass.revision_number.ToString();

                string material_sales = (Convert.ToString(txt_material_sales_cost.Text.Replace("£", string.Empty)));
                string hardware_sales = (Convert.ToString(txt_hardware_sales_cost.Text.Replace("£", string.Empty)));
                string labour_sales = (Convert.ToString(txt_labour_sales_cost.Text.Replace("£", string.Empty)));
                string paint_sales = (Convert.ToString(txt_paint_total.Text.Replace("£", string.Empty)));
                string total_sales = (Convert.ToString(txt_item_total.Text.Replace("£", string.Empty)));
                string material = (Convert.ToString(txt_material_cost.Text.Replace("£", string.Empty)));
                string hardware = (Convert.ToString(txt_hardware_cost.Text.Replace("£", string.Empty)));
                string addon = (Convert.ToString(txt_addon.Text.Replace("£", string.Empty)));
                string labour = (Convert.ToString(txt_labour_cost.Text.Replace("£", string.Empty)));
                string fire = (Convert.ToString(txt_fire.Text.Replace("£", string.Empty)));
                string security = (Convert.ToString(txt_security.Text.Replace("£", string.Empty)));
                string jamb_width = (Convert.ToString(txt_jamb_width.Text.Replace("m", string.Empty)));
                string jamb_height = (Convert.ToString(txt_jamb_height.Text.Replace("m", string.Empty)));

                if (material_sales == "")
                {
                    material_sales = "0";

                }
                if (hardware_sales == "")
                {
                    hardware_sales = "0";

                }
                if (paint_sales == "")
                {
                    paint_sales = "0";

                }
                if (total_sales == "")
                {
                    total_sales = "0";

                }
                if (material == "")
                {
                    material = "0";

                }
                if (hardware == "")
                {
                    hardware = "0";

                }
                if (labour == "")
                {
                    labour = "0";

                }
                if (labour_sales == "")
                {

                    labour_sales = "0";
                }

                if (fire == "")
                {
                    fire = "0";

                }
                if (security == "")
                {
                    security = "0";

                }
                if (jamb_height == "")
                {
                    jamb_height = "0";

                }
                if (jamb_width == "")
                {
                    jamb_width = "0";

                }
                if (addon == "")
                {
                    addon = "0";

                }

                txt_material_sales_cost.Text = "£" + material_sales;
                txt_hardware_sales_cost.Text = "£" + hardware_sales;
                txt_paint_total.Text = "£" + paint_sales;
                txt_labour_sales_cost.Text = "£" + labour_sales;
                txt_item_total.Text = "£" + total_sales;
                txt_material_cost.Text = "£" + material;
                txt_hardware_cost.Text = "£" + hardware;
                txt_addon.Text = "£" + addon;
                txt_labour_cost.Text = "£" + labour;
                txt_fire.Text = "£" + fire;
                txt_security.Text = "£" + security;
                txt_jamb_height.Text = jamb_height + "mm";
                txt_jamb_width.Text = jamb_width + "mm";

                try
                {
                    double hardware_markup = Convert.ToDouble(txt_hardware_markup.Text);
                    double hardware_cost = Convert.ToDouble(Convert.ToString(txt_hardware_cost.Text.Replace("£", string.Empty)));
                    double sales_hardware = total * hardware_markup;
                    txt_hardware_sales_cost.Text = "£" + Convert.ToString(sales_hardware);

                    double material_markup = Convert.ToDouble(txt_material_markup.Text);
                    double material_cost = Convert.ToDouble(Convert.ToString(txt_material_cost.Text.Replace("£", string.Empty)));
                    double sales_material = material_cost * material_markup;
                    txt_material_sales_cost.Text = "£" + Convert.ToString(sales_material);
                    txt_material_cost.Text = "£" + material_cost;

                    double labour_markup = Convert.ToDouble(txt_labour_markup.Text);
                    double labour_cost = Convert.ToDouble(Convert.ToString(txt_labour_cost.Text.Replace("£", string.Empty)));
                    double security_cost = Convert.ToDouble(Convert.ToString(txt_security.Text.Replace("£", string.Empty)));
                    double fire_cost = Convert.ToDouble(Convert.ToString(txt_fire.Text.Replace("£", string.Empty)));

                    double sales_labour = labour_markup * Convert.ToInt32(labour_cost);
                    txt_labour_sales_cost.Text = "£" + Convert.ToString(sales_labour);
                    txt_labour_cost.Text = "£" + labour_cost;

                    double paint_cost = Convert.ToDouble(Convert.ToString(txt_paint_total.Text.Replace("£", string.Empty)));
                    double addon_cost = Convert.ToDouble(Convert.ToString(txt_addon.Text.Replace("£", string.Empty)));
                   


                    double item_total = (sales_labour + sales_hardware + paint_cost + sales_material)+security_cost + fire_cost+ addon_cost;
                    txt_item_total.Text = "£" + Convert.ToString(item_total);
                }

                catch
                {
                    return;
                }
               




            }




        }
        
        void Edit_Items()
        {

            this.ada_finish.Fill(dT_finish.dt_finish);

            this.c_View_Security_RatingTableAdapter.Fill(this.dT_Ratings.C_View_Security_Rating);
            this.c_View_Fire_RatingsTableAdapter.Fill(this.dT_Ratings.C_View_Fire_Ratings);

            ConnectionClass.Dispose_connection(ada_materials.Connection);
            ada_materials.Connection = ConnectionClass.GetConnection_jodan_quote();
            this.ada_materials.Fill(dT_Material.DT_materials);
            cmb_material_edit.DataSource = dT_Material.DT_materials;
            cmb_material_edit.DisplayMember = "description";
            cmb_material_edit.ValueMember = "id";
            cmb_material_edit.TabIndex = 1;

            this.ada_Jamb_Styles.Fill(this.dT_Jam_Styles.C_View_Jam_Styles);
            cmb_jam_style_edit.DataSource = this.dT_Jam_Styles.C_View_Jam_Styles;
            cmb_jam_style_edit.DisplayMember = "description";
            cmb_jam_style_edit.ValueMember = "id";

            this.ada_door_styles.Fill(dT_Door_Type.DT_door_styles);
            cmb_door_type_edit.DataSource = dT_Door_Type.DT_door_styles;
            cmb_door_type_edit.DisplayMember = "description";
            cmb_door_type_edit.ValueMember = "id";

            cmb_material_thickness_edit.Visible = true;
            cmb_material_thickness.Visible = false;
            cmb_material_edit.Visible = true;
            cmb_material.Visible = false;
            cmb_finish_edit.Visible = true;
            cmb_finish.Visible = false;
            cmb_door_type_edit.Visible = true;
            cmb_door_type.Visible = false;
            cmb_fire_edit.Visible = true;
            cmb_fire.Visible = false;
            cmb_security_edit.Visible = true;
            cmb_security.Visible = false;
            cmb_jam_style_edit.Visible = true;
            cmb_jam_style.Visible = false;

            txt_item.Text = Convert.ToString(Valuesclass.item_id);
            txt_project.Text = Convert.ToString(Valuesclass.project_id);
            txt_revision.Text = Convert.ToString(Valuesclass.revision_number);
            Combobox_values();

            txt_material_sales_cost.Text = "£" + (Convert.ToString(txt_material_sales_cost.Text.Replace("£", string.Empty)));
            txt_hardware_sales_cost.Text = "£" + (Convert.ToString(txt_hardware_sales_cost.Text.Replace("£", string.Empty)));
            txt_paint_total.Text = "£" + (Convert.ToString(txt_paint_total.Text.Replace("£", string.Empty)));
            txt_labour_sales_cost.Text = "£" + (Convert.ToString(txt_labour_sales_cost.Text.Replace("£", string.Empty)));
            txt_item_total.Text = "£" + (Convert.ToString(txt_item_total.Text.Replace("£", string.Empty)));
            txt_addon.Text = "£" + (Convert.ToString(txt_addon.Text.Replace("£", string.Empty)));
            txt_security.Text = "£" + (Convert.ToString(txt_security.Text.Replace("£", string.Empty)));
            txt_fire.Text = "£" + (Convert.ToString(txt_fire.Text.Replace("£", string.Empty)));
            txt_jamb_height.Text = (Convert.ToString(txt_jamb_height.Text.Replace("m", string.Empty))) + "mm";
            txt_jamb_width.Text = (Convert.ToString(txt_jamb_width.Text.Replace("m", string.Empty))) + "mm";

            double total = 0;
            double addon_total =0;
            for (int i = 0; i < grid_hardware_on_item.Rows.Count; ++i)
            {

                total += Convert.ToDouble(grid_hardware_on_item.Rows[i].Cells["hardware_cost_total"].Value);


            }
            for (int i = 0; i < grid_addon.Rows.Count; ++i)
            {

                addon_total += Convert.ToDouble(grid_addon.Rows[i].Cells["addon_total_cost"].Value);


            }
            txt_hardware_cost.Text = "£" + total.ToString();
            txt_addon.Text = "£" + addon_total.ToString();
            Calculate_Cost();
         
        }

        void Format()
        {

            grid_addon.EnableHeadersVisualStyles = false;
            grid_addon.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_addon.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_addon.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_addon.DefaultCellStyle.BackColor = Color.AliceBlue;


            grid_hardware_on_item.EnableHeadersVisualStyles = false;
            grid_hardware_on_item.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_hardware_on_item.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_hardware_on_item.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_hardware_on_item.DefaultCellStyle.BackColor = Color.AliceBlue;

        

        }

        void Calculate_Cost()
        {
            if (dT_Item_Details._DT_Item_Details.Rows.Count > 0)
            {
                DataTable dt = new DataTable();
                txt_list.Text = "";
                txt_warning.Visible = false;
                for (var i = 0; i < Valuesclass.Calculate_material_list.Count; i++)

                {
                    object val = dT_Item_Details._DT_Item_Details.Rows[0][Convert.ToString(Valuesclass.Calculate_material_list[i])];
                    if (val == DBNull.Value)
                    {
                        string Null_column = "- " + Valuesclass.Calculate_material_list[i].ToString().Replace("_", " ");
                        txt_list.AppendText(Environment.NewLine);
                        txt_list.Text = txt_list.Text + Null_column.ToString();


                    }

                }
                if (txt_list.Text != "")
                {

                    txt_warning.Visible = true;
                    return;

                }


             
                String sql = "C_Calculate_Material_Cost";
                SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(command);


                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@project_id", dT_Item_Details._DT_Item_Details.Rows[0]["project_id"].ToString());
                command.Parameters.AddWithValue("@item_id", dT_Item_Details._DT_Item_Details.Rows[0]["item_id"].ToString());
                command.Parameters.AddWithValue("@revision_id", dT_Item_Details._DT_Item_Details.Rows[0]["revision_id"].ToString());
                command.Parameters.AddWithValue("@material_description", dT_Item_Details._DT_Item_Details.Rows[0]["Material Description"].ToString());
                command.Parameters.AddWithValue("@Material_thickness", Convert.ToDouble(dT_Item_Details._DT_Item_Details.Rows[0]["Material_thickness"]));
                command.Parameters.AddWithValue("@door_type", Convert.ToInt32(dT_Item_Details._DT_Item_Details.Rows[0]["door_type_id"].ToString()));
                command.Parameters.AddWithValue("@structual_op_width", Convert.ToInt32(dT_Item_Details._DT_Item_Details.Rows[0]["structual_op_width"]));
                command.Parameters.AddWithValue("@structual_op_height", Convert.ToInt32(dT_Item_Details._DT_Item_Details.Rows[0]["structual_op_height"]));
                command.Parameters.AddWithValue("@finish_description", Convert.ToString(dT_Item_Details._DT_Item_Details.Rows[0]["Finish Description"]));
                command.Parameters.AddWithValue("@fire_rating_id", Convert.ToInt32(cmb_fire_edit.SelectedValue));
                command.Parameters.AddWithValue("@security_rating_id", Convert.ToString(cmb_security_edit.SelectedValue));


               //
                da.Fill(dt);
                ConnectionClass.Dispose_connection(conn);

              
                double total_cost = 0;

                for (int i = 2; i <= 5; ++i)
                {
                    // MessageBox.Show(table.Rows[0][i].ToString(),"");


                    total_cost += Convert.ToDouble(dt.Rows[0][i].ToString());


                }

             
                txt_material_cost.Text = "£" + total_cost.ToString();
                txt_paint_total.Text = "£" + Convert.ToString(dt.Rows[0]["paint_cost"]);
                

               


                
            string material_sales = (Convert.ToString(txt_material_sales_cost.Text.Replace("£", string.Empty)));
            string hardware_sales = (Convert.ToString(txt_hardware_sales_cost.Text.Replace("£", string.Empty)));
            string labour_sales = (Convert.ToString(txt_labour_sales_cost.Text.Replace("£", string.Empty)));
            string paint_sales = (Convert.ToString(txt_paint_total.Text.Replace("£", string.Empty)));
            string total_sales = (Convert.ToString(txt_item_total.Text.Replace("£", string.Empty)));
            string material = (Convert.ToString(txt_material_cost.Text.Replace("£", string.Empty)));
            string hardware =  (Convert.ToString(txt_hardware_cost.Text.Replace("£", string.Empty)));
            string labour =  (Convert.ToString(txt_labour_cost.Text.Replace("£", string.Empty)));
            string fire = (Convert.ToString(txt_fire.Text.Replace("£", string.Empty)));
            string security = (Convert.ToString(txt_security.Text.Replace("£", string.Empty)));
            string jamb_width = (Convert.ToString(txt_jamb_width.Text.Replace("m", string.Empty)));
            string jamb_height = (Convert.ToString(txt_jamb_height.Text.Replace("m", string.Empty)));
            string addon = (Convert.ToString(txt_addon.Text.Replace("£", string.Empty)));
              
           

            if (material_sales == "")
            {
                material_sales = "0";

            }
            if (hardware_sales == "")
            {
                hardware_sales = "0";

            }
            if (paint_sales == "")
            {
                paint_sales = "0";

            }
            if (total_sales == "")
            {
                total_sales = "0";

            }
            if (material == "")
            {
                material = "0";

            }
            if (hardware == "")
            {
                hardware = "0";

            }
            if (addon == "")
            {
                addon = "0";

            }
            if (labour == "")
            {
                labour = "0";

            }
            if(labour_sales == "")
            {

                labour_sales = "0";
            }

            if (fire == "")
            {

                fire = "0";
            }
            if (security == "")
            {

                security = "0";
            }
            if (jamb_height == "")
             {
                jamb_height = "0";

             }
            if (jamb_width == "")
            {
                jamb_width = "0";

            }

            txt_material_sales_cost.Text = "£" + material_sales;
            txt_hardware_sales_cost.Text = "£" + hardware_sales;
            txt_paint_total.Text = "£" + paint_sales;
            txt_labour_sales_cost.Text = "£" + labour_sales;
            txt_item_total.Text = "£" + total_sales;
            txt_material_cost.Text = "£" + material;
            txt_hardware_cost.Text = "£" + hardware;
            txt_labour_cost.Text = "£" + labour;
             txt_addon.Text = "£" + addon;
            txt_fire.Text = "£" + fire;
            txt_security.Text = "£" + security;
            txt_jamb_width.Text = jamb_width + "mm";
            txt_jamb_height.Text = jamb_height + "mm";


            }

            Refresh_Data();

        }

        void Calculate_Cost_Edit_Mode()
        {
            try
            {
                if (dT_Item_Details._DT_Item_Details.Rows.Count < 0 )
                {

                  //  return;
                }

                else
                {


                    txt_list.Text = "";
                    txt_warning.Visible = false;

                    for (var i = 0; i < Valuesclass.Calculate_material_list.Count; i++)

                    {
                        object val = dT_Item_Details._DT_Item_Details.Rows[0][Convert.ToString(Valuesclass.Calculate_material_list[i])];
                        if (val == DBNull.Value)
                        {
                            string Null_column = "- " + Valuesclass.Calculate_material_list[i].ToString().Replace("_", " ");
                            txt_list.AppendText(Environment.NewLine);
                            txt_list.Text = txt_list.Text + Null_column.ToString();


                        }

                    }
                    if (txt_list.Text != "")
                    {

                        txt_warning.Visible = true;
                        // return;

                    }



                  //  DataTable table = new DataTable();
                    String sql = "C_Calculate_Material_Cost";
                    SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(command);

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
                    command.Parameters.AddWithValue("@item_id", Valuesclass.item_id);
                    command.Parameters.AddWithValue("@revision_id", Valuesclass.revision_number);
                    command.Parameters.AddWithValue("@material_description", cmb_material_edit.Text);
                    command.Parameters.AddWithValue("@Material_thickness", Convert.ToDouble(cmb_material_thickness_edit.Text));
                    command.Parameters.AddWithValue("@door_type", cmb_door_type_edit.SelectedValue);
                    command.Parameters.AddWithValue("@structual_op_width", Convert.ToInt32(txt_structual_width.Text));
                    command.Parameters.AddWithValue("@structual_op_height", Convert.ToInt32(txt_structual_height.Text));
                    command.Parameters.AddWithValue("@finish_description", Convert.ToString(cmb_finish_edit.Text));
                    command.Parameters.AddWithValue("@fire_rating_id", Convert.ToInt32(cmb_fire_edit.SelectedValue));
                    command.Parameters.AddWithValue("@security_rating_id", Convert.ToString(cmb_security_edit.SelectedValue));
                    function.Functionsclass.dt_skins.Clear();
                    da.Fill(function.Functionsclass.dt_skins);
                    if (function.Functionsclass.dt_skins.Rows.Count < 0)
                    {
                        return;
                    }
                    double total_cost = 0;

                    for (int i = 2; i <= 5; ++i)
                    {

                        total_cost += Convert.ToDouble(function.Functionsclass.dt_skins.Rows[0][i].ToString());

                    }

                    txt_material_cost.Text = "£" + total_cost.ToString();
                    txt_paint_total.Text = "£" + Convert.ToString(function.Functionsclass.dt_skins.Rows[0]["paint_cost"]);
                    txt_security.Text = "£" + Convert.ToString(function.Functionsclass.dt_skins.Rows[0]["security_cost"]);
                    txt_fire.Text = "£" + Convert.ToString(function.Functionsclass.dt_skins.Rows[0]["fire_cost"]);
                    ConnectionClass.Dispose_connection(conn);
                    return;
                }

            }
          
             catch(Exception)
            {
                //MessageBox.Show(ex.ToString(), "");
            }
        }

        void lock_controls()
        {
           

            if (Valuesclass.locked_identifiter == 0)
            {
                
                panel_door_input.Enabled = false;
                panel_spec.Enabled = false;
                panel_addon.Enabled = false;
                panel_spec.Enabled = false;
                panel_addon.Enabled = false;
                panel_total.Enabled = false;
                panel_handle.Enabled = false;
                btn_save.Enabled = false;
                btn_revise.Enabled = false;
                btn_printscren.Enabled = false;
                btn_save.Enabled = false;
                btn_add_hardware.Enabled = true;
                btn_dimensions.Enabled = true;
                btn_lock.Enabled = true;
                Valuesclass.locked_identifiter = 1;
                btn_lock.Text = "         Unlock";
                btn_lock.Image = JodanQuote.Properties.Resources.unlock;

                cmb_material_thickness.Visible = true;
                cmb_material_thickness_edit.Visible = false;
                cmb_material.Visible = true;
                cmb_material_edit.Visible = false;
                cmb_finish.Visible = true;
                cmb_finish_edit.Visible = false;
                cmb_door_type.Visible = true;
                cmb_door_type_edit.Visible = false;
                cmb_security_edit.Visible = false;
                cmb_security.Visible = true;
                cmb_fire_edit.Visible = false;
                cmb_fire.Visible = true;
                cmb_jam_style_edit.Visible = false;
                cmb_jam_style.Visible = true;
                Fill_data();
          
                return;

            }
            else
            {
                panel_door_input.Enabled = true;
                panel_handle.Enabled = true;
                panel_addon.Enabled = true;
                panel_spec.Enabled = true;
                panel_addon.Enabled = true;
                panel_total.Enabled = true;
                btn_lock.Text = "        Lock";
                btn_lock.Image = JodanQuote.Properties.Resources.locked;
                btn_save.Enabled = true;
                btn_revise.Enabled = true;
                btn_printscren.Enabled = true;
                btn_save.Enabled = true;
                Valuesclass.locked_identifiter = 0;

                Edit_Items();


                Combobox_values();
                    





                return;
            }

        }

        void Combobox_values()
        {



            if (cmb_door_type.Text != null)
            {
               

                cmb_door_type_edit.Text = cmb_door_type.Text;

            }
            else
            {
                cmb_door_type_edit.SelectedIndex = 1;
            }
            if (cmb_material.Text != null && cmb_material.Text != "")
            {

                cmb_material_edit.Text = cmb_material.Text;
                Fill_material_thickness();

            }
            else
            {
                cmb_material_edit.SelectedIndex = 1;
                Fill_material_thickness();
            }
            if(cmb_finish.Text!=null)
            {

                cmb_finish_edit.Text = cmb_finish.Text;
            }
            else
            {
                cmb_finish_edit.SelectedIndex = 1;
            }
            if (cmb_fire.Text != null)
            {

                cmb_fire_edit.Text = cmb_fire.Text;
            }
            else
            {
                cmb_fire_edit.SelectedIndex = 1;
            }
            if (cmb_security.Text != null)
            {

                cmb_security_edit.Text = cmb_security.Text;
            }
            else
            {
                cmb_security_edit.SelectedIndex = 1;
            }
            if (cmb_jam_style.Text != null)
            {

                cmb_jam_style_edit.Text = cmb_jam_style.Text;
            }
            else
            {
                cmb_jam_style.SelectedIndex = 1;
            }

            if(cmb_material_thickness.Text != null)
            {

                cmb_material_thickness_edit.Text = cmb_material_thickness.Text;
            }

        }

        void Max_Quote()
        {

            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand select_max_quote_id = new SqlCommand(Statementsclass.select_max_quote_id, conn);
            SqlDataReader read_max_quote_id = select_max_quote_id.ExecuteReader();

            if (read_max_quote_id.Read())
            {
                Valuesclass.quote_id = (Convert.ToInt32(read_max_quote_id["Quote ID"])) + 1;
                read_max_quote_id.Close();
            }

            ConnectionClass.Dispose_connection(conn);

        }

        void Copy_Hardware()
        {
            Max_Quote();

            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
           
            for (int i = 0; i < grid_hardware_on_item.Rows.Count; i++)
            {

                SqlCommand insert_hardware = new SqlCommand(Statementsclass.insert_hardware, conn);
                insert_hardware.Parameters.AddWithValue("@id", Valuesclass.quote_id);
                insert_hardware.Parameters.AddWithValue("@hardware_id", grid_hardware_on_item.Rows[i].Cells["ID_hardware"].Value);
                insert_hardware.Parameters.AddWithValue("@hardware_description", grid_hardware_on_item.Rows[i].Cells["description"].Value);
                insert_hardware.Parameters.AddWithValue("@hardware_cost", grid_hardware_on_item.Rows[i].Cells["hardware_cost_sale"].Value);
                insert_hardware.Parameters.AddWithValue("@Quantity", grid_hardware_on_item.Rows[i].Cells["quantity_hardware"].Value);
                insert_hardware.Parameters.AddWithValue("@total_cost", grid_hardware_on_item.Rows[i].Cells["hardware_cost_total"].Value);
                insert_hardware.ExecuteNonQuery();



            }

            ConnectionClass.Dispose_connection(conn);




        }

        void Fill_material_thickness()
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
                Calculate_Cost_Edit_Mode();

            }

        }

        void Fill_jamb_details()
        {


            if (cmb_jam_style_edit.Visible == true && cmb_jam_style_edit.SelectedItem != null == true)
            {

                Int16 id = Convert.ToInt16(((DataRowView)cmb_jam_style_edit.SelectedItem)["id"]);
                dT_Material_Thickness.EnforceConstraints = false;
                txt_jamb_height.Text = dT_Jam_Styles.C_View_Jam_Styles.Rows[id-1]["default_jamb_depth"].ToString() + "mm";
                txt_jamb_width.Text = dT_Jam_Styles.C_View_Jam_Styles.Rows[id-1]["default_jamb_width"].ToString() + "mm";
            }

        }

        private void FrmItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
        }

        private void btn_dimensions_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_frame_height.Text) != true && string.IsNullOrWhiteSpace(txt_frame_width.Text) != true)
            {
                Valuesclass.dimension_height = Convert.ToInt32(txt_structual_height.Text);
                Valuesclass.dimension_width = Convert.ToInt32(txt_structual_width.Text);

            }
            else
            {
                Valuesclass.dimension_height = 0;
                Valuesclass.dimension_width = 0;

            }

            Valuesclass.item_id = Convert.ToInt32(txt_item.Text.ToString());

            FrmDimensions dimensions = new FrmDimensions();
            dimensions.ShowDialog();
            Valuesclass.new_item_identifier = 0;
            Valuesclass.locked_identifiter = 0;
            string dorr = cmb_door_type_edit.Text;
        
            ConnectionClass.Dispose_connection(ada_materials.Connection);
       
          
            ada_Item_Details.Fill(dT_Item_Details._DT_Item_Details,Valuesclass.project_id,Valuesclass.item_id,Valuesclass.revision_number);
            ada_door_styles.Fill(dT_Door_Type.DT_door_styles);
            cmb_door_type_edit.Text = dorr;
            Calculate_Cost_Edit_Mode();
            Refresh_Data();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuote quote = new FrmQuote();
            quote.Show();
        }

        private void btn_printscren_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
            int width = this.Width-45;
            int height = this.Height- 45;
            string path = @"\\designsvr1\apps\Design and Supply CSharp\Source Files\JodanQuote\Temp Folder\Item Printscreen.JPG";
            Bitmap printscreen = new Bitmap(width, height);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(227, 150, 0, 0, printscreen.Size);

            printscreen.Save(path, ImageFormat.Jpeg);

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;
            pd.DefaultPageSettings.Color = false;
            pd.PrintPage += PrintPage;
            pd.Print();
        }

        private void PrintPage(object o, PrintPageEventArgs e)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(@"\\designsvr1\apps\Design and Supply CSharp\Source Files\JodanQuote\Temp Folder\Item Printscreen.JPG");
            Point loc = new Point(-210, -140);
            e.Graphics.DrawImage(img, loc);
        }

        private void btn_lock_Click(object sender, EventArgs e)
        {
            lock_controls();
          

        }

        private void btn_add_hardware_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHardwareSelect select = new FrmHardwareSelect();
            select.Show();
        }
       
        private void btn_save_Click(object sender, EventArgs e)
        {
            Refresh_Data();

            foreach(Control cntrl in panel_door_input.Controls)
            {
                if(cntrl is ComboBox)
                {
                    ComboBox cmb = cntrl as ComboBox;

                    if (string.IsNullOrEmpty(cmb.Text))
                    {

                        cntrl.Text = "";
                    }
                    if (cmb.SelectedItem == null && cmb.Visible == true)
                    {
                        MessageBox.Show("Please Ensure All Door Input Boxes Have A Value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                if(cntrl is TextBox)
                {


                    TextBox text = cntrl as TextBox;

                    if (string.IsNullOrEmpty(text.Text) && text.Visible == true)
                    {
                        MessageBox.Show("Please Ensure All Door Input Boxes Have A Value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
             

            }

            int material_id = Convert.ToInt16(((DataRowView)cmb_material_edit.SelectedItem)["id"]);
            string materialthickness = cmb_material_thickness_edit.Text;
            int finish_id = Convert.ToInt16(((DataRowView)cmb_finish_edit.SelectedItem)["id"]);
            int door_type_id = Convert.ToInt16(((DataRowView)cmb_door_type_edit.SelectedItem)["id"]);
            int jamb_style_id = Convert.ToInt16(((DataRowView)cmb_jam_style_edit.SelectedItem)["id"]);
            int fire_rating_id = Convert.ToInt16(((DataRowView)cmb_fire_edit.SelectedItem)["id"]);
            int security_rating_id = Convert.ToInt16(((DataRowView)cmb_security_edit.SelectedItem)["id"]);
            string material_cost = Convert.ToString(txt_material_sales_cost.Text.Replace("£", string.Empty));
            string hardware_cost = Convert.ToString(txt_hardware_sales_cost.Text.Replace("£", string.Empty));
            string labour_cost = Convert.ToString(txt_labour_sales_cost.Text.Replace("£", string.Empty));
            string paint_total = Convert.ToString(txt_paint_total.Text.Replace("£", string.Empty));
            string total_cost = Convert.ToString(txt_item_total.Text.Replace("£", string.Empty));
            string fire_cost = Convert.ToString(txt_fire.Text.Replace("£", string.Empty));
            string security_cost = Convert.ToString(txt_security.Text.Replace("£", string.Empty));
            string jamb_width = Convert.ToString(txt_jamb_width.Text.Replace("m", string.Empty));
            string jamb_height = Convert.ToString(txt_jamb_height.Text.Replace("m", string.Empty));

            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand update_quotation_item = new SqlCommand(Statementsclass.update_quotation_item, conn);
            update_quotation_item.Parameters.AddWithValue("@structure_width", txt_structual_width.Text);
            update_quotation_item.Parameters.AddWithValue("@structure_height", txt_structual_height.Text);
            update_quotation_item.Parameters.AddWithValue("@frame_height", txt_frame_height.Text);
            update_quotation_item.Parameters.AddWithValue("@frame_width", txt_frame_width.Text);
            update_quotation_item.Parameters.AddWithValue("@finish_id", finish_id);
            update_quotation_item.Parameters.AddWithValue("@fire_id", fire_rating_id);
            update_quotation_item.Parameters.AddWithValue("@security_rating_id", security_rating_id);
            update_quotation_item.Parameters.AddWithValue("@material_thickness", materialthickness);
            update_quotation_item.Parameters.AddWithValue("@material_id", material_id);
            update_quotation_item.Parameters.AddWithValue("@jamb_style_id", jamb_style_id);
            update_quotation_item.Parameters.AddWithValue("@jamb_width", jamb_width);
            update_quotation_item.Parameters.AddWithValue("@jamb_height", jamb_height);
            update_quotation_item.Parameters.AddWithValue("@markup_hardware",txt_hardware_markup.Text );
            update_quotation_item.Parameters.AddWithValue("@door_type", door_type_id);
            update_quotation_item.Parameters.AddWithValue("@markup_material", txt_material_markup.Text);
            update_quotation_item.Parameters.AddWithValue("@labour_rate",txt_labour_markup.Text ); 
            update_quotation_item.Parameters.AddWithValue("@hardware_cost", hardware_cost);
            update_quotation_item.Parameters.AddWithValue("@material_cost", material_cost);
            update_quotation_item.Parameters.AddWithValue("@fire_rating_cost", fire_cost);
            update_quotation_item.Parameters.AddWithValue("@security_rating_cost", security_cost);
            update_quotation_item.Parameters.AddWithValue("@labour_cost", labour_cost);
            update_quotation_item.Parameters.AddWithValue("@paint_cost", paint_total);
            update_quotation_item.Parameters.AddWithValue("@total_cost", total_cost);
            update_quotation_item.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            update_quotation_item.Parameters.AddWithValue("@item_id", Valuesclass.item_id);
            update_quotation_item.Parameters.AddWithValue("@revision_id", Valuesclass.revision_number);
           
            update_quotation_item.ExecuteNonQuery();
            ConnectionClass.Dispose_connection(conn);
            MessageBox.Show("Item Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Valuesclass.new_item_identifier = 0;
            lock_controls();
            Fill_data();
            Calculate_Cost();
            btn_back.PerformClick();
        }
               
        private void btn_add_hardware_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            FrmHardwareSelect select = new FrmHardwareSelect();
            select.ShowDialog();
            Valuesclass.new_item_identifier = 0;
            Fill_data();
            Refresh_Data();
            Edit_Items();
        }

        private void btn_revise_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you Sure You Want To Revise This Item?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {

                if (Valuesclass.new_item_identifier == 0)
                {

                    string project_id = dT_Item_Details._DT_Item_Details.Rows[0]["project_id"].ToString();
                    string item_id = dT_Item_Details._DT_Item_Details.Rows[0]["item_id"].ToString();
                    int Revision = Convert.ToInt32(dT_Item_Details._DT_Item_Details.Rows[0]["Revision_id"].ToString());
                    string order_id = dT_Item_Details._DT_Item_Details.Rows[0]["order_id"].ToString();
                    string material_id = dT_Item_Details._DT_Item_Details.Rows[0]["material_id"].ToString();
                    string finish_id = dT_Item_Details._DT_Item_Details.Rows[0]["finish_id"].ToString();
                    string door_ref = dT_Item_Details._DT_Item_Details.Rows[0]["door_ref"].ToString();
                    string door_style = dT_Item_Details._DT_Item_Details.Rows[0]["door_style"].ToString();
                    string door_type = dT_Item_Details._DT_Item_Details.Rows[0]["door_type"].ToString();
                    string structual_op_height = dT_Item_Details._DT_Item_Details.Rows[0]["structual_op_height"].ToString();
                    string structual_op_width = dT_Item_Details._DT_Item_Details.Rows[0]["structual_op_width"].ToString();
                    string frame_width = dT_Item_Details._DT_Item_Details.Rows[0]["frame_width"].ToString();
                    string frame_height = dT_Item_Details._DT_Item_Details.Rows[0]["frame_height"].ToString();
                    string total_cost = dT_Item_Details._DT_Item_Details.Rows[0]["total_cost"].ToString();
                    string material_thickness = dT_Item_Details._DT_Item_Details.Rows[0]["material_thickness"].ToString();
                    string finish_description = dT_Item_Details._DT_Item_Details.Rows[0]["Finish Description"].ToString();
                    string markup_hardware = dT_Item_Details._DT_Item_Details.Rows[0]["markup_hardware"].ToString();
                    string markup_material = dT_Item_Details._DT_Item_Details.Rows[0]["markup_material"].ToString();
                    string labour_rate = dT_Item_Details._DT_Item_Details.Rows[0]["labour_rate"].ToString();
                    string material_cost = dT_Item_Details._DT_Item_Details.Rows[0]["material_cost"].ToString();
                    string hardware_cost = dT_Item_Details._DT_Item_Details.Rows[0]["hardware_cost"].ToString();
                    string labour_cost = dT_Item_Details._DT_Item_Details.Rows[0]["labour_cost"].ToString();
                    string paint_cost = dT_Item_Details._DT_Item_Details.Rows[0]["paint_cost"].ToString();
                    string item_total = dT_Item_Details._DT_Item_Details.Rows[0]["total_cost"].ToString();

                    SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                    SqlCommand revise_item = new SqlCommand(Statementsclass.revise_item, conn);
                    revise_item.Parameters.AddWithValue("@item_id", item_id);
                    revise_item.Parameters.AddWithValue("@project_id", project_id);
                    revise_item.Parameters.AddWithValue("@item_date", DateTime.Now);
                    revise_item.Parameters.AddWithValue("@revision_id", Revision + 1);
                    revise_item.Parameters.AddWithValue("@material_id", material_id);
                    revise_item.Parameters.AddWithValue("@finish_id", finish_id);
                    revise_item.Parameters.AddWithValue("@door_ref", door_ref);
                    revise_item.Parameters.AddWithValue("@door_type", door_type);
                    revise_item.Parameters.AddWithValue("@door_style", door_style);
                    revise_item.Parameters.AddWithValue("@structual_op_height", structual_op_height);
                    revise_item.Parameters.AddWithValue("@structual_op_width", structual_op_width);
                    revise_item.Parameters.AddWithValue("@frame_width", frame_width);
                    revise_item.Parameters.AddWithValue("@frame_height", frame_height);
                    revise_item.Parameters.AddWithValue("@finish_description", finish_description);
                    revise_item.Parameters.AddWithValue("@material_thickness", material_thickness);
                    revise_item.Parameters.AddWithValue("@created_by", loginclass.Login.globalFullName);
                    revise_item.Parameters.AddWithValue("@markup_hardware", markup_hardware);
                    revise_item.Parameters.AddWithValue("@markup_material", markup_material);
                    revise_item.Parameters.AddWithValue("@labour_rate", labour_rate);
                    revise_item.Parameters.AddWithValue("@hardware_cost", hardware_cost);
                    revise_item.Parameters.AddWithValue("@material_cost", material_cost);
                    revise_item.Parameters.AddWithValue("@labour_cost", labour_cost);
                    revise_item.Parameters.AddWithValue("@oaint_cost", paint_cost);
                    revise_item.Parameters.AddWithValue("@total_cost", item_total);
                    revise_item.ExecuteNonQuery();
                    ConnectionClass.Dispose_connection(conn);
                    Valuesclass.revision_number = Revision + 1;
                    MessageBox.Show("Item Successfully Revised", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Max_Quote();
                Copy_Hardware();
                
                dT_Door_Type.Clear();
                this.dt_Hardware_Item.DT_Hardware_Item.Clear();
                this.dT_Material.DT_materials.Clear();
                dt_Hardware_Item.EnforceConstraints = false;
                this.sALES_LEDGERTableAdapter.Fill(dT_customer.SALES_LEDGER, Valuesclass.customer_name);
                this.ada_Hardware_Item.Fill(dt_Hardware_Item.DT_Hardware_Item, Valuesclass.quote_id);
                this.ada_Item_Details.Fill(dT_Item_Details._DT_Item_Details, Valuesclass.project_id, Valuesclass.item_id, Valuesclass.revision_number);
            }

            else
            {
                return;
            }
            Valuesclass.locked_identifiter = 1;
            Fill_data();
            lock_controls();
            Edit_Items();
        }

        private void grid_hardware_on_item_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dT_Item_Details.Tables[0].Rows.Count <0)

            {
                if (e.ColumnIndex == 2)
                {
                    //Calculate_Cost_Edit_Mode();
                    Refresh_Data();
                }


            }
           


        }

        private void txt_material_markup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Calculate_Cost_Edit_Mode();
                Refresh_Data();

            }
            catch
            {

            }
        }

        private void txt_hardware_markup_TextChanged(object sender, EventArgs e)
        {
            try
            {
         
                Refresh_Data();

            }
            catch
            {

            }
        }

        private void txt_labour_markup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Calculate_Cost_Edit_Mode();
                Refresh_Data();

            }
            catch
            {

            }
        }

        private void txt_material_cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Calculate_Cost_Edit_Mode();
                Refresh_Data();

            }
            catch 
            {
                
            }
        }

        private void txt_hardware_cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Refresh_Data();

            }
            catch
            {

            }
        }

        private void txt_labour_cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Refresh_Data();

            }
            catch
            {

            }
        }

        private void cmb_material_edit_SelectedValueChanged(object sender, EventArgs e)
        {
            Fill_material_thickness();
           // Calculate_Cost_Edit_Mode();
        }

        private void cmb_door_type_edit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_door_type_edit.Visible == true && cmb_door_type_edit.SelectedItem != null)
            {

                Calculate_Cost_Edit_Mode();
                Refresh_Data();

            }

        }

        private void cmb_material_thickness_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmb_material_thickness_edit.Visible == true && cmb_material_thickness_edit.Text != null)
            {

                Calculate_Cost_Edit_Mode();


            }
        }

        private void grid_hardware_on_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == grid_hardware_on_item.Columns["btn_delete_hardware"].Index && e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                int ID = Convert.ToInt32(grid_hardware_on_item.Rows[i].Cells["delete_id"].Value);
                SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                SqlCommand delete_item_hardware = new SqlCommand(Statementsclass.delete_item_hardware, conn);
                delete_item_hardware.Parameters.AddWithValue("@ID", ID);
                delete_item_hardware.ExecuteNonQuery();
                ConnectionClass.Dispose_connection(conn);
                Fill_data();
                Edit_Items();
                Calculate_Cost_Edit_Mode();
            }
        }

        private void cmb_material_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_material_edit.Visible == true && cmb_material_edit.SelectedItem != null)
            {

                Calculate_Cost_Edit_Mode();


            }
        }

        private void cmb_material_thickness_edit_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_material_thickness_edit.Visible == true && cmb_material_thickness_edit.SelectedItem != null)
            {

                Calculate_Cost_Edit_Mode();


            }
        }

        private void cmb_finish_edit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_finish_edit.Visible == true && cmb_finish_edit.SelectedItem != null)
            {

                Calculate_Cost_Edit_Mode();


            }
        }

        private void grid_hardware_on_item_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == grid_hardware_on_item.Columns["hardware_cost_sale"].Index && e.RowIndex >= 0)
                {
                //    int i = e.RowIndex;
                //    double cost = Convert.ToDouble(grid_hardware_on_item.Rows[i].Cells["hardware_cost_sale"].Value);
                //    int quantity = Convert.ToInt32(grid_hardware_on_item.Rows[i].Cells["quantity_hardware"].Value);

                //    grid_hardware_on_item.Rows[i].Cells["hardware_cost_total"].Value = cost * quantity;
                //    Refresh_Data();

                }

                if (e.ColumnIndex == grid_hardware_on_item.Columns["quantity_hardware"].Index && e.RowIndex >= 0)
                {
                    int i = e.RowIndex;
                    double cost = Convert.ToDouble(grid_hardware_on_item.Rows[i].Cells["hardware_cost_sale"].Value);
                    int quantity = Convert.ToInt32(grid_hardware_on_item.Rows[i].Cells["quantity_hardware"].Value);

                    grid_hardware_on_item.Rows[i].Cells["hardware_cost_total"].Value = cost * quantity;
                    SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                    SqlCommand update_hardware_item = new SqlCommand(Statementsclass.update_hardware_item, conn);
                    update_hardware_item.Parameters.AddWithValue("@quantity", quantity);
                    update_hardware_item.Parameters.AddWithValue("@total_cost", grid_hardware_on_item.Rows[i].Cells["hardware_cost_total"].Value);
                    update_hardware_item.Parameters.AddWithValue("@id", grid_hardware_on_item.Rows[i].Cells["delete_id"].Value);
                    update_hardware_item.ExecuteNonQuery();
                    Refresh_Data();

                }
            }
            catch (Exception )
            {
              //  MessageBox.Show(ex.ToString(), "");
            }
        

        }

        private void cmb_fire_edit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_fire_edit.Visible == true && cmb_fire_edit.SelectedItem != null)
            {

                Calculate_Cost_Edit_Mode();
                Refresh_Data();
              

            }
        }

        private void cmb_security_edit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_security_edit.Visible == true && cmb_security_edit.SelectedItem != null)
            {

                Calculate_Cost_Edit_Mode();
                Refresh_Data();

            }
        }

        private void btn_view_skins_Click(object sender, EventArgs e)
        {
            Calculate_Cost();
            FrmViewSkins skins = new FrmViewSkins();
            skins.ShowDialog();
        }

        private void cmb_jam_style_edit_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmb_jam_style_edit.Visible == true && cmb_jam_style_edit.SelectedItem != null)
            {

                Fill_jamb_details();
            }
        }

      

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            Valuesclass.structual_op_width =Convert.ToInt32(txt_structual_width.Text);
            FrmAddOnSelect addon = new FrmAddOnSelect();
            addon.ShowDialog();
            this.c_View_Item_Add_OnTableAdapter.Fill(this.dT_Item_Add_On.C_View_Item_Add_On, Valuesclass.quote_id);
            Refresh_Data();
        }

        private void grid_addon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_addon.Columns["btn_delete_addon"].Index && e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                int ID = Convert.ToInt32(grid_addon.Rows[i].Cells["addon_id"].Value);
                SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                SqlCommand delete_item_addon = new SqlCommand(Statementsclass.delete_item_addon, conn);
                delete_item_addon.Parameters.AddWithValue("@ID", ID);
                delete_item_addon.ExecuteNonQuery();
                ConnectionClass.Dispose_connection(conn);
                this.c_View_Item_Add_OnTableAdapter.Fill(this.dT_Item_Add_On.C_View_Item_Add_On, Valuesclass.quote_id);
                Refresh_Data();
            }
        }

        private void btn_view_addons_Click(object sender, EventArgs e)
        {
            FrmViewAddon view = new FrmViewAddon();
            view.ShowDialog();
        }

        private void btn_view_skins_Click_1(object sender, EventArgs e)
        {
            FrmViewSkins skins = new FrmViewSkins();
            skins.ShowDialog();
        }

       
    }
    
}

