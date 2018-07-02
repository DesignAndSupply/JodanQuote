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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.dT_customer1 = new JodanQuote.Datasource.DT_customer();
            this.grid_settings = new System.Windows.Forms.DataGridView();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.date_modified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markup_hardware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markup_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labour_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.single_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.double_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.single_flood_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.double_flood_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_Settings = new JodanQuote.Datasource.DT_Settings();
            this.ada_setting = new JodanQuote.Datasource.DT_SettingsTableAdapters.ada_setting();
            ((System.ComponentModel.ISupportInitialize)(this.dT_customer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSettingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Settings)).BeginInit();
            this.SuspendLayout();
            // 
            // dT_customer1
            // 
            this.dT_customer1.DataSetName = "DT_customer";
            this.dT_customer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.grid_settings.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_settings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_settings.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_settings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_settings.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_settings.Location = new System.Drawing.Point(49, 135);
            this.grid_settings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_settings.MaximumSize = new System.Drawing.Size(7055, 328);
            this.grid_settings.Name = "grid_settings";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_settings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_settings.RowHeadersVisible = false;
            this.grid_settings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_settings.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_settings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_settings.Size = new System.Drawing.Size(600, 71);
            this.grid_settings.TabIndex = 23;
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
            this.btn_save.Location = new System.Drawing.Point(535, 29);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 37);
            this.btn_save.TabIndex = 70;
            this.btn_save.Text = "     Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // date_modified
            // 
            this.date_modified.DataPropertyName = "date_modified";
            this.date_modified.HeaderText = "Date Modified";
            this.date_modified.Name = "date_modified";
            // 
            // markup_hardware
            // 
            this.markup_hardware.DataPropertyName = "markup_hardware";
            this.markup_hardware.HeaderText = "Markup Hardware";
            this.markup_hardware.Name = "markup_hardware";
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
            // ada_setting
            // 
            this.ada_setting.ClearBeforeFill = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(686, 316);
            this.Controls.Add(this.pct_logo);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.grid_settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dT_customer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSettingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Settings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Datasource.DT_customer dT_customer1;
        private System.Windows.Forms.DataGridView grid_settings;
        private Datasource.DT_Settings dT_Settings;
        private System.Windows.Forms.BindingSource dTSettingBindingSource;
        private Datasource.DT_SettingsTableAdapters.ada_setting ada_setting;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedmodifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn markup_hardware;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_modified;
        private System.Windows.Forms.DataGridViewTextBoxColumn markup_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn labour_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn single_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn double_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn single_flood_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn double_flood_extra;
    }
}