namespace LaundrySystem.Forms.Maintenance {
    partial class StaffForm {
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
            this.staffTable = new System.Windows.Forms.DataGridView();
            this.tblstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laundrydbDataSet = new LaundrySystem.laundrydbDataSet();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tblstaffTableAdapter = new LaundrySystem.laundrydbDataSetTableAdapters.tblstaffTableAdapter();
            this.strStaffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strStaffFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strStaffMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strStaffLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strStaffContactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strStaffEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strStaffStreetNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strStaffStreetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strStaffBarangay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strStaffUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strStaffPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enumStaffModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enumStaffActiveStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundrydbDataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.staffTable);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 492);
            this.panel2.TabIndex = 3;
            // 
            // staffTable
            // 
            this.staffTable.AllowUserToAddRows = false;
            this.staffTable.AllowUserToDeleteRows = false;
            this.staffTable.AutoGenerateColumns = false;
            this.staffTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.staffTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strStaffIDDataGridViewTextBoxColumn,
            this.strStaffFirstNameDataGridViewTextBoxColumn,
            this.strStaffMiddleNameDataGridViewTextBoxColumn,
            this.strStaffLastNameDataGridViewTextBoxColumn,
            this.strStaffContactNoDataGridViewTextBoxColumn,
            this.strStaffEmailDataGridViewTextBoxColumn,
            this.strStaffStreetNo,
            this.strStaffStreetName,
            this.strStaffBarangay,
            this.strStaffUserNameDataGridViewTextBoxColumn,
            this.strStaffPasswordDataGridViewTextBoxColumn,
            this.enumStaffModeDataGridViewTextBoxColumn,
            this.enumStaffActiveStatusDataGridViewTextBoxColumn});
            this.staffTable.DataSource = this.tblstaffBindingSource;
            this.staffTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffTable.Location = new System.Drawing.Point(0, 0);
            this.staffTable.MultiSelect = false;
            this.staffTable.Name = "staffTable";
            this.staffTable.ReadOnly = true;
            this.staffTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffTable.Size = new System.Drawing.Size(983, 434);
            this.staffTable.TabIndex = 1;
            // 
            // tblstaffBindingSource
            // 
            this.tblstaffBindingSource.DataMember = "tblstaff";
            this.tblstaffBindingSource.DataSource = this.laundrydbDataSet;
            // 
            // laundrydbDataSet
            // 
            this.laundrydbDataSet.DataSetName = "laundrydbDataSet";
            this.laundrydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.05087F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.94913F));
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
            this.btnAdd.Size = new System.Drawing.Size(486, 52);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.mainButtonClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(495, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(485, 52);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.mainButtonClick);
            // 
            // tblstaffTableAdapter
            // 
            this.tblstaffTableAdapter.ClearBeforeFill = true;
            // 
            // strStaffIDDataGridViewTextBoxColumn
            // 
            this.strStaffIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strStaffIDDataGridViewTextBoxColumn.DataPropertyName = "strStaffID";
            this.strStaffIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.strStaffIDDataGridViewTextBoxColumn.Name = "strStaffIDDataGridViewTextBoxColumn";
            this.strStaffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strStaffFirstNameDataGridViewTextBoxColumn
            // 
            this.strStaffFirstNameDataGridViewTextBoxColumn.DataPropertyName = "strStaffFirstName";
            this.strStaffFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.strStaffFirstNameDataGridViewTextBoxColumn.Name = "strStaffFirstNameDataGridViewTextBoxColumn";
            this.strStaffFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.strStaffFirstNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // strStaffMiddleNameDataGridViewTextBoxColumn
            // 
            this.strStaffMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "strStaffMiddleName";
            this.strStaffMiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.strStaffMiddleNameDataGridViewTextBoxColumn.Name = "strStaffMiddleNameDataGridViewTextBoxColumn";
            this.strStaffMiddleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.strStaffMiddleNameDataGridViewTextBoxColumn.Width = 92;
            // 
            // strStaffLastNameDataGridViewTextBoxColumn
            // 
            this.strStaffLastNameDataGridViewTextBoxColumn.DataPropertyName = "strStaffLastName";
            this.strStaffLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.strStaffLastNameDataGridViewTextBoxColumn.Name = "strStaffLastNameDataGridViewTextBoxColumn";
            this.strStaffLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.strStaffLastNameDataGridViewTextBoxColumn.Width = 81;
            // 
            // strStaffContactNoDataGridViewTextBoxColumn
            // 
            this.strStaffContactNoDataGridViewTextBoxColumn.DataPropertyName = "strStaffContactNo";
            this.strStaffContactNoDataGridViewTextBoxColumn.HeaderText = "Contact No.";
            this.strStaffContactNoDataGridViewTextBoxColumn.Name = "strStaffContactNoDataGridViewTextBoxColumn";
            this.strStaffContactNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.strStaffContactNoDataGridViewTextBoxColumn.Width = 87;
            // 
            // strStaffEmailDataGridViewTextBoxColumn
            // 
            this.strStaffEmailDataGridViewTextBoxColumn.DataPropertyName = "strStaffEmail";
            this.strStaffEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.strStaffEmailDataGridViewTextBoxColumn.Name = "strStaffEmailDataGridViewTextBoxColumn";
            this.strStaffEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.strStaffEmailDataGridViewTextBoxColumn.Width = 55;
            // 
            // strStaffStreetNo
            // 
            this.strStaffStreetNo.DataPropertyName = "strStaffStreetNo";
            this.strStaffStreetNo.HeaderText = "Street No.";
            this.strStaffStreetNo.Name = "strStaffStreetNo";
            this.strStaffStreetNo.ReadOnly = true;
            this.strStaffStreetNo.Width = 78;
            // 
            // strStaffStreetName
            // 
            this.strStaffStreetName.DataPropertyName = "strStaffStreetName";
            this.strStaffStreetName.HeaderText = "Street Name";
            this.strStaffStreetName.Name = "strStaffStreetName";
            this.strStaffStreetName.ReadOnly = true;
            this.strStaffStreetName.Width = 89;
            // 
            // strStaffBarangay
            // 
            this.strStaffBarangay.DataPropertyName = "strStaffBarangay";
            this.strStaffBarangay.HeaderText = "Barangay";
            this.strStaffBarangay.Name = "strStaffBarangay";
            this.strStaffBarangay.ReadOnly = true;
            this.strStaffBarangay.Width = 75;
            // 
            // strStaffUserNameDataGridViewTextBoxColumn
            // 
            this.strStaffUserNameDataGridViewTextBoxColumn.DataPropertyName = "strStaffUserName";
            this.strStaffUserNameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.strStaffUserNameDataGridViewTextBoxColumn.Name = "strStaffUserNameDataGridViewTextBoxColumn";
            this.strStaffUserNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.strStaffUserNameDataGridViewTextBoxColumn.Width = 78;
            // 
            // strStaffPasswordDataGridViewTextBoxColumn
            // 
            this.strStaffPasswordDataGridViewTextBoxColumn.DataPropertyName = "strStaffPassword";
            this.strStaffPasswordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.strStaffPasswordDataGridViewTextBoxColumn.Name = "strStaffPasswordDataGridViewTextBoxColumn";
            this.strStaffPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.strStaffPasswordDataGridViewTextBoxColumn.Width = 76;
            // 
            // enumStaffModeDataGridViewTextBoxColumn
            // 
            this.enumStaffModeDataGridViewTextBoxColumn.DataPropertyName = "enumStaffMode";
            this.enumStaffModeDataGridViewTextBoxColumn.HeaderText = "Mode";
            this.enumStaffModeDataGridViewTextBoxColumn.Name = "enumStaffModeDataGridViewTextBoxColumn";
            this.enumStaffModeDataGridViewTextBoxColumn.ReadOnly = true;
            this.enumStaffModeDataGridViewTextBoxColumn.Width = 57;
            // 
            // enumStaffActiveStatusDataGridViewTextBoxColumn
            // 
            this.enumStaffActiveStatusDataGridViewTextBoxColumn.DataPropertyName = "enumStaffActiveStatus";
            this.enumStaffActiveStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.enumStaffActiveStatusDataGridViewTextBoxColumn.Name = "enumStaffActiveStatusDataGridViewTextBoxColumn";
            this.enumStaffActiveStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.enumStaffActiveStatusDataGridViewTextBoxColumn.Width = 60;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "StaffForm";
            this.Size = new System.Drawing.Size(983, 492);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundrydbDataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView staffTable;
        private System.Windows.Forms.BindingSource tblstaffBindingSource;
        private laundrydbDataSet laundrydbDataSet;
        private laundrydbDataSetTableAdapters.tblstaffTableAdapter tblstaffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStaffAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStaffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStaffFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStaffMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStaffLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStaffContactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStaffEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStaffStreetNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStaffStreetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStaffBarangay;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStaffUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStaffPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enumStaffModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enumStaffActiveStatusDataGridViewTextBoxColumn;
    }
}
