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
using Connection;
using Statements;

namespace JodanQuote
{
    public partial class FrmMain : Form
    {
        DataTable dt_quote = new DataTable();
        
        public FrmMain()
        {
            
            InitializeComponent();
            Fill_data();
            Format();
            this.ada_setting.Fill(dT_Settings.DT_Setting);

        }

        void Format()
        {
          
          
            grid_quote_list.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_quote_list.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_quote_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_quote_list.EnableHeadersVisualStyles = false;
            btn_copy.DisplayIndex = grid_quote_list.ColumnCount - 1;
            btn_open.DisplayIndex = grid_quote_list.ColumnCount - 1;
            grid_quote_list.Columns["Project ID"].FillWeight = 52;
            grid_quote_list.Columns["Project ID"].HeaderText = "  Project    Number";
            grid_quote_list.Columns["Number Of Items"].FillWeight = 53;
            grid_quote_list.Columns["Number Of Items"].HeaderText = " Number  Of Items";
            grid_quote_list.Columns["Total Value"].FillWeight = 40;
            grid_quote_list.Columns["Total Value"].DefaultCellStyle.NullValue = "£0";
            grid_quote_list.Columns["Total Value"].HeaderText = " Total  Value";
            grid_quote_list.Columns["Project Reference"].FillWeight = 68;
            grid_quote_list.Columns["Date Created"].FillWeight = 53;
            grid_quote_list.Columns["Customer Name"].FillWeight = 110;
            grid_quote_list.Columns["Date Created"].DefaultCellStyle.Format = "d";
            grid_quote_list.Columns["Total Value"].DefaultCellStyle.Format = "C2";
            foreach (DataGridViewColumn col in grid_quote_list.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if(loginclass.Login.globalSuperUser == true)
            {

                btn_settings.Visible = true;

            }
        }
                   
        void Fill_data()
        {


            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter ada = new SqlDataAdapter(Statementsclass.select_quote_item_count, conn);
            ada.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
            ada.Fill(dt_quote);
            grid_quote_list.DataSource = dt_quote;
            ConnectionClass.Dispose_connection(conn);

        
        }

        void Search()
        {
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            DateTime d =  DateTime.Today;
            String today = d.ToShortDateString();
            DateTime start_date = Convert.ToDateTime(date_start.Text + " 00:00:00".ToString());
            DateTime end_date = Convert.ToDateTime(date_end.Text + " 23:59:59".ToString());



            if (string.IsNullOrEmpty(txt_customer.Text) == false && string.IsNullOrEmpty(txt_quote_id.Text) == false && string.IsNullOrEmpty(txt_reference.Text) == true && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {
                dt_quote.Clear();
                SqlDataAdapter search_quote_customer = new SqlDataAdapter(Statementsclass.search_quote_customer, conn);
                search_quote_customer.SelectCommand.Parameters.AddWithValue("@customer", txt_customer.Text.ToString());
                search_quote_customer.SelectCommand.Parameters.AddWithValue("@project_id", Convert.ToInt32(txt_quote_id.Text.ToString()));
                search_quote_customer.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_quote_customer.Fill(dt_quote);
               // Format();
                return;


            }
            if (string.IsNullOrEmpty(txt_customer.Text) == false && string.IsNullOrEmpty(txt_quote_id.Text) == true && string.IsNullOrEmpty(txt_reference.Text) == true && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {

                dt_quote.Clear();
                SqlDataAdapter search_customer = new SqlDataAdapter(Statementsclass.search_customer, conn);
                search_customer.SelectCommand.Parameters.AddWithValue("@customer", txt_customer.Text.ToString());
                search_customer.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_customer.Fill(dt_quote);
               // Format();
                return;


            }
            if (string.IsNullOrEmpty(txt_customer.Text) == true && string.IsNullOrEmpty(txt_quote_id.Text) == false && string.IsNullOrEmpty(txt_reference.Text) == true && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {

                dt_quote.Clear();
              
                SqlDataAdapter search_quote = new SqlDataAdapter(Statementsclass.search_quote, conn);
                search_quote.SelectCommand.Parameters.AddWithValue("@project_id", Convert.ToInt32(txt_quote_id.Text.ToString()));
                search_quote.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_quote.Fill(dt_quote);
               // Format();
                return;

            }
            if (string.IsNullOrEmpty(txt_customer.Text) == false && string.IsNullOrEmpty(txt_quote_id.Text) == false && string.IsNullOrEmpty(txt_reference.Text) == false && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {

                dt_quote.Clear();

                SqlDataAdapter search_quote_customer_reference = new SqlDataAdapter(Statementsclass.search_quote_customer_reference, conn);
                search_quote_customer_reference.SelectCommand.Parameters.AddWithValue("@project_id", Convert.ToInt32(txt_quote_id.Text.ToString()));
                search_quote_customer_reference.SelectCommand.Parameters.AddWithValue("@customer", txt_customer.Text.ToString());
                search_quote_customer_reference.SelectCommand.Parameters.AddWithValue("@reference", txt_reference.Text.ToString());
                search_quote_customer_reference.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);

                search_quote_customer_reference.Fill(dt_quote);
                 Format();
                return;

            }
            if (string.IsNullOrEmpty(txt_customer.Text) == true && string.IsNullOrEmpty(txt_quote_id.Text) == true && string.IsNullOrEmpty(txt_reference.Text) == false && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {

                dt_quote.Clear();

                SqlDataAdapter search_reference = new SqlDataAdapter(Statementsclass.search_reference, conn);
                search_reference.SelectCommand.Parameters.AddWithValue("@reference", txt_reference.Text.ToString());
                search_reference.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);

                search_reference.Fill(dt_quote);
                Format();
                return;

            }
            if (string.IsNullOrEmpty(txt_customer.Text) == false && string.IsNullOrEmpty(txt_quote_id.Text) == true && string.IsNullOrEmpty(txt_reference.Text) == false && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {

                dt_quote.Clear();

                SqlDataAdapter search_quote_reference = new SqlDataAdapter(Statementsclass.search_quote_reference, conn);
                search_quote_reference.SelectCommand.Parameters.AddWithValue("@reference", txt_reference.Text.ToString());
                search_quote_reference.SelectCommand.Parameters.AddWithValue("@project_id", Convert.ToInt32(txt_quote_id.Text.ToString()));
                search_quote_reference.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_quote_reference.Fill(dt_quote);
                Format();
                return;

            }
            if (string.IsNullOrEmpty(txt_customer.Text) == true && string.IsNullOrEmpty(txt_quote_id.Text) == false && string.IsNullOrEmpty(txt_reference.Text) == false && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {

                dt_quote.Clear();

                SqlDataAdapter search_customer_reference = new SqlDataAdapter(Statementsclass.search_customer_reference, conn);
                search_customer_reference.SelectCommand.Parameters.AddWithValue("@customer", txt_customer.Text.ToString());
                search_customer_reference.SelectCommand.Parameters.AddWithValue("@reference", txt_reference.Text.ToString());
                search_customer_reference.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_customer_reference.Fill(dt_quote);
                Format();
                return;

            }
            if (string.IsNullOrEmpty(txt_customer.Text) == true && string.IsNullOrEmpty(txt_quote_id.Text) == true && string.IsNullOrEmpty(txt_reference.Text) == true && date_start.Text.ToString() == today && date_end.Text.ToString() == today)
            {
                dt_quote.Clear();
                Fill_data();
                return;

            }
            if (string.IsNullOrEmpty(txt_customer.Text) == true && string.IsNullOrEmpty(txt_quote_id.Text) == true && string.IsNullOrEmpty(txt_reference.Text) == true && date_start.Text.ToString() != today || date_end.Text.ToString() != today)
            {

                dt_quote.Clear();

                SqlDataAdapter search_dates = new SqlDataAdapter(Statementsclass.search_dates, conn);
                search_dates.SelectCommand.Parameters.AddWithValue("@start_date",start_date);
                search_dates.SelectCommand.Parameters.AddWithValue("@end_date", end_date);
                search_dates.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_dates.Fill(dt_quote);
                Format();
                return;


            }
            if (string.IsNullOrEmpty(txt_customer.Text) == true && string.IsNullOrEmpty(txt_quote_id.Text) == false && string.IsNullOrEmpty(txt_reference.Text) == true && date_start.Text.ToString() != today || date_end.Text.ToString() != today)
            {

                dt_quote.Clear();

                SqlDataAdapter search_dates_quote = new SqlDataAdapter(Statementsclass.search_dates_quote, conn);
                search_dates_quote.SelectCommand.Parameters.AddWithValue("@start_date", start_date);
                search_dates_quote.SelectCommand.Parameters.AddWithValue("@end_date", end_date);
                search_dates_quote.SelectCommand.Parameters.AddWithValue("@project_id", Convert.ToInt32(txt_quote_id.Text.ToString()));
                search_dates_quote.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_dates_quote.Fill(dt_quote);
                Format();
                return;


            }
            if (string.IsNullOrWhiteSpace(txt_customer.Text) == false && string.IsNullOrWhiteSpace(txt_quote_id.Text) == true && string.IsNullOrWhiteSpace(txt_reference.Text) == true && date_start.Text.ToString() != today || date_end.Text.ToString() != today)
            {

                dt_quote.Clear();

                SqlDataAdapter search_dates_customer = new SqlDataAdapter(Statementsclass.search_dates_customer, conn);
                search_dates_customer.SelectCommand.Parameters.AddWithValue("@start_date", start_date);
                search_dates_customer.SelectCommand.Parameters.AddWithValue("@end_date", end_date);
                search_dates_customer.SelectCommand.Parameters.AddWithValue("@customer", txt_customer.Text.ToString());
                search_dates_customer.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_dates_customer.Fill(dt_quote);
                Format();
                return;


            }
            if (string.IsNullOrWhiteSpace(txt_customer.Text) == true && string.IsNullOrWhiteSpace(txt_quote_id.Text) == true && string.IsNullOrWhiteSpace(txt_reference.Text) == false && date_start.Text.ToString() != today || date_end.Text.ToString() != today)
            {

                dt_quote.Clear();

                SqlDataAdapter search_dates_reference = new SqlDataAdapter(Statementsclass.search_dates_reference, conn);
                search_dates_reference.SelectCommand.Parameters.AddWithValue("@start_date", start_date);
                search_dates_reference.SelectCommand.Parameters.AddWithValue("@end_date", end_date);
                search_dates_reference.SelectCommand.Parameters.AddWithValue("@reference", txt_reference.Text.ToString());
                search_dates_reference.SelectCommand.Parameters.AddWithValue("@jodan_Y_N", Valuesclass.jodan_y_n);
                search_dates_reference.Fill(dt_quote);
                Format();
                return;


            }
        }

        void Select_max_project_id()
        {



            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();

            SqlCommand select_max_project = new SqlCommand(Statementsclass.select_max_project_id, conn);
            SqlDataReader read_max_project_id = select_max_project.ExecuteReader();


            if (read_max_project_id.Read())
            {
                Valuesclass.project_id = (Convert.ToInt32(read_max_project_id["Project ID"])) ;
                read_max_project_id.Close();
            }
            ConnectionClass.Dispose_connection(conn);
        }

        void Select_quote_id()
        {

            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand select_max_quote_id = new SqlCommand(Statementsclass.select_max_quote_id, conn);
            SqlDataReader read_max_quote_id = select_max_quote_id.ExecuteReader();

            if (read_max_quote_id.Read())
            {
                Valuesclass.quote_id = (Convert.ToInt32(read_max_quote_id["Quote ID"]));
                read_max_quote_id.Close();
            }

            ConnectionClass.Dispose_connection(conn);

        }

        void Copy_converted_hardware()
        {
            DataTable dt_copy_hardware = new DataTable();
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlDataAdapter copy_hardware = new SqlDataAdapter(Statementsclass.copy_hardware, conn);
            copy_hardware.SelectCommand.Parameters.AddWithValue("@ID", Valuesclass.id);
            copy_hardware.Fill(dt_copy_hardware);

            for (int i = 0; i < dt_copy_hardware.Rows.Count; i++)
            {
                Select_quote_id();
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
                insert_hardware.Parameters.AddWithValue("@Quantity", dt_copy_hardware.Rows[i]["Hardware cost"]);
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
            copy_item_convert.SelectCommand.Parameters.AddWithValue("@project_Id",Valuesclass.project_id);
            copy_item_convert.Fill(dt_copy_item);


            for (int i = 0; i < dt_copy_item.Rows.Count; i++)
            {
                Valuesclass.id  = ((dt_copy_item.Rows[i]["id"]) as int?) ?? 0;
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
                double? discount = ((dt_copy_item.Rows[i]["discount_percentage"]) as double?) ?? 0;
                double? additional = ((dt_copy_item.Rows[i]["additional_cost"]) as double?) ?? 0;
                double? security_rating_cost = ((dt_copy_item.Rows[i]["security_rating_cost"]) as double?) ?? 0;
                double? fire_rating_cost = ((dt_copy_item.Rows[i]["fire_rating_cost"]) as double?) ?? 0;
                double converted_cost = 0;
              
                SqlConnection conn2 = ConnectionClass.GetConnection_jodan_quote();


                SqlCommand insert_copied_item = new SqlCommand(Statementsclass.insert_copied_item, conn2);



                Select_max_project_id();
  
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
                insert_copied_item.Parameters.AddWithValue("@converted_cost", 0);
                insert_copied_item.Parameters.AddWithValue("@total_cost", converted_total_cost);
                insert_copied_item.Parameters.AddWithValue("@discount_percentage", discount);
                insert_copied_item.Parameters.AddWithValue("@additional_cost", additional);
                ConnectionClass.Dispose_connection(conn);



                insert_copied_item.ExecuteNonQuery();
                ConnectionClass.Dispose_connection(conn2);


                Copy_converted_hardware();





            }

            ConnectionClass.Dispose_connection(conn);


        }

        private void grid_quote_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            Valuesclass.new_item_identifier = 0;
            Valuesclass.customer_name = grid_quote_list.Rows[i].Cells["Customer Name"].Value.ToString();
            Valuesclass.project_id = Convert.ToInt32(grid_quote_list.Rows[i].Cells["Project ID"].Value);
            try
            {
                if (e.ColumnIndex == grid_quote_list.Columns["btn_open"].Index && e.RowIndex >= 0)
                {

                    
                  
                    FrmQuote quote = new FrmQuote();
                    quote.Show();
                    this.Hide();




                }
                if (e.ColumnIndex == grid_quote_list.Columns["btn_copy"].Index && e.RowIndex >= 0)
                {
                    Valuesclass.new_item_identifier = 1;
                    Valuesclass.project_id =Convert.ToInt32(grid_quote_list.Rows[i].Cells["Project ID"].Value);
                    DialogResult confirm = MessageBox.Show("Are You Sure You Want To Copy Quotation?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        Valuesclass.customer_name = "";

                        if (Valuesclass.jodan_y_n == 0)
                        {

                            FrmCustomerSelect select = new FrmCustomerSelect();
                            select.ShowDialog();
                        }
                        else
                        {
                            Valuesclass.customer_name = "JODAN CONTRACTS LTD                                         ";
                            Valuesclass.customer_account_ref = "JODAN CONTRACTS LTD                                         ";
                        }
                       
                        if (string.IsNullOrEmpty(Valuesclass.customer_name) == true)
                        {
                            return;
                        }

                        SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                        SqlCommand copy_project = new SqlCommand(Statementsclass.copy_project, conn);
                        copy_project.Parameters.AddWithValue("@project_Id", Valuesclass.project_id);
                        SqlDataReader reader = copy_project.ExecuteReader();

                        if (reader.Read())
                        {




                            SqlConnection conn2 = ConnectionClass.GetConnection_jodan_quote();

                            SqlCommand insert_copied_project = new SqlCommand(Statementsclass.insert_copied_project, conn2);

                            insert_copied_project.Parameters.AddWithValue("@convertion_id", Valuesclass.project_id);
                            insert_copied_project.Parameters.AddWithValue("@customer_ref", Valuesclass.customer_account_ref);
                            insert_copied_project.Parameters.AddWithValue("@site_ref", reader["site_ref"].ToString());
                            insert_copied_project.Parameters.AddWithValue("@project_ref", reader["project_ref"].ToString());
                            insert_copied_project.Parameters.AddWithValue("@date_created", DateTime.Now);
                            insert_copied_project.Parameters.AddWithValue("@quote_status", reader["quote_status"].ToString());
                            insert_copied_project.Parameters.AddWithValue("@jodan_y_n",Valuesclass.jodan_y_n );
                            insert_copied_project.ExecuteNonQuery();

                            ConnectionClass.Dispose_connection(conn);
                            ConnectionClass.Dispose_connection(conn2);






                        }

                        Copy_Item();
                        Copy_converted_hardware();

                        Valuesclass.jodan_y_n = 0;


                        MessageBox.Show("Quotation Successfully Converted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmQuote quote = new FrmQuote();
                        quote.Show();
                        this.Hide();

                    }
                    else
                    {
                        return;
                    }
                   

                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "");
            }
        }

        private void btn_new_project_Click(object sender, EventArgs e)
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


            SqlConnection conn2 = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand select_max_quote_id = new SqlCommand(Statementsclass.select_max_quote_id, conn2);
            SqlDataReader read_max_quote_id = select_max_quote_id.ExecuteReader();

            if (read_max_quote_id.Read())
            {
                Valuesclass.quote_id = (Convert.ToInt32(read_max_quote_id["Quote ID"])) + 1;
                read_max_quote_id.Close();
            }

            Valuesclass.new_item_identifier = 1;
            
           
            SqlCommand insert_new_project = new SqlCommand(Statementsclass.insert_new_project, conn2);
            insert_new_project.Parameters.AddWithValue("@customer_id", Valuesclass.customer_account_ref);
            insert_new_project.Parameters.AddWithValue("@quote_date", DateTime.Now);
            insert_new_project.Parameters.AddWithValue("@created_by", loginclass.Login.globalFullName.ToString());
            insert_new_project.ExecuteNonQuery();
            ConnectionClass.Dispose_connection(conn2);
            this.Hide();
            FrmQuote project = new FrmQuote();
            project.Show();
        }

        private void txt_quote_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Search();
            }
        }

        private void txt_customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Search();
            }
           
        }

        private void pct_clear_Click(object sender, EventArgs e)
        {
          
            dt_quote.Rows.Clear();
            txt_customer.Text = "";
            txt_quote_id.Text = "";
            txt_reference.Text = "";
            date_start.Text = DateTime.Now.ToShortDateString();
            date_end.Text = DateTime.Now.ToShortDateString();
            Fill_data();
        
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            dt_quote.Clear();
            if(Valuesclass.jodan_y_n == 0)
            {
                Valuesclass.jodan_y_n = 1;
                btn_filter.Text = "        Filter            Jodan";
                pct_logo.Image = JodanQuote.Properties.Resources.Logo;
                pct_logo.Location = new Point(20, 28);
                // D&S TO JODAN MODE
            }
            else
            {
                Valuesclass.jodan_y_n = 0;
                btn_filter.Text = "        Filter            Others";
                pct_logo.Image = JodanQuote.Properties.Resources.Jodan;
                pct_logo.Location = new Point(5, 8);
                //Jodan to Other cusotmers
            }

            Fill_data();
            Format();
        }

        private void txt_reference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Search();
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.ShowDialog();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txt_quote_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void date_start_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void date_end_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
