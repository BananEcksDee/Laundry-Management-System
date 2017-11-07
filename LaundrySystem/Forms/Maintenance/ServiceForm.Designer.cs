namespace LaundrySystem.Forms.Maintenance {
    partial class ServiceForm {
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
            this.servicesTable = new System.Windows.Forms.DataGridView();
            this.serviceviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laundrydbDataSet1 = new LaundrySystem.laundrydbDataSet();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.laundrydbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laundrydbDataSet = new LaundrySystem.laundrydbDataSet();
            this.tblserviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblserviceTableAdapter = new LaundrySystem.laundrydbDataSetTableAdapters.tblserviceTableAdapter();
            this.serviceviewTableAdapter = new LaundrySystem.laundrydbDataSetTableAdapters.serviceviewTableAdapter();
            this.strServiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strServiceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dblServicePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enumCategoryUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundrydbDataSet1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laundrydbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundrydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblserviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.servicesTable);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 492);
            this.panel2.TabIndex = 3;
            // 
            // servicesTable
            // 
            this.servicesTable.AllowUserToAddRows = false;
            this.servicesTable.AllowUserToDeleteRows = false;
            this.servicesTable.AutoGenerateColumns = false;
            this.servicesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strServiceIDDataGridViewTextBoxColumn,
            this.strServiceNameDataGridViewTextBoxColumn,
            this.dblServicePriceDataGridViewTextBoxColumn,
            this.strCategoryNameDataGridViewTextBoxColumn,
            this.enumCategoryUnitDataGridViewTextBoxColumn});
            this.servicesTable.DataSource = this.serviceviewBindingSource;
            this.servicesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesTable.Location = new System.Drawing.Point(0, 0);
            this.servicesTable.MultiSelect = false;
            this.servicesTable.Name = "servicesTable";
            this.servicesTable.ReadOnly = true;
            this.servicesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesTable.Size = new System.Drawing.Size(983, 434);
            this.servicesTable.TabIndex = 1;
            // 
            // serviceviewBindingSource
            // 
            this.serviceviewBindingSource.DataMember = "serviceview";
            this.serviceviewBindingSource.DataSource = this.laundrydbDataSet1;
            // 
            // laundrydbDataSet1
            // 
            this.laundrydbDataSet1.DataSetName = "laundrydbDataSet";
            this.laundrydbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.94913F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.05087F));
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
            this.btnAdd.Size = new System.Drawing.Size(484, 52);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(493, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(487, 52);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnClick);
            // 
            // laundrydbDataSetBindingSource
            // 
            this.laundrydbDataSetBindingSource.DataSource = this.laundrydbDataSet;
            this.laundrydbDataSetBindingSource.Position = 0;
            // 
            // laundrydbDataSet
            // 
            this.laundrydbDataSet.DataSetName = "laundrydbDataSet";
            this.laundrydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblserviceBindingSource
            // 
            this.tblserviceBindingSource.DataMember = "tblservice";
            this.tblserviceBindingSource.DataSource = this.laundrydbDataSet;
            // 
            // tblserviceTableAdapter
            // 
            this.tblserviceTableAdapter.ClearBeforeFill = true;
            // 
            // serviceviewTableAdapter
            // 
            this.serviceviewTableAdapter.ClearBeforeFill = true;
            // 
            // strServiceIDDataGridViewTextBoxColumn
            // 
            this.strServiceIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.strServiceIDDataGridViewTextBoxColumn.DataPropertyName = "strServiceID";
            this.strServiceIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.strServiceIDDataGridViewTextBoxColumn.Name = "strServiceIDDataGridViewTextBoxColumn";
            this.strServiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.strServiceIDDataGridViewTextBoxColumn.Width = 41;
            // 
            // strServiceNameDataGridViewTextBoxColumn
            // 
            this.strServiceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strServiceNameDataGridViewTextBoxColumn.DataPropertyName = "strServiceName";
            this.strServiceNameDataGridViewTextBoxColumn.HeaderText = "Service Name";
            this.strServiceNameDataGridViewTextBoxColumn.Name = "strServiceNameDataGridViewTextBoxColumn";
            this.strServiceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dblServicePriceDataGridViewTextBoxColumn
            // 
            this.dblServicePriceDataGridViewTextBoxColumn.DataPropertyName = "dblServicePrice";
            this.dblServicePriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.dblServicePriceDataGridViewTextBoxColumn.Name = "dblServicePriceDataGridViewTextBoxColumn";
            this.dblServicePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strCategoryNameDataGridViewTextBoxColumn
            // 
            this.strCategoryNameDataGridViewTextBoxColumn.DataPropertyName = "strCategoryName";
            this.strCategoryNameDataGridViewTextBoxColumn.HeaderText = "Category Name";
            this.strCategoryNameDataGridViewTextBoxColumn.Name = "strCategoryNameDataGridViewTextBoxColumn";
            this.strCategoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enumCategoryUnitDataGridViewTextBoxColumn
            // 
            this.enumCategoryUnitDataGridViewTextBoxColumn.DataPropertyName = "enumCategoryUnit";
            this.enumCategoryUnitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.enumCategoryUnitDataGridViewTextBoxColumn.Name = "enumCategoryUnitDataGridViewTextBoxColumn";
            this.enumCategoryUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ServiceForm";
            this.Size = new System.Drawing.Size(983, 492);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundrydbDataSet1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laundrydbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundrydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblserviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView servicesTable;
        private System.Windows.Forms.BindingSource tblserviceBindingSource;
        private laundrydbDataSet laundrydbDataSet;
        private laundrydbDataSetTableAdapters.tblserviceTableAdapter tblserviceTableAdapter;
        private System.Windows.Forms.BindingSource laundrydbDataSetBindingSource;
        private System.Windows.Forms.BindingSource serviceviewBindingSource;
        private laundrydbDataSet laundrydbDataSet1;
        private laundrydbDataSetTableAdapters.serviceviewTableAdapter serviceviewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn strServiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strServiceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dblServicePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enumCategoryUnitDataGridViewTextBoxColumn;
    }
}
