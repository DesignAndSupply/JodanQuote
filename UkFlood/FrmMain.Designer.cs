namespace UkFlood
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
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.grid_quote_list = new System.Windows.Forms.DataGridView();
            this.btn_open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_quote_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
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
            // pct_logo
            // 
            this.pct_logo.Image = global::UkFlood.Properties.Resources.Logo;
            this.pct_logo.Location = new System.Drawing.Point(22, 22);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(123, 50);
            this.pct_logo.TabIndex = 14;
            this.pct_logo.TabStop = false;
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
            this.grid_quote_list.Location = new System.Drawing.Point(283, 165);
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
            this.grid_quote_list.Size = new System.Drawing.Size(645, 323);
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 559);
            this.Controls.Add(this.grid_quote_list);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_quote_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.DataGridView grid_quote_list;
        private System.Windows.Forms.DataGridViewButtonColumn btn_open;
    }
}

