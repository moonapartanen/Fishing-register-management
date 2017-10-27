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

            switch (type)
            {
                case 4: 
                    return Select("SELECT kayttajat.id, kayttajat.username, kayttajat.password, kayttajat.osoite, kayttajat.toimipaikka, kayttajat.postinumero, kalastusalueet.nimi FROM kayttajat INNER JOIN kalastusalueet ON kayttajat.kalastusalue_id = kalastusalueet.id");
                case 5:
                    return getWaterSystems();
                case 6:
                    return Select("SELECT kalastusalueet.id, kalastusalueet.nimi, vesistot.nimi FROM kalastusalueet INNER JOIN vesistot ON kalastusalueet.vesisto_id = vesistot.id");
                default:
                    return Select("SELECT * FROM resurssit INNER JOIN tyypit ON resurssit.tyyppi_id = tyypit.id WHERE tyypit.id ='" + type + "'");
            }
           
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
