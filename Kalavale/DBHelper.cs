using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace Kalavale {
    class DBHelper {
        //connectionstring app.configissa
        private string connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        public DBHelper() {
        }

        public DataTable getResourcesByType(int idx) {
            DataTable dt = new DataTable();
            string queryString = "";

            switch (idx) {
                case 0:
                    queryString = "SELECT nimi FROM kalat";
                    break;
                case 1:
                    queryString = "SELECT nimi FROM pyydykset";
                    break;
                case 2:
                    queryString = "SELECT nimi FROM kayttajat";
                    break;
            }

            try {
                using (MySqlConnection conn = new MySqlConnection(connString)) {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, conn)) {
                        adapter.Fill(dt);
                    }
                }
            }catch(MySqlException e) {
                MessageBox.Show(e.Message);
            }
            
            return dt;
        }

        /*public void ManageDatabase(string query) {
            if (this.OpenConnection() == true) {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }*/
    }
}
