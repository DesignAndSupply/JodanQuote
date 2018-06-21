namespace JodanQuote
{
    partial class FrmDimensions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDimensions));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_structual_height = new System.Windows.Forms.TextBox();
            this.txt_structual_width = new System.Windows.Forms.TextBox();
            this.chk_panel = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_complete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(77, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Structual Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(77, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Structual Width:";
            // 
            // txt_structual_height
            // 
            this.txt_structual_height.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_structual_height.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_structual_height.Location = new System.Drawing.Point(218, 125);
            this.txt_structual_height.Name = "txt_structual_height";
            this.txt_structual_height.Size = new System.Drawing.Size(130, 20);
            this.txt_structual_height.TabIndex = 2;
            // 
            // txt_structual_width
            // 
            this.txt_structual_width.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_structual_width.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_structual_width.Location = new System.Drawing.Point(218, 96);
            this.txt_structual_width.Name = "txt_structual_width";
            this.txt_structual_width.Size = new System.Drawing.Size(130, 20);
            this.txt_structual_width.TabIndex = 1;
            // 
            // chk_panel
            // 
            this.chk_panel.AutoSize = true;
            this.chk_panel.Location = new System.Drawing.Point(218, 158);
            this.chk_panel.Name = "chk_panel";
            this.chk_panel.Size = new System.Drawing.Size(15, 14);
            this.chk_panel.TabIndex = 60;
            this.chk_panel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(77, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "With Overpanel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(89, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 39);
            this.label2.TabIndex = 62;
            this.label2.Text = "Maximum single size: 1408mm x 3000mm\r\nMaximum double size: 2800mm x 3000mm\r\nMax p" +
    "anel size: 2800mm x 1300mm\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(119, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 24);
            this.label3.TabIndex = 63;
            this.label3.Text = "Enter Dimensions:";
            // 
            // btn_complete
            // 
            this.btn_complete.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_complete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_complete.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_complete.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_complete.Image = global::JodanQuote.Properties.Resources.tick2;
            this.btn_complete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_complete.Location = new System.Drawing.Point(345, 186);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(86, 43);
            this.btn_complete.TabIndex = 67;
            this.btn_complete.Text = "     Enter         Dimensions";
            this.btn_complete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_complete.UseVisualStyleBackColor = false;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // FrmDimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(443, 241);
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_panel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_structual_height);
            this.Controls.Add(this.txt_structual_width);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDimensions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dimensions";
         //   this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDimensions_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_structual_height;
        private System.Windows.Forms.TextBox txt_structual_width;
        private System.Windows.Forms.CheckBox chk_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_complete;
    }
}