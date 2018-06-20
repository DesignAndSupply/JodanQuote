namespace JodanQuote
{
    partial class FrmHardwareSelect
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHardwareSelect));
            this.grid_hardware = new System.Windows.Forms.DataGridView();
            this.hardware_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardware_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardware_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardware_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardware_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cviewhardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_hardware = new JodanQuote.Datasource.DT_hardware();
            this.pct_clear = new System.Windows.Forms.PictureBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_des = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.c_view_hardwareTableAdapter = new JodanQuote.Datasource.DT_hardwareTableAdapters.c_view_hardwareTableAdapter();
            this.grid_hardware_selected = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_add_hardware = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_hardware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewhardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_hardware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_hardware_selected)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_hardware
            // 
            this.grid_hardware.AllowUserToAddRows = false;
            this.grid_hardware.AutoGenerateColumns = false;
            this.grid_hardware.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_hardware.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_hardware.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_hardware.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_hardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_hardware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hardware_id,
            this.hardware_description,
            this.hardware_cost,
            this.hardware_quantity,
            this.hardware_total,
            this.btn_add});
            this.grid_hardware.DataSource = this.cviewhardwareBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_hardware.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_hardware.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_hardware.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_hardware.Location = new System.Drawing.Point(29, 73);
            this.grid_hardware.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_hardware.MaximumSize = new System.Drawing.Size(480, 465);
            this.grid_hardware.MinimumSize = new System.Drawing.Size(480, 465);
            this.grid_hardware.Name = "grid_hardware";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_hardware.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_hardware.RowHeadersVisible = false;
            this.grid_hardware.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_hardware.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_hardware.Size = new System.Drawing.Size(480, 465);
            this.grid_hardware.TabIndex = 68;
            this.grid_hardware.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_hardware_CellContentClick);
            this.grid_hardware.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_hardware_CellEndEdit);
            this.grid_hardware.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_hardware_CellLeave);
            // 
            // hardware_id
            // 
            this.hardware_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.hardware_id.DataPropertyName = "id";
            this.hardware_id.HeaderText = "";
            this.hardware_id.Name = "hardware_id";
            this.hardware_id.ReadOnly = true;
            this.hardware_id.Visible = false;
            // 
            // hardware_description
            // 
            this.hardware_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.hardware_description.DataPropertyName = "Description";
            this.hardware_description.HeaderText = "Description";
            this.hardware_description.Name = "hardware_description";
            this.hardware_description.ReadOnly = true;
            this.hardware_description.Width = 119;
            // 
            // hardware_cost
            // 
            this.hardware_cost.DataPropertyName = "Cost";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.hardware_cost.DefaultCellStyle = dataGridViewCellStyle2;
            this.hardware_cost.HeaderText = "Cost";
            this.hardware_cost.Name = "hardware_cost";
            this.hardware_cost.ReadOnly = true;
            this.hardware_cost.Width = 69;
            // 
            // hardware_quantity
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.Format = "1";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            this.hardware_quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.hardware_quantity.HeaderText = "Quantity";
            this.hardware_quantity.Name = "hardware_quantity";
            this.hardware_quantity.Width = 95;
            // 
            // hardware_total
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.hardware_total.DefaultCellStyle = dataGridViewCellStyle4;
            this.hardware_total.HeaderText = "Total";
            this.hardware_total.Name = "hardware_total";
            this.hardware_total.ReadOnly = true;
            this.hardware_total.Width = 71;
            // 
            // btn_add
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.NullValue = "Add";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.AliceBlue;
            this.btn_add.DefaultCellStyle = dataGridViewCellStyle5;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.HeaderText = "";
            this.btn_add.Name = "btn_add";
            this.btn_add.Width = 5;
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
            // pct_clear
            // 
            this.pct_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_clear.Image = global::JodanQuote.Properties.Resources.clear;
            this.pct_clear.Location = new System.Drawing.Point(354, 38);
            this.pct_clear.Name = "pct_clear";
            this.pct_clear.Size = new System.Drawing.Size(26, 20);
            this.pct_clear.TabIndex = 73;
            this.pct_clear.TabStop = false;
            this.pct_clear.Click += new System.EventHandler(this.pct_clear_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_description.Location = new System.Drawing.Point(185, 19);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(41, 15);
            this.lbl_description.TabIndex = 72;
            this.lbl_description.Text = "Type:";
            // 
            // lbl_des
            // 
            this.lbl_des.AutoSize = true;
            this.lbl_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_des.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_des.Location = new System.Drawing.Point(32, 19);
            this.lbl_des.Name = "lbl_des";
            this.lbl_des.Size = new System.Drawing.Size(84, 15);
            this.lbl_des.TabIndex = 71;
            this.lbl_des.Text = "Description:";
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_description.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_description.Location = new System.Drawing.Point(32, 38);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(110, 20);
            this.txt_description.TabIndex = 70;
            this.txt_description.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_description_KeyDown);
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_type.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(188, 37);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(163, 21);
            this.cmb_type.TabIndex = 74;
            this.cmb_type.TextChanged += new System.EventHandler(this.cmb_type_TextChanged);
            // 
            // c_view_hardwareTableAdapter
            // 
            this.c_view_hardwareTableAdapter.ClearBeforeFill = true;
            // 
            // grid_hardware_selected
            // 
            this.grid_hardware_selected.AllowUserToAddRows = false;
            this.grid_hardware_selected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grid_hardware_selected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_hardware_selected.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_hardware_selected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_hardware_selected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_hardware_selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_hardware_selected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cost,
            this.Description,
            this.Quantity,
            this.Total,
            this.btn_delete});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_hardware_selected.DefaultCellStyle = dataGridViewCellStyle13;
            this.grid_hardware_selected.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_hardware_selected.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_hardware_selected.Location = new System.Drawing.Point(543, 71);
            this.grid_hardware_selected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_hardware_selected.MaximumSize = new System.Drawing.Size(345, 465);
            this.grid_hardware_selected.MinimumSize = new System.Drawing.Size(345, 465);
            this.grid_hardware_selected.Name = "grid_hardware_selected";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_hardware_selected.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grid_hardware_selected.RowHeadersVisible = false;
            this.grid_hardware_selected.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_hardware_selected.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_hardware_selected.Size = new System.Drawing.Size(345, 465);
            this.grid_hardware_selected.TabIndex = 75;
            this.grid_hardware_selected.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_hardware_selected_CellContentClick);
            // 
            // id
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle9.NullValue = "Add";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.AliceBlue;
            this.id.DefaultCellStyle = dataGridViewCellStyle9;
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            this.id.Width = 5;
            // 
            // cost
            // 
            this.cost.HeaderText = "cost";
            this.cost.Name = "cost";
            this.cost.Visible = false;
            this.cost.Width = 47;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.DefaultCellStyle = dataGridViewCellStyle10;
            this.Description.FillWeight = 123.181F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle11;
            this.Quantity.FillWeight = 123.181F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle12;
            this.Total.FillWeight = 123.181F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_delete.FillWeight = 30.45685F;
            this.btn_delete.HeaderText = "";
            this.btn_delete.Image = global::JodanQuote.Properties.Resources.clear;
            this.btn_delete.MinimumWidth = 15;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_add_hardware
            // 
            this.btn_add_hardware.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_add_hardware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_hardware.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_add_hardware.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_add_hardware.Image = global::JodanQuote.Properties.Resources.Save;
            this.btn_add_hardware.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_hardware.Location = new System.Drawing.Point(911, 505);
            this.btn_add_hardware.Name = "btn_add_hardware";
            this.btn_add_hardware.Size = new System.Drawing.Size(98, 37);
            this.btn_add_hardware.TabIndex = 76;
            this.btn_add_hardware.Text = "            Add                  Hardware ";
            this.btn_add_hardware.UseVisualStyleBackColor = false;
            this.btn_add_hardware.Click += new System.EventHandler(this.btn_add_hardware_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_clear.Image = global::JodanQuote.Properties.Resources.Bin;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(911, 462);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 37);
            this.btn_clear.TabIndex = 77;
            this.btn_clear.Text = "            Clear               Selection";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_back.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_back.Image = global::JodanQuote.Properties.Resources.ReturnArrow;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(911, 419);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 37);
            this.btn_back.TabIndex = 78;
            this.btn_back.Text = "    Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FrmHardwareSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1038, 558);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add_hardware);
            this.Controls.Add(this.grid_hardware_selected);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.pct_clear);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_des);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.grid_hardware);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHardwareSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Hardware";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHardwareSelect_FormClosed);
            this.Load += new System.EventHandler(this.FrmHardwareSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_hardware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewhardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_hardware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_hardware_selected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_hardware;
        private System.Windows.Forms.PictureBox pct_clear;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_des;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.ComboBox cmb_type;
        private Datasource.DT_hardware dT_hardware;
        private System.Windows.Forms.BindingSource cviewhardwareBindingSource;
        private Datasource.DT_hardwareTableAdapters.c_view_hardwareTableAdapter c_view_hardwareTableAdapter;
        private System.Windows.Forms.DataGridView grid_hardware_selected;
        private System.Windows.Forms.Button btn_add_hardware;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardware_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardware_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardware_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardware_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardware_total;
        private System.Windows.Forms.DataGridViewButtonColumn btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn btn_delete;
    }
}