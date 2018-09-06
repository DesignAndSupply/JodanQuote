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
using Statements;
using values;

namespace JodanQuote
{
    public partial class FrmQuote : Form
    {
       
        public FrmQuote()
        {
            InitializeComponent();
            Fill_data();
            Textbox_Format();
            Format();
            Edit();
         

        }

        private void FrmQuote_Shown(object sender, EventArgs e)
        {
            Fill_data();
            Format();
         
        }

        void Fill_data()
        {

            dT_Quote.EnforceConstraints = false;
            this.ada_quote_items.Fill(dT_Quote.DT_Quote_Items, Valuesclass.project_id);
            this.c_View_StatusTableAdapter.Fill(this.dT_Status.C_View_Status);
            this.ada_setting.Fill(dT_Settings.DT_Setting);
            grid_items_on_quote.DataSource = this.dT_Quote.DT_Quote_Items;
            Valuesclass.project_ref = txt_project_ref.Text;
            Valuesclass.quote_status = cmb_quote_status.Text;
            try
            {

                this.sALES_LEDGERTableAdapter.Fill(this.dT_customer.SALES_LEDGER, (dT_Quote.DT_Quote_Items.Rows[0]["customer_ref"].ToString()));

            }
            catch
            {

            }
            
            
        }

        void select_max_item()
        {

            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand select_max_item_id = new SqlCommand(Statementsclass.select_max_item_id, conn);
            select_max_item_id.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            var check_item = select_max_item_id.ExecuteScalar();
            if (string.IsNullOrWhiteSpace(check_item.ToString()))
            {
                Valuesclass.max_item_id = 1;


            }
            else
            {
                Valuesclass.max_item_id = Convert.ToInt32(check_item) + 1;

            }
            Valuesclass.item_id = Valuesclass.max_item_id;
            ConnectionClass.Dispose_connection(conn);
            //select_max_revison();
        }

        void Select_quote_id()
        {

            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand select_max_quote_id = new SqlCommand(Statementsclass.select_max_quote_id, conn);
            SqlDataReader read_max_quote_id = select_max_quote_id.ExecuteReader();

            if (read_max_quote_id.Read())
            {
                Valuesclass.quote_id = (Convert.ToInt32(read_max_quote_id["Quote ID"])) ;
                read_max_quote_id.Close();
            }

            ConnectionClass.Dispose_connection(conn);

        }

        void Select_max_project_id()
        {



            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();

            SqlCommand select_max_project = new SqlCommand(Statementsclass.select_max_project_id, conn);
            SqlDataReader read_max_project_id = select_max_project.ExecuteReader();


            if (read_max_project_id.Read())
            {
                Valuesclass.project_id = (Convert.ToInt32(read_max_project_id["Project ID"])) + 1;
                read_max_project_id.Close();
            }
            ConnectionClass.Dispose_connection(conn);
        }

        void Edit()
        {
            

            if (Valuesclass.new_item_identifier == 0)
            {
                
                main_tab_project_additions.Enabled = false;
                Valuesclass.new_item_identifier = 1;
                btn_edit.Text = "         Edit            Details";
                btn_edit.Image = JodanQuote.Properties.Resources.Revise;
                cmb_quote_status.Visible = false;
                txt_quote_status.Visible = true;
               
            }

            else
            {


                main_tab_project_additions.Enabled = true;

                Valuesclass.new_item_identifier = 0;
                btn_edit.Text = "         Save         Quotation";
                btn_edit.Image = JodanQuote.Properties.Resources.Save;
                cmb_quote_status.Visible = true;
                txt_quote_status.Visible = false;
          
            }

        

        }

        void Format()
        {
            main_tab_project_additions.Appearance = TabAppearance.FlatButtons;
            main_tab_project_additions.ItemSize = new Size(0, 1);
            main_tab_project_additions.SizeMode = TabSizeMode.Fixed;
           
            grid_items_on_quote.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            btn_view.DisplayIndex = grid_items_on_quote.ColumnCount - 1;
            btn_copy.DisplayIndex = grid_items_on_quote.ColumnCount - 1;
            btn_delete_item.DisplayIndex = grid_items_on_quote.ColumnCount - 1;
            txt_project.Text = Valuesclass.project_id.ToString();
            txt_customer.Text = Valuesclass.customer_name;
            grid_items_on_quote.EnableHeadersVisualStyles = false;
            grid_items_on_quote.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_items_on_quote.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_items_on_quote.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_items_on_quote.DefaultCellStyle.BackColor = Color.AliceBlue;
         
            if (string.IsNullOrWhiteSpace(dT_Quote.DT_Quote_Items.Rows[0]["convertion_id"].ToString()))
            {
                pct_logo.Image = JodanQuote.Properties.Resources.Logo;
                pct_logo.Location = new Point(20, 28);
               
                btn_view_original.Enabled = false;
            }
            if(Valuesclass.jodan_y_n==0)
            {
                //Valuesclass.jodan_y_n = 0;
      
                pct_logo.Image = JodanQuote.Properties.Resources.Jodan;
                pct_logo.Location = new Point(5, 8);
                btn_view_original.Enabled = true;
    

            }

        
        }

