using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem.Forms.Transaction {
    public partial class TransactionForm : UserControl {
        public TransactionForm() {
            InitializeComponent();
            t = new TransactionAddingForm();
            t.Dock = DockStyle.Fill;
            panelMain.Controls.Add(t);
        }
        TransactionAddingForm t;
        TransactionEditingForm te;
        private void btnAddClick(object sender, EventArgs e) {
            panelMain.Controls.Clear();
            t = new TransactionAddingForm();
            t.Dock = DockStyle.Fill;
            panelMain.Controls.Add(t);
        }

        private void btnEditClick(object sender, EventArgs e) {
            panelMain.Controls.Clear();
            te = new TransactionEditingForm();
            te.Dock = DockStyle.Fill;
            panelMain.Controls.Add(te);
        }
    }
}
