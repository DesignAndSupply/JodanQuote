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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_quote_list = new System.Windows.Forms.DataGridView();
            this.btn_open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_quote_id = new System.Windows.Forms.TextBox();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.pct_clear = new System.Windows.Forms.PictureBox();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.btn_new_project = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_quote_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btn_new_project);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1927, 100);
            this.panel1.TabIndex = 11;
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
            // grid_quote_list
            // 
            this.grid_quote_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_quote_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_quote_list.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_quote_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_quote_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_quote_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_quote_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_open});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_quote_list.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_quote_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_quote_list.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_quote_list.Location = new System.Drawing.Point(261, 165);
            this.grid_quote_list.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.grid_quote_list.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_quote_list.Size = new System.Drawing.Size(655, 323);
            this.grid_quote_list.TabIndex = 22;
            this.grid_quote_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_quote_list_CellContentClick);
            // 
            // btn_open
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.NullValue = "Open";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
            this.btn_open.DefaultCellStyle = dataGridViewCellStyle2;
            this.btn_open.FillWeight = 50F;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_open.HeaderText = "";
            this.btn_open.MinimumWidth = 50;
            this.btn_open.Name = "btn_open";
            this.btn_open.Width = 52;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_description.Location = new System.Drawing.Point(364, 118);
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
            this.lbl_id.Location = new System.Drawing.Point(262, 118);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(67, 15);
            this.lbl_id.TabIndex = 38;
            this.lbl_id.Text = "Quote ID:";
            // 
            // txt_quote_id
            // 
            this.txt_quote_id.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_quote_id.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_quote_id.Location = new System.Drawing.Point(263, 135);
            this.txt_quote_id.Name = "txt_quote_id";
            this.txt_quote_id.Size = new System.Drawing.Size(68, 20);
            this.txt_quote_id.TabIndex = 37;
            this.txt_quote_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_quote_id_KeyDown);
            // 
            // txt_customer
            // 
            this.txt_customer.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_customer.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_customer.Location = new System.Drawing.Point(360, 135);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(178, 20);
            this.txt_customer.TabIndex = 36;
            this.txt_customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_customer_KeyDown);
            // 
            // pct_clear
            // 
            this.pct_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_clear.Image = global::JodanQuote.Properties.Resources.clear;
            this.pct_clear.Location = new System.Drawing.Point(545, 134);
            this.pct_clear.Name = "pct_clear";
            this.pct_clear.Size = new System.Drawing.Size(26, 20);
            this.pct_clear.TabIndex = 40;
            this.pct_clear.TabStop = false;
            this.pct_clear.Click += new System.EventHandler(this.pct_clear_Click);
            // 
            // pct_logo
            // 
            this.pct_logo.Image = global::JodanQuote.Properties.Resources.Jodan;
            this.pct_logo.Location = new System.Drawing.Point(12, 12);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(151, 86);
            this.pct_logo.TabIndex = 16;
            this.pct_logo.TabStop = false;
            // 
            // btn_new_project
            // 
            this.btn_new_project.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_new_project.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_new_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_project.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_new_project.Image = global::JodanQuote.Properties.Resources.NewRecord;
            this.btn_new_project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new_project.Location = new System.Drawing.Point(896, 31);
            this.btn_new_project.Name = "btn_new_project";
            this.btn_new_project.Size = new System.Drawing.Size(115, 42);
            this.btn_new_project.TabIndex = 0;
            this.btn_new_project.Text = "New Project";
            this.btn_new_project.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new_project.UseVisualStyleBackColor = false;
            this.btn_new_project.Click += new System.EventHandler(this.btn_new_project_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1031, 559);
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
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_quote_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grid_quote_list;
        private System.Windows.Forms.DataGridViewButtonColumn btn_open;
        private System.Windows.Forms.Button btn_new_project;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_quote_id;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.PictureBox pct_clear;
    }
}

