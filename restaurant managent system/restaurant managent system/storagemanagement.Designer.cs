namespace restaurant_managent_system
{
    partial class storagemanagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.bookingtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showtable = new System.Windows.Forms.Button();
            this.itemlistgb = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantdbDataSet17 = new restaurant_managent_system.restaurantdbDataSet17();
            this.itemtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.itempricetxt = new System.Windows.Forms.TextBox();
            this.itemtypetxt = new System.Windows.Forms.TextBox();
            this.itemnametxt = new System.Windows.Forms.TextBox();
            this.itemidtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.insertbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.generateitemid = new System.Windows.Forms.Button();
            this.itemtblTableAdapter1 = new restaurant_managent_system.restaurantdbDataSet17TableAdapters.itemtblTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemlistgb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 30);
            this.panel1.TabIndex = 8;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closebtn.Image = global::restaurant_managent_system.Properties.Resources.close_red;
            this.closebtn.Location = new System.Drawing.Point(1047, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(28, 30);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closebtn.TabIndex = 1;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // bookingtblBindingSource
            // 
            this.bookingtblBindingSource.DataMember = "bookingtbl";
            // 
            // showtable
            // 
            this.showtable.BackColor = System.Drawing.Color.LightSeaGreen;
            this.showtable.FlatAppearance.BorderSize = 0;
            this.showtable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.showtable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.showtable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showtable.Location = new System.Drawing.Point(467, 365);
            this.showtable.Name = "showtable";
            this.showtable.Size = new System.Drawing.Size(608, 44);
            this.showtable.TabIndex = 10;
            this.showtable.Text = "Show Item List";
            this.showtable.UseVisualStyleBackColor = false;
            this.showtable.Click += new System.EventHandler(this.showtable_Click);
            // 
            // itemlistgb
            // 
            this.itemlistgb.AutoGenerateColumns = false;
            this.itemlistgb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemlistgb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.itemlistgb.DataSource = this.itemtblBindingSource1;
            this.itemlistgb.Location = new System.Drawing.Point(467, 80);
            this.itemlistgb.Name = "itemlistgb";
            this.itemlistgb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemlistgb.Size = new System.Drawing.Size(608, 271);
            this.itemlistgb.TabIndex = 9;
            this.itemlistgb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.itemlistgb_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "itemId";
            this.dataGridViewTextBoxColumn1.HeaderText = "itemId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "itemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "itemName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "itemType";
            this.dataGridViewTextBoxColumn3.HeaderText = "itemType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "itemPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "itemPrice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // itemtblBindingSource1
            // 
            this.itemtblBindingSource1.DataMember = "itemtbl";
            this.itemtblBindingSource1.DataSource = this.restaurantdbDataSet17;
            // 
            // restaurantdbDataSet17
            // 
            this.restaurantdbDataSet17.DataSetName = "restaurantdbDataSet17";
            this.restaurantdbDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemtblBindingSource
            // 
            this.itemtblBindingSource.DataMember = "itemtbl";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.itempricetxt);
            this.groupBox2.Controls.Add(this.itemtypetxt);
            this.groupBox2.Controls.Add(this.itemnametxt);
            this.groupBox2.Controls.Add(this.itemidtxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(1, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 279);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // itempricetxt
            // 
            this.itempricetxt.Location = new System.Drawing.Point(21, 228);
            this.itempricetxt.Name = "itempricetxt";
            this.itempricetxt.Size = new System.Drawing.Size(270, 20);
            this.itempricetxt.TabIndex = 7;
            // 
            // itemtypetxt
            // 
            this.itemtypetxt.Location = new System.Drawing.Point(21, 165);
            this.itemtypetxt.Name = "itemtypetxt";
            this.itemtypetxt.Size = new System.Drawing.Size(270, 20);
            this.itemtypetxt.TabIndex = 6;
            // 
            // itemnametxt
            // 
            this.itemnametxt.Location = new System.Drawing.Point(21, 104);
            this.itemnametxt.Name = "itemnametxt";
            this.itemnametxt.Size = new System.Drawing.Size(270, 20);
            this.itemnametxt.TabIndex = 5;
            // 
            // itemidtxt
            // 
            this.itemidtxt.Location = new System.Drawing.Point(21, 39);
            this.itemidtxt.Name = "itemidtxt";
            this.itemidtxt.Size = new System.Drawing.Size(270, 20);
            this.itemidtxt.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Item Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Item Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Item Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item ID";
            // 
            // insertbtn
            // 
            this.insertbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.insertbtn.FlatAppearance.BorderSize = 0;
            this.insertbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.insertbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.insertbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertbtn.Location = new System.Drawing.Point(1, 365);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(146, 44);
            this.insertbtn.TabIndex = 13;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Location = new System.Drawing.Point(153, 365);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(119, 44);
            this.updatebtn.TabIndex = 14;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Location = new System.Drawing.Point(278, 365);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(141, 44);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // generateitemid
            // 
            this.generateitemid.BackColor = System.Drawing.Color.LightSeaGreen;
            this.generateitemid.FlatAppearance.BorderSize = 0;
            this.generateitemid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.generateitemid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.generateitemid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateitemid.Location = new System.Drawing.Point(1, 56);
            this.generateitemid.Name = "generateitemid";
            this.generateitemid.Size = new System.Drawing.Size(418, 24);
            this.generateitemid.TabIndex = 15;
            this.generateitemid.Text = "Generate Item ID";
            this.generateitemid.UseVisualStyleBackColor = false;
            this.generateitemid.Click += new System.EventHandler(this.generateitemid_Click);
            // 
            // itemtblTableAdapter1
            // 
            this.itemtblTableAdapter1.ClearBeforeFill = true;
            // 
            // storagemanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 415);
            this.Controls.Add(this.generateitemid);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showtable);
            this.Controls.Add(this.itemlistgb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "storagemanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "storagemanagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.storagemanagement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemlistgb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.BindingSource bookingtblBindingSource;
        private restaurantdbDataSet restaurantdbDataSet;
        private restaurantdbDataSetTableAdapters.bookingtblTableAdapter bookingtblTableAdapter;
        private System.Windows.Forms.Button showtable;
        private System.Windows.Forms.DataGridView itemlistgb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox itempricetxt;
        private System.Windows.Forms.TextBox itemtypetxt;
        private System.Windows.Forms.TextBox itemnametxt;
        private System.Windows.Forms.TextBox itemidtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private restaurantdbDataSet1 restaurantdbDataSet1;
        private System.Windows.Forms.BindingSource itemtblBindingSource;
        private restaurantdbDataSet1TableAdapters.itemtblTableAdapter itemtblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button generateitemid;
        private restaurantdbDataSet17 restaurantdbDataSet17;
        private System.Windows.Forms.BindingSource itemtblBindingSource1;
        private restaurantdbDataSet17TableAdapters.itemtblTableAdapter itemtblTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}