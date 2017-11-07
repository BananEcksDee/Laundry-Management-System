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
    public partial class StaffForm : UserControl {
        public StaffForm() {
            InitializeComponent();
            con = Program.Con;
            if (con.State != ConnectionState.Open) {
                con.Open();
            }
            MySqlDataAdapter a = new MySqlDataAdapter(
            "SELECT * from tblstaff", con);
            DataTable t = new DataTable();
            a.Fill(t);
            staffTable.DataSource = t;
        }
        MySqlConnection con;
        StaffEditingForm s;
        private void mainButtonClick(object sender, EventArgs e) {
            if (sender.Equals(btnAdd)) {
                panel2.Controls.Clear();
                s = new StaffEditingForm();
                panel2.Controls.Add(s);
                s.Dock = DockStyle.Fill;
            }
            if (sender.Equals(btnEdit)) {
                int selectedRowCount = staffTable.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0) {
                    DataGridViewRow r = staffTable.SelectedRows[0];
                    Staff.StaffMode mode = Staff.StaffMode.Encoder;
                    if (r.Cells[11].Value.ToString().Equals("Admin")) {
                        mode = Staff.StaffMode.Admin;
                    }
                    Staff.StaffStatus status = Staff.StaffStatus.Active;
                    if (r.Cells[12].Value.ToString().Equals("Inactive")) {
                        status = Staff.StaffStatus.Inactive;
                    }
                    Staff staff = new Staff(
                        r.Cells[0].Value.ToString(),
                        r.Cells[1].Value.ToString(),
                        r.Cells[2].Value.ToString(),
                        r.Cells[3].Value.ToString(),
                        r.Cells[4].Value.ToString(),
                        r.Cells[5].Value.ToString(),
                        r.Cells[6].Value.ToString(),
                        r.Cells[7].Value.ToString(),
                        r.Cells[8].Value.ToString(),
                        r.Cells[9].Value.ToString(),
                        r.Cells[10].Value.ToString(),
                        mode,
                        status);
                    panel2.Controls.Clear();
                    s = new StaffEditingForm(staff);
                    panel2.Controls.Add(s);
                    s.Dock = DockStyle.Fill;
                }
                
            }
        }


    }
}
