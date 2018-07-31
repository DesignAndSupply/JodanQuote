namespace JodanQuote
{
    partial class FrmViewAddon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewAddon));
            this.grid_addon = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addonwidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addonheightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.powdercoatedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labourcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labour_hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powdercoatcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitmaterialcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cViewItemAddOnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_Item_Add_On = new JodanQuote.Datasource.DT_Item_Add_On();
            this.c_View_Item_Add_OnTableAdapter = new JodanQuote.Datasource.DT_Item_Add_OnTableAdapters.C_View_Item_Add_OnTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid_addon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cViewItemAddOnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Item_Add_On)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_addon
            // 
            this.grid_addon.AllowUserToAddRows = false;
            this.grid_addon.AllowUserToDeleteRows = false;
            this.grid_addon.AllowUserToResizeColumns = false;
            this.grid_addon.AllowUserToResizeRows = false;
            this.grid_addon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grid_addon.AutoGenerateColumns = false;
            this.grid_addon.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_addon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_addon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_addon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_addon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.addonwidthDataGridViewTextBoxColumn,
            this.addonheightDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.removableDataGridViewCheckBoxColumn,
            this.powdercoatedDataGridViewCheckBoxColumn,
            this.materialcostDataGridViewTextBoxColumn,
            this.labourcostDataGridViewTextBoxColumn,
            this.labour_hours,
            this.powdercoatcostDataGridViewTextBoxColumn,
            this.unitmaterialcostDataGridViewTextBoxColumn});
            this.grid_addon.DataSource = this.cViewItemAddOnBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_addon.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_addon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_addon.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_addon.Location = new System.Drawing.Point(37, 19);
            this.grid_addon.Name = "grid_addon";
            this.grid_addon.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_addon.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_addon.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            this.grid_addon.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_addon.Size = new System.Drawing.Size(1026, 200);
            this.grid_addon.TabIndex = 59;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 130F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addonwidthDataGridViewTextBoxColumn
            // 
            this.addonwidthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addonwidthDataGridViewTextBoxColumn.DataPropertyName = "add_on_width";
            this.addonwidthDataGridViewTextBoxColumn.HeaderText = " Addon Width";
            this.addonwidthDataGridViewTextBoxColumn.Name = "addonwidthDataGridViewTextBoxColumn";
            this.addonwidthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addonheightDataGridViewTextBoxColumn
            // 
            this.addonheightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addonheightDataGridViewTextBoxColumn.DataPropertyName = "add_on_height";
            this.addonheightDataGridViewTextBoxColumn.HeaderText = "Addon Height";
            this.addonheightDataGridViewTextBoxColumn.Name = "addonheightDataGridViewTextBoxColumn";
            this.addonheightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // removableDataGridViewCheckBoxColumn
            // 
            this.removableDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.removableDataGridViewCheckBoxColumn.DataPropertyName = "removable";
            this.removableDataGridViewCheckBoxColumn.FillWeight = 107F;
            this.removableDataGridViewCheckBoxColumn.HeaderText = "Removable";
            this.removableDataGridViewCheckBoxColumn.Name = "removableDataGridViewCheckBoxColumn";
            this.removableDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // powdercoatedDataGridViewCheckBoxColumn
            // 
            this.powdercoatedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.powdercoatedDataGridViewCheckBoxColumn.DataPropertyName = "powder_coated";
            this.powdercoatedDataGridViewCheckBoxColumn.HeaderText = "Powder Coated";
            this.powdercoatedDataGridViewCheckBoxColumn.Name = "powdercoatedDataGridViewCheckBoxColumn";
            this.powdercoatedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // materialcostDataGridViewTextBoxColumn
            // 
            this.materialcostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materialcostDataGridViewTextBoxColumn.DataPropertyName = "material_cost";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.materialcostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.materialcostDataGridViewTextBoxColumn.HeaderText = "Material Cost";
            this.materialcostDataGridViewTextBoxColumn.Name = "materialcostDataGridViewTextBoxColumn";
            this.materialcostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labourcostDataGridViewTextBoxColumn
            // 
            this.labourcostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.labourcostDataGridViewTextBoxColumn.DataPropertyName = "labour_cost";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.labourcostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.labourcostDataGridViewTextBoxColumn.HeaderText = "Labour  Cost";
            this.labourcostDataGridViewTextBoxColumn.Name = "labourcostDataGridViewTextBoxColumn";
            this.labourcostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labour_hours
            // 
            this.labour_hours.DataPropertyName = "labour_hours";
            this.labour_hours.HeaderText = "Labour Hours";
            this.labour_hours.Name = "labour_hours";
            this.labour_hours.ReadOnly = true;
            // 
            // powdercoatcostDataGridViewTextBoxColumn
            // 
            this.powdercoatcostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.powdercoatcostDataGridViewTextBoxColumn.DataPropertyName = "powder_coat_cost";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.powdercoatcostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.powdercoatcostDataGridViewTextBoxColumn.HeaderText = "Powder Coat Cost";
            this.powdercoatcostDataGridViewTextBoxColumn.Name = "powdercoatcostDataGridViewTextBoxColumn";
            this.powdercoatcostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitmaterialcostDataGridViewTextBoxColumn
            // 
            this.unitmaterialcostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitmaterialcostDataGridViewTextBoxColumn.DataPropertyName = "unit_material_cost";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.unitmaterialcostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.unitmaterialcostDataGridViewTextBoxColumn.HeaderText = "Total Cost";
            this.unitmaterialcostDataGridViewTextBoxColumn.Name = "unitmaterialcostDataGridViewTextBoxColumn";
            this.unitmaterialcostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cViewItemAddOnBindingSource
            // 
            this.cViewItemAddOnBindingSource.DataMember = "C_View_Item_Add_On";
            this.cViewItemAddOnBindingSource.DataSource = this.dT_Item_Add_On;
            // 
            // dT_Item_Add_On
            // 
            this.dT_Item_Add_On.DataSetName = "DT_Item_Add_On";
            this.dT_Item_Add_On.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c_View_Item_Add_OnTableAdapter
            // 
            this.c_View_Item_Add_OnTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewAddon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1129, 244);
            this.Controls.Add(this.grid_addon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmViewAddon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmViewAddon";
            ((System.ComponentModel.ISupportInitialize)(this.grid_addon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cViewItemAddOnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Item_Add_On)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_addon;
        private System.Windows.Forms.BindingSource cViewItemAddOnBindingSource;
        private Datasource.DT_Item_Add_On dT_Item_Add_On;
        private Datasource.DT_Item_Add_OnTableAdapters.C_View_Item_Add_OnTableAdapter c_View_Item_Add_OnTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addonwidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addonheightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn removableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn powdercoatedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labourcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labour_hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn powdercoatcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitmaterialcostDataGridViewTextBoxColumn;
    }
}