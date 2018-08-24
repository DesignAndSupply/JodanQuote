namespace JodanQuote
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_new_project = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_quote_id = new System.Windows.Forms.TextBox();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.pct_clear = new System.Windows.Forms.PictureBox();
            this.grid_quote_list = new System.Windows.Forms.DataGridView();
            this.btn_open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Reference = new System.Windows.Forms.Label();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_quote_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_filter);
            this.panel1.Controls.Add(this.btn_new_project);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1927, 100);
            this.panel1.TabIndex = 11;
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_settings.Image = global::JodanQuote.Properties.Resources.Settings;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(690, 30);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(93, 42);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.Text = "         Quote          Settings";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Visible = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_filter.Image = ((System.Drawing.Image)(resources.GetObject("btn_filter.Image")));
            this.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filter.Location = new System.Drawing.Point(787, 30);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(93, 42);
            this.btn_filter.TabIndex = 1;
            this.btn_filter.Text = "        Filter            Jodan";
            this.btn_filter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_new_project
            // 
            this.btn_new_project.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_new_project.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_project.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_new_project.Image = ((System.Drawing.Image)(resources.GetObject("btn_new_project.Image")));
            this.btn_new_project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new_project.Location = new System.Drawing.Point(885, 30);
            this.btn_new_project.Name = "btn_new_project";
            this.btn_new_project.Size = new System.Drawing.Size(93, 42);
            this.btn_new_project.TabIndex = 0;
            this.btn_new_project.Text = "        New             Project";
            this.btn_new_project.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new_project.UseVisualStyleBackColor = false;
            this.btn_new_project.Click += new System.EventHandler(this.btn_new_project_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.pct_logo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 1104);
            this.panel2.TabIndex = 12;
            // 
            // pct_logo
            // 
            this.pct_logo.Image = ((System.Drawing.Image)(resources.GetObject("pct_logo.Image")));
            this.pct_logo.Location = new System.Drawing.Point(10, 12);
            this.pct_logo.Margin = new System.Windows.Forms.Padding(300, 3, 3, 3);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(152, 76);
            this.pct_logo.TabIndex = 16;
            this.pct_logo.TabStop = false;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_description.Location = new System.Drawing.Point(453, 129);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(72, 15);
            this.lbl_description.TabIndex = 39;
            this.lbl_description.Text = "Customer:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_id.Location = new System.Drawing.Point(229, 129);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(74, 15);
            this.lbl_id.TabIndex = 38;
            this.lbl_id.Text = "Project ID:";
            // 
            // txt_quote_id
            // 
            this.txt_quote_id.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_quote_id.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_quote_id.Location = new System.Drawing.Point(229, 146);
            this.txt_quote_id.Name = "txt_quote_id";
            this.txt_quote_id.Size = new System.Drawing.Size(86, 20);
            this.txt_quote_id.TabIndex = 37;
            this.txt_quote_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_quote_id_KeyDown);
            this.txt_quote_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quote_id_KeyPress);
            // 
            // txt_customer
            // 
            this.txt_customer.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_customer.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_customer.Location = new System.Drawing.Point(449, 146);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(163, 20);
            this.txt_customer.TabIndex = 36;
            this.txt_customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_customer_KeyDown);
            // 
            // pct_clear
            // 
            this.pct_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_clear.Image = ((System.Drawing.Image)(resources.GetObject("pct_clear.Image")));
            this.pct_clear.Location = new System.Drawing.Point(746, 150);
            this.pct_clear.Name = "pct_clear";
            this.pct_clear.Size = new System.Drawing.Size(26, 20);
            this.pct_clear.TabIndex = 40;
            this.pct_clear.TabStop = false;
            this.pct_clear.Click += new System.EventHandler(this.pct_clear_Click);
            // 
            // grid_quote_list
            // 
            this.grid_quote_list.AllowUserToAddRows = false;
            this.grid_quote_list.AllowUserToDeleteRows = false;
            this.grid_quote_list.AllowUserToResizeColumns = false;
            this.grid_quote_list.AllowUserToResizeRows = false;
            this.grid_quote_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_quote_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_quote_list.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_quote_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_quote_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_quote_list.ColumnHeadersHeight = 40;
            this.grid_quote_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_quote_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_open});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_quote_list.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_quote_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_quote_list.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_quote_list.Location = new System.Drawing.Point(227, 183);
            this.grid_quote_list.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_quote_list.MaximumSize = new System.Drawing.Size(755, 328);
            this.grid_quote_list.MinimumSize = new System.Drawing.Size(455, 328);
            this.grid_quote_list.Name = "grid_quote_list";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_quote_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_quote_list.RowHeadersVisible = false;
            this.grid_quote_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_quote_list.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_quote_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_quote_list.Size = new System.Drawing.Size(747, 328);
            this.grid_quote_list.TabIndex = 22;
            this.grid_quote_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_quote_list_CellContentClick);
            // 
            // btn_open
            // 
            this.btn_open.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.NullValue = "Open";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
            this.btn_open.DefaultCellStyle = dataGridViewCellStyle2;
            this.btn_open.FillWeight = 26F;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.HeaderText = "";
            this.btn_open.MinimumWidth = 26;
            this.btn_open.Name = "btn_open";
            // 
            // Reference
            // 
            this.Reference.AutoSize = true;
            this.Reference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reference.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Reference.Location = new System.Drawing.Point(326, 129);
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(77, 15);
            this.Reference.TabIndex = 42;
            this.Reference.Text = "Reference:";
            // 
            // txt_reference
            // 
            this.txt_reference.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_reference.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_reference.Location = new System.Drawing.Point(326, 146);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(106, 20);
            this.txt_reference.TabIndex = 41;
            this.txt_reference.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_reference_KeyDown);
            // 
            // date_end
            // 
            this.date_end.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_end.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.date_end.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.date_end.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.date_end.CalendarTitleForeColor = System.Drawing.Color.CornflowerBlue;
            this.date_end.CalendarTrailingForeColor = System.Drawing.Color.AliceBlue;
            this.date_end.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date_end.CustomFormat = "00/00/0000";
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_end.Location = new System.Drawing.Point(636, 159);
            this.date_end.MinDate = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(98, 20);
            this.date_end.TabIndex = 2;
            this.date_end.ValueChanged += new System.EventHandler(this.date_end_ValueChanged);
            // 
            // date_start
            // 
            this.date_start.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_start.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.date_start.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.date_start.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.date_start.CalendarTitleForeColor = System.Drawing.Color.CornflowerBlue;
            this.date_start.CalendarTrailingForeColor = System.Drawing.Color.AliceBlue;
            this.date_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date_start.CustomFormat = "00/00/0000";
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_start.Location = new System.Drawing.Point(636, 133);
            this.date_start.MinDate = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(98, 20);
            this.date_start.TabIndex = 43;
            this.date_start.ValueChanged += new System.EventHandler(this.date_start_ValueChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1031, 559);
            this.Controls.Add(this.date_start);
            this.Controls.Add(this.date_end);
            this.Controls.Add(this.Reference);
            this.Controls.Add(this.txt_reference);
            this.Controls.Add(this.pct_clear);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_quote_id);
            this.Controls.Add(this.txt_customer);
            this.Controls.Add(this.grid_quote_list);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_quote_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_new_project;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_quote_id;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.PictureBox pct_clear;
        private System.Windows.Forms.DataGridView grid_quote_list;
        private System.Windows.Forms.Label Reference;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.DataGridViewButtonColumn btn_open;
        private System.Windows.Forms.DateTimePicker date_start;
    }
}

