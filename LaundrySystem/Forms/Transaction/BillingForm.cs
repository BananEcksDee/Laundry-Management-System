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
    public partial class BillingForm : UserControl {
        Transaction t;
        MySqlConnection con;
        public BillingForm(Transaction t) {
            this.t = t;
            con = Program.Con;
            InitializeComponent();
            txtStuff.Clear();
            double totalCost = 0;
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT concat(strCustomerFirstName, ' ', strCustomerLastName, ' ', strCustomerMiddleName) AS fullname,enumCustomerMembership,enumStatus FROM tblCustomer,tblTransaction WHERE tblTransaction.strTransactionID = '" + t.TransactionID + "' AND tblTransaction.strTransactionCustomerID = tblCustomer.strCustomerID";
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string orderStatus = reader.GetString("enumStatus");
            string membershipStatus = reader.GetString("enumCustomerMembership");
            txtStuff.Text += "Transcation ID: " + t.TransactionID + "\n";
            txtStuff.Text +=  "Customer Full Name: " +reader.GetString("fullname") + "\n";
            txtStuff.Text += "Bill:\n";
            cmd.CommandText = "SELECT a.strServiceName,b.dblAmount,c.dblServicePrice From tblService a, tblServicesRendered b, tblServicePrices c,tblTransaction d WHERE b.strServiceID = a.strServiceID AND c.strServiceID = a.strServiceID AND d.strTransactionID = b.strTransactionID AND d.strTransactionID = '"+ t.TransactionID + "'";
            reader.Close();
            reader = cmd.ExecuteReader();
            while (reader.Read()) {
                totalCost += reader.GetDouble("dblAmount") * reader.GetDouble("dblServicePrice");
                txtStuff.Text += reader.GetString("strServiceName") + " " + reader.GetDouble("dblAmount") + " " + reader.GetDouble("dblServicePrice") + "\n";
            }
            txtStuff.Text += "Discounts: ";
            if (membershipStatus.Equals("Yes")) {
                txtStuff.Text += "Less 10% Membership discount";
                totalCost /= 0.9;
            }else {
                txtStuff.Text += "None";
            }
            txtStuff.Text += "\nPenalties:";
            if (orderStatus.Equals("Overdue")) {
                txtStuff.Text += "+20% Overdue Penalty";
                totalCost *= 1.2;
            }else {
                txtStuff.Text += "None";
            }
            txtStuff.Text += "\nTotal cost : " + totalCost;
            reader.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Parent.Dispose();
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE tbltransaction SET enumStatus = 'Claimed' WHERE strTransactionID = '" + t.TransactionID + "'";
            cmd.ExecuteNonQuery();
            btnCancel_Click(null, null);
        }
    }
}
