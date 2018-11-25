namespace restaurant_managent_system
{
    partial class bookinglist
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
            this.restaurantdbDataSet = new restaurant_managent_system.restaurantdbDataSet();
            this.bookingtblTableAdapter = new restaurant_managent_system.restaurantdbDataSetTableAdapters.bookingtblTableAdapter();
            this.bookinglistgb = new System.Windows.Forms.DataGridView();
            this.showtable = new System.Windows.Forms.Button();
            this.searachcmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchvaluetxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.restaurantdbDataSet6 = new restaurant_managent_system.restaurantdbDataSet6();
            this.bookingtblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingtblTableAdapter1 = new restaurant_managent_system.restaurantdbDataSet6TableAdapters.bookingtblTableAdapter();
            this.bookingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfGuestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfTableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantdbDataSet9 = new restaurant_managent_system.restaurantdbDataSet9();
            this.bookingtblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingtblTableAdapter2 = new restaurant_managent_system.restaurantdbDataSet9TableAdapters.bookingtblTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinglistgb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 29);
            this.panel1.TabIndex = 0;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closebtn.Image = global::restaurant_managent_system.Properties.Resources.close_red;
            this.closebtn.Location = new System.Drawing.Point(681, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(28, 29);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closebtn.TabIndex = 1;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // bookingtblBindingSource
            // 
            this.bookingtblBindingSource.DataMember = "bookingtbl";
            this.bookingtblBindingSource.DataSource = this.restaurantdbDataSet;
            // 
            // restaurantdbDataSet
            // 
            this.restaurantdbDataSet.DataSetName = "restaurantdbDataSet";
            this.restaurantdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingtblTableAdapter
            // 
            this.bookingtblTableAdapter.ClearBeforeFill = true;
            // 
            // bookinglistgb
            // 
            this.bookinglistgb.AutoGenerateColumns = false;
            this.bookinglistgb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookinglistgb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIdDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.bookingStartTimeDataGridViewTextBoxColumn,
            this.bookingEndTimeDataGridViewTextBoxColumn,
            this.noOfGuestDataGridViewTextBoxColumn,
            this.noOfTableDataGridViewTextBoxColumn});
            this.bookinglistgb.DataSource = this.bookingtblBindingSource2;
            this.bookinglistgb.Location = new System.Drawing.Point(0, 113);
            this.bookinglistgb.Name = "bookinglistgb";
            this.bookinglistgb.Size = new System.Drawing.Size(709, 270);
            this.bookinglistgb.TabIndex = 1;
            // 
            // showtable
            // 
            this.showtable.BackColor = System.Drawing.Color.LightSeaGreen;
            this.showtable.FlatAppearance.BorderSize = 0;
            this.showtable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.showtable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.showtable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showtable.Location = new System.Drawing.Point(0, 390);
            this.showtable.Name = "showtable";
            this.showtable.Size = new System.Drawing.Size(709, 43);
            this.showtable.TabIndex = 2;
            this.showtable.Text = "Show Booking List";
            this.showtable.UseVisualStyleBackColor = false;
            this.showtable.Click += new System.EventHandler(this.showtable_Click);
            // 
            // searachcmb
            // 
            this.searachcmb.FormattingEnabled = true;
            this.searachcmb.Items.AddRange(new object[] {
            "BookingID",
            "CustomerID",
            "BookingDate"});
            this.searachcmb.Location = new System.Drawing.Point(109, 71);
            this.searachcmb.Name = "searachcmb";
            this.searachcmb.Size = new System.Drawing.Size(121, 21);
            this.searachcmb.TabIndex = 3;
            this.searachcmb.SelectedIndexChanged += new System.EventHandler(this.searachcmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search By";
            // 
            // searchvaluetxt
            // 
            this.searchvaluetxt.Location = new System.Drawing.Point(245, 72);
            this.searchvaluetxt.Name = "searchvaluetxt";
            this.searchvaluetxt.Size = new System.Drawing.Size(295, 20);
            this.searchvaluetxt.TabIndex = 5;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Location = new System.Drawing.Point(546, 71);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(138, 21);
            this.searchbtn.TabIndex = 6;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // restaurantdbDataSet6
            // 
            this.restaurantdbDataSet6.DataSetName = "restaurantdbDataSet6";
            this.restaurantdbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingtblBindingSource1
            // 
            this.bookingtblBindingSource1.DataMember = "bookingtbl";
            this.bookingtblBindingSource1.DataSource = this.restaurantdbDataSet6;
            // 
            // bookingtblTableAdapter1
            // 
            this.bookingtblTableAdapter1.ClearBeforeFill = true;
            // 
            // bookingIdDataGridViewTextBoxColumn
            // 
            this.bookingIdDataGridViewTextBoxColumn.DataPropertyName = "bookingId";
            this.bookingIdDataGridViewTextBoxColumn.HeaderText = "bookingId";
            this.bookingIdDataGridViewTextBoxColumn.Name = "bookingIdDataGridViewTextBoxColumn";
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "bookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "bookingDate";
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            // 
            // bookingStartTimeDataGridViewTextBoxColumn
            // 
            this.bookingStartTimeDataGridViewTextBoxColumn.DataPropertyName = "bookingStartTime";
            this.bookingStartTimeDataGridViewTextBoxColumn.HeaderText = "bookingStartTime";
            this.bookingStartTimeDataGridViewTextBoxColumn.Name = "bookingStartTimeDataGridViewTextBoxColumn";
            // 
            // bookingEndTimeDataGridViewTextBoxColumn
            // 
            this.bookingEndTimeDataGridViewTextBoxColumn.DataPropertyName = "bookingEndTime";
            this.bookingEndTimeDataGridViewTextBoxColumn.HeaderText = "bookingEndTime";
            this.bookingEndTimeDataGridViewTextBoxColumn.Name = "bookingEndTimeDataGridViewTextBoxColumn";
            // 
            // noOfGuestDataGridViewTextBoxColumn
            // 
            this.noOfGuestDataGridViewTextBoxColumn.DataPropertyName = "NoOfGuest";
            this.noOfGuestDataGridViewTextBoxColumn.HeaderText = "NoOfGuest";
            this.noOfGuestDataGridViewTextBoxColumn.Name = "noOfGuestDataGridViewTextBoxColumn";
            // 
            // noOfTableDataGridViewTextBoxColumn
            // 
            this.noOfTableDataGridViewTextBoxColumn.DataPropertyName = "NoOfTable";
            this.noOfTableDataGridViewTextBoxColumn.HeaderText = "NoOfTable";
            this.noOfTableDataGridViewTextBoxColumn.Name = "noOfTableDataGridViewTextBoxColumn";
            // 
            // restaurantdbDataSet9
            // 
            this.restaurantdbDataSet9.DataSetName = "restaurantdbDataSet9";
            this.restaurantdbDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingtblBindingSource2
            // 
            this.bookingtblBindingSource2.DataMember = "bookingtbl";
            this.bookingtblBindingSource2.DataSource = this.restaurantdbDataSet9;
            // 
            // bookingtblTableAdapter2
            // 
            this.bookingtblTableAdapter2.ClearBeforeFill = true;
            // 
            // bookinglist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 445);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchvaluetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searachcmb);
            this.Controls.Add(this.showtable);
            this.Controls.Add(this.bookinglistgb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookinglist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bookinglist";
            this.Load += new System.EventHandler(this.bookinglist_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinglistgb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closebtn;
        private restaurantdbDataSet restaurantdbDataSet;
        private System.Windows.Forms.BindingSource bookingtblBindingSource;
        private restaurantdbDataSetTableAdapters.bookingtblTableAdapter bookingtblTableAdapter;
        private System.Windows.Forms.DataGridView bookinglistgb;
        private System.Windows.Forms.Button showtable;
        private System.Windows.Forms.ComboBox searachcmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchvaluetxt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private restaurantdbDataSet6 restaurantdbDataSet6;
        private System.Windows.Forms.BindingSource bookingtblBindingSource1;
        private restaurantdbDataSet6TableAdapters.bookingtblTableAdapter bookingtblTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfGuestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfTableDataGridViewTextBoxColumn;
        private restaurantdbDataSet9 restaurantdbDataSet9;
        private System.Windows.Forms.BindingSource bookingtblBindingSource2;
        private restaurantdbDataSet9TableAdapters.bookingtblTableAdapter bookingtblTableAdapter2;
    }
}