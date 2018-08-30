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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuote));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maintab_doors_on_quote = new System.Windows.Forms.TabControl();
            this.tab_door_on_quote = new System.Windows.Forms.TabPage();
            this.grid_items_on_quote = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_view = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_copy = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_delete_item = new System.Windows.Forms.DataGridViewImageColumn();
            this.Item_Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTQuoteItemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dT_Quote = new JodanQuote.Datasource.DT_Quote();
            this.dTQuoteItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_view_original = new System.Windows.Forms.Button();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_project = new System.Windows.Forms.TextBox();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.sALESLEDGERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_customer = new JodanQuote.Datasource.DT_customer();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.btn_email_project = new System.Windows.Forms.Button();
            this.lbl_quote_id = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_new_item = new System.Windows.Forms.Button();
            this.btn_print_project = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_notes = new System.Windows.Forms.Button();
            this.btn_additional_cost = new System.Windows.Forms.Button();
            this.btn_quote_details = new System.Windows.Forms.Button();
            this.main_tab_project_additions = new System.Windows.Forms.TabControl();
            this.tab_quote_details = new System.Windows.Forms.TabPage();
            this.txt_project_ref = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quote_status = new System.Windows.Forms.TextBox();
            this.cmb_quote_status = new System.Windows.Forms.ComboBox();
            this.cViewStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_Status = new JodanQuote.Datasource.DT_Status();
            this.tab_additonal_cost = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_installation = new System.Windows.Forms.TextBox();
            this.txt_delivery_charge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_survery_charge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_notes = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.ada_setting = new JodanQuote.Datasource.DT_SettingsTableAdapters.ada_setting();
            this.dT_Settings = new JodanQuote.Datasource.DT_Settings();
            this.c_View_StatusTableAdapter = new JodanQuote.Datasource.DT_StatusTableAdapters.C_View_StatusTableAdapter();
            this.Item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revision_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALES_LEDGERTableAdapter = new JodanQuote.Datasource.DT_customerTableAdapters.SALES_LEDGERTableAdapter();
            this.ada_quote_items = new JodanQuote.Datasource.DT_QuoteTableAdapters.ada_quote_items();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.maintab_doors_on_quote.SuspendLayout();
            this.tab_door_on_quote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_items_on_quote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTQuoteItemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Quote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTQuoteItemsBindingSource)).BeginInit();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sALESLEDGERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.main_tab_project_additions.SuspendLayout();
            this.tab_quote_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cViewStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Status)).BeginInit();
            this.tab_additonal_cost.SuspendLayout();
            this.tab_notes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Settings)).BeginInit();
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
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
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
            this.label6.Location = new System.Drawing.Point(516, 134);
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
            this.maintab_doors_on_quote.Location = new System.Drawing.Point(507, 128);
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
            this.tab_door_on_quote.Text = "                        ";
            // 
            // grid_items_on_quote
            // 
            this.grid_items_on_quote.AllowUserToAddRows = false;
            this.grid_items_on_quote.AllowUserToDeleteRows = false;
            this.grid_items_on_quote.AllowUserToResizeColumns = false;
            this.grid_items_on_quote.AllowUserToResizeRows = false;
            this.grid_items_on_quote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_items_on_quote.AutoGenerateColumns = false;
            this.grid_items_on_quote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_items_on_quote.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_items_on_quote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_items_on_quote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_items_on_quote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_items_on_quote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.revisionidDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn2,
            this.date_created,
            this.dataGridViewTextBoxColumn2,
            this.btn_view,
            this.btn_copy,
            this.btn_delete_item,
            this.Item_Identity});
            this.grid_items_on_quote.DataSource = this.dTQuoteItemsBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_items_on_quote.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid_items_on_quote.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_items_on_quote.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_items_on_quote.Location = new System.Drawing.Point(67, 74);
            this.grid_items_on_quote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_items_on_quote.Name = "grid_items_on_quote";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_items_on_quote.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_items_on_quote.RowHeadersVisible = false;
            this.grid_items_on_quote.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_items_on_quote.Size = new System.Drawing.Size(591, 237);
            this.grid_items_on_quote.TabIndex = 24;
            this.grid_items_on_quote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_items_on_quote_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "item_id";
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "   Item    Number";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // revisionidDataGridViewTextBoxColumn
            // 
            this.revisionidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.revisionidDataGridViewTextBoxColumn.DataPropertyName = "revision_id";
            this.revisionidDataGridViewTextBoxColumn.FillWeight = 80F;
            this.revisionidDataGridViewTextBoxColumn.HeaderText = "Revision Number";
            this.revisionidDataGridViewTextBoxColumn.Name = "revisionidDataGridViewTextBoxColumn";
            // 
            // createdbyDataGridViewTextBoxColumn2
            // 
            this.createdbyDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdbyDataGridViewTextBoxColumn2.DataPropertyName = "created_by";
            this.createdbyDataGridViewTextBoxColumn2.HeaderText = "Created By";
            this.createdbyDataGridViewTextBoxColumn2.Name = "createdbyDataGridViewTextBoxColumn2";
            // 
            // date_created
            // 
            this.date_created.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_created.DataPropertyName = "item_date";
            this.date_created.FillWeight = 85F;
            this.date_created.HeaderText = "    Date     Created";
            this.date_created.Name = "date_created";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "total_cost";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.FillWeight = 80F;
            this.dataGridViewTextBoxColumn2.HeaderText = "   Total     Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btn_view
            // 
            this.btn_view.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.NullValue = "Open";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.AliceBlue;
            this.btn_view.DefaultCellStyle = dataGridViewCellStyle3;
            this.btn_view.FillWeight = 40F;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.HeaderText = "";
            this.btn_view.Name = "btn_view";
            this.btn_view.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btn_copy
            // 
            this.btn_copy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_copy.FillWeight = 20F;
            this.btn_copy.HeaderText = "";
            this.btn_copy.Image = ((System.Drawing.Image)(resources.GetObject("btn_copy.Image")));
            this.btn_copy.Name = "btn_copy";
            // 
            // btn_delete_item
            // 
            this.btn_delete_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_delete_item.FillWeight = 20F;
            this.btn_delete_item.HeaderText = "";
            this.btn_delete_item.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete_item.Image")));
            this.btn_delete_item.Name = "btn_delete_item";
            // 
            // Item_Identity
            // 
            this.Item_Identity.DataPropertyName = "Item Identity";
            this.Item_Identity.HeaderText = "Item Identity";
            this.Item_Identity.Name = "Item_Identity";
            this.Item_Identity.Visible = false;
            this.Item_Identity.Width = 106;
            // 
            // dTQuoteItemsBindingSource1
            // 
            this.dTQuoteItemsBindingSource1.DataMember = "DT_Quote_Items";
            this.dTQuoteItemsBindingSource1.DataSource = this.dT_Quote;
            // 
            // dT_Quote
            // 
            this.dT_Quote.DataSetName = "DT_Quote";
            this.dT_Quote.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTQuoteItemsBindingSource
            // 
            this.dTQuoteItemsBindingSource.DataMember = "DT_Quote_Items";
            this.dTQuoteItemsBindingSource.DataSource = this.dT_Quote;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_header.Controls.Add(this.btn_view_original);
            this.pnl_header.Controls.Add(this.btn_convert);
            this.pnl_header.Controls.Add(this.btn_edit);
            this.pnl_header.Controls.Add(this.txt_project);
            this.pnl_header.Controls.Add(this.txt_customer);
            this.pnl_header.Controls.Add(this.lbl_customer);
            this.pnl_header.Controls.Add(this.btn_email_project);
            this.pnl_header.Controls.Add(this.lbl_quote_id);
            this.pnl_header.Controls.Add(this.btn_back);
            this.pnl_header.Controls.Add(this.btn_new_item);
            this.pnl_header.Controls.Add(this.btn_print_project);
            this.pnl_header.Controls.Add(this.pictureBox3);
            this.pnl_header.Location = new System.Drawing.Point(-1, -1);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1927, 100);
            this.pnl_header.TabIndex = 48;
            // 
            // btn_view_original
            // 
            this.btn_view_original.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_view_original.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_original.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_view_original.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_view_original.Image = global::JodanQuote.Properties.Resources.Search_Small_;
            this.btn_view_original.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view_original.Location = new System.Drawing.Point(566, 30);
            this.btn_view_original.Name = "btn_view_original";
            this.btn_view_original.Size = new System.Drawing.Size(98, 37);
            this.btn_view_original.TabIndex = 49;
            this.btn_view_original.Text = "            View              Original";
            this.btn_view_original.UseVisualStyleBackColor = false;
            this.btn_view_original.Click += new System.EventHandler(this.btn_view_original_Click);
            // 
            // btn_convert
            // 
            this.btn_convert.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_convert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_convert.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_convert.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_convert.Image = ((System.Drawing.Image)(resources.GetObject("btn_convert.Image")));
            this.btn_convert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_convert.Location = new System.Drawing.Point(666, 29);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(98, 37);
            this.btn_convert.TabIndex = 48;
            this.btn_convert.Text = "   Convert    Quotation";
            this.btn_convert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_convert.UseVisualStyleBackColor = false;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(961, 29);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 37);
            this.btn_edit.TabIndex = 47;
            this.btn_edit.Text = "         Edit            Details";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_project
            // 
            this.txt_project.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_project.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txt_project.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_project.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt_project.Location = new System.Drawing.Point(319, 25);
            this.txt_project.MaxLength = 15;
            this.txt_project.Name = "txt_project";
            this.txt_project.Size = new System.Drawing.Size(200, 15);
            this.txt_project.TabIndex = 46;
            // 
            // txt_customer
            // 
            this.txt_customer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_customer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txt_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_customer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sALESLEDGERBindingSource, "customer_name", true));
            this.txt_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt_customer.Location = new System.Drawing.Point(320, 56);
            this.txt_customer.MaxLength = 15;
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(200, 15);
            this.txt_customer.TabIndex = 43;
            // 
            // sALESLEDGERBindingSource
            // 
            this.sALESLEDGERBindingSource.DataMember = "SALES_LEDGER";
            this.sALESLEDGERBindingSource.DataSource = this.dT_customer;
            // 
            // dT_customer
            // 
            this.dT_customer.DataSetName = "DT_customer";
            this.dT_customer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_customer.Location = new System.Drawing.Point(150, 53);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(152, 24);
            this.lbl_customer.TabIndex = 44;
            this.lbl_customer.Text = "Customer Name:";
            // 
            // btn_email_project
            // 
            this.btn_email_project.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_email_project.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_email_project.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_email_project.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_email_project.Image = ((System.Drawing.Image)(resources.GetObject("btn_email_project.Image")));
            this.btn_email_project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_email_project.Location = new System.Drawing.Point(763, 29);
            this.btn_email_project.Name = "btn_email_project";
            this.btn_email_project.Size = new System.Drawing.Size(98, 37);
            this.btn_email_project.TabIndex = 41;
            this.btn_email_project.Text = "   Email      Quotation";
            this.btn_email_project.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_email_project.UseVisualStyleBackColor = false;
            this.btn_email_project.Click += new System.EventHandler(this.btn_email_project_Click);
            // 
            // lbl_quote_id
            // 
            this.lbl_quote_id.AutoSize = true;
            this.lbl_quote_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quote_id.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_quote_id.Location = new System.Drawing.Point(145, 20);
            this.lbl_quote_id.Name = "lbl_quote_id";
            this.lbl_quote_id.Size = new System.Drawing.Size(157, 25);
            this.lbl_quote_id.TabIndex = 42;
            this.lbl_quote_id.Text = "Quote Number:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_back.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(1163, 29);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 37);
            this.btn_back.TabIndex = 40;
            this.btn_back.Text = "    Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_new_item
            // 
            this.btn_new_item.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_new_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_item.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_new_item.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_new_item.Image = ((System.Drawing.Image)(resources.GetObject("btn_new_item.Image")));
            this.btn_new_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new_item.Location = new System.Drawing.Point(1063, 29);
            this.btn_new_item.Name = "btn_new_item";
            this.btn_new_item.Size = new System.Drawing.Size(98, 37);
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
            this.btn_print_project.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_print_project.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_print_project.Image = ((System.Drawing.Image)(resources.GetObject("btn_print_project.Image")));
            this.btn_print_project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print_project.Location = new System.Drawing.Point(863, 29);
            this.btn_print_project.Name = "btn_print_project";
            this.btn_print_project.Size = new System.Drawing.Size(98, 37);
            this.btn_print_project.TabIndex = 39;
            this.btn_print_project.Text = "            Print                  Quotation";
            this.btn_print_project.UseVisualStyleBackColor = false;
            this.btn_print_project.Click += new System.EventHandler(this.btn_print_project_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JodanQuote.Properties.Resources.Logo;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 54);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.Location = new System.Drawing.Point(-3, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 639);
            this.panel6.TabIndex = 50;
            // 
            // btn_notes
            // 
            this.btn_notes.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_notes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notes.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_notes.Location = new System.Drawing.Point(381, 123);
            this.btn_notes.Name = "btn_notes";
            this.btn_notes.Size = new System.Drawing.Size(64, 24);
            this.btn_notes.TabIndex = 60;
            this.btn_notes.Text = "Notes";
            this.btn_notes.UseVisualStyleBackColor = false;
            this.btn_notes.Click += new System.EventHandler(this.btn_notes_Click);
            // 
            // btn_additional_cost
            // 
            this.btn_additional_cost.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_additional_cost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_additional_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_additional_cost.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_additional_cost.Location = new System.Drawing.Point(273, 123);
            this.btn_additional_cost.Name = "btn_additional_cost";
            this.btn_additional_cost.Size = new System.Drawing.Size(109, 24);
            this.btn_additional_cost.TabIndex = 58;
            this.btn_additional_cost.Text = "Additional Costs";
            this.btn_additional_cost.UseVisualStyleBackColor = false;
            this.btn_additional_cost.Click += new System.EventHandler(this.btn_additional_cost_Click);
            // 
            // btn_quote_details
            // 
            this.btn_quote_details.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_quote_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quote_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quote_details.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_quote_details.Location = new System.Drawing.Point(178, 123);
            this.btn_quote_details.Name = "btn_quote_details";
            this.btn_quote_details.Size = new System.Drawing.Size(95, 24);
            this.btn_quote_details.TabIndex = 57;
            this.btn_quote_details.Text = "Quote Details";
            this.btn_quote_details.UseVisualStyleBackColor = false;
            this.btn_quote_details.Click += new System.EventHandler(this.btn_quote_details_Click);
            // 
            // main_tab_project_additions
            // 
            this.main_tab_project_additions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.main_tab_project_additions.Controls.Add(this.tab_quote_details);
            this.main_tab_project_additions.Controls.Add(this.tab_additonal_cost);
            this.main_tab_project_additions.Controls.Add(this.tab_notes);
            this.main_tab_project_additions.Enabled = false;
            this.main_tab_project_additions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_tab_project_additions.Location = new System.Drawing.Point(175, 117);
            this.main_tab_project_additions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.main_tab_project_additions.Name = "main_tab_project_additions";
            this.main_tab_project_additions.SelectedIndex = 0;
            this.main_tab_project_additions.Size = new System.Drawing.Size(279, 420);
            this.main_tab_project_additions.TabIndex = 59;
            // 
            // tab_quote_details
            // 
            this.tab_quote_details.Controls.Add(this.txt_project_ref);
            this.tab_quote_details.Controls.Add(this.label4);
            this.tab_quote_details.Controls.Add(this.label3);
            this.tab_quote_details.Controls.Add(this.txt_quote_status);
            this.tab_quote_details.Controls.Add(this.cmb_quote_status);
            this.tab_quote_details.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tab_quote_details.Location = new System.Drawing.Point(4, 24);
            this.tab_quote_details.Name = "tab_quote_details";
            this.tab_quote_details.Padding = new System.Windows.Forms.Padding(3);
            this.tab_quote_details.Size = new System.Drawing.Size(271, 392);
            this.tab_quote_details.TabIndex = 0;
            this.tab_quote_details.Text = "Quote Details";
            this.tab_quote_details.UseVisualStyleBackColor = true;
            // 
            // txt_project_ref
            // 
            this.txt_project_ref.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dTQuoteItemsBindingSource, "project_ref", true));
            this.txt_project_ref.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_project_ref.Location = new System.Drawing.Point(33, 66);
            this.txt_project_ref.Name = "txt_project_ref";
            this.txt_project_ref.Size = new System.Drawing.Size(181, 21);
            this.txt_project_ref.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(34, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Quote Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(33, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Project Reference:";
            // 
            // txt_quote_status
            // 
            this.txt_quote_status.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dTQuoteItemsBindingSource, "quote_status", true));
            this.txt_quote_status.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_quote_status.Location = new System.Drawing.Point(33, 140);
            this.txt_quote_status.Name = "txt_quote_status";
            this.txt_quote_status.Size = new System.Drawing.Size(181, 21);
            this.txt_quote_status.TabIndex = 41;
            // 
            // cmb_quote_status
            // 
            this.cmb_quote_status.DataSource = this.cViewStatusBindingSource;
            this.cmb_quote_status.DisplayMember = "description";
            this.cmb_quote_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_quote_status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_quote_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_quote_status.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmb_quote_status.FormattingEnabled = true;
            this.cmb_quote_status.Location = new System.Drawing.Point(34, 140);
            this.cmb_quote_status.Name = "cmb_quote_status";
            this.cmb_quote_status.Size = new System.Drawing.Size(181, 21);
            this.cmb_quote_status.TabIndex = 42;
            this.cmb_quote_status.ValueMember = "description";
            // 
            // cViewStatusBindingSource
            // 
            this.cViewStatusBindingSource.DataMember = "C_View_Status";
            this.cViewStatusBindingSource.DataSource = this.dT_Status;
            // 
            // dT_Status
            // 
            this.dT_Status.DataSetName = "DT_Status";
            this.dT_Status.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_additonal_cost
            // 
            this.tab_additonal_cost.Controls.Add(this.label2);
            this.tab_additonal_cost.Controls.Add(this.txt_installation);
            this.tab_additonal_cost.Controls.Add(this.txt_delivery_charge);
            this.tab_additonal_cost.Controls.Add(this.label5);
            this.tab_additonal_cost.Controls.Add(this.txt_survery_charge);
            this.tab_additonal_cost.Controls.Add(this.label1);
            this.tab_additonal_cost.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tab_additonal_cost.Location = new System.Drawing.Point(4, 24);
            this.tab_additonal_cost.Name = "tab_additonal_cost";
            this.tab_additonal_cost.Padding = new System.Windows.Forms.Padding(3);
            this.tab_additonal_cost.Size = new System.Drawing.Size(271, 392);
            this.tab_additonal_cost.TabIndex = 1;
            this.tab_additonal_cost.Text = "Additional Cost";
            this.tab_additonal_cost.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(34, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Installation Charge:";
            // 
            // txt_installation
            // 
            this.txt_installation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dTQuoteItemsBindingSource, "installation_cost", true));
            this.txt_installation.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_installation.Location = new System.Drawing.Point(33, 200);
            this.txt_installation.Name = "txt_installation";
            this.txt_installation.Size = new System.Drawing.Size(206, 21);
            this.txt_installation.TabIndex = 44;
            this.txt_installation.Text = "0";
            this.txt_installation.Enter += new System.EventHandler(this.txt_installation_Enter);
            this.txt_installation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_installation_KeyDown);
            this.txt_installation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_installation_KeyPress);
            // 
            // txt_delivery_charge
            // 
            this.txt_delivery_charge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dTQuoteItemsBindingSource, "delivery_cost", true));
            this.txt_delivery_charge.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_delivery_charge.Location = new System.Drawing.Point(33, 124);
            this.txt_delivery_charge.Name = "txt_delivery_charge";
            this.txt_delivery_charge.Size = new System.Drawing.Size(206, 21);
            this.txt_delivery_charge.TabIndex = 43;
            this.txt_delivery_charge.Text = "0";
            this.txt_delivery_charge.Enter += new System.EventHandler(this.txt_delivery_charge_Enter);
            this.txt_delivery_charge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_delivery_charge_KeyDown);
            this.txt_delivery_charge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_delivery_charge_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(34, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Survey Charge:";
            // 
            // txt_survery_charge
            // 
            this.txt_survery_charge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dTQuoteItemsBindingSource, "survey_cost", true));
            this.txt_survery_charge.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_survery_charge.Location = new System.Drawing.Point(33, 61);
            this.txt_survery_charge.Name = "txt_survery_charge";
            this.txt_survery_charge.Size = new System.Drawing.Size(206, 21);
            this.txt_survery_charge.TabIndex = 42;
            this.txt_survery_charge.Text = "0";
            this.txt_survery_charge.Enter += new System.EventHandler(this.txt_survery_charge_Enter);
            this.txt_survery_charge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_survery_charge_KeyDown);
            this.txt_survery_charge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_survery_charge_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(34, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Delivery Charge:";
            // 
            // tab_notes
            // 
            this.tab_notes.Controls.Add(this.label7);
            this.tab_notes.Controls.Add(this.txt_notes);
            this.tab_notes.Location = new System.Drawing.Point(4, 24);
            this.tab_notes.Name = "tab_notes";
            this.tab_notes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_notes.Size = new System.Drawing.Size(271, 392);
            this.tab_notes.TabIndex = 2;
            this.tab_notes.Text = "Notes";
            this.tab_notes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(33, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Project Notes:";
            // 
            // txt_notes
            // 
            this.txt_notes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dTQuoteItemsBindingSource, "project_notes", true));
            this.txt_notes.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_notes.Location = new System.Drawing.Point(32, 61);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(206, 164);
            this.txt_notes.TabIndex = 42;
            // 
            // ada_setting
            // 
            this.ada_setting.ClearBeforeFill = true;
            // 
            // dT_Settings
            // 
            this.dT_Settings.DataSetName = "DT_Settings";
            this.dT_Settings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c_View_StatusTableAdapter
            // 
            this.c_View_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // Item_id
            // 
            this.Item_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_id.DataPropertyName = "Item ID";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            this.Item_id.DefaultCellStyle = dataGridViewCellStyle6;
            this.Item_id.FillWeight = 58.38951F;
            this.Item_id.HeaderText = "Item ID";
            this.Item_id.Name = "Item_id";
            // 
            // revision_number
            // 
            this.revision_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.revision_number.DataPropertyName = "Revision Number";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            this.revision_number.DefaultCellStyle = dataGridViewCellStyle7;
            this.revision_number.FillWeight = 60.83147F;
            this.revision_number.HeaderText = "Revision Number";
            this.revision_number.Name = "revision_number";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "Item Date";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            this.dateCreatedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.dateCreatedDataGridViewTextBoxColumn.FillWeight = 88.38951F;
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Created";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "Created By";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            this.createdByDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.createdByDataGridViewTextBoxColumn.FillWeight = 88.38951F;
            this.createdByDataGridViewTextBoxColumn.HeaderText = "Created By";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            // 
            // sALES_LEDGERTableAdapter
            // 
            this.sALES_LEDGERTableAdapter.ClearBeforeFill = true;
            // 
            // ada_quote_items
            // 
            this.ada_quote_items.ClearBeforeFill = true;
            // 
            // FrmQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1272, 557);
            this.Controls.Add(this.btn_quote_details);
            this.Controls.Add(this.btn_notes);
            this.Controls.Add(this.btn_additional_cost);
            this.Controls.Add(this.main_tab_project_additions);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maintab_doors_on_quote);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmQuote_FormClosed);
            this.Shown += new System.EventHandler(this.FrmQuote_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.maintab_doors_on_quote.ResumeLayout(false);
            this.tab_door_on_quote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_items_on_quote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTQuoteItemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Quote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTQuoteItemsBindingSource)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sALESLEDGERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.main_tab_project_additions.ResumeLayout(false);
            this.tab_quote_details.ResumeLayout(false);
            this.tab_quote_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cViewStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Status)).EndInit();
            this.tab_additonal_cost.ResumeLayout(false);
            this.tab_additonal_cost.PerformLayout();
            this.tab_notes.ResumeLayout(false);
            this.tab_notes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Settings)).EndInit();
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
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_email_project;
        private System.Windows.Forms.Label lbl_quote_id;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_new_item;
        private System.Windows.Forms.Button btn_print_project;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.DataGridView grid_items_on_quote;
        private System.Windows.Forms.Button btn_notes;
        private System.Windows.Forms.Button btn_additional_cost;
        private System.Windows.Forms.Button btn_quote_details;
        private System.Windows.Forms.TabControl main_tab_project_additions;
        private System.Windows.Forms.TabPage tab_quote_details;
        private System.Windows.Forms.ComboBox cmb_quote_status;
        private System.Windows.Forms.TextBox txt_project_ref;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tab_additonal_cost;
        private System.Windows.Forms.TextBox txt_delivery_charge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_survery_charge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.TextBox txt_project;
        private Datasource.DT_SettingsTableAdapters.ada_setting ada_setting;
        private Datasource.DT_Settings dT_Settings;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_quote_status;
        private Datasource.DT_Status dT_Status;
        private System.Windows.Forms.BindingSource cViewStatusBindingSource;
        private Datasource.DT_StatusTableAdapters.C_View_StatusTableAdapter c_View_StatusTableAdapter;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn revision_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource sALESLEDGERBindingSource;
        private Datasource.DT_customer dT_customer;
        private Datasource.DT_customerTableAdapters.SALES_LEDGERTableAdapter sALES_LEDGERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn revision_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private Datasource.DT_QuoteTableAdapters.ada_quote_items c_View_Project_QuotationTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_installation;
        private System.Windows.Forms.BindingSource dTQuoteItemsBindingSource;
        private Datasource.DT_Quote dT_Quote;
        private Datasource.DT_QuoteTableAdapters.ada_quote_items ada_quote_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn quote_id;
        private System.Windows.Forms.BindingSource dTQuoteItemsBindingSource1;
        private System.Windows.Forms.Button btn_view_original;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_created;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn btn_view;
        private System.Windows.Forms.DataGridViewImageColumn btn_copy;
        private System.Windows.Forms.DataGridViewImageColumn btn_delete_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Identity;
    }
}