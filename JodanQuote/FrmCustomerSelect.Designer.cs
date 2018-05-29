namespace JodanQuote
{
    partial class FrmCustomerSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerSelect));
            this.cmb_customers = new System.Windows.Forms.ComboBox();
            this.btn_complete = new System.Windows.Forms.Button();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_customers
            // 
            this.cmb_customers.BackColor = System.Drawing.Color.AliceBlue;
            this.cmb_customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_customers.DropDownHeight = 60;
            this.cmb_customers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_customers.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmb_customers.FormattingEnabled = true;
            this.cmb_customers.IntegralHeight = false;
            this.cmb_customers.ItemHeight = 15;
            this.cmb_customers.Location = new System.Drawing.Point(118, 103);
            this.cmb_customers.MaxDropDownItems = 5;
            this.cmb_customers.Name = "cmb_customers";
            this.cmb_customers.Size = new System.Drawing.Size(206, 23);
            this.cmb_customers.TabIndex = 8;
            // 
            // btn_complete
            // 
            this.btn_complete.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_complete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_complete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_complete.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_complete.Image = global::JodanQuote.Properties.Resources.tick2;
            this.btn_complete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_complete.Location = new System.Drawing.Point(311, 193);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(95, 38);
            this.btn_complete.TabIndex = 30;
            this.btn_complete.Text = "    Complete";
            this.btn_complete.UseVisualStyleBackColor = false;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_customer.Location = new System.Drawing.Point(108, 9);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(223, 31);
            this.lbl_customer.TabIndex = 39;
            this.lbl_customer.Text = "Select Customer:";
            // 
            // FrmCustomerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.cmb_customers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomerSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_customers;
        private System.Windows.Forms.Button btn_complete;
        private System.Windows.Forms.Label lbl_customer;
    }
}