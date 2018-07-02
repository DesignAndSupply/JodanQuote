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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuote));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maintab_doors_on_quote = new System.Windows.Forms.TabControl();
            this.tab_door_on_quote = new System.Windows.Forms.TabPage();
            this.grid_items_on_quote = new System.Windows.Forms.DataGridView();
            this.dTQuoteItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dt_quote = new JodanQuote.Datasource.dt_quote();
            this.pnl_header = new System.Windows.Forms.Panel();
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
            this.cmb_quote_status = new System.Windows.Forms.ComboBox();
            this.cViewStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_Status = new JodanQuote.Datasource.DT_Status();
            this.txt_project_ref = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quote_status = new System.Windows.Forms.TextBox();
            this.tab_additonal_cost = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_notes = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ada_setting = new JodanQuote.Datasource.DT_SettingsTableAdapters.ada_setting();
            this.dT_Settings = new JodanQuote.Datasource.DT_Settings();
            this.ada_quote = new JodanQuote.Datasource.dt_quoteTableAdapters.ada_quote();
            this.c_View_StatusTableAdapter = new JodanQuote.Datasource.DT_StatusTableAdapters.C_View_StatusTableAdapter();
            this.sALES_LEDGERTableAdapter = new JodanQuote.Datasource.DT_customerTableAdapters.SALES_LEDGERTableAdapter();
            this.Item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revision_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revision_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_view = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_copy = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_delete_item = new System.Windows.Forms.DataGridViewImageColumn();
            this.quoteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.maintab_doors_on_quote.SuspendLayout();
            this.tab_door_on_quote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_items_on_quote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTQuoteItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_quote)).BeginInit();
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
            this.label6.Location = new System.Drawing.Point(490, 134);
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
            this.maintab_doors_on_quote.Location = new System.Drawing.Point(481, 128);
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
            this.Item,
            this.revision_id,
            this.itemDateDataGridViewTextBoxColumn,
            this.created_by,
            this.totalCostDataGridViewTextBoxColumn,
            this.btn_view,
            this.btn_copy,
            this.btn_delete_item,
            this.quoteIDDataGridViewTextBoxColumn});
            this.grid_items_on_quote.DataSource = this.dTQuoteItemsBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_items_on_quote.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_items_on_quote.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_items_on_quote.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_items_on_quote.Location = new System.Drawing.Point(19, 65);
            this.grid_items_on_quote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_items_on_quote.Name = "grid_items_on_quote";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_items_on_quote.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_items_on_quote.RowHeadersVisible = false;
            this.grid_items_on_quote.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_items_on_quote.Size = new System.Drawing.Size(672, 237);
            this.grid_items_on_quote.TabIndex = 24;
            this.grid_items_on_quote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_items_on_quote_CellContentClick);
            // 
            // dTQuoteItemsBindingSource
            // 
            this.dTQuoteItemsBindingSource.DataMember = "DT_Quote_Items";
            this.dTQuoteItemsBindingSource.DataSource = this.dt_quote;
            // 
            // dt_quote
            // 
            this.dt_quote.DataSetName = "dt_quote";
            this.dt_quote.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.CornflowerBlue;
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
            // btn_convert
            // 
            this.btn_convert.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_convert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_convert.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_convert.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_convert.Image = global::JodanQuote.Properties.Resources.Convert;
            this.btn_convert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_convert.Location = new System.Drawing.Point(615, 28);
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
            this.btn_edit.Image = global::JodanQuote.Properties.Resources.Revise;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(915, 28);
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
            this.txt_project.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dTQuoteItemsBindingSource, "Project ID", true));
            this.txt_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_project.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt_project.Location = new System.Drawing.Point(385, 25);
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
            this.txt_customer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sALESLEDGERBindingSource, "NAME", true));
            this.txt_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt_customer.Location = new System.Drawing.Point(386, 56);
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
            this.lbl_customer.Location = new System.Drawing.Point(216, 53);
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
            this.btn_email_project.Image = global::JodanQuote.Properties.Resources.Email;
            this.btn_email_project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_email_project.Location = new System.Drawing.Point(717, 28);
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
            this.lbl_quote_id.Location = new System.Drawing.Point(211, 20);
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
            this.btn_back.Image = global::JodanQuote.Properties.Resources.ReturnArrow;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(1117, 28);
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
            this.btn_new_item.Image = global::JodanQuote.Properties.Resources.NewRecord;
            this.btn_new_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new_item.Location = new System.Drawing.Point(1017, 28);
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
            this.btn_print_project.Image = global::JodanQuote.Properties.Resources.Print_Small;
            this.btn_print_project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print_project.Location = new System.Drawing.Point(817, 28);
            this.btn_print_project.Name = "btn_print_project";
            this.btn_print_project.Size = new System.Drawing.Size(98, 37);
            this.btn_print_project.TabIndex = 39;
            this.btn_print_project.Text = "            Print                  Quotation";
            this.btn_print_project.UseVisualStyleBackColor = false;
            this.btn_print_project.Click += new System.EventHandler(this.btn_print_project_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JodanQuote.Properties.Resources.Jodan;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 86);
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
            this.tab_quote_details.Controls.Add(this.cmb_quote_status);
            this.tab_quote_details.Controls.Add(this.txt_project_ref);
            this.tab_quote_details.Controls.Add(this.label4);
            this.tab_quote_details.Controls.Add(this.label3);
            this.tab_quote_details.Controls.Add(this.txt_quote_status);
            this.tab_quote_details.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tab_quote_details.Location = new System.Drawing.Point(4, 24);
            this.tab_quote_details.Name = "tab_quote_details";
            this.tab_quote_details.Padding = new System.Windows.Forms.Padding(3);
            this.tab_quote_details.Size = new System.Drawing.Size(271, 392);
            this.tab_quote_details.TabIndex = 0;
            this.tab_quote_details.Text = "Quote Details";
            this.tab_quote_details.UseVisualStyleBackColor = true;
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
            // txt_project_ref
            // 
            this.txt_project_ref.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_project_ref.Location = new System.Drawing.Point(33, 66);
            this.txt_project_ref.Name = "txt_project_ref";
            this.txt_project_ref.Size = new System.Drawing.Size(181, 21);
            this.txt_project_ref.TabIndex = 41;
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
            this.txt_quote_status.TabIndex = 44;
            // 
            // tab_additonal_cost
            // 
            this.tab_additonal_cost.Controls.Add(this.textBox3);
            this.tab_additonal_cost.Controls.Add(this.label5);
            this.tab_additonal_cost.Controls.Add(this.textBox4);
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
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBox3.Location = new System.Drawing.Point(33, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 21);
            this.textBox3.TabIndex = 45;
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
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBox4.Location = new System.Drawing.Point(33, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 21);
            this.textBox4.TabIndex = 42;
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
            this.tab_notes.Controls.Add(this.textBox6);
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
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Quotation Notes:";
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBox6.Location = new System.Drawing.Point(32, 61);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(206, 164);
            this.textBox6.TabIndex = 42;
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
            // ada_quote
            // 
            this.ada_quote.ClearBeforeFill = true;
            // 
            // c_View_StatusTableAdapter
            // 
            this.c_View_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // sALES_LEDGERTableAdapter
            // 
            this.sALES_LEDGERTableAdapter.ClearBeforeFill = true;
            // 
            // Item_id
            // 
            this.Item_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_id.DataPropertyName = "Item ID";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            this.Item_id.DefaultCellStyle = dataGridViewCellStyle8;
            this.Item_id.FillWeight = 58.38951F;
            this.Item_id.HeaderText = "Item ID";
            this.Item_id.Name = "Item_id";
            // 
            // revision_number
            // 
            this.revision_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.revision_number.DataPropertyName = "Revision Number";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            this.revision_number.DefaultCellStyle = dataGridViewCellStyle9;
            this.revision_number.FillWeight = 60.83147F;
            this.revision_number.HeaderText = "Revision Number";
            this.revision_number.Name = "revision_number";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "Item Date";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            this.dateCreatedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.dateCreatedDataGridViewTextBoxColumn.FillWeight = 88.38951F;
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Created";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "Created By";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            this.createdByDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.createdByDataGridViewTextBoxColumn.FillWeight = 88.38951F;
            this.createdByDataGridViewTextBoxColumn.HeaderText = "Created By";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.DataPropertyName = "Item ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Item.DefaultCellStyle = dataGridViewCellStyle2;
            this.Item.FillWeight = 20F;
            this.Item.HeaderText = "Item Number";
            this.Item.Name = "Item";
            // 
            // revision_id
            // 
            this.revision_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.revision_id.DataPropertyName = "Revision Number";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.revision_id.DefaultCellStyle = dataGridViewCellStyle3;
            this.revision_id.FillWeight = 20F;
            this.revision_id.HeaderText = "Revision Number";
            this.revision_id.Name = "revision_id";
            // 
            // itemDateDataGridViewTextBoxColumn
            // 
            this.itemDateDataGridViewTextBoxColumn.DataPropertyName = "Item Date";
            this.itemDateDataGridViewTextBoxColumn.HeaderText = "Item Date";
            this.itemDateDataGridViewTextBoxColumn.Name = "itemDateDataGridViewTextBoxColumn";
            this.itemDateDataGridViewTextBoxColumn.Width = 102;
            // 
            // created_by
            // 
            this.created_by.DataPropertyName = "Created By";
            this.created_by.HeaderText = "Created By";
            this.created_by.Name = "created_by";
            this.created_by.Width = 114;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "Total Cost";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.totalCostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalCostDataGridViewTextBoxColumn.FillWeight = 25F;
            this.totalCostDataGridViewTextBoxColumn.HeaderText = " Total Cost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // btn_view
            // 
            this.btn_view.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.NullValue = "Open";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.AliceBlue;
            this.btn_view.DefaultCellStyle = dataGridViewCellStyle5;
            this.btn_view.FillWeight = 15F;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.HeaderText = "";
            this.btn_view.Name = "btn_view";
            this.btn_view.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btn_copy
            // 
            this.btn_copy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_copy.FillWeight = 10F;
            this.btn_copy.HeaderText = "";
            this.btn_copy.Image = global::JodanQuote.Properties.Resources.Copy_small_;
            this.btn_copy.Name = "btn_copy";
            // 
            // btn_delete_item
            // 
            this.btn_delete_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_delete_item.FillWeight = 10F;
            this.btn_delete_item.HeaderText = "";
            this.btn_delete_item.Image = global::JodanQuote.Properties.Resources.clear;
            this.btn_delete_item.Name = "btn_delete_item";
            // 
            // quoteIDDataGridViewTextBoxColumn
            // 
            this.quoteIDDataGridViewTextBoxColumn.DataPropertyName = "Quote ID";
            this.quoteIDDataGridViewTextBoxColumn.HeaderText = "Quote ID";
            this.quoteIDDataGridViewTextBoxColumn.Name = "quoteIDDataGridViewTextBoxColumn";
            this.quoteIDDataGridViewTextBoxColumn.Visible = false;
            this.quoteIDDataGridViewTextBoxColumn.Width = 89;
            // 
            // FrmQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 557);
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
            ((System.ComponentModel.ISupportInitialize)(this.dTQuoteItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_quote)).EndInit();
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txt_project;
        private Datasource.DT_SettingsTableAdapters.ada_setting ada_setting;
        private Datasource.DT_Settings dT_Settings;
        private System.Windows.Forms.BindingSource dTQuoteItemsBindingSource;
        private Datasource.dt_quote dt_quote;
        private Datasource.dt_quoteTableAdapters.ada_quote ada_quote;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_quote_status;
        private Datasource.DT_Status dT_Status;
        private System.Windows.Forms.BindingSource cViewStatusBindingSource;
        private Datasource.DT_StatusTableAdapters.C_View_StatusTableAdapter c_View_StatusTableAdapter;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.BindingSource sALESLEDGERBindingSource;
        private Datasource.DT_customer dT_customer;
        private Datasource.DT_customerTableAdapters.SALES_LEDGERTableAdapter sALES_LEDGERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn revision_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn revision_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btn_view;
        private System.Windows.Forms.DataGridViewImageColumn btn_copy;
        private System.Windows.Forms.DataGridViewImageColumn btn_delete_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteIDDataGridViewTextBoxColumn;
    }
}