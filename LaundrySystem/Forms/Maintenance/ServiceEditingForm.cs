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
    public partial class ServiceEditingForm : UserControl {
        MySqlConnection con;
        public ServiceEditingForm() {
            InitializeComponent();
            con = Program.Con;
            if (con.State != ConnectionState.Open) {
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand("SELECT strCategoryID,strCategoryName FROM tblCategory", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cboCategory.DataSource = dt;
            cboCategory.ValueMember = "strCategoryID";
            cboCategory.DisplayMember = "strCategoryName";
        }
        public ServiceEditingForm(Service service) {
            InitializeComponent();
            con = Program.Con;
            if(con.State != ConnectionState.Open) {
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand("SELECT strCategoryID,strCategoryName FROM tblCategory", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cboCategory.DataSource = dt;
            cboCategory.ValueMember = "strCategoryID";
            cboCategory.DisplayMember = "strCategoryName";

            txtID.Text = service.ID;
            txtName.Text = service.Name;
            txtPrice.Text = service.Price.ToString();
            cboCategory.Text = service.Category;
            Service.CategoryUnit unit = Service.CategoryUnit.pcs;
            if (unit.Equals(Service.CategoryUnit.kg)) {
                cboUnit.Text = "Kilo";
            }else {
                cboUnit.Text = "Pieces";
            }
            isEdit = true;
            txtID.Enabled = false;
            toEdit = service;
        }
        Service toEdit;
        ServiceForm s;
        bool isEdit = false;
        private void btnConfirm_Click(object sender, EventArgs e) {
            bool flag = false;
            bool flag2 = false;
            if (txtID.Text.Trim().Equals("")) {
                flag = true;
            }
            if (txtName.Text.Trim().Equals("")) {
                flag = true;
            }
            if (txtPrice.Text.Trim().Equals("")) {
                flag = true;
            }
            if (cboUnit.Text.Trim().Equals("")) {
                flag = true;
            }
            if (flag) {
                MessageBox.Show("All fields must be filled");
            }else {
                try {
                    double test = double.Parse(txtPrice.Text.Trim());
                    flag2 = true;
                }
                catch(Exception ex) {
                    MessageBox.Show("Price is not a valid number");
                }
            }
            if (flag2) {
                con = Program.Con;
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                if (isEdit) {
                    Service service = new Service();
                    service.ID = txtID.Text;
                    service.Name = txtName.Text;
                    service.Price = double.Parse(txtPrice.Text);
                    service.Category = cboCategory.SelectedValue.ToString();
                    Service.CategoryUnit unit = Service.CategoryUnit.kg;
                    if (cboUnit.Text.Equals("Pieces")) {
                        unit = Service.CategoryUnit.pcs;
                    }
                    service.Unit = unit;
                    if (service.Price != toEdit.Price) {
                        cmd.CommandText = "INSERT INTO tblserviceprices(strServiceID,dtmServiceDateOf,dblServicePrice) values('" +
                            service.ID + "'," +
                            "NOW()," + service.Price + ")";
                        cmd.ExecuteNonQuery();
                    }
                    cmd.CommandText = "UPDATE tblservice SET " +
                            "strServiceName = '" + service.Name + "', " +
                            "strServiceCategoryID = '" + service.Category + "' " +
                            "WHERE strServiceID = '" + service.ID + "'";
                    cmd.ExecuteNonQuery();
                }
                else {
                    //cmd.CommandText
                    cmd.CommandText = "INSERT INTO tblservice values('" +
                        txtID.Text + "','" +
                        txtName.Text + "','" +
                        cboCategory.SelectedValue.ToString() + "')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO tblserviceprices(strServiceID,dtmServiceDateOf,dblServicePrice) values('" +
                        txtID.Text + "'," +
                        "NOW()," + txtPrice.Text + ")";
                    cmd.ExecuteNonQuery();

                }
                btnBack_Click(null, null);
            }
            
        }
        private void btnBack_Click(object sender, EventArgs e) {
            s = new ServiceForm();
            panel1.Controls.Clear();
            s.Dock = DockStyle.Fill;
            panel1.Controls.Add(s);
        }

        
    }
}