        void Textbox_Format()
        {
         
          
            string delivery_charge = txt_delivery_charge.Text.Replace("£", string.Empty);
            string install_charge = txt_installation.Text.Replace("£", string.Empty);
            string survey_charge = txt_survery_charge.Text.Replace("£", string.Empty);


            txt_survery_charge.Text = "£" + survey_charge;
            txt_delivery_charge.Text = "£" + delivery_charge;
            txt_installation.Text = "£" + install_charge;

        }

        void Copy_hardware()
        {
            DataTable dt_copy_hardware = new DataTable();
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter copy_hardware = new SqlDataAdapter(Statementsclass.copy_hardware, conn);
            copy_hardware.SelectCommand.Parameters.AddWithValue("@ID", Valuesclass.id);
            copy_hardware.Fill(dt_copy_hardware);

            for (int i = 0; i < dt_copy_hardware.Rows.Count; i++)
            {

                int? Hardware = ((dt_copy_hardware.Rows[i]["Hardware ID"]) as int?) ?? 0;
                int? category = ((dt_copy_hardware.Rows[i]["Category ID"]) as int?) ?? 0;
                int? Quantity = ((dt_copy_hardware.Rows[i]["Quantity"]) as int?) ?? 0;
                Double? Total_Cost = ((dt_copy_hardware.Rows[i]["Total Cost"]) as Double?) ?? 0;

                SqlCommand insert_hardware = new SqlCommand(Statementsclass.insert_hardware, conn);
                insert_hardware.Parameters.AddWithValue("@id", Valuesclass.quote_id);
                insert_hardware.Parameters.AddWithValue("@hardware_id", Hardware);
                insert_hardware.Parameters.AddWithValue("@category_id", category);
                insert_hardware.Parameters.AddWithValue("@hardware_description", dt_copy_hardware.Rows[i]["Hardware Description"]);
                insert_hardware.Parameters.AddWithValue("@hardware_cost", dt_copy_hardware.Rows[i]["Hardware cost"]);
                insert_hardware.Parameters.AddWithValue("@Quantity", Quantity);
                insert_hardware.Parameters.AddWithValue("@total_cost", Total_Cost);
                insert_hardware.ExecuteNonQuery();



            }

            ConnectionClass.Dispose_connection(conn);


        }

        void Copy_addon()
        {
            DataTable dt_copy_addon = new DataTable();
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter copy_addon = new SqlDataAdapter(Statementsclass.copy_addon, conn);
            copy_addon.SelectCommand.Parameters.AddWithValue("@ID", Valuesclass.id);
            copy_addon.Fill(dt_copy_addon);

            for (int i = 0; i < dt_copy_addon.Rows.Count; i++)
            {

                int add_on_id = Convert.ToInt32((dt_copy_addon.Rows[i]["add_on_id"]).ToString());
                int add_on_width =Convert.ToInt32(dt_copy_addon.Rows[i]["add_on_width"].ToString());
                int add_on_height = Convert.ToInt32(dt_copy_addon.Rows[i]["add_on_height"].ToString());
                int material_id =  Convert.ToInt32((dt_copy_addon.Rows[i]["material_id"]).ToString());
                double? material_thickness = ((dt_copy_addon.Rows[i]["material_thickness"]) as double?) ?? 0;
                int add_on_material_id = Convert.ToInt32((dt_copy_addon.Rows[i]["add_on_material_id"]).ToString());
                double? material_cost = ((dt_copy_addon.Rows[i]["material_cost"]) as double?) ?? 0;
                int? labour_hours = ((dt_copy_addon.Rows[i]["labour_hours"]) as int?) ?? 0;
                double? labour_cost = ((dt_copy_addon.Rows[i]["labour_cost"]) as double?) ?? 0;
                int? position = ((dt_copy_addon.Rows[i]["position"]) as int?) ?? 0;
                int? removable = ((dt_copy_addon.Rows[i]["removable"]) as int?) ?? 0;
                int? qty = ((dt_copy_addon.Rows[i]["qty"]) as int?) ?? 0;
                int? powder_coated = ((dt_copy_addon.Rows[i]["powder_coated"]) as int?) ?? 0;
                double? powder_coat_cost = ((dt_copy_addon.Rows[i]["powder_coat_cost"]) as double?) ?? 0;
                double? unit_material_cost = ((dt_copy_addon.Rows[i]["unit_material_cost"]) as double?) ?? 0;
         

                SqlCommand insert_add_on = new SqlCommand(Statementsclass.insert_add_on, conn);
                insert_add_on.Parameters.AddWithValue("@quotation_id", Valuesclass.quote_id);
                insert_add_on.Parameters.AddWithValue("@add_on_id", dt_copy_addon.Rows[i]["add_on_id"].ToString());
                insert_add_on.Parameters.AddWithValue("@add_on_width", dt_copy_addon.Rows[i]["add_on_width"].ToString());
                insert_add_on.Parameters.AddWithValue("@add_on_height", dt_copy_addon.Rows[i]["add_on_height"].ToString());
                insert_add_on.Parameters.AddWithValue("@material_id", material_id);
                insert_add_on.Parameters.AddWithValue("@material_thickness", material_thickness);
                insert_add_on.Parameters.AddWithValue("@add_on_material_id", add_on_material_id);
                insert_add_on.Parameters.AddWithValue("@material_cost", material_cost);
                insert_add_on.Parameters.AddWithValue("@labour_hours", labour_hours);
                insert_add_on.Parameters.AddWithValue("@labour_cost", labour_cost);
                insert_add_on.Parameters.AddWithValue("@position", position);
                insert_add_on.Parameters.AddWithValue("@removable", removable);
                insert_add_on.Parameters.AddWithValue("@qty", qty);
                insert_add_on.Parameters.AddWithValue("@powder_coated", powder_coated);
                insert_add_on.Parameters.AddWithValue("@powder_coat_cost", powder_coat_cost);
                insert_add_on.Parameters.AddWithValue("@unit_material_cost", unit_material_cost);
                insert_add_on.ExecuteNonQuery();


            }

        }

