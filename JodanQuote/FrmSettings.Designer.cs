namespace JodanQuote
{
    partial class FrmSettings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.dT_customer1 = new JodanQuote.Datasource.DT_customer();
            this.dTSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_Settings = new JodanQuote.Datasource.DT_Settings();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.ada_setting = new JodanQuote.Datasource.DT_SettingsTableAdapters.ada_setting();
            this.tab_settings = new System.Windows.Forms.TabControl();
            this.tab_markup = new System.Windows.Forms.TabPage();
            this.grid_settings = new System.Windows.Forms.DataGridView();
            this.markup_hardware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_modified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markup_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labour_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.single_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.double_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.single_flood_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.double_flood_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_stock = new System.Windows.Forms.TabPage();
            this.grid_stock = new System.Windows.Forms.DataGridView();
            this.chk_jodan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cviewhardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_hardware = new JodanQuote.Datasource.DT_hardware();
            this.c_view_hardwareTableAdapter = new JodanQuote.Datasource.DT_hardwareTableAdapters.c_view_hardwareTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dT_customer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSettingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            this.tab_settings.SuspendLayout();
            this.tab_markup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_settings)).BeginInit();
            this.tab_stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewhardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_hardware)).BeginInit();
            this.SuspendLayout();
            // 
            // dT_customer1
            // 
            this.dT_customer1.DataSetName = "DT_customer";
            this.dT_customer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTSettingBindingSource
            // 
            this.dTSettingBindingSource.DataMember = "DT_Setting";
            this.dTSettingBindingSource.DataSource = this.dT_Settings;
            // 
            // dT_Settings
            // 
            this.dT_Settings.DataSetName = "DT_Settings";
            this.dT_Settings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pct_logo
            // 
            this.pct_logo.Image = global::JodanQuote.Properties.Resources.Jodan;
            this.pct_logo.Location = new System.Drawing.Point(22, 12);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(151, 86);
            this.pct_logo.TabIndex = 69;
            this.pct_logo.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_save.Image = global::JodanQuote.Properties.Resources.Save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(1013, 64);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 37);
            this.btn_save.TabIndex = 70;
            this.btn_save.Text = "     Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ada_setting
            // 
            this.ada_setting.ClearBeforeFill = true;
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.tab_markup);
            this.tab_settings.Controls.Add(this.tab_stock);
            this.tab_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_settings.Location = new System.Drawing.Point(22, 107);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.SelectedIndex = 0;
            this.tab_settings.Size = new System.Drawing.Size(1101, 394);
            this.tab_settings.TabIndex = 71;
            // 
            // tab_markup
            // 
            this.tab_markup.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tab_markup.Controls.Add(this.grid_settings);
            this.tab_markup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_markup.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tab_markup.Location = new System.Drawing.Point(4, 22);
            this.tab_markup.Name = "tab_markup";
            this.tab_markup.Padding = new System.Windows.Forms.Padding(3);
            this.tab_markup.Size = new System.Drawing.Size(1093, 368);
            this.tab_markup.TabIndex = 0;
            this.tab_markup.Text = "Markup";
            // 
            // grid_settings
            // 
            this.grid_settings.AllowUserToAddRows = false;
            this.grid_settings.AllowUserToDeleteRows = false;
            this.grid_settings.AllowUserToResizeColumns = false;
            this.grid_settings.AllowUserToResizeRows = false;
            this.grid_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_settings.AutoGenerateColumns = false;
            this.grid_settings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_settings.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.grid_settings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_settings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_settings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_settings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.markup_hardware,
            this.date_modified,
            this.markup_material,
            this.labour_rate,
            this.single_extra,
            this.double_extra,
            this.single_flood_extra,
            this.double_flood_extra});
            this.grid_settings.DataSource = this.dTSettingBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_settings.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_settings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_settings.GridColor = System.Drawing.Color.AliceBlue;
            this.grid_settings.Location = new System.Drawing.Point(18, 49);
            this.grid_settings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_settings.MaximumSize = new System.Drawing.Size(7055, 328);
            this.grid_settings.Name = "grid_settings";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_settings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_settings.RowHeadersVisible = false;
            this.grid_settings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_settings.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_settings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_settings.Size = new System.Drawing.Size(1049, 119);
            this.grid_settings.TabIndex = 72;
            // 
            // markup_hardware
            // 
            this.markup_hardware.DataPropertyName = "markup_hardware";
            this.markup_hardware.HeaderText = "Markup Hardware";
            this.markup_hardware.Name = "markup_hardware";
            // 
            // date_modified
            // 
            this.date_modified.DataPropertyName = "date_modified";
            this.date_modified.HeaderText = "Date Modified";
            this.date_modified.Name = "date_modified";
            // 
            // markup_material
            // 
            this.markup_material.DataPropertyName = "markup_material";
            this.markup_material.HeaderText = "Markup Material";
            this.markup_material.Name = "markup_material";
            // 
            // labour_rate
            // 
            this.labour_rate.DataPropertyName = "labour_rate";
            this.labour_rate.HeaderText = "Labour Rate";
            this.labour_rate.Name = "labour_rate";
            // 
            // single_extra
            // 
            this.single_extra.DataPropertyName = "single_extra";
            this.single_extra.HeaderText = "Single Extra";
            this.single_extra.Name = "single_extra";
            // 
            // double_extra
            // 
            this.double_extra.DataPropertyName = "double_extra";
            this.double_extra.HeaderText = "Double Extra";
            this.double_extra.Name = "double_extra";
            // 
            // single_flood_extra
            // 
            this.single_flood_extra.DataPropertyName = "single_flood_extra";
            this.single_flood_extra.HeaderText = "Single Flood Extra";
            this.single_flood_extra.Name = "single_flood_extra";
            // 
            // double_flood_extra
            // 
            this.double_flood_extra.DataPropertyName = "double_flood_extra";
            this.double_flood_extra.HeaderText = "Double Flood Extra";
            this.double_flood_extra.Name = "double_flood_extra";
            // 
            // tab_stock
            // 
            this.tab_stock.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tab_stock.Controls.Add(this.grid_stock);
            this.tab_stock.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tab_stock.Location = new System.Drawing.Point(4, 22);
            this.tab_stock.Name = "tab_stock";
            this.tab_stock.Padding = new System.Windows.Forms.Padding(3);
            this.tab_stock.Size = new System.Drawing.Size(1093, 368);
            this.tab_stock.TabIndex = 1;
            this.tab_stock.Text = "Stock";
            // 
            // grid_stock
            // 
            this.grid_stock.AllowUserToAddRows = false;
            this.grid_stock.AllowUserToDeleteRows = false;
            this.grid_stock.AllowUserToResizeColumns = false;
            this.grid_stock.AllowUserToResizeRows = false;
            this.grid_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_stock.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grid_stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk_jodan});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_stock.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_stock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.grid_stock.GridColor = System.Drawing.Color.AliceBlue;
            this.grid_stock.Location = new System.Drawing.Point(176, 42);
            this.grid_stock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_stock.MaximumSize = new System.Drawing.Size(7055, 328);
            this.grid_stock.Name = "grid_stock";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_stock.RowHeadersVisible = false;
            this.grid_stock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_stock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_stock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_stock.Size = new System.Drawing.Size(677, 293);
            this.grid_stock.TabIndex = 73;
            // 
            // chk_jodan
            // 
            this.chk_jodan.DataPropertyName = "jodan_stock";
            this.chk_jodan.HeaderText = "Jodan Stock";
            this.chk_jodan.Name = "chk_jodan";
            this.chk_jodan.TrueValue = "1";
            // 
            // cviewhardwareBindingSource
            // 
            this.cviewhardwareBindingSource.DataMember = "c_view_hardware";
            this.cviewhardwareBindingSource.DataSource = this.dT_hardware;
            // 
            // dT_hardware
            // 
            this.dT_hardware.DataSetName = "DT_hardware";
            this.dT_hardware.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c_view_hardwareTableAdapter
            // 
            this.c_view_hardwareTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1135, 516);
            this.Controls.Add(this.tab_settings);
            this.Controls.Add(this.pct_logo);
            this.Controls.Add(this.btn_save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dT_customer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSettingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            this.tab_settings.ResumeLayout(false);
            this.tab_markup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_settings)).EndInit();
            this.tab_stock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewhardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_hardware)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Datasource.DT_customer dT_customer1;
        private Datasource.DT_Settings dT_Settings;
        private System.Windows.Forms.BindingSource dTSettingBindingSource;
        private Datasource.DT_SettingsTableAdapters.ada_setting ada_setting;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedmodifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TabControl tab_settings;
        private System.Windows.Forms.TabPage tab_markup;
        private System.Windows.Forms.DataGridView grid_settings;
        private System.Windows.Forms.DataGridViewTextBoxColumn markup_hardware;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_modified;
        private System.Windows.Forms.DataGridViewTextBoxColumn markup_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn labour_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn single_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn double_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn single_flood_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn double_flood_extra;
        private System.Windows.Forms.TabPage tab_stock;
        private System.Windows.Forms.DataGridView grid_stock;
        private Datasource.DT_hardware dT_hardware;
        private System.Windows.Forms.BindingSource cviewhardwareBindingSource;
        private Datasource.DT_hardwareTableAdapters.c_view_hardwareTableAdapter c_view_hardwareTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_jodan;
    }
}