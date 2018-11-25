namespace restaurant_managent_system
{
    partial class orderlist
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchvaluetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searachcmb = new System.Windows.Forms.ComboBox();
            this.showtable = new System.Windows.Forms.Button();
            this.bookinglistgb = new System.Windows.Forms.DataGridView();
            this.ordertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantdbDataSet13 = new restaurant_managent_system.restaurantdbDataSet13();
            this.bookingtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingtblTableAdapter = new restaurant_managent_system.restaurantdbDataSet13TableAdapters.bookingtblTableAdapter();
            this.restaurantdbDataSet14 = new restaurant_managent_system.restaurantdbDataSet14();
            this.ordertblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordertblTableAdapter1 = new restaurant_managent_system.restaurantdbDataSet14TableAdapters.ordertblTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookinglistgb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Location = new System.Drawing.Point(542, 49);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(138, 21);
            this.searchbtn.TabIndex = 13;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchvaluetxt
            // 
            this.searchvaluetxt.Location = new System.Drawing.Point(241, 50);
            this.searchvaluetxt.Name = "searchvaluetxt";
            this.searchvaluetxt.Size = new System.Drawing.Size(295, 20);
            this.searchvaluetxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search By";
            // 
            // searachcmb
            // 
            this.searachcmb.FormattingEnabled = true;
            this.searachcmb.Items.AddRange(new object[] {
            "OrderID",
            "CustomerID",
            "DeliveryDate"});
            this.searachcmb.Location = new System.Drawing.Point(105, 49);
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
            this.showtable.Location = new System.Drawing.Point(-4, 368);
            this.showtable.Name = "showtable";
            this.showtable.Size = new System.Drawing.Size(709, 43);
            this.showtable.TabIndex = 9;
            this.showtable.Text = "Show Booking List";
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
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.bookinglistgb.DataSource = this.ordertblBindingSource1;
            this.bookinglistgb.Location = new System.Drawing.Point(-4, 92);
            this.bookinglistgb.Name = "bookinglistgb";
            this.bookinglistgb.Size = new System.Drawing.Size(709, 270);
            this.bookinglistgb.TabIndex = 8;
            // 
            // ordertblBindingSource
            // 
            this.ordertblBindingSource.DataMember = "ordertbl";
            // 
            // restaurantdbDataSet13
            // 
            this.restaurantdbDataSet13.DataSetName = "restaurantdbDataSet13";
            this.restaurantdbDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingtblBindingSource
            // 
            this.bookingtblBindingSource.DataMember = "bookingtbl";
            this.bookingtblBindingSource.DataSource = this.restaurantdbDataSet13;
            // 
            // bookingtblTableAdapter
            // 
            this.bookingtblTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantdbDataSet14
            // 
            this.restaurantdbDataSet14.DataSetName = "restaurantdbDataSet14";
            this.restaurantdbDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordertblBindingSource1
            // 
            this.ordertblBindingSource1.DataMember = "ordertbl";
            this.ordertblBindingSource1.DataSource = this.restaurantdbDataSet14;
            // 
            // ordertblTableAdapter1
            // 
            this.ordertblTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "orderId";
            this.dataGridViewTextBoxColumn1.HeaderText = "orderId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customerId";
            this.dataGridViewTextBoxColumn2.HeaderText = "customerId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "deliveryDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "deliveryDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "deliveryAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "deliveryAddress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "totalItem";
            this.dataGridViewTextBoxColumn5.HeaderText = "totalItem";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "totalQuantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "totalQuantity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "totalBill";
            this.dataGridViewTextBoxColumn7.HeaderText = "totalBill";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // orderlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 460);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchvaluetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searachcmb);
            this.Controls.Add(this.showtable);
            this.Controls.Add(this.bookinglistgb);
            this.Name = "orderlist";
            this.Text = "orderlist";
            this.Load += new System.EventHandler(this.orderlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookinglistgb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchvaluetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searachcmb;
        private System.Windows.Forms.Button showtable;
        private System.Windows.Forms.DataGridView bookinglistgb;
        private restaurantdbDataSet5 restaurantdbDataSet5;
        private System.Windows.Forms.BindingSource ordertblBindingSource;
        private restaurantdbDataSet5TableAdapters.ordertblTableAdapter ordertblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBillDataGridViewTextBoxColumn;
        private restaurantdbDataSet13 restaurantdbDataSet13;
        private System.Windows.Forms.BindingSource bookingtblBindingSource;
        private restaurantdbDataSet13TableAdapters.bookingtblTableAdapter bookingtblTableAdapter;
        private restaurantdbDataSet14 restaurantdbDataSet14;
        private System.Windows.Forms.BindingSource ordertblBindingSource1;
        private restaurantdbDataSet14TableAdapters.ordertblTableAdapter ordertblTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}