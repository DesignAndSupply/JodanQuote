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
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;
using values;
using Connection;
using Statements;

namespace JodanQuote
{
    public partial class FrmNewitem : Form
    {
        static int locked_identifiter = 0;

        public FrmNewitem()
        {
            InitializeComponent();
          
        }   

        private void FrmNewitem_Shown(object sender, EventArgs e)
        {
            Fill_data();
            Format();
            Select_data();
        }

        void Fill_data()
        {

            lbl_quote.Text =  Valuesclass.project_id.ToString();
            lbl_item.Text =  Valuesclass.max_item_id.ToString();
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

        void Select_data()
        {
            SqlConnection conn = ConnectionClass.GetConnection_jodan_quote();
            SqlCommand select_quote_details = new SqlCommand(Statementsclass.select_item_details, conn);
            select_quote_details.Parameters.AddWithValue("@project_id", Valuesclass.project_id);
            select_quote_details.Parameters.AddWithValue("@item_id", Convert.ToInt32(lbl_item.Text.ToString()));
            SqlDataReader reader = select_quote_details.ExecuteReader();

            if (reader.Read())
            {

                txt_structual_height.Text  = reader["structual_op_height"].ToString();
                txt_structual_width.Text = reader["structual_op_width"].ToString();


                ConnectionClass.Dispose_connection(conn);


            }

          

        }

        void lock_controls()
        {
            if (locked_identifiter == 0)
            {
                foreach (Control pnl in this.Controls)
                {
                    if (pnl is Panel)
                    {
                        foreach (Control ctrl in pnl.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                        {
                            if (ctrl is TextBox)
                            {
                                ctrl.Enabled = false;
                            }
                            else if (ctrl is ComboBox)
                            {
                                ctrl.Enabled = false;
                            }
                            else if (ctrl is DataGridView)
                            {
                                ctrl.Enabled = false;
                            }
                            else if (ctrl is Button)
                            {

                                // ctrl.Enabled = false;

                            }
                            else
                            {

                            }


                        }


                    }



                }
                locked_identifiter = 1;
                btn_lock.Text = "     Unlock";
                btn_lock.Image = JodanQuote.Properties.Resources.unlock;
                btn_dimensions.Enabled = false;
            }
            else
            {
                foreach (Control pnl in this.Controls)
                {
                    if (pnl is Panel)
                    {
                        foreach (Control ctrl in pnl.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                        {
                            if (ctrl is TextBox)
                            {
                                ctrl.Enabled = true;
                            }
                            else if (ctrl is ComboBox)
                            {
                                ctrl.Enabled = true;
                            }
                            else if (ctrl is DataGridView)
                            {
                                ctrl.Enabled = true;
                            }
                            else if (ctrl is Button)
                            {

                                // ctrl.Enabled = false;

                            }
                            else
                            {

                            }


                        }


                    }



                }
                locked_identifiter = 0;
                btn_lock.Text = "       lock";
                btn_lock.Image = JodanQuote.Properties.Resources.locked;
                btn_dimensions.Enabled = true;
            }


        }

        private void FrmItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
        }

        private void grid_panel_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == grid_panel_info.Columns["extras_panel"].Index && e.RowIndex >= 0)
                {

                    grid_panel_info.BeginEdit(true);
                    ((ComboBox)grid_panel_info.EditingControl).DroppedDown = true;
                }

            }
            catch
            {


            }
        }

        private void btn_dimensions_Click(object sender, EventArgs e)
        {
            FrmDimensions dimensions = new FrmDimensions();
            dimensions.Show();
            this.Hide();
            Valuesclass.item_id = Convert.ToInt32(lbl_item.Text.ToString());
            Valuesclass.new_item_identifier = 1;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_print_item_Click(object sender, EventArgs e)
        {


            this.CenterToScreen();

            string path = @"\\designsvr1\apps\Design and Supply CSharp\Source Files\JodanQuote\Temp Folder\Item Printscreen.JPG";
            Bitmap printscreen = new Bitmap(1425, 750);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(225, 150, 0, 0, printscreen.Size);

            printscreen.Save(path, ImageFormat.Jpeg);

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;
            pd.DefaultPageSettings.Color = false;
            pd.PrintPage += PrintPage;
            pd.Print();
            if (File.Exists(path))
            {

                File.Delete(path);
              
            }

        }

        private void PrintPage(object o, PrintPageEventArgs e)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(@"\\designsvr1\apps\Design and Supply CSharp\Source Files\JodanQuote\Temp Folder\Item Printscreen.JPG");
            Point loc = new Point(100, 100);
            e.Graphics.DrawImage(img, loc);
        }

        private void btn_lock_Click(object sender, EventArgs e)
        {

        }
    }


 }

        
    
