using System.Collections.Generic;
using System.Data;
using System.Linq;
using Kalavale.Entities;
using MySql.Data.MySqlClient;

namespace Kalavale.Repositories {
    class SurveyRepository : Repository<Survey> {
        public SurveyRepository() : base("kyselyt") { }

        public void Add(Survey survey) {
            using (MySqlTransaction tr = Connection.BeginTransaction()) {
                using (MySqlCommand cmd = tr.Connection.CreateCommand()) {
                    cmd.CommandText = "INSERT INTO kyselyt (id, nimi, luontipvm) VALUES (@id, @name, @creationDate) " +
                        "ON DUPLICATE KEY UPDATE nimi=@name, luontipvm=@creationDate";

                    cmd.Parameters.AddWithValue("id", survey.Id);
                    cmd.Parameters.AddWithValue("name", survey.Name);
                    cmd.Parameters.AddWithValue("creationDate", survey.CreationDate);

                    cmd.Transaction = tr;
                    cmd.ExecuteNonQuery();

                    if (survey.Id == null) survey.Id = (int?)cmd.LastInsertedId;
                }

                foreach (Question question in survey.Questions) {
                    using (MySqlCommand cmd = tr.Connection.CreateCommand()) {
                        cmd.CommandText = "INSERT INTO kysymykset (id, kysely_id, kysymystyyppi_id, kysymysnro, kysymysotsikko) " +
                            "VALUES (@id, @surveyId, @type, @number, @title) " +
                            "ON DUPLICATE KEY UPDATE kysymystyyppi_id = @type, kysymysnro = @number, kysymysotsikko = @title";

                        cmd.Parameters.AddWithValue("id", question.Id);
                        cmd.Parameters.AddWithValue("surveyId", survey.Id);
                        cmd.Parameters.AddWithValue("type", question.Type);
                        cmd.Parameters.AddWithValue("number", question.Number);
                        cmd.Parameters.AddWithValue("title", question.Title);

                        cmd.Transaction = tr;
                        cmd.ExecuteNonQuery();

                        if (question.Id == null) question.Id = (int?)cmd.LastInsertedId;
                    }

                    if (question.Type >= 5 && question.Type <= 9) {

                        using (MySqlCommand cmd = tr.Connection.CreateCommand()) {
                            cmd.CommandText = "DELETE FROM kysymys_kentat WHERE kysymys_id = @id";
                            cmd.Parameters.AddWithValue("id", question.Id);

                            cmd.ExecuteNonQuery();
                        }

                        foreach (Field field in question.Fields) {
                            using (MySqlCommand cmd = tr.Connection.CreateCommand()) {
                                cmd.CommandText = "INSERT INTO kysymys_kentat (kysymys_id, rivi_resurssi_id, sarake_resurssi_id) " +
                                    "VALUES (@questionId, @rowResourceId, @columnResourceId)";

                                cmd.Parameters.AddWithValue("questionId", question.Id);
                                cmd.Parameters.AddWithValue("rowResourceId", field.RowResourceId);
                                cmd.Parameters.AddWithValue("columnResourceId", field.ColumnResourceId);

                                cmd.Transaction = tr;
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                tr.Commit();
            }
        }

        public override Survey GetById(int id) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "SELECT * FROM kyselyt WHERE kysely_id = @id";
                cmd.Parameters.AddWithValue("id", id);

                return ToList(cmd).FirstOrDefault();
            }
        }

        public IEnumerable<Survey> GetByResearchArea(int id) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "SELECT * FROM kyselyt k INNER JOIN tutkimusalue_kyselyt tk ON k.id = tk.kysely_id " +
                    "WHERE tk.tutkimusalue_id = @id";

                cmd.Parameters.AddWithValue("id", id);

                return ToList(cmd);
            }
        }

        protected override IEnumerable<Survey> ToList(MySqlCommand sCmd) {
            List<Survey> surveys = new List<Survey>();

            using (MySqlDataReader reader = sCmd.ExecuteReader()) {
                while (reader.Read()) {
                    Survey survey = new Survey();
                    Map(reader, survey);
                    surveys.Add(survey);
                }
            }

            foreach (Survey survey in surveys) {
                using (MySqlCommand qCmd = Connection.CreateCommand()) {
                    qCmd.CommandText = "SELECT * FROM kysymykset WHERE kysely_id = @id;";
                    qCmd.Parameters.AddWithValue("id", survey.Id);

                    using (MySqlDataReader reader = qCmd.ExecuteReader()) {
                        while (reader.Read()) {
                            Question question = new Question();
                            Map(reader, question);
                            survey.Questions.Add(question);
                        }
                    }
                }

                foreach (Question question in survey.Questions) {
                    if (question.Type >= 5 && question.Type <= 9) {
                        using (MySqlCommand fCmd = Connection.CreateCommand()) {
                            fCmd.CommandText = "SELECT * FROM kysymys_kentat WHERE kysymys_id = @id;";
                            fCmd.Parameters.AddWithValue("id", question.Id);

                            using (MySqlDataReader reader = fCmd.ExecuteReader()) {
                                while (reader.Read()) {
                                    Field field = new Field();
                                    Map(reader, field);
                                    question.Fields.Add(field);
                                }
                            }
                        }
                    }
                }
            }

            return surveys;
        }

        protected override void Map(IDataRecord record, Survey survey) {
            survey.Id = (int)record["id"];
            survey.Name = record["nimi"].ToString();
            survey.CreationDate = record["luontipvm"].ToString();
        }

        protected void Map(IDataRecord record, Question question) {
            question.Id = (int)record["id"];
            question.SurveyId = (int)record["kysely_id"];
            question.Number = (int)record["kysymysnro"];
            question.Title = record["kysymysotsikko"].ToString();
            question.Type = (int)record["kysymystyyppi"];
        }

        protected void Map(IDataRecord record, Field field) {
            field.QuestionId = (int)record["kysymys_id"];
            field.RowResourceId = (int)record["rivi_resurssi_id"];
            field.ColumnResourceId = (int)record["sarake_resurssi_id"];
        }
    }
}