        void Copy_converted_hardware()
        {
            Select_quote_id();
            DataTable dt_copy_hardware = new DataTable();
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter copy_hardware = new SqlDataAdapter(Statementsclass.copy_hardware, conn);
            copy_hardware.SelectCommand.Parameters.AddWithValue("@ID", Valuesclass.id);
            copy_hardware.Fill(dt_copy_hardware);
         
            for (int i = 0; i < dt_copy_hardware.Rows.Count; i++)
            {

                int? Hardware = ((dt_copy_hardware.Rows[i]["Hardware ID"]) as int?) ?? 0;
                int? category = ((dt_copy_hardware.Rows[i]["Category ID"]) as int?) ?? 0;
                int? Quantity = ((dt_copy_hardware.Rows[i]["Quantity"]) as int?) ?? 0;
                double? Total_Cost = ((dt_copy_hardware.Rows[i]["Total Cost"]) as double?) ?? 0;

                SqlCommand insert_hardware = new SqlCommand(Statementsclass.insert_hardware, conn);
                insert_hardware.Parameters.AddWithValue("@id", Valuesclass.quote_id);
                insert_hardware.Parameters.AddWithValue("@hardware_id", Hardware);
                insert_hardware.Parameters.AddWithValue("@category_id", category);
                insert_hardware.Parameters.AddWithValue("@hardware_description", dt_copy_hardware.Rows[i]["Hardware Description"]);
                insert_hardware.Parameters.AddWithValue("@hardware_cost", dt_copy_hardware.Rows[i]["Hardware cost"]);
                insert_hardware.Parameters.AddWithValue("@Quantity", dt_copy_hardware.Rows[i]["Quantity"]);
                insert_hardware.Parameters.AddWithValue("@total_cost", (dt_copy_hardware.Rows[i]["Total Cost"]));
                insert_hardware.ExecuteNonQuery();



            }

            ConnectionClass.Dispose_connection(conn);


        }
       
