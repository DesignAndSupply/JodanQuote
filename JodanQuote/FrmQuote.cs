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
        public static int locked_identifiter = 1;

        public FrmQuote()
        {
            InitializeComponent();
            Fill_data();
            btn_edit.PerformClick();
            Format();
            
        }

        void Fill_data()
        {


            this.ada_quote.Fill(dt_quote.DT_Quote_Items, Valuesclass.project_id);
            this.c_View_StatusTableAdapter.Fill(this.dT_Status.C_View_Status);
            grid_items_on_quote.DataSource = this.dt_quote.DT_Quote_Items;
            Valuesclass.project_ref = txt_project_ref.Text;
            Valuesclass.quote_status = cmb_quote_status.Text;
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
                Valuesclass.quote_id = (Convert.ToInt32(read_max_quote_id["Quote ID"])) + 1;
                read_max_quote_id.Close();
            }

            ConnectionClass.Dispose_connection(conn);

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
            txt_customer.Text = Valuesclass.customer_account_ref;
            grid_items_on_quote.EnableHeadersVisualStyles = false;
            grid_items_on_quote.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_items_on_quote.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_items_on_quote.DefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_items_on_quote.DefaultCellStyle.BackColor = Color.AliceBlue;

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

                SqlCommand insert_hardware = new SqlCommand(Statementsclass.insert_hardware, conn);
                insert_hardware.Parameters.AddWithValue("@id", Valuesclass.quote_id);
                insert_hardware.Parameters.AddWithValue("@hardware_id", dt_copy_hardware.Rows[i]["Hardware ID"]);
                insert_hardware.Parameters.AddWithValue("@hardware_description", dt_copy_hardware.Rows[i]["Hardware Description"]);
                insert_hardware.Parameters.AddWithValue("@hardware_cost", dt_copy_hardware.Rows[i]["Hardware cost"]);
                insert_hardware.Parameters.AddWithValue("@Quantity", dt_copy_hardware.Rows[i]["Quantity"]);
                insert_hardware.Parameters.AddWithValue("@total_cost", dt_copy_hardware.Rows[i]["Total Cost"]);
                insert_hardware.ExecuteNonQuery();



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
            update_project.ExecuteNonQuery();
            ConnectionClass.Dispose_connection(conn);
            MessageBox.Show("Project Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Fill_data();

        }

        private void btn_new_item_Click(object sender, EventArgs e)
        {
           
            Valuesclass.new_item_identifier = 1;
            DialogResult confirm = MessageBox.Show("Add New Item To This Quotation?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Valuesclass.revision_number = 1;
                select_max_item();
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
            }

            else
            {
                return;
            }
        }
            
        private void btn_back_Click(object sender, EventArgs e)
        {
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
                    Valuesclass.quote_id = Convert.ToInt32(dt_quote.DT_Quote_Items.Rows[i]["Quote ID"].ToString());
                    Valuesclass.item_id = Convert.ToInt32(dt_quote.DT_Quote_Items.Rows[i]["Item Id"].ToString());
                    Valuesclass.revision_number = Convert.ToInt32(dt_quote.DT_Quote_Items.Rows[i]["Revision Number"].ToString());
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
                        int item_id = Convert.ToInt32(dt_quote.DT_Quote_Items.Rows[i]["Item Id"].ToString());
                        SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                        SqlCommand delete_quote_item = new SqlCommand(Statementsclass.delete_quote_item, conn);
                        delete_quote_item.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
                        delete_quote_item.Parameters.AddWithValue("@item_id", item_id);
                        delete_quote_item.ExecuteNonQuery();
                        Fill_data();
                        

                    }


                }

                if (e.ColumnIndex == grid_items_on_quote.Columns["btn_copy"].Index && e.RowIndex >= 0)
                {
                    int i = e.RowIndex;
                    select_max_item();
                    Select_quote_id();
                    //Valuesclass.quote_id = Convert.ToInt32(dt_quote.Rows[i]["Quote Id"].ToString());
                    Valuesclass.item_id = Convert.ToInt32(dt_quote.DT_Quote_Items.Rows[i]["Item Id"].ToString());

                    SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
                    SqlCommand copy_item = new SqlCommand(Statementsclass.copy_item, conn);
                    copy_item.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
                    copy_item.Parameters.AddWithValue("@item_id", Valuesclass.item_id);
                    SqlDataReader reader = copy_item.ExecuteReader();

                    if (reader.Read())
                    {

                        SqlConnection conn2 = ConnectionClass.GetConnection_jodan_quote();


                        SqlCommand insert_copied_item = new SqlCommand(Statementsclass.insert_copied_item, conn2);
                        insert_copied_item.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
                        insert_copied_item.Parameters.AddWithValue("@item_id", Valuesclass.max_item_id);
                        insert_copied_item.Parameters.AddWithValue("@order_id", reader["order_id"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@item_date",DateTime.Now);
                        insert_copied_item.Parameters.AddWithValue("@door_ref", reader["door_ref"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@door_type", reader["door_type"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@door_style", reader["door_style"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@structual_op_height", reader["structual_op_height"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@structual_op_width", reader["structual_op_width"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@frame_width", reader["frame_width"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@frame_height", reader["frame_height"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@total_cost", reader["total_cost"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@created_by",loginclass.Login.globalFullName);
                        insert_copied_item.Parameters.AddWithValue("@markup_material", reader["markup_material"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@material_cost", reader["material_cost"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@markup_hardware", reader["markup_hardware"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@hardware_cost", reader["hardware_cost"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@labour_rate", reader["labour_rate"].ToString());
                        insert_copied_item.Parameters.AddWithValue("@labour_cost", reader["labour_cost"].ToString());
                        ConnectionClass.Dispose_connection(conn);



                        insert_copied_item.ExecuteNonQuery();
                        ConnectionClass.Dispose_connection(conn2);



                    }
                    Valuesclass.id = Convert.ToInt32(grid_items_on_quote.Rows[i].Cells["Quote_ID"].Value);
                    Copy_hardware();
                    Fill_data();
                    MessageBox.Show("Item Copy Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }






            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "");
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
        }

        private void btn_additional_cost_Click(object sender, EventArgs e)
        {
            main_tab_project_additions.SelectedTab = tab_additonal_cost;
        }

        private void btn_notes_Click(object sender, EventArgs e)
        {
            main_tab_project_additions.SelectedTab = tab_notes;
        }

        private void btn_email_project_Click(object sender, EventArgs e)
        {
            FrmMailQuote mail = new FrmMailQuote();
            mail.ShowDialog();
        }

        private void FrmQuote_Shown(object sender, EventArgs e)
        {
            Fill_data();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (locked_identifiter == 0)
            {
                Save();
                main_tab_project_additions.Enabled = false;
                locked_identifiter = 1;
                btn_edit.Text = "         Edit            Details";
                btn_edit.Image = JodanQuote.Properties.Resources.Revise;

                cmb_quote_status.Visible = false;
                txt_quote_status.Visible = true;

            }

            else
            {

               
                main_tab_project_additions.Enabled = true;
             
                locked_identifiter = 0;
                btn_edit.Text = "         Save         Quotation";
                btn_edit.Image = JodanQuote.Properties.Resources.Save;
                cmb_quote_status.Visible = true;
                txt_quote_status.Visible = false;
               // cmb_quote_status.Text = dt_quote.DT_Quote_Items.Rows[0]["quote_status"].ToString();
            }

            Fill_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fill_data();
        }
    }
    
}
