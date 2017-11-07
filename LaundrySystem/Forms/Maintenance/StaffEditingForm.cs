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
    public partial class StaffEditingForm : UserControl {
        public StaffEditingForm() {
            InitializeComponent();
            con = Program.Con;
            if (con.State != ConnectionState.Open) {
                con.Open();
            }
        }
        MySqlConnection con;
        public StaffEditingForm(Staff staff) {
            InitializeComponent();
            con = Program.Con;
            if (con.State != ConnectionState.Open) {
                con.Open();
            }
            this.staff = staff;
            isEdit = true;
            txtID.Text = staff.ID;
            txtFirst.Text = staff.FirstName;
            txtMiddle.Text = staff.MiddleName;
            txtLast.Text = staff.LastName;
            txtEmail.Text = staff.Email;
            txtBarangay.Text = staff.Barangay;
            txtStreetName.Text = staff.StreetName;
            txtStreetNo.Text = staff.StreetNo;
            txtContact.Text = staff.ContactNo;
            txtPassword.Text = staff.Password;
            txtUsername.Text = staff.Username;
            cboMode.Text = staff.Mode.ToString();
            if (staff.Status.Equals(Staff.StaffStatus.Inactive)) {
                checkActive.CheckState = CheckState.Unchecked;
            }
            checkActive.AutoCheck = true;

        }
        Staff staff;
        private bool isEdit = false;
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
            if (txtEmail.Text.Trim().Equals("")) {
                flag = true;
            }
            if (txtUsername.Text.Trim().Equals("")) {
                flag = true;
            }
            if (txtPassword.Text.Trim().Equals("")) {
                flag = true;
            }
            if (cboMode.Text.Trim().Equals("")) {
                flag = true;
            }
            if (flag) {
                MessageBox.Show("All fields must be filled");
            }else {
                con = Program.Con;
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                if (isEdit) {
                    string active = "Inactive";
                    if (checkActive.Checked) {
                        active = "Active";
                    }
                    cmd.CommandText = "UPDATE tblstaff SET " +
                        "strStaffID = '" + txtID.Text + "'," +
                        "strStaffFirstName = '" + txtFirst.Text + "'," +
                        "strStaffMiddleName = '" + txtMiddle.Text + "'," +
                        "strStaffLastName = '" + txtLast.Text + "'," +
                        "strStaffContactNo = '" + txtContact.Text + "'," +
                        "strStaffStreetNo = '" + txtStreetNo.Text + "'," +
                        "strStaffStreetName = '" + txtStreetName.Text + "'," +
                        "strStaffBarangay = '" + txtBarangay.Text + "'," +
                        "strStaffEmail = '" + txtEmail.Text + "'," +
                        "strStaffUserName = '" + txtUsername.Text + "'," +
                        "strStaffPassword = '" + txtPassword.Text + "'," +
                        "enumStaffMode = '" + cboMode.Text + "'," +
                        "enumStaffActiveStatus = '" + active + "' " +
                        "WHERE strStaffID = '" + staff.ID + "'";
                }
                else {
                    cmd.CommandText = "INSERT INTO tblstaff(strStaffID,strStaffFirstName,strStaffMiddleName,strStaffLastName,strStaffContactNo,strStaffEmail,strStaffStreetNo,strStaffStreetName,strStaffBarangay,strStaffUserName,strStaffPassword,enumStaffMode,enumStaffActiveStatus) values('" 
                    + txtID.Text + "','"
                    + txtFirst.Text + "','"
                    + txtMiddle.Text + "','"
                    + txtLast.Text + "','"
                    + txtContact.Text + "','"
                    + txtEmail.Text + "','"
                    + txtStreetNo.Text + "','"
                    + txtStreetName.Text + "','"
                    + txtBarangay.Text + "','"
                    + txtUsername.Text + "','"
                    + txtPassword.Text + "','"
                    + cboMode.Text + "','"
                    + "Active')";
                }
                cmd.ExecuteNonQuery();
                btnBack_Click(null, null);
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e) {
            panel1.Controls.Clear();
            StaffForm f = new StaffForm();
            panel1.Controls.Add(f);
            this.Parent.Dock = DockStyle.Fill;

        }
    }
}
