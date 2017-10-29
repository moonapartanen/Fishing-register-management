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

        private void Insert(string query) {
            try {
                using (MySqlConnection conn = new MySqlConnection(connString)) {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                        cmd.ExecuteNonQuery();
                    }
                }
            } catch (MySqlException e) {
                MessageBox.Show(e.Message);
            }
        }

        private long InsertWithOutput(string query) {
            try {
                using (MySqlConnection conn = new MySqlConnection(connString)) {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                        cmd.ExecuteNonQuery();

                        return cmd.LastInsertedId;
                    }
                }
            } catch (MySqlException e) {
                MessageBox.Show(e.Message);
            }

            return -1;
        }

        public DataTable getResourcesByType(int type) {
            return Select("SELECT * FROM resurssit AS r INNER JOIN resurssityypit AS rt ON r.resurssityyppi_id = rt.id WHERE rt.id = " + type);
        }

        public DataTable getQuestionTypes() {
            return Select("SELECT * FROM kysymystyypit");
        }

        //TODO: tämä viritys oikeaksi ratkaisuksi
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
