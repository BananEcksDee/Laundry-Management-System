using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem.Forms.Maintenance {
    public partial class MaintenanceForm : UserControl {
        public MaintenanceForm() {
            InitializeComponent();
        }
        CustomerForm c;
        StaffForm f;
        ServiceForm s;
        private void mainButtonClicked(object sender, EventArgs e) {
            if (sender.Equals(btnCustomers)) {
                panelMain.Controls.Clear();
                c = new CustomerForm();
                c.Dock = DockStyle.Fill;
                panelMain.Controls.Add(c);
            }
            if (sender.Equals(btnStaff)) {
                panelMain.Controls.Clear();
                f = new StaffForm();
                f.Dock = DockStyle.Fill;
                panelMain.Controls.Add(f);
            }
            if (sender.Equals(btnServices)) {
                panelMain.Controls.Clear();
                s = new ServiceForm();
                s.Dock = DockStyle.Fill;
                panelMain.Controls.Add(s);
            }

        }
    }
}
