namespace LaundrySystem.Forms.Maintenance {
    partial class CustomerForm {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customerTable = new System.Windows.Forms.DataGridView();
            this.tblcustomerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.laundrydbDataSet = new LaundrySystem.laundrydbDataSet();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tblcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laundrydbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblcustomerTableAdapter = new LaundrySystem.laundrydbDataSetTableAdapters.tblcustomerTableAdapter();
            this.strCustomerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCustomerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCustomerMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCustomerContactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCustomerStreetNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCustomerStreetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCustomerBarangay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enumCustomerMembershipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundrydbDataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundrydbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customerTable);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 492);
            this.panel2.TabIndex = 2;
            // 
            // customerTable
            // 
            this.customerTable.AllowUserToAddRows = false;
            this.customerTable.AllowUserToDeleteRows = false;
            this.customerTable.AutoGenerateColumns = false;
            this.customerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strCustomerIDDataGridViewTextBoxColumn,
            this.strCustomerFirstNameDataGridViewTextBoxColumn,
            this.strCustomerMiddleNameDataGridViewTextBoxColumn,
            this.strCustomerLastName,
            this.strCustomerContactNoDataGridViewTextBoxColumn,
            this.strCustomerStreetNo,
            this.strCustomerStreetName,
            this.strCustomerBarangay,
            this.enumCustomerMembershipDataGridViewTextBoxColumn});
            this.customerTable.DataSource = this.tblcustomerBindingSource1;
            this.customerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTable.Location = new System.Drawing.Point(0, 0);
            this.customerTable.MultiSelect = false;
            this.customerTable.Name = "customerTable";
            this.customerTable.ReadOnly = true;
            this.customerTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerTable.Size = new System.Drawing.Size(983, 434);
            this.customerTable.TabIndex = 1;
            // 
            // tblcustomerBindingSource1
            // 
            this.tblcustomerBindingSource1.DataMember = "tblcustomer";
            this.tblcustomerBindingSource1.DataSource = this.laundrydbDataSet;
            // 
            // laundrydbDataSet
            // 
            this.laundrydbDataSet.DataSetName = "laundrydbDataSet";
            this.laundrydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.1526F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.8474F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEdit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 434);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(983, 58);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(487, 52);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.menuClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(496, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(484, 52);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.menuClick);
            // 
            // tblcustomerBindingSource
            // 
            this.tblcustomerBindingSource.DataMember = "tblcustomer";
            this.tblcustomerBindingSource.DataSource = this.laundrydbDataSet;
            // 
            // laundrydbDataSetBindingSource
            // 
            this.laundrydbDataSetBindingSource.DataSource = this.laundrydbDataSet;
            this.laundrydbDataSetBindingSource.Position = 0;
            // 
            // tblcustomerTableAdapter
            // 
            this.tblcustomerTableAdapter.ClearBeforeFill = true;
            // 
            // strCustomerIDDataGridViewTextBoxColumn
            // 
            this.strCustomerIDDataGridViewTextBoxColumn.DataPropertyName = "strCustomerID";
            this.strCustomerIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.strCustomerIDDataGridViewTextBoxColumn.Name = "strCustomerIDDataGridViewTextBoxColumn";
            this.strCustomerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strCustomerFirstNameDataGridViewTextBoxColumn
            // 
            this.strCustomerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "strCustomerFirstName";
            this.strCustomerFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.strCustomerFirstNameDataGridViewTextBoxColumn.Name = "strCustomerFirstNameDataGridViewTextBoxColumn";
            this.strCustomerFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strCustomerMiddleNameDataGridViewTextBoxColumn
            // 
            this.strCustomerMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "strCustomerMiddleName";
            this.strCustomerMiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.strCustomerMiddleNameDataGridViewTextBoxColumn.Name = "strCustomerMiddleNameDataGridViewTextBoxColumn";
            this.strCustomerMiddleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strCustomerLastName
            // 
            this.strCustomerLastName.DataPropertyName = "strCustomerLastName";
            this.strCustomerLastName.HeaderText = "Last Name";
            this.strCustomerLastName.Name = "strCustomerLastName";
            this.strCustomerLastName.ReadOnly = true;
            // 
            // strCustomerContactNoDataGridViewTextBoxColumn
            // 
            this.strCustomerContactNoDataGridViewTextBoxColumn.DataPropertyName = "strCustomerContactNo";
            this.strCustomerContactNoDataGridViewTextBoxColumn.HeaderText = "Contact No.";
            this.strCustomerContactNoDataGridViewTextBoxColumn.Name = "strCustomerContactNoDataGridViewTextBoxColumn";
            this.strCustomerContactNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strCustomerStreetNo
            // 
            this.strCustomerStreetNo.DataPropertyName = "strCustomerStreetNo";
            this.strCustomerStreetNo.HeaderText = "Street No.";
            this.strCustomerStreetNo.Name = "strCustomerStreetNo";
            this.strCustomerStreetNo.ReadOnly = true;
            // 
            // strCustomerStreetName
            // 
            this.strCustomerStreetName.DataPropertyName = "strCustomerStreetName";
            this.strCustomerStreetName.HeaderText = "Street Name";
            this.strCustomerStreetName.Name = "strCustomerStreetName";
            this.strCustomerStreetName.ReadOnly = true;
            // 
            // strCustomerBarangay
            // 
            this.strCustomerBarangay.DataPropertyName = "strCustomerBarangay";
            this.strCustomerBarangay.HeaderText = "Barangay";
            this.strCustomerBarangay.Name = "strCustomerBarangay";
            this.strCustomerBarangay.ReadOnly = true;
            // 
            // enumCustomerMembershipDataGridViewTextBoxColumn
            // 
            this.enumCustomerMembershipDataGridViewTextBoxColumn.DataPropertyName = "enumCustomerMembership";
            this.enumCustomerMembershipDataGridViewTextBoxColumn.HeaderText = "Membership";
            this.enumCustomerMembershipDataGridViewTextBoxColumn.Name = "enumCustomerMembershipDataGridViewTextBoxColumn";
            this.enumCustomerMembershipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "CustomerForm";
            this.Size = new System.Drawing.Size(983, 492);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundrydbDataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundrydbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView customerTable;
        private System.Windows.Forms.BindingSource tblcustomerBindingSource;
        private laundrydbDataSet laundrydbDataSet;
        private System.Windows.Forms.BindingSource laundrydbDataSetBindingSource;
        private laundrydbDataSetTableAdapters.tblcustomerTableAdapter tblcustomerTableAdapter;
        private System.Windows.Forms.BindingSource tblcustomerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCustomerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCustomerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCustomerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCustomerMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCustomerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCustomerContactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCustomerStreetNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCustomerStreetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCustomerBarangay;
        private System.Windows.Forms.DataGridViewTextBoxColumn enumCustomerMembershipDataGridViewTextBoxColumn;
    }
}
