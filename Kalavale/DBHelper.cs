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

        // TODO: kaikki kyselyt pitää parametrisoida!!
        // TODO: pitää kehittää ORM tyylinen ratkaisu datatablen palauttamisen sijasta

        string connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        public DBHelper() {
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

        private void ExecNonQuery(string query) {
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

        public DataTable getResources() {
            return Select("SELECT id, nimi, resurssityyppi_id FROM resurssit");
        }

        public DataTable getResearchAreas() {
            return Select("SELECT id, nimi FROM tutkimusalueet");
        }

        public DataTable getQuestionTypes() {
            return Select("SELECT id, nimi FROM kysymystyypit");
        }

        public DataTable getSurveys() {
            return Select("SELECT id, nimi, luontipvm FROM kyselyt");
        }

        public DataTable getSurveysByRAId(int id) {
            return Select("SELECT id, nimi FROM kyselyt k" +
                " INNER JOIN tutkimusalue_kyselyt tk ON k.id = tk.kysely_id" + 
                " WHERE tk.tutkimusalue_id = " + id);
        }

        public void deleteSurveyById(int id) {
            // TODO: pitää poistaa kyselyyn liittyvät kysymykset ja vastaukset
            ExecNonQuery("DELETE FROM kyselyt WHERE id = " + id);
        }

        public void deleteRASurvey(int surveyId, int researchAreaId) {
            // TODO: pitääko poistaa tähän kalastusaluekohtaiseen kyselyyn liittyvät vastaukset?
            ExecNonQuery("DELETE FROM tutkimusalue_kyselyt WHERE kysely_id = " + surveyId + " AND tutkimusalue_id = " + researchAreaId);
        }

        public void addSurveyToRA(int researchAreaId, int surveyId, string date) {
            ExecNonQuery("INSERT INTO tutkimusalue_kyselyt (tutkimusalue_id, kysely_id, kyselypvm)" +
                            " VALUES (" + researchAreaId + ", " + surveyId + ", '" + date + "')");
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
                            ExecNonQuery("INSERT INTO kysymys_kentat (kysymys_id, sarake_resurssi_id, rivi_resurssi_id)" +
                                " VALUES (" + questionId + ", " + j + ", " + i + ")");
                        }
                    }
                } else if (q.Type <= 9) {
                    foreach (int i in q.Rows) {
                        ExecNonQuery("INSERT INTO kysymys_kentat (kysymys_id, sarake_resurssi_id)" +
                                " VALUES (" + questionId + ", " + i + ")");
                    }
                }
            }
        }
    }
}