        void Copy_Item()
        {

            DataTable dt_copy_item = new DataTable();
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter copy_item_convert = new SqlDataAdapter(Statementsclass.copy_item_convert, conn);
            copy_item_convert.SelectCommand.Parameters.AddWithValue("@project_Id", dT_Quote.DT_Quote_Items.Rows[0]["Project ID"]);
            copy_item_convert.Fill(dt_copy_item);


            for (int i = 0; i < dt_copy_item.Rows.Count; i++)
            {
                Valuesclass.id =Convert.ToInt32(dt_copy_item.Rows[i]["id"]);
                int? door_type_id = ((dt_copy_item.Rows[i]["door_type_id"]) as int?) ?? 0;
                int? order_id = ((dt_copy_item.Rows[i]["order_id"]) as int?) ?? 0;
                int? material_id = ((dt_copy_item.Rows[i]["material_id"]) as int?) ?? 0;
                int? finish_id = ((dt_copy_item.Rows[i]["finish_id"]) as int?) ?? 0;
                int? fire_rating_id = ((dt_copy_item.Rows[i]["fire_rating_id"]) as int?) ?? 0;
                int? jamb_style_id = ((dt_copy_item.Rows[i]["jamb_style_id"]) as int?) ?? 0;
                int? security_rating_id = ((dt_copy_item.Rows[i]["security_rating_id"]) as int?) ?? 0;
                int? infill_id = ((dt_copy_item.Rows[i]["infill_id"]) as int?) ?? 0;
                int? material_thickness = ((dt_copy_item.Rows[i]["material_thickness"]) as int?) ?? 0;
                double? total_cost = ((dt_copy_item.Rows[i]["total_cost"]) as double?) ?? 0;
                double? security_rating_cost = ((dt_copy_item.Rows[i]["security_rating_cost"]) as double?) ?? 0;
                double? fire_rating_cost = ((dt_copy_item.Rows[i]["fire_rating_cost"]) as double?) ?? 0;
                double? additional_cost = ((dt_copy_item.Rows[i]["additional_cost"]) as double?) ?? 0;
                double? discount_percentage = ((dt_copy_item.Rows[i]["discount_percentage"]) as double?) ?? 0;
                double converted_cost = 0;
                SqlConnection conn3 = ConnectionClass.GetConnection_dsl();
                SqlCommand Select_door_type = new SqlCommand(Statementsclass.Select_door_type, conn3);
                Select_door_type.Parameters.AddWithValue("@id", door_type_id);
                SqlDataReader read_door_type = Select_door_type.ExecuteReader();

                if (read_door_type.Read())
                {
                    string door_style = (Convert.ToString(read_door_type["description"]));
                    Valuesclass.double_single = (Convert.ToInt32(read_door_type["double_door"]));
                    read_door_type.Close();
                }
                SqlConnection conn2 = ConnectionClass.GetConnection_jodan_quote();


                SqlCommand insert_copied_item = new SqlCommand(Statementsclass.insert_copied_item, conn2);


                if (Valuesclass.double_single == 1)
                {

                    converted_cost = Convert.ToInt32(dT_Settings.DT_Setting.Rows[0]["double_extra"].ToString());


                }
                else
                {

                    converted_cost = Convert.ToInt32(dT_Settings.DT_Setting.Rows[0]["single_extra"].ToString());


                }


                double? converted_total_cost = total_cost + converted_cost;
                insert_copied_item.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
                insert_copied_item.Parameters.AddWithValue("@item_id", i + 1);
                insert_copied_item.Parameters.AddWithValue("@order_id", order_id);
                insert_copied_item.Parameters.AddWithValue("@material_id", material_id);
                insert_copied_item.Parameters.AddWithValue("@finish_id", finish_id);
                insert_copied_item.Parameters.AddWithValue("@fire_rating_id", fire_rating_id);
                insert_copied_item.Parameters.AddWithValue("@security_rating_id", security_rating_id);
                insert_copied_item.Parameters.AddWithValue("@infill_id", infill_id);
                insert_copied_item.Parameters.AddWithValue("@jamb_style_id", jamb_style_id);
                insert_copied_item.Parameters.AddWithValue("@item_date", DateTime.Now);
                insert_copied_item.Parameters.AddWithValue("@door_ref", dt_copy_item.Rows[i]["door_ref"]);
                insert_copied_item.Parameters.AddWithValue("@finish_colour", dt_copy_item.Rows[i]["finish_colour"]);
                insert_copied_item.Parameters.AddWithValue("@door_type", door_type_id);
                insert_copied_item.Parameters.AddWithValue("@item_notes", dt_copy_item.Rows[i]["item_notes"]);
                insert_copied_item.Parameters.AddWithValue("@door_style", dt_copy_item.Rows[i]["door_style"]);
                insert_copied_item.Parameters.AddWithValue("@structual_op_height", dt_copy_item.Rows[i]["structual_op_height"]);
                insert_copied_item.Parameters.AddWithValue("@structual_op_width", dt_copy_item.Rows[i]["structual_op_width"]);
                insert_copied_item.Parameters.AddWithValue("@frame_width", dt_copy_item.Rows[i]["frame_width"]);
                insert_copied_item.Parameters.AddWithValue("@frame_height", dt_copy_item.Rows[i]["frame_height"]);
                insert_copied_item.Parameters.AddWithValue("@jamb_width", dt_copy_item.Rows[i]["jamb_width"]);
                insert_copied_item.Parameters.AddWithValue("@jamb_height", dt_copy_item.Rows[i]["jamb_height"]);
                insert_copied_item.Parameters.AddWithValue("@finish_description", dt_copy_item.Rows[i]["finish_description"]);
                insert_copied_item.Parameters.AddWithValue("@material_thickness", material_thickness);
                insert_copied_item.Parameters.AddWithValue("@created_by", loginclass.Login.globalFullName);
                insert_copied_item.Parameters.AddWithValue("@markup_material", dt_copy_item.Rows[i]["markup_material"]);
                insert_copied_item.Parameters.AddWithValue("@material_cost", dt_copy_item.Rows[i]["material_cost"]);
                insert_copied_item.Parameters.AddWithValue("@markup_hardware", dt_copy_item.Rows[i]["markup_hardware"]);
                insert_copied_item.Parameters.AddWithValue("@hardware_cost", dt_copy_item.Rows[i]["hardware_cost"]);
                insert_copied_item.Parameters.AddWithValue("@paint_cost", dt_copy_item.Rows[i]["paint_cost"]);
                insert_copied_item.Parameters.AddWithValue("@addon_cost", dt_copy_item.Rows[i]["addon_cost"]);
                insert_copied_item.Parameters.AddWithValue("@security_rating_cost", dt_copy_item.Rows[i]["security_rating_cost"]);
                insert_copied_item.Parameters.AddWithValue("@fire_rating_cost", dt_copy_item.Rows[i]["fire_rating_cost"]);
                insert_copied_item.Parameters.AddWithValue("@labour_rate", dt_copy_item.Rows[i]["labour_rate"]);
                insert_copied_item.Parameters.AddWithValue("@labour_cost", dt_copy_item.Rows[i]["labour_cost"]);
                insert_copied_item.Parameters.AddWithValue("@converted_cost", converted_cost);
                insert_copied_item.Parameters.AddWithValue("@additional_cost", additional_cost);
                insert_copied_item.Parameters.AddWithValue("@discount_percentage", discount_percentage);
                insert_copied_item.Parameters.AddWithValue("@total_cost", converted_total_cost);
                ConnectionClass.Dispose_connection(conn);
         


                insert_copied_item.ExecuteNonQuery();
                ConnectionClass.Dispose_connection(conn2);


           
                Copy_converted_hardware();
                Copy_addon();


            }

            ConnectionClass.Dispose_connection(conn);


        }

