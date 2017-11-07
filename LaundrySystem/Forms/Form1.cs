using LaundrySystem.Forms.About_Us;
using LaundrySystem.Forms.Maintenance;
using LaundrySystem.Forms.Transaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        MaintenanceForm m;
        TransactionForm t;
        AboutUs a;
        BillingForm b;
        private void mainButtonClicked(object sender, EventArgs e) {
            if (sender.Equals(btnMaintenance)) {
                panelMain.Controls.Clear();
                m = new MaintenanceForm();
                m.Dock = DockStyle.Fill;
                panelMain.Controls.Add(m);

            }
            if (sender.Equals(btnReport)) {

            }
            if (sender.Equals(btnTransaction)) {
                panelMain.Controls.Clear();
                t = new TransactionForm();
                t.Dock = DockStyle.Fill;
                panelMain.Controls.Add(t);
            }
            if (sender.Equals(btnAbout)) {
                panelMain.Controls.Clear();
                a = new AboutUs();
                a.Dock = DockStyle.Fill;
                panelMain.Controls.Add(a);
            }
        }
    }
}
