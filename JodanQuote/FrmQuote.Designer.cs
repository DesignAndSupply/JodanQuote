namespace JodanQuote
{
    partial class FrmQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuote));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maintab_doors_on_quote = new System.Windows.Forms.TabControl();
            this.tab_door_on_quote = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_email_project = new System.Windows.Forms.Button();
            this.lbl_quote_id = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            this.btn_new_item = new System.Windows.Forms.Button();
            this.btn_print_project = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.grid_items_on_quote = new System.Windows.Forms.DataGridView();
            this.btn_view = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.maintab_doors_on_quote.SuspendLayout();
            this.tab_door_on_quote.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_items_on_quote)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.pct_logo);
            this.panel2.Location = new System.Drawing.Point(-563, -327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 1104);
            this.panel2.TabIndex = 14;
            // 
            // pct_logo
            // 
            this.pct_logo.Location = new System.Drawing.Point(22, 22);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(123, 50);
            this.pct_logo.TabIndex = 14;
            this.pct_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(-563, -327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1927, 100);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JodanQuote.Properties.Resources.Jodan;
            this.pictureBox2.Location = new System.Drawing.Point(-554, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 86);
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(278, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Items on Quote";
            // 
            // maintab_doors_on_quote
            // 
            this.maintab_doors_on_quote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maintab_doors_on_quote.Controls.Add(this.tab_door_on_quote);
            this.maintab_doors_on_quote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintab_doors_on_quote.Location = new System.Drawing.Point(265, 156);
            this.maintab_doors_on_quote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintab_doors_on_quote.Name = "maintab_doors_on_quote";
            this.maintab_doors_on_quote.SelectedIndex = 0;
            this.maintab_doors_on_quote.Size = new System.Drawing.Size(707, 411);
            this.maintab_doors_on_quote.TabIndex = 55;
            // 
            // tab_door_on_quote
            // 
            this.tab_door_on_quote.BackColor = System.Drawing.Color.AliceBlue;
            this.tab_door_on_quote.Controls.Add(this.grid_items_on_quote);
            this.tab_door_on_quote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_door_on_quote.ForeColor = System.Drawing.SystemColors.Control;
            this.tab_door_on_quote.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tab_door_on_quote.Location = new System.Drawing.Point(4, 24);
            this.tab_door_on_quote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tab_door_on_quote.Name = "tab_door_on_quote";
            this.tab_door_on_quote.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tab_door_on_quote.Size = new System.Drawing.Size(699, 383);
            this.tab_door_on_quote.TabIndex = 0;
            this.tab_door_on_quote.Text = "                         ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.btn_email_project);
            this.panel5.Controls.Add(this.lbl_quote_id);
            this.panel5.Controls.Add(this.btn_back);
            this.panel5.Controls.Add(this.btn_);
            this.panel5.Controls.Add(this.btn_new_item);
            this.panel5.Controls.Add(this.btn_print_project);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(-6, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1927, 100);
            this.panel5.TabIndex = 48;
            // 
            // btn_email_project
            // 
            this.btn_email_project.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_email_project.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_email_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email_project.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_email_project.Image = global::JodanQuote.Properties.Resources.Email;
            this.btn_email_project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_email_project.Location = new System.Drawing.Point(541, 27);
            this.btn_email_project.Name = "btn_email_project";
            this.btn_email_project.Size = new System.Drawing.Size(88, 37);
            this.btn_email_project.TabIndex = 41;
            this.btn_email_project.Text = "      Email          Project";
            this.btn_email_project.UseVisualStyleBackColor = false;
            // 
            // lbl_quote_id
            // 
            this.lbl_quote_id.AutoSize = true;
            this.lbl_quote_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quote_id.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_quote_id.Location = new System.Drawing.Point(203, 27);
            this.lbl_quote_id.Name = "lbl_quote_id";
            this.lbl_quote_id.Size = new System.Drawing.Size(131, 31);
            this.lbl_quote_id.TabIndex = 42;
            this.lbl_quote_id.Text = "Quote ID:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_back.Image = global::JodanQuote.Properties.Resources.ReturnArrow;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(938, 27);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 37);
            this.btn_back.TabIndex = 40;
            this.btn_back.Text = "    Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_
            // 
            this.btn_.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_.Location = new System.Drawing.Point(837, 27);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(95, 37);
            this.btn_.TabIndex = 40;
            this.btn_.UseVisualStyleBackColor = false;
            // 
            // btn_new_item
            // 
            this.btn_new_item.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_new_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_item.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_new_item.Image = global::JodanQuote.Properties.Resources.NewRecord;
            this.btn_new_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new_item.Location = new System.Drawing.Point(736, 27);
            this.btn_new_item.Name = "btn_new_item";
            this.btn_new_item.Size = new System.Drawing.Size(95, 37);
            this.btn_new_item.TabIndex = 40;
            this.btn_new_item.Text = " New Item";
            this.btn_new_item.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new_item.UseVisualStyleBackColor = false;
            this.btn_new_item.Click += new System.EventHandler(this.btn_new_item_Click);
            // 
            // btn_print_project
            // 
            this.btn_print_project.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_print_project.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_project.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_print_project.Image = global::JodanQuote.Properties.Resources.Print_Small;
            this.btn_print_project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print_project.Location = new System.Drawing.Point(635, 27);
            this.btn_print_project.Name = "btn_print_project";
            this.btn_print_project.Size = new System.Drawing.Size(95, 37);
            this.btn_print_project.TabIndex = 39;
            this.btn_print_project.Text = "        Print           Project";
            this.btn_print_project.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JodanQuote.Properties.Resources.Jodan;
            this.pictureBox3.Location = new System.Drawing.Point(12, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 86);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.Controls.Add(this.lbl_customer);
            this.panel6.Controls.Add(this.txt_customer);
            this.panel6.Location = new System.Drawing.Point(-3, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 639);
            this.panel6.TabIndex = 50;
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_customer.Location = new System.Drawing.Point(9, 352);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(149, 25);
            this.lbl_customer.TabIndex = 44;
            this.lbl_customer.Text = "Customer Ref:";
            // 
            // txt_customer
            // 
            this.txt_customer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txt_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt_customer.Location = new System.Drawing.Point(10, 380);
            this.txt_customer.Multiline = true;
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(148, 114);
            this.txt_customer.TabIndex = 43;
            // 
            // grid_items_on_quote
            // 
            this.grid_items_on_quote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_items_on_quote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_items_on_quote.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_items_on_quote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_items_on_quote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_items_on_quote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_items_on_quote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_view});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_items_on_quote.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_items_on_quote.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_items_on_quote.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_items_on_quote.Location = new System.Drawing.Point(128, 38);
            this.grid_items_on_quote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_items_on_quote.Name = "grid_items_on_quote";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_items_on_quote.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_items_on_quote.RowHeadersVisible = false;
            this.grid_items_on_quote.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_items_on_quote.Size = new System.Drawing.Size(428, 323);
            this.grid_items_on_quote.TabIndex = 24;
            // 
            // btn_view
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.NullValue = "View";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
            this.btn_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.btn_view.FillWeight = 50F;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_view.HeaderText = "";
            this.btn_view.MinimumWidth = 50;
            this.btn_view.Name = "btn_view";
            this.btn_view.Width = 52;
            // 
            // FrmQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 633);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maintab_doors_on_quote);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quote";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.maintab_doors_on_quote.ResumeLayout(false);
            this.tab_door_on_quote.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_items_on_quote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl maintab_doors_on_quote;
        private System.Windows.Forms.TabPage tab_door_on_quote;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_email_project;
        private System.Windows.Forms.Label lbl_quote_id;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.Button btn_new_item;
        private System.Windows.Forms.Button btn_print_project;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.DataGridView grid_items_on_quote;
        private System.Windows.Forms.DataGridViewButtonColumn btn_view;
    }
}