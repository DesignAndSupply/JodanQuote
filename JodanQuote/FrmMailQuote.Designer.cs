namespace JodanQuote
{
    partial class FrmMailQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMailQuote));
            this.grid_email_recipients = new System.Windows.Forms.DataGridView();
            this.chk_recipient = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_email_recipients)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_email_recipients
            // 
            this.grid_email_recipients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_email_recipients.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_email_recipients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_email_recipients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_email_recipients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_email_recipients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk_recipient});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_email_recipients.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_email_recipients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_email_recipients.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_email_recipients.Location = new System.Drawing.Point(56, 37);
            this.grid_email_recipients.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_email_recipients.Name = "grid_email_recipients";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_email_recipients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_email_recipients.RowHeadersVisible = false;
            this.grid_email_recipients.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_email_recipients.Size = new System.Drawing.Size(519, 266);
            this.grid_email_recipients.TabIndex = 25;
            this.grid_email_recipients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_email_recipients_CellContentClick);
            // 
            // chk_recipient
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = false;
            this.chk_recipient.DefaultCellStyle = dataGridViewCellStyle2;
            this.chk_recipient.FalseValue = "0";
            this.chk_recipient.HeaderText = "Select Recipient";
            this.chk_recipient.Name = "chk_recipient";
            this.chk_recipient.TrueValue = "1";
            this.chk_recipient.Width = 115;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_send.Image = global::JodanQuote.Properties.Resources.Email;
            this.btn_send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_send.Location = new System.Drawing.Point(528, 329);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(77, 39);
            this.btn_send.TabIndex = 43;
            this.btn_send.Text = "        Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // FrmMailQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(659, 405);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.grid_email_recipients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMailQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Recipients";
            ((System.ComponentModel.ISupportInitialize)(this.grid_email_recipients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_email_recipients;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_recipient;
        private System.Windows.Forms.Button btn_send;
    }
}