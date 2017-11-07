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
    public partial class ServiceForm : UserControl {
        public ServiceForm() {
            InitializeComponent();
            FillData();
        }
        MySqlConnection con;
        ServiceEditingForm s;
        void FillData() {
            string query = "SELECT DISTINCT `tblservice`.`strServiceID` AS `strServiceID`,`tblservice`.`strServiceName` AS `strServiceName`,`tblserviceprices`.`dblServicePrice` AS `dblServicePrice`,`tblcategory`.`strCategoryName` AS `strCategoryName`,`tblcategory`.`enumCategoryUnit` AS `enumCategoryUnit` FROM((`tblcategory` JOIN `tblservice` ON ((`tblcategory`.`strCategoryID` = `tblservice`.`strServiceCategoryID`))) JOIN `tblserviceprices` ON ((`tblservice`.`strServiceID` = `tblserviceprices`.`strServiceID`)))" +
                "WHERE tblserviceprices.dtmServiceDateOf IN(SELECT MAX(dtmServiceDateOf) FROM tblserviceprices GROUP BY strServiceID)";
            using (con = Program.Con) {
                using (MySqlDataAdapter a = new MySqlDataAdapter(
            query, con)) {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    servicesTable.DataSource = t;
                }
            }
        }
        private void btnClick(object sender, EventArgs e) {
            if (sender.Equals(btnAdd)) {
                panel2.Controls.Clear();
                s = new ServiceEditingForm();
                s.Dock = DockStyle.Fill;
                panel2.Controls.Add(s);
            }
            if (sender.Equals(btnEdit)) {
                int selectedRowCount = servicesTable.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0) {
                    DataGridViewRow d = servicesTable.SelectedRows[0];
                    Service service = new Service();
                    service.ID = d.Cells[0].Value.ToString();
                    service.Name = d.Cells[1].Value.ToString();
                    service.Price =  double.Parse(d.Cells[2].Value.ToString()) ;
                    service.Category = d.Cells[3].Value.ToString();
                    Service.CategoryUnit unit = Service.CategoryUnit.kg;
                    if (d.Cells[4].Value.Equals("pcs")) {
                        unit = Service.CategoryUnit.kg;
                    }
                    service.Unit = unit;
                    panel2.Controls.Clear();
                    s = new ServiceEditingForm(service);
                    s.Dock = DockStyle.Fill;
                    panel2.Controls.Add(s);
                }
            }
        }
    }
}
