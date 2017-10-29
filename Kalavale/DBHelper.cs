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
        string connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        DataTable _resources, _questionTypes;

        public DBHelper() {
            _resources = Select("SELECT id, nimi, resurssityyppi_id FROM resurssit");
            _questionTypes = Select("SELECT id, nimi FROM kysymystyypit");
        }

        private DataTable Select(string query) {
            using (MySqlConnection conn = new MySqlConnection(connString))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            using(DataTable dt = new DataTable()) {
                try {
                    adapter.Fill(dt);
                } catch (MySqlException e) {
                    MessageBox.Show(e.Message);
                }

                return dt;
            }
        }

        private void Insert(string query) {
            using (MySqlConnection conn = new MySqlConnection(connString)) 
            using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                try {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                } catch (MySqlException e) {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private long InsertWithOutput(string query) {
            using (MySqlConnection conn = new MySqlConnection(connString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                try {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                } catch (MySqlException e) {
                    MessageBox.Show(e.Message);
                }

                return cmd.LastInsertedId;
            }
        }

        public DataTable getUsers() {
            return Select("SELECT id, nimi, osoite, postinumero, toimipaikka");
        }

        public DataTable getResourcesByType(int type) {
            return _resources.Select("resurssityyppi_id = " + type).CopyToDataTable();
        }

        public DataTable getQuestionTypes() {
            return _questionTypes;
        }

        //TODO: tämä viritys
        public void saveSurvey(Survey s) {
            long surveyId = InsertWithOutput("INSERT INTO kyselyt (nimi, luontipvm) VALUES ('" + s.Name + "', '" + s.CreationDate + "')");

            foreach(Question q in s.Questions) {
                long questionId = InsertWithOutput("INSERT INTO kysymykset (kysely_id, kysymystyyppi_id, kysymysnro, kysymysotsikko)" +
                    " VALUES (" + surveyId + ", " + q.Type + ", " + q.Number + ", '" + q.Title + "')");

                if (q.Type == 5) {
                    foreach (int i in q.Rows) {
                        foreach (int j in q.Columns) {
                            Insert("INSERT INTO kysymys_kentat (kysymys_id, sarake_resurssi_id, rivi_resurssi_id)" +
                                " VALUES (" + questionId + ", " + j + ", " + i + ")");
                        }
                    }
                } else if (q.Type <= 9) {
                    foreach (int i in q.Rows) {
                        Insert("INSERT INTO kysymys_kentat (kysymys_id, sarake_resurssi_id)" +
                                " VALUES (" + questionId + ", " + i + ")");
                    }
                }
            }
        }
    }
}