        void Save()
        {

            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand update_project = new SqlCommand(Statementsclass.update_project, conn);
            update_project.Parameters.AddWithValue("@quote_status", cmb_quote_status.Text.ToString());
            update_project.Parameters.AddWithValue("@project_ref", txt_project_ref.Text);
            update_project.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            update_project.Parameters.AddWithValue("@project_notes", txt_notes.Text);
            update_project.Parameters.AddWithValue("@survey_cost", txt_survery_charge.Text.Replace("£", string.Empty));
            update_project.Parameters.AddWithValue("@installation_cost", txt_installation.Text.Replace("£", string.Empty));
            update_project.Parameters.AddWithValue("@delivery_cost", txt_delivery_charge.Text.Replace("£", string.Empty));
            update_project.ExecuteNonQuery();
            ConnectionClass.Dispose_connection(conn);
         
            Fill_data();

        }

        void insert_blank_hardware()
        {
            for (int i =0; i < 1; i++)
            {
                string hardware_description = "Monarch 102x76x 3mm Ball ";
                double hardware_cost = 3.12;
                int quantity = 1;
                double total_cost = 3.12;
                Select_quote_id();
                SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                SqlCommand insert_hardware = new SqlCommand(Statementsclass.insert_hardware, conn);
                insert_hardware.Parameters.AddWithValue("@id", Valuesclass.quote_id);
                insert_hardware.Parameters.AddWithValue("@hardware_id", 4983);
                insert_hardware.Parameters.AddWithValue("@category_id", 11);
                insert_hardware.Parameters.AddWithValue("@hardware_description", hardware_description);
                insert_hardware.Parameters.AddWithValue("@hardware_cost", hardware_cost);
                insert_hardware.Parameters.AddWithValue("@quantity", quantity);
                insert_hardware.Parameters.AddWithValue("@total_cost", total_cost);
                insert_hardware.ExecuteNonQuery();
                ConnectionClass.Dispose_connection(conn);

                string seal_description = "D Seal 6x8";

                total_cost = 47.15;

                SqlConnection conn2 = ConnectionClass.GetConnection_jodan_quote();
                SqlCommand insert_seal = new SqlCommand(Statementsclass.insert_hardware, conn2);
                insert_seal.Parameters.AddWithValue("@id", Valuesclass.quote_id);
                insert_seal.Parameters.AddWithValue("@hardware_id", 4894);
                insert_seal.Parameters.AddWithValue("@category_id", 40);
                insert_seal.Parameters.AddWithValue("@hardware_description", seal_description);
                insert_seal.Parameters.AddWithValue("@hardware_cost", total_cost);
                insert_seal.Parameters.AddWithValue("@quantity", quantity);
                insert_seal.Parameters.AddWithValue("@total_cost", total_cost);
                insert_seal.ExecuteNonQuery();
                ConnectionClass.Dispose_connection(conn2);
            }
            
           


          

        }

