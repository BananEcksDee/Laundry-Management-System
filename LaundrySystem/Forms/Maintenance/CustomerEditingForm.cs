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

namespace LaundrySystem.Forms.Maintenance {
    public partial class CustomerEditingForm : UserControl {
        public CustomerEditingForm() {
            InitializeComponent();
            con = Program.Con;
            if(con.State != ConnectionState.Open) {
                con.Open();
            }
        }
        MySqlConnection con;
        public bool isTemp = false;
        bool isConfirm = false;
        bool isEdit=false;
        public Customer cust;
        public CustomerEditingForm(Customer cust) {
            InitializeComponent();
            con = Program.Con;
            if (con.State != ConnectionState.Open) {
                con.Open();
            }
            txtID.Text = cust.ID;
            txtFirst.Text = cust.FirstName;
            txtLast.Text = cust.LastName;
            txtMiddle.Text = cust.MiddleName;
            txtContact.Text = cust.ContactNo;
            txtBarangay.Text = cust.Barangay;
            txtStreetName.Text = cust.StreetName;
            txtStreetNo.Text = cust.StreetNo;
            if (cust.Membership.Equals(Customer.membershipStatus.No)){
                checkMember.CheckState = CheckState.Unchecked;
            }else {
                checkMember.CheckState = CheckState.Checked;
            }
            this.cust = cust;
            this.isEdit = true;
        }
        private void btnBack_Click(object sender, EventArgs e) {
            if (!isTemp) {
                panel1.Controls.Clear();
                CustomerForm f = new CustomerForm();
                panel1.Controls.Add(f);
                this.Parent.Dock = DockStyle.Fill;
            }
            else {
                ((Form)this.TopLevelControl).Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            bool flag = false;
            if (txtID.Text.Trim().Equals("")) {
                flag = true;
            }
            if (txtFirst.Text.Trim().Equals("")) {
                flag = true;
            }
            if (txtMiddle.Text.Trim().Equals("")) {
                flag = true;
            }
            if (txtLast.Text.Trim().Equals("")) {
                flag = true;
            }
            if (txtStreetNo.Text.Trim().Equals("")) {
                flag = true;
            }
            if (txtStreetName.Text.Trim().Equals("")) {
                flag = true;
            }
            if (txtBarangay.Text.Trim().Equals("")) {
                flag = true;
            }
            if (txtContact.Text.Trim().Equals("")) {
                flag = true;
            }
            if (flag) {
                MessageBox.Show("All fields must be filled");
            }else {
                con = Program.Con;
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                string membership = "No";
                if (checkMember.Checked) {
                    membership = "Yes";
                }
                if (isEdit) {
                    cmd.CommandText = "UPDATE tblcustomer SET " +
                        "strCustomerID = '" + txtID.Text + "'," +
                        "strCustomerFirstName = '" + txtFirst.Text + "'," +
                        "strCustomerMiddleName = '" + txtMiddle.Text + "'," +
                        "strCustomerLastName = '" + txtLast.Text + "'," +
                        "strCustomerStreetNo = '" + txtStreetNo.Text + "'," +
                        "strCustomerStreetName = '" + txtStreetName.Text + "'," +
                        "strCustomerBarangay = '" + txtBarangay.Text + "'," +
                        "strCustomerContactNo = '" + txtContact.Text + "'," +
                        "enumCustomerMembership = '" + membership + "' " +
                        "WHERE strCustomerID = '" + cust.ID + "'";
                }
                else {

                    cmd.CommandText = "INSERT INTO tblcustomer(strCustomerID,strCustomerFirstName,strCustomerLastName,strCustomerMiddleName,strCustomerStreetNo,strCustomerStreetName,strCustomerBarangay,strCustomerContactNo,enumCustomerMembership) values('" 
                        + txtID.Text + "','"
                        + txtFirst.Text + "','"
                        + txtLast.Text + "','"
                        + txtMiddle.Text + "','"
                        + txtStreetNo.Text + "','"
                        + txtStreetName.Text + "','"
                        + txtBarangay.Text + "','"
                        + txtContact.Text + "','"
                        + membership + "')";
                }
                cust = new Customer();
                cust.ID = txtID.Text ;
                cust.FirstName= txtFirst.Text;
                cust.LastName= txtLast.Text;
                cust.MiddleName= txtMiddle.Text;
                cust.ContactNo= txtContact.Text;
                cust.Barangay =txtBarangay.Text;
                cust.StreetName= txtStreetName.Text;
                cust.StreetNo= txtStreetNo.Text;
                if (checkMember.CheckState.Equals(CheckState.Checked)) {
                    cust.Membership = Customer.membershipStatus.Yes;
                }else {
                    cust.Membership = Customer.membershipStatus.No;
                }
                isConfirm = true;
                cmd.ExecuteNonQuery();
                btnBack_Click(null, null);
            }
            
        }
    }
}
