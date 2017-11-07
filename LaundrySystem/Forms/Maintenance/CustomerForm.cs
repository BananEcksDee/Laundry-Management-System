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
    public partial class CustomerForm : UserControl {
        public CustomerForm() {
            InitializeComponent();
            FillData();
        }
        MySqlConnection con;
        void FillData() {
            using (con = Program.Con) {
                using (MySqlDataAdapter a = new MySqlDataAdapter(
            "SELECT * from tblcustomer", con)) {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    customerTable.DataSource = t;
                }
            }
        }

        CustomerEditingForm c;
        private void menuClick(object sender, EventArgs e) {
            if (sender.Equals(btnAdd)) {
                panel2.Controls.Clear();
                c = new CustomerEditingForm();
                c.Dock = DockStyle.Fill;
                panel2.Controls.Add(c);
            }
            if (sender.Equals(btnEdit)) {
                int selectedRowCount = customerTable.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0) {
                    DataGridViewRow d = customerTable.SelectedRows[0];
                    Customer.membershipStatus x = Customer.membershipStatus.No;
                    if (d.Cells[8].Value.ToString().Equals("Yes")) {
                        x = Customer.membershipStatus.Yes;
                    }
                    Customer cust = new Customer(
                        d.Cells[0].Value.ToString(),
                        d.Cells[1].Value.ToString(),
                        d.Cells[2].Value.ToString(),
                        d.Cells[3].Value.ToString(),
                        d.Cells[4].Value.ToString(),
                        d.Cells[5].Value.ToString(),
                        d.Cells[6].Value.ToString(),
                        d.Cells[7].Value.ToString(),x
                        );
                    panel2.Controls.Clear();
                    c = new CustomerEditingForm(cust);
                    c.Dock = DockStyle.Fill;
                    panel2.Controls.Add(c);
                }
                else {
                    MessageBox.Show("Select a customer to edit");
                }
                   
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.tblcustomerTableAdapter.FillBy(this.laundrydbDataSet.tblcustomer);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
