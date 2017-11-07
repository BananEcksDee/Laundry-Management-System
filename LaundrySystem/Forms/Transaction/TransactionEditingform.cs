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

namespace LaundrySystem.Forms.Transaction {
    public partial class TransactionEditingForm : UserControl {
        List<string> list = new List<string>() { "Pending", "Ready", "Overdue", "Repossessed" };
        TransactionAddingForm t;
        public TransactionEditingForm() {
            InitializeComponent();
            con = Program.Con;

            dt = new DataTable();
            dataGridView1.DataSource = dt;
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT strTransactionID,strTransactionCustomerID,concat(strCustomerFirstName,' ',strCustomerLastName,' ',strCustomerMiddleName) AS fullname,dtmTransactionOrdered,dtmTransactionPickup,enumStatus FROM tbltransaction,tblcustomer WHERE tbltransaction.strTransactionCustomerID = tblCustomer.strCustomerID AND enumStatus IN('Pending','Ready','Overdue') ORDER BY dtmTransactionPickup";
            MySqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            dt.Columns["strTransactionID"].ReadOnly = true;
            dt.Columns["strTransactionID"].ColumnName = "Transaction ID";
            dt.Columns["strTransactionCustomerID"].ReadOnly = true;
            dt.Columns["strTransactionCustomerID"].ColumnName = "Customer ID";
            dt.Columns["fullname"].ReadOnly = true;
            dt.Columns["fullname"].ColumnName = "Full Name";
            dt.Columns["dtmTransactionOrdered"].ReadOnly = true;
            dt.Columns["dtmTransactionOrdered"].ColumnName = "Date Ordered";
            dt.Columns["dtmTransactionPickup"].ReadOnly = true;
            dt.Columns["dtmTransactionPickup"].ColumnName = "Pickup Date";
            dt.Columns["enumStatus"].ReadOnly = true;
            dt.Columns["enumStatus"].ColumnName = "Status";
            reader.Close();
        }
        DataTable dt;
        MySqlConnection con;

        private void button1_Click(object sender, EventArgs e) {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0) {
                DataGridViewRow d = dataGridView1.SelectedRows[0];
                MessageBox.Show(d.Cells[4].Value.ToString());
            }
        }

        private void btnEditClick(object sender, EventArgs e) {
            
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0) {
                Transaction transaction = new Transaction();
                DataGridViewRow d = dataGridView1.SelectedRows[0];
                transaction.TransactionID = d.Cells[0].Value.ToString();
                transaction.CustomerID = d.Cells[1].Value.ToString();
                transaction.DateOrdered = d.Cells[3].Value.ToString();
                transaction.DatePickup = d.Cells[4].Value.ToString();
                transaction.Status = d.Cells[5].Value.ToString();
                panelMain.Controls.Clear();
                t = new TransactionAddingForm(transaction);
                t.Dock = DockStyle.Fill;
                panelMain.Controls.Add(t);
            }
            
        }
    }
}
