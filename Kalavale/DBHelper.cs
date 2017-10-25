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

        private DataTable Select(string query) {
            DataTable dt = new DataTable();

            try {
                using (MySqlConnection conn = new MySqlConnection(connString)) {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn)) {
                        adapter.Fill(dt);
                    }
                }
            } catch (MySqlException e) {
                MessageBox.Show(e.Message);
            }

            return dt;
        }

        public DataTable getResourcesByType(int type) {
            return Select("SELECT * FROM resurssit INNER JOIN tyypit ON resurssit.tyyppi_id = tyypit.id WHERE tyypit.id ='" + type + "'");
        }

        public DataTable getWaterSystems() {
            return Select("SELECT * FROM vesistot");
        }

        public DataTable getFishingAreas(int id) {
            return Select("SELECT * FROM kalastusalueet WHERE vesisto_id = '" + id + "'");
        }

        public DataTable getQuestionTypes() {
            return Select("SELECT * FROM kysymystyypit");
        }
    }
}
