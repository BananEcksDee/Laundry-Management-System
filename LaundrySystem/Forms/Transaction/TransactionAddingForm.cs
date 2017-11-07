using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LaundrySystem.Forms.Maintenance;
namespace LaundrySystem.Forms.Transaction {
    public partial class TransactionAddingForm : UserControl {
        private bool isEdit = false;
        private List<DataRow> toAdd = new List<DataRow>();
        BillingForm b;
        List<string> list = new List<string>() { "Pending", "Ready", "Overdue"};
        public TransactionAddingForm() {
            con = Program.Con;
            if (con.State != ConnectionState.Open) {
                con.Open();
            }
            InitializeComponent();
            reloadComboBox();
            table = new DataTable("tblServicesRendered");
            table.Columns.Add("strServiceID");
            table.Columns.Add("strServiceName");
            table.Columns.Add("dblAmount");
            table.Columns.Add("dblTotal");
            tableServices.DataSource = table;
            cboStatus.DataSource = list;
        }
        Transaction transaction;
        public TransactionAddingForm(Transaction t) {
            isEdit = true;
            toAdd = new List<DataRow>();
            this.transaction = t;
            con = Program.Con;
            if (con.State != ConnectionState.Open) {
                con.Open();
            }
            InitializeComponent();
            reloadComboBox();
            table = new DataTable("tblServicesRendered");
            table.Columns.Add("strServiceID");
            table.Columns.Add("strServiceName");
            table.Columns.Add("dblAmount");
            table.Columns.Add("dblTotal");
            tableServices.DataSource = table;
            cboStatus.DataSource = list;
            txtTransactionID.Enabled = false;
            btnConfirm.Enabled = true;
            btnCheckout.Enabled = true;
            linkLabel1.Enabled = false;
            linkLabel1.Visible = false;
            labeltext.Enabled = false;
            labeltext.Visible = false;
            cboName.Enabled = false;
            cboServices.Enabled = true;
            cboStatus.Enabled = true;
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *,concat(strCustomerFirstName, ' ', strCustomerLastName, ' ', strCustomerMiddleName) AS fullname from tblCustomer WHERE strCustomerID = '" + transaction.CustomerID+"'" ;
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            cboName.Text = reader.GetString("fullname");
            txtTransactionID.Text = transaction.TransactionID;
            cboStatus.Text = transaction.Status;
            reader.Close();
            cboName.Enabled = false;
            /*
             * TOO MUCH EFFORT RIGHT NOW
             * COMPLEX SQL STATEMENTS
             * NEED CURRENT PRICES TO MATCH
            
            cmd.CommandText = "SELECT  from tblservicesrendered WHERE strTransactionID = '" + transaction.TransactionID + "'";
            reader = cmd.ExecuteReader();
            table.Load(reader);
            reader.Close();
            /*
            row["strServiceID"] = cboServices.SelectedValue.ToString();
            row["strServiceName"] = cboServices.Text;
            row["dblAmount"] = txtQty.Text;
            row["dblTotal"] = txtTotal.Text;
            */
        }

        DataTable dt;
        DataTable dt2;
        DataTable table;
        MySqlConnection con;
        private void reloadComboBox() {
            MySqlCommand cmd = new MySqlCommand("SELECT *,concat(strCustomerFirstName,' ',strCustomerLastName,' ',strCustomerMiddleName) AS fullname from tblCustomer ORDER BY fullname", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            cboName.DataSource = dt;
            cboName.ValueMember = "strCustomerID";
            cboName.DisplayMember = "fullname";
            cmd.CommandText = "SELECT DISTINCT `tblservice`.`strServiceID` AS `strServiceID`,`tblservice`.`strServiceName` AS `strServiceName`,`tblserviceprices`.`dblServicePrice` AS `dblServicePrice`,`tblcategory`.`strCategoryName` AS `strCategoryName`,`tblcategory`.`enumCategoryUnit` AS `enumCategoryUnit` FROM((`tblcategory` JOIN `tblservice` ON ((`tblcategory`.`strCategoryID` = `tblservice`.`strServiceCategoryID`))) JOIN `tblserviceprices` ON ((`tblservice`.`strServiceID` = `tblserviceprices`.`strServiceID`))) WHERE tblserviceprices.dtmServiceDateOf IN(SELECT MAX(dtmServiceDateOf) FROM tblserviceprices GROUP BY strServiceID) ORDER BY strServiceName";
            reader = cmd.ExecuteReader();
            dt2 = new DataTable();
            dt2.Load(reader);
            cboServices.DataSource = dt2;
            cboServices.ValueMember = "strServiceID";
            cboServices.DisplayMember = "strServiceName";
        }
        private void linkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Form f = new Form();
            f.Size = this.Size;
            CustomerEditingForm c = new CustomerEditingForm();
            c.isTemp = true;
            f.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            var so = f.ShowDialog();
            if (c.cust != null) {
                reloadComboBox();
                cboName.SelectedItem = c.cust.FirstName + " " + c.cust.MiddleName + " " + c.cust.LastName;
                cboName.SelectedValue = c.cust.ID;
                txtID.Text = c.cust.ID;
                txtContact.Text = c.cust.ContactNo;
                if (c.cust.Membership.Equals(Customer.membershipStatus.Yes)) {
                    checkMember.CheckState = CheckState.Checked;
                }
            }
            
        }
        private void cboName_SelectedIndexChanged(object sender, EventArgs e) {
            DataRow data = dt.Rows.Find(cboName.SelectedValue.ToString());
            if(data != null) {
                txtContact.Text = data["strCustomerContactNo"].ToString();
                txtID.Text = data["strCustomerID"].ToString();
                if (data["enumCustomerMembership"].ToString().Equals("Yes")) {
                    checkMember.CheckState = CheckState.Checked;
                }
                cboServices.Enabled = true;
                // temporary work around for setting the correct values
                // pls dont forget
                cboServices.SelectedIndex = 1;
                cboServices.SelectedIndex = 0;
                btnAdd.Enabled = true;
            }
        }