        private void btn_new_item_Click(object sender, EventArgs e)
        {
           
            Valuesclass.new_item_identifier = 1;
            DialogResult confirm = MessageBox.Show("Add New Item To This Quotation?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Save();
                Valuesclass.revision_number = 1;
                select_max_item();
                Select_quote_id();
                this.ada_setting.Fill(dT_Settings.DT_Setting);
                SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                SqlCommand insert_new_project_quote = new SqlCommand(Statementsclass.insert_new_project_quote, conn);
                insert_new_project_quote.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
                insert_new_project_quote.Parameters.AddWithValue("@item_id", Valuesclass.max_item_id);
                insert_new_project_quote.Parameters.AddWithValue("@item_date", DateTime.Now);
                insert_new_project_quote.Parameters.AddWithValue("@created_by", loginclass.Login.globalFullName);
                insert_new_project_quote.Parameters.AddWithValue("@markup_material", dT_Settings.DT_Setting.Rows[0]["markup_material"].ToString());
                insert_new_project_quote.Parameters.AddWithValue("@markup_hardware", dT_Settings.DT_Setting.Rows[0]["markup_hardware"].ToString());
                insert_new_project_quote.Parameters.AddWithValue("@labour_rate", dT_Settings.DT_Setting.Rows[0]["labour_rate"].ToString());
                insert_new_project_quote.ExecuteNonQuery();
                ConnectionClass.Dispose_connection(conn);
                Fill_data();
                this.Hide();
                FrmItem item = new FrmItem();
                item.Show();
                insert_blank_hardware();
            }

            else
            {
                return;
            }
        }
            
        private void btn_back_Click(object sender, EventArgs e)
        {
            Valuesclass.jodan_y_n = 1;
            this.Hide();
            FrmMain main = new FrmMain();
            main.Show();
        }

        private void btn_print_project_Click(object sender, EventArgs e)
        {
            FrmQuoteReport report = new FrmQuoteReport();
            report.Show();
            this.Hide();

        }

        private void grid_items_on_quote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == grid_items_on_quote.Columns["btn_view"].Index && e.RowIndex >= 0)
                {

                    int i = e.RowIndex;
                    Valuesclass.quote_id = Convert.ToInt32(dT_Quote.DT_Quote_Items.Rows[i]["Item Identity"].ToString());
                    Valuesclass.item_id = Convert.ToInt32(dT_Quote.DT_Quote_Items.Rows[i]["Item_Id"].ToString());
                    Valuesclass.revision_number = Convert.ToInt32(dT_Quote.DT_Quote_Items.Rows[i]["revision_id"].ToString());
                    //select_max_revison();
                    Valuesclass.new_item_identifier = 0;
                    Valuesclass.locked_identifiter = 0;
                    FrmItem item = new FrmItem();
                    item.Show();
                    this.Hide();




                }

