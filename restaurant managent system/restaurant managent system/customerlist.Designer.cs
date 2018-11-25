namespace restaurant_managent_system
{
    partial class customerlist
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
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchvaluetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searachcmb = new System.Windows.Forms.ComboBox();
            this.showtable = new System.Windows.Forms.Button();
            this.bookinglistgb = new System.Windows.Forms.DataGridView();
            this.customertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantdbDataSet7 = new restaurant_managent_system.restaurantdbDataSet7();
            this.customertblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customertblTableAdapter1 = new restaurant_managent_system.restaurantdbDataSet7TableAdapters.customertblTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookinglistgb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertblBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 26);
            this.panel1.TabIndex = 0;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Location = new System.Drawing.Point(546, 34);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(138, 21);
            this.searchbtn.TabIndex = 13;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchvaluetxt
            // 
            this.searchvaluetxt.Location = new System.Drawing.Point(245, 35);
            this.searchvaluetxt.Name = "searchvaluetxt";
            this.searchvaluetxt.Size = new System.Drawing.Size(295, 20);
            this.searchvaluetxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search By";
            // 
            // searachcmb
            // 
            this.searachcmb.FormattingEnabled = true;
            this.searachcmb.Items.AddRange(new object[] {
            "CustomerID",
            "CustomerName",
            "CustomerEmail",
            "CustomerPhoneNo",
            "CustomerAddress"});
            this.searachcmb.Location = new System.Drawing.Point(109, 34);
            this.searachcmb.Name = "searachcmb";
            this.searachcmb.Size = new System.Drawing.Size(121, 21);
            this.searachcmb.TabIndex = 10;
            this.searachcmb.SelectedIndexChanged += new System.EventHandler(this.searachcmb_SelectedIndexChanged);
            // 
            // showtable
            // 
            this.showtable.BackColor = System.Drawing.Color.LightSeaGreen;
            this.showtable.FlatAppearance.BorderSize = 0;
            this.showtable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.showtable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.showtable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showtable.Location = new System.Drawing.Point(0, 353);
            this.showtable.Name = "showtable";
            this.showtable.Size = new System.Drawing.Size(709, 43);
            this.showtable.TabIndex = 9;
            this.showtable.Text = "Show Customer List";
            this.showtable.UseVisualStyleBackColor = false;
            this.showtable.Click += new System.EventHandler(this.showtable_Click);
            // 
            // bookinglistgb
            // 
            this.bookinglistgb.AutoGenerateColumns = false;
            this.bookinglistgb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookinglistgb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.bookinglistgb.DataSource = this.customertblBindingSource1;
            this.bookinglistgb.Location = new System.Drawing.Point(0, 77);
            this.bookinglistgb.Name = "bookinglistgb";
            this.bookinglistgb.Size = new System.Drawing.Size(709, 270);
            this.bookinglistgb.TabIndex = 8;
            // 
            // customertblBindingSource
            // 
            this.customertblBindingSource.DataMember = "customertbl";
            // 
            // restaurantdbDataSet7
            // 
            this.restaurantdbDataSet7.DataSetName = "restaurantdbDataSet7";
            this.restaurantdbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customertblBindingSource1
            // 
            this.customertblBindingSource1.DataMember = "customertbl";
            this.customertblBindingSource1.DataSource = this.restaurantdbDataSet7;
            // 
            // customertblTableAdapter1
            // 
            this.customertblTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "customerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "customerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "customerEmail";
            this.dataGridViewTextBoxColumn3.HeaderText = "customerEmail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "customerPhoneNo";
            this.dataGridViewTextBoxColumn4.HeaderText = "customerPhoneNo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "customerAddress";
            this.dataGridViewTextBoxColumn5.HeaderText = "customerAddress";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // customerlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 430);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchvaluetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searachcmb);
            this.Controls.Add(this.showtable);
            this.Controls.Add(this.bookinglistgb);
            this.Controls.Add(this.panel1);
            this.Name = "customerlist";
            this.Text = "customerlist";
            this.Load += new System.EventHandler(this.customerlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookinglistgb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertblBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchvaluetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searachcmb;
        private System.Windows.Forms.Button showtable;
        private System.Windows.Forms.DataGridView bookinglistgb;
        private restaurantdbDataSet2 restaurantdbDataSet2;
        private System.Windows.Forms.BindingSource customertblBindingSource;
        private restaurantdbDataSet2TableAdapters.customertblTableAdapter customertblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private restaurantdbDataSet7 restaurantdbDataSet7;
        private System.Windows.Forms.BindingSource customertblBindingSource1;
        private restaurantdbDataSet7TableAdapters.customertblTableAdapter customertblTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}