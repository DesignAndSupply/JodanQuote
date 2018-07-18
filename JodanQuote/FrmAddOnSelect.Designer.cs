namespace JodanQuote
{
    partial class FrmAddOnSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOnSelect));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add_on = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.cmb_material_thickness_edit = new System.Windows.Forms.ComboBox();
            this.dTMaterialThicknessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_Material_Thickness = new JodanQuote.Datasource.DT_Material_Thickness();
            this.cmb_material_edit = new System.Windows.Forms.ComboBox();
            this.dTmaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_Material = new JodanQuote.Datasource.DT_Material();
            this.chk_removable = new System.Windows.Forms.CheckBox();
            this.cViewAddonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_Item_Add_On = new JodanQuote.Datasource.DT_Item_Add_On();
            this.chk_coating = new System.Windows.Forms.CheckBox();
            this.ada_materials = new JodanQuote.Datasource.DT_MaterialTableAdapters.ada_materials();
            this.ada_material_thickness = new JodanQuote.Datasource.DT_Material_ThicknessTableAdapters.Ada_material_thickness();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_add_on_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_addon_material_type = new System.Windows.Forms.ComboBox();
            this.cViewAddOnMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_View_Add_On_MaterialTableAdapter = new JodanQuote.Datasource.DT_Item_Add_OnTableAdapters.C_View_Add_On_MaterialTableAdapter();
            this.c_View_AddonsTableAdapter = new JodanQuote.Datasource.DT_Item_Add_OnTableAdapters.C_View_AddonsTableAdapter();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.btn_structure_width = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dTMaterialThicknessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Material_Thickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTmaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cViewAddonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Item_Add_On)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cViewAddOnMaterialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_back.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_back.Image = global::JodanQuote.Properties.Resources.ReturnArrow;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(454, 229);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 37);
            this.btn_back.TabIndex = 81;
            this.btn_back.Text = "    Back";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_clear.Image = global::JodanQuote.Properties.Resources.Bin;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(454, 272);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 37);
            this.btn_clear.TabIndex = 80;
            this.btn_clear.Text = "            Clear               Selection";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add_on
            // 
            this.btn_add_on.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_add_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_on.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_add_on.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_add_on.Image = global::JodanQuote.Properties.Resources.Save;
            this.btn_add_on.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_on.Location = new System.Drawing.Point(454, 315);
            this.btn_add_on.Name = "btn_add_on";
            this.btn_add_on.Size = new System.Drawing.Size(98, 37);
            this.btn_add_on.TabIndex = 79;
            this.btn_add_on.Text = "          Add Item";
            this.btn_add_on.UseVisualStyleBackColor = false;
            this.btn_add_on.Click += new System.EventHandler(this.btn_add_on_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(58, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Material Thickness:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.AliceBlue;
            this.label13.Location = new System.Drawing.Point(58, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 86;
            this.label13.Text = "Material:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(58, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 85;
            this.label8.Text = "Height:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(58, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Width:";
            // 
            // txt_height
            // 
            this.txt_height.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_height.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_height.Location = new System.Drawing.Point(201, 179);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(186, 20);
            this.txt_height.TabIndex = 6;
            this.txt_height.Text = "0";
            // 
            // txt_width
            // 
            this.txt_width.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_width.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_width.Location = new System.Drawing.Point(201, 149);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(186, 20);
            this.txt_width.TabIndex = 5;
            this.txt_width.Text = "0";
            // 
            // cmb_material_thickness_edit
            // 
            this.cmb_material_thickness_edit.DataSource = this.dTMaterialThicknessBindingSource;
            this.cmb_material_thickness_edit.DisplayMember = "thickness";
            this.cmb_material_thickness_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_material_thickness_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_material_thickness_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_material_thickness_edit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmb_material_thickness_edit.FormattingEnabled = true;
            this.cmb_material_thickness_edit.Location = new System.Drawing.Point(201, 118);
            this.cmb_material_thickness_edit.Name = "cmb_material_thickness_edit";
            this.cmb_material_thickness_edit.Size = new System.Drawing.Size(186, 21);
            this.cmb_material_thickness_edit.TabIndex = 4;
            this.cmb_material_thickness_edit.ValueMember = "thickness";
            // 
            // dTMaterialThicknessBindingSource
            // 
            this.dTMaterialThicknessBindingSource.DataMember = "DT_Material_Thickness";
            this.dTMaterialThicknessBindingSource.DataSource = this.dT_Material_Thickness;
            // 
            // dT_Material_Thickness
            // 
            this.dT_Material_Thickness.DataSetName = "DT_Material_Thickness";
            this.dT_Material_Thickness.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_material_edit
            // 
            this.cmb_material_edit.DataSource = this.dTmaterialsBindingSource;
            this.cmb_material_edit.DisplayMember = "description";
            this.cmb_material_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_material_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_material_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_material_edit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmb_material_edit.FormattingEnabled = true;
            this.cmb_material_edit.Location = new System.Drawing.Point(201, 87);
            this.cmb_material_edit.Name = "cmb_material_edit";
            this.cmb_material_edit.Size = new System.Drawing.Size(186, 21);
            this.cmb_material_edit.TabIndex = 3;
            this.cmb_material_edit.ValueMember = "id";
            this.cmb_material_edit.SelectedValueChanged += new System.EventHandler(this.cmb_material_edit_SelectedValueChanged);
            // 
            // dTmaterialsBindingSource
            // 
            this.dTmaterialsBindingSource.DataMember = "DT_materials";
            this.dTmaterialsBindingSource.DataSource = this.dT_Material;
            // 
            // dT_Material
            // 
            this.dT_Material.DataSetName = "DT_Material";
            this.dT_Material.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chk_removable
            // 
            this.chk_removable.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_removable.AutoSize = true;
            this.chk_removable.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cViewAddonsBindingSource, "can_be_removable", true));
            this.chk_removable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_removable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_removable.ForeColor = System.Drawing.Color.AliceBlue;
            this.chk_removable.Location = new System.Drawing.Point(201, 301);
            this.chk_removable.Name = "chk_removable";
            this.chk_removable.Size = new System.Drawing.Size(84, 23);
            this.chk_removable.TabIndex = 92;
            this.chk_removable.Text = "Removable:";
            this.chk_removable.UseVisualStyleBackColor = true;
            // 
            // cViewAddonsBindingSource
            // 
            this.cViewAddonsBindingSource.DataMember = "C_View_Addons";
            this.cViewAddonsBindingSource.DataSource = this.dT_Item_Add_On;
            // 
            // dT_Item_Add_On
            // 
            this.dT_Item_Add_On.DataSetName = "DT_Item_Add_On";
            this.dT_Item_Add_On.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chk_coating
            // 
            this.chk_coating.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_coating.AutoSize = true;
            this.chk_coating.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cViewAddonsBindingSource, "default_powder_coat_unit", true));
            this.chk_coating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_coating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_coating.ForeColor = System.Drawing.Color.AliceBlue;
            this.chk_coating.Location = new System.Drawing.Point(201, 269);
            this.chk_coating.Name = "chk_coating";
            this.chk_coating.Size = new System.Drawing.Size(106, 23);
            this.chk_coating.TabIndex = 93;
            this.chk_coating.Text = "Powder Coating";
            this.chk_coating.UseVisualStyleBackColor = true;
            // 
            // ada_materials
            // 
            this.ada_materials.ClearBeforeFill = true;
            // 
            // ada_material_thickness
            // 
            this.ada_material_thickness.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(58, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Add On Type:";
            // 
            // cmb_add_on_type
            // 
            this.cmb_add_on_type.DataSource = this.cViewAddonsBindingSource;
            this.cmb_add_on_type.DisplayMember = "description";
            this.cmb_add_on_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_add_on_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_add_on_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_add_on_type.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmb_add_on_type.FormattingEnabled = true;
            this.cmb_add_on_type.Location = new System.Drawing.Point(201, 56);
            this.cmb_add_on_type.Name = "cmb_add_on_type";
            this.cmb_add_on_type.Size = new System.Drawing.Size(186, 21);
            this.cmb_add_on_type.TabIndex = 2;
            this.cmb_add_on_type.ValueMember = "id";
            this.cmb_add_on_type.SelectedIndexChanged += new System.EventHandler(this.cmb_add_on_type_SelectedIndexChanged);
            this.cmb_add_on_type.SelectedValueChanged += new System.EventHandler(this.cmb_add_on_type_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(58, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "Add On Material Type:";
            // 
            // cmb_addon_material_type
            // 
            this.cmb_addon_material_type.DataSource = this.cViewAddOnMaterialBindingSource;
            this.cmb_addon_material_type.DisplayMember = "description";
            this.cmb_addon_material_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_addon_material_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_addon_material_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_addon_material_type.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmb_addon_material_type.FormattingEnabled = true;
            this.cmb_addon_material_type.Location = new System.Drawing.Point(201, 25);
            this.cmb_addon_material_type.Name = "cmb_addon_material_type";
            this.cmb_addon_material_type.Size = new System.Drawing.Size(186, 21);
            this.cmb_addon_material_type.TabIndex = 1;
            this.cmb_addon_material_type.ValueMember = "id";
            this.cmb_addon_material_type.SelectedValueChanged += new System.EventHandler(this.cmb_addon_material_type_SelectedValueChanged);
            // 
            // cViewAddOnMaterialBindingSource
            // 
            this.cViewAddOnMaterialBindingSource.DataMember = "C_View_Add_On_Material";
            this.cViewAddOnMaterialBindingSource.DataSource = this.dT_Item_Add_On;
            // 
            // c_View_Add_On_MaterialTableAdapter
            // 
            this.c_View_Add_On_MaterialTableAdapter.ClearBeforeFill = true;
            // 
            // c_View_AddonsTableAdapter
            // 
            this.c_View_AddonsTableAdapter.ClearBeforeFill = true;
            // 
            // txt_qty
            // 
            this.txt_qty.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_qty.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_qty.Location = new System.Drawing.Point(201, 209);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(186, 20);
            this.txt_qty.TabIndex = 7;
            this.txt_qty.Text = "0";
            // 
            // txt_position
            // 
            this.txt_position.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_position.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_position.Location = new System.Drawing.Point(201, 239);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(186, 20);
            this.txt_position.TabIndex = 8;
            // 
            // btn_structure_width
            // 
            this.btn_structure_width.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_structure_width.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_structure_width.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_structure_width.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_structure_width.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_structure_width.Location = new System.Drawing.Point(439, 148);
            this.btn_structure_width.Margin = new System.Windows.Forms.Padding(0);
            this.btn_structure_width.Name = "btn_structure_width";
            this.btn_structure_width.Size = new System.Drawing.Size(122, 27);
            this.btn_structure_width.TabIndex = 102;
            this.btn_structure_width.Text = "Use Structure Width";
            this.btn_structure_width.UseVisualStyleBackColor = false;
            this.btn_structure_width.Click += new System.EventHandler(this.btn_structure_width_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(58, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 104;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(58, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 103;
            this.label5.Text = "Quantity:";
            // 
            // FrmAddOnSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(569, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_structure_width);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_addon_material_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_add_on_type);
            this.Controls.Add(this.chk_coating);
            this.Controls.Add(this.chk_removable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_width);
            this.Controls.Add(this.cmb_material_edit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add_on);
            this.Controls.Add(this.cmb_material_thickness_edit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddOnSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addons";
            ((System.ComponentModel.ISupportInitialize)(this.dTMaterialThicknessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Material_Thickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTmaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cViewAddonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Item_Add_On)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cViewAddOnMaterialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add_on;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.ComboBox cmb_material_thickness_edit;
        private System.Windows.Forms.ComboBox cmb_material_edit;
        private System.Windows.Forms.CheckBox chk_removable;
        private System.Windows.Forms.CheckBox chk_coating;
        private Datasource.DT_Material dT_Material;
        private System.Windows.Forms.BindingSource dTmaterialsBindingSource;
        private Datasource.DT_MaterialTableAdapters.ada_materials ada_materials;
        private Datasource.DT_Material_Thickness dT_Material_Thickness;
        private System.Windows.Forms.BindingSource dTMaterialThicknessBindingSource;
        private Datasource.DT_Material_ThicknessTableAdapters.Ada_material_thickness ada_material_thickness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_add_on_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_addon_material_type;
        private Datasource.DT_Item_Add_On dT_Item_Add_On;
        private System.Windows.Forms.BindingSource cViewAddOnMaterialBindingSource;
        private Datasource.DT_Item_Add_OnTableAdapters.C_View_Add_On_MaterialTableAdapter c_View_Add_On_MaterialTableAdapter;
        private System.Windows.Forms.BindingSource cViewAddonsBindingSource;
        private Datasource.DT_Item_Add_OnTableAdapters.C_View_AddonsTableAdapter c_View_AddonsTableAdapter;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Button btn_structure_width;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}