        private void cboServices_SelectedIndexChanged(object sender, EventArgs e) {
            txtQty.Enabled = true;
            for (int x = 0; x < dt2.Rows.Count; x++) {
                if (dt2.Rows[x]["strServiceID"].Equals(cboServices.SelectedValue.ToString())){
                    txtPrice.Text = dt2.Rows[x]["dblServicePrice"].ToString();
                    break;
                }
            }
            if (txtPrice.Text != "") {
                txtTotal.Text = (double.Parse(txtQty.Value.ToString())* double.Parse(txtPrice.Text)).ToString();
            }
            
        }

        private void btnAddServiceClick(object sender, EventArgs e) {
            DataRow row = table.NewRow();
            row["strServiceID"] = cboServices.SelectedValue.ToString();
            row["strServiceName"] = cboServices.Text;
            row["dblAmount"] = txtQty.Text;
            row["dblTotal"] = txtTotal.Text;
            table.Rows.Add(row);
            if (isEdit) {
                toAdd.Add(row);
            }
            btnConfirm.Enabled = true;
        }

        private void btnConfirmClick(object sender, EventArgs e) {
            if (txtTransactionID.Text.Equals("")) {
                MessageBox.Show("Transaction ID Must Be Filled");
            }
            else {
                try {
                    if (!isEdit) {
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "INSERT INTO tbltransaction(strTransactionID,strTransactionCustomerID,strTransactionStaffID,dtmTransactionOrdered,dtmTransactionPickup) values("
                            + "'" + txtTransactionID.Text + "',"
                            + "'" + cboName.SelectedValue.ToString() + "',"
                            + "'1',"
                            + "NOW(),"
                            + "'" + dtmPickup.Value.ToString("yyyy-MM-dd") + "')";
                        cmd.ExecuteNonQuery();
                        foreach (DataRow row in table.Rows) {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "INSERT INTO tblservicesrendered (strServiceID,strTransactionID,dblAmount) VALUES(@Service,@Transaction,@Amount)";
                            cmd.Parameters.Add("@Service", MySqlDbType.VarChar).Value = row["strServiceID"];
                            cmd.Parameters.Add("@Transaction", MySqlDbType.VarChar).Value = txtTransactionID.Text;
                            cmd.Parameters.Add("@Amount", MySqlDbType.Double).Value = row["dblAmount"];
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else {
                        MySqlCommand cmd = con.CreateCommand();
                        foreach (DataRow row in toAdd) {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "INSERT INTO tblservicesrendered (strServiceID,strTransactionID,dblAmount) VALUES(@Service,@Transaction,@Amount)";
                            cmd.Parameters.Add("@Service", MySqlDbType.VarChar).Value = row["strServiceID"];
                            cmd.Parameters.Add("@Transaction", MySqlDbType.VarChar).Value = txtTransactionID.Text;
                            cmd.Parameters.Add("@Amount", MySqlDbType.Double).Value = row["dblAmount"];
                            cmd.ExecuteNonQuery();
                        }
                        toAdd.Clear();
                        cmd.CommandText = "UPDATE tbltransaction SET enumStatus = '" + cboStatus.Text + "' WHERE strTransactionID = '" + txtTransactionID.Text + "'";
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Changes Saved");
                }
                catch(MySqlException exce) {
                    MessageBox.Show("Error duplicate ID");
                }
            }
            
        }

        private void txtQtyValueChanged(object sender, EventArgs e) {
            txtTotal.Text = (double.Parse(txtQty.Value.ToString()) * double.Parse(txtPrice.Text)).ToString();
        }

        private void btnCheckoutClick(object sender, EventArgs e) {
            BillingForm b = new BillingForm(this.transaction);
            Form f = new Form();
            f.Size = this.Size;
            f.Controls.Add(b);
            b.Dock = DockStyle.Fill;
            var so = f.ShowDialog();
            TransactionAddingForm fc = new TransactionAddingForm();
            panelMain.Controls.Clear();
            fc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fc);
        }

        private void txtTransactionChanged(object sender, EventArgs e) {
            if(txtTransactionID.Text != "") {
                cboName.Enabled = true;
                linkLabel1.Enabled = true;
            }else {
                cboName.Enabled = false;
                linkLabel1.Enabled = false;
            }
        }
    }
}
