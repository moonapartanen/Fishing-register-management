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

        public DataTable Select(string query) {
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

        public DataTable getUsers()
        {
            return Select("SELECT kayttajat.id, kayttajat.nimi, kayttajat.osoite, kayttajat.postinumero, kayttajat.toimipaikka, tutkimusalueet.nimi FROM kayttajat INNER JOIN tutkimusalueet ON kayttajat.tutkimusalue_id = tutkimusalueet.id");
        }

        public DataTable getWaterSystems()
        {
            return Select("SELECT id, nimi FROM vesistot");
        }

        public DataTable getResources() {
            return Select("SELECT id, nimi, resurssityyppi_id FROM resurssit");
        }

        public DataTable getResearchAreas() {
            return Select("SELECT tutkimusalueet.id, tutkimusalueet.nimi, vesistot.nimi FROM tutkimusalueet INNER JOIN vesistot ON tutkimusalueet.vesisto_id = vesistot.id");
        }

        public DataTable getFishingAreas()
        {
            return Select("SELECT kalastusalueet.id, kalastusalueet.nimi, tutkimusalueet.nimi FROM kalastusalueet INNER JOIN tutkimusalueet ON kalastusalueet.tutkimusalue_id = tutkimusalueet.id");
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


        // TIETOKANNAN HALLINTAA

        public void updateResources(int id, string name)
        {
            ExecNonQuery("UPDATE resurssit SET nimi = '" + name + "' WHERE id = " + id);
        }

        public void updateWaterSystems(int id, string name)
        {
            ExecNonQuery("UPDATE vesistot SET nimi = '" + name + "' WHERE id = " + id);
        }

        public void updateResearchAreas(int id, string name, int waterSystemsId)
        {
            ExecNonQuery("UPDATE tutkimusalueet SET nimi = '" + name + "', vesisto_id = " + waterSystemsId + " WHERE id = " + id);
        }

        public void updateFishingAreas(int id, string name, int researchAreaId)
        {
            ExecNonQuery("UPDATE kalastusalueet SET nimi = '" + name + "', tutkimusalue_id = " + researchAreaId + " WHERE id = " + id);
        }

        public void updateUsers(int id, string name, string address, string postalCode, string city, int researchAreaId)
        {
            ExecNonQuery("UPDATE kayttajat SET nimi = '" + name + "', osoite = '" + address + "', postinumero = '" + postalCode + "', toimipaikka = '" + city + "', tutkimusalue_id = " + researchAreaId + " WHERE id = " + id);
        }

        public void insertResources(string name, int resourceType)
        {
            ExecNonQuery("INSERT INTO resurssit (nimi, resurssityyppi_id) VALUES ('" + name + "'," + resourceType + ")");
        }

        public void insertWaterSystems(string name)
        {
            ExecNonQuery("INSERT INTO vesistot (nimi) VALUES ('" + name + "')");
        }

        public void insertFishingAreas(string name, int researchAreaId)
        {
            ExecNonQuery("INSERT INTO kalastusalueet (nimi, tutkimusalue_id) VALUES ('" + name + "', " + researchAreaId + ")");
        }

        public void insertResearchAreas(string name, int waterSystemsId)
        {
            ExecNonQuery("INSERT INTO tutkimusalueet (nimi, vesisto_id) VALUES ('" + name + "', " + waterSystemsId + ")");
        }

        public void insertUsers(string name, string address, string postalCode, string city, int researchAreaId, string key)
        {
            ExecNonQuery("INSERT INTO kayttajat (nimi, osoite, postinumero, toimipaikka, vastausavain, tutkimusalue_id) VALUES ('" + name + "', '" + address + "', '" + postalCode + "', '" + city + "', '" + key + "', " + researchAreaId + ")");
        }

        public void deleteFromDatabase(int id, string table)
        {
            ExecNonQuery("DELETE FROM " + table + " WHERE id = " + id);
        }
    }
}