                if (e.ColumnIndex == grid_items_on_quote.Columns["btn_delete_item"].Index && e.RowIndex >= 0)
                {

                    int i = e.RowIndex;
                    DialogResult delete = MessageBox.Show("Delete Item From Project?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if(delete == DialogResult.Yes)
                    {

                        int ID = Convert.ToInt32(grid_items_on_quote.Rows[i].Cells["Item_Identity"].Value);
                        SqlConnection conn2 = ConnectionClass.GetConnection_jodan_quote();
                        SqlCommand delete_multiple_item_hardware = new SqlCommand(Statementsclass.delete_multiple_item_hardware, conn2);
                        delete_multiple_item_hardware.Parameters.AddWithValue("@id", ID);
                        delete_multiple_item_hardware.ExecuteNonQuery();
                        ConnectionClass.Dispose_connection(conn2);

                        int item = Convert.ToInt32(dT_Quote.DT_Quote_Items.Rows[i]["Item_Id"].ToString());
                        int project_id = Convert.ToInt32(dT_Quote.DT_Quote_Items.Rows[i]["Project ID"].ToString());
                        SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                        SqlCommand delete_quote_item = new SqlCommand(Statementsclass.delete_quote_item, conn);
                        delete_quote_item.Parameters.AddWithValue("@item_id", item);
                        delete_quote_item.Parameters.AddWithValue("@project_id", project_id);
                        delete_quote_item.ExecuteNonQuery();
                        Fill_data();


                      


                    }


                }

                if (e.ColumnIndex == grid_items_on_quote.Columns["btn_copy"].Index && e.RowIndex >= 0)
                {
                    int i = e.RowIndex;
                    select_max_item();
                 
                    Valuesclass.item_id = Convert.ToInt32(dT_Quote.DT_Quote_Items.Rows[i]["Item_Id"].ToString());
                    SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                    SqlCommand copy_item = new SqlCommand(Statementsclass.copy_item, conn);
                    copy_item.Parameters.AddWithValue("@id", grid_items_on_quote.Rows[i].Cells["Item_Identity"].Value);
                    SqlDataReader reader = copy_item.ExecuteReader();

                    if (reader.Read())
                    {

                        int? order_id = (reader["order_id"] as int?)?? 0;
                        int? material_id = (reader["material_id"] as int?) ?? 0;
                        int? finish_id = (reader["finish_id"] as int?) ?? 0;
                        int? fire_rating_id = (reader["fire_rating_id"] as int?) ?? 0;
                        int? security_rating_id = (reader["security_rating_id"] as int?) ?? 0;
                        int? infill_id = (reader["infill_id"] as int?) ?? 0;
                        int? jamb_style_id = (reader["jamb_style_id"] as int?) ?? 0;
                        double? material_thickness = (reader["material_thickness"] as double?) ?? 0;
                        double? total_cost = (reader["total_cost"] as double?)?? 0;
                        double? converted_cost = Convert.ToDouble((reader["converted_cost"]as double? )?? 0);
                        double? addon_cost = Convert.ToDouble((reader["addon_cost"] as double?) ?? 0);
                        double? fire_rating_cost = Convert.ToDouble((reader["fire_rating_cost"] as double?) ?? 0);
                        double? security_rating_cost = Convert.ToDouble((reader["security_rating_cost"] as double?) ?? 0);
                        double? paint_cost = Convert.ToDouble((reader["paint_cost"] as double?) ?? 0);
                        double? additional_cost = Convert.ToDouble((reader["additional_cost"] as double?) ?? 0);
                        double? discount_percentage = Convert.ToDouble((reader["discount_percentage"] as double?) ?? 0);
                        SqlConnection conn2 = ConnectionClass.GetConnection_jodan_quote();
                        
                      
                        SqlCommand insert_copied_item = new SqlCommand(Statementsclass.insert_copied_item, conn2);
                     
                        insert_copied_item.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
                        insert_copied_item.Parameters.AddWithValue("@item_id", Valuesclass.max_item_id);
                        insert_copied_item.Parameters.AddWithValue("@order_id", order_id);
                        insert_copied_item.Parameters.AddWithValue("@material_id", material_id);
                        insert_copied_item.Parameters.AddWithValue("@finish_id", finish_id);
                        insert_copied_item.Parameters.AddWithValue("@fire_rating_id", fire_rating_id);
                        insert_copied_item.Parameters.AddWithValue("@security_rating_id", security_rating_id);
                        insert_copied_item.Parameters.AddWithValue("@infill_id", infill_id);
                        insert_copied_item.Parameters.AddWithValue("@jamb_style_id", jamb_style_id);
                        insert_copied_item.Parameters.AddWithValue("@item_notes", reader["item_notes"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@item_date",DateTime.Now);
                        insert_copied_item.Parameters.AddWithValue("@door_ref", reader["door_ref"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@door_type", reader["door_type_id"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@door_style", reader["door_style"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@structual_op_height", reader["structual_op_height"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@structual_op_width", reader["structual_op_width"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@frame_width", reader["frame_width"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@frame_height", reader["frame_height"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@jamb_width", reader["jamb_width"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@jamb_height", reader["jamb_height"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@finish_description", reader["finish_description"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@finish_colour", reader["finish_colour"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@material_thickness", material_thickness);
                        insert_copied_item.Parameters.AddWithValue("@created_by",loginclass.Login.globalFullName);
                        insert_copied_item.Parameters.AddWithValue("@markup_material", reader["markup_material"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@material_cost", reader["material_cost"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@markup_hardware", reader["markup_hardware"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@hardware_cost", reader["hardware_cost"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@labour_rate", reader["labour_rate"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@labour_cost", reader["labour_cost"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@fire_rating_cost", fire_rating_cost);
                        insert_copied_item.Parameters.AddWithValue("@security_rating_cost", security_rating_cost);
                        insert_copied_item.Parameters.AddWithValue("@paint_cost", paint_cost);
                        insert_copied_item.Parameters.AddWithValue("@addon_cost", addon_cost);
                        insert_copied_item.Parameters.AddWithValue("@converted_cost", converted_cost);
                        insert_copied_item.Parameters.AddWithValue("@total_cost", total_cost);
                        insert_copied_item.Parameters.AddWithValue("@additional_cost", additional_cost);
                        insert_copied_item.Parameters.AddWithValue("@discount_percentage", discount_percentage);
                        ConnectionClass.Dispose_connection(conn);

                      

                        insert_copied_item.ExecuteNonQuery();
                        ConnectionClass.Dispose_connection(conn2);



                    }

                  
                    Valuesclass.id = Convert.ToInt32(grid_items_on_quote.Rows[i].Cells["Item_Identity"].Value);
                    Select_quote_id();
                    Copy_hardware();
                    Copy_addon();
                    Fill_data();
                    MessageBox.Show("Item Copy Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }






            }
            catch
            {
              // MessageBox.Show(ex.ToString(), "");
            }
           
        }

        private void FrmQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
        }

        private void btn_quote_details_Click(object sender, EventArgs e)
        {
            main_tab_project_additions.SelectedTab = tab_quote_details;
            this.ActiveControl = txt_project_ref;
        }

        private void btn_additional_cost_Click(object sender, EventArgs e)
        {
            main_tab_project_additions.SelectedTab = tab_additonal_cost;
            Textbox_Format();
        }

        private void btn_notes_Click(object sender, EventArgs e)
        {
            main_tab_project_additions.SelectedTab = tab_notes;
            this.ActiveControl = txt_notes;

        }

        private void btn_email_project_Click(object sender, EventArgs e)
        {
            FrmMailQuote mail = new FrmMailQuote();
            mail.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit();
            
            if (Valuesclass.new_item_identifier == 1)
            
            {
                Save();
                MessageBox.Show("Project Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Textbox_Format();
            }

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            try
            {

                Valuesclass.new_item_identifier = 1;
                DialogResult confirm = MessageBox.Show("Are You Sure You Want To Copy Quotation?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    Valuesclass.customer_name = "";
                    FrmCustomerSelect select = new FrmCustomerSelect();
                    select.ShowDialog();

                }
                Select_max_project_id();
              

                if (string.IsNullOrEmpty(Valuesclass.customer_name) == true)
                {
                    return;
                }
                SqlConnection conn2 = ConnectionClass.GetConnection_jodan_quote();
                SqlCommand copy_project = new SqlCommand(Statementsclass.copy_project, conn2);
                copy_project.Parameters.AddWithValue("@project_Id", dT_Quote.DT_Quote_Items.Rows[0]["Project ID"]);
                SqlDataReader reader = copy_project.ExecuteReader();

                if (reader.Read())
                {




                    SqlConnection conn3 = ConnectionClass.GetConnection_jodan_quote();
                
                    SqlCommand insert_copied_project = new SqlCommand(Statementsclass.insert_copied_project, conn3);

                    insert_copied_project.Parameters.AddWithValue("@convertion_id", dT_Quote.DT_Quote_Items.Rows[0]["Project ID"]);
                    insert_copied_project.Parameters.AddWithValue("@customer_ref", Valuesclass.customer_account_ref);
                    insert_copied_project.Parameters.AddWithValue("@site_ref", reader["site_ref"].ToString());
                    insert_copied_project.Parameters.AddWithValue("@project_ref", reader["project_ref"].ToString());
                    insert_copied_project.Parameters.AddWithValue("@date_created", DateTime.Now);
                    insert_copied_project.Parameters.AddWithValue("@quote_status", reader["quote_status"].ToString());
                    insert_copied_project.Parameters.AddWithValue("@jodan_y_n", 0);
                    
                    insert_copied_project.ExecuteNonQuery();

                    ConnectionClass.Dispose_connection(conn3);
                    ConnectionClass.Dispose_connection(conn2);






                }

               
                Copy_Item();
              
                dT_customer.Clear();
                dT_Quote.Clear();
                this.dT_customer.SALES_LEDGER.Clear();
                this.dT_Quote.DT_Quote_Items.Clear();
                dT_customer.EnforceConstraints = false;
             
                this.ada_quote_items.Fill(dT_Quote.DT_Quote_Items, Valuesclass.project_id);
                this.sALES_LEDGERTableAdapter.Fill(dT_customer.SALES_LEDGER, Valuesclass.customer_account_ref);
                txt_customer.Text = Valuesclass.customer_name;
                Valuesclass.jodan_y_n = 0;
                Format();
                MessageBox.Show("Quotation Successfully Converted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "");

            }

            


        }

        private void txt_delivery_charge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_installation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_survery_charge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_survery_charge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                this.ActiveControl = txt_delivery_charge;
                Textbox_Format();
            }
        }

        private void txt_delivery_charge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                this.ActiveControl = txt_installation;
                Textbox_Format();
            }
        }

        private void txt_installation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                this.ActiveControl = txt_survery_charge;
                Textbox_Format();
            }
        }

        private void txt_survery_charge_Enter(object sender, EventArgs e)
        {
            Textbox_Format();
        }

        private void txt_delivery_charge_Enter(object sender, EventArgs e)
        {
            Textbox_Format();
        }

        private void txt_installation_Enter(object sender, EventArgs e)
        {
            Textbox_Format();
        }

        private void btn_view_original_Click(object sender, EventArgs e)
        {
            Save();
            Valuesclass.project_id = Convert.ToInt32(dT_Quote.DT_Quote_Items.Rows[0]["convertion_id"].ToString());
            Fill_data();
            Valuesclass.jodan_y_n = 1;
            Format();
            txt_customer.Text = dT_customer.SALES_LEDGER.Rows[0]["customer_name"].ToString();


        }

       
    }
    
}
