using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem {
    static class Program {
        static private MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password = kenneth02;database=laundrydb");

        public static MySqlConnection Con {
            get {
                return con;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            con.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
