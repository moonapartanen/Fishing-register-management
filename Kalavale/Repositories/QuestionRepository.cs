using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalavale.Entities;
using MySql.Data.MySqlClient;

namespace Kalavale.Repositories {
    class QuestionRepository : Repository<Question> {
        public QuestionRepository() : base("kysymykset") { }

        public void AddRange(List<Question> questions, int surveyId) {
            foreach(Question question in questions) {
                using (MySqlCommand cmd = Connection.CreateCommand()) {
                    cmd.CommandText = "INSERT INTO kysymykset (kysely_id, kysymystyyppi_id, kysymysnro, kysymysotsikko) " +
                        "VALUES (@surveyId, @type, @number, @title)";

                    cmd.Parameters.AddWithValue("surveyId", surveyId);
                    cmd.Parameters.AddWithValue("type", question.Type);
                    cmd.Parameters.AddWithValue("number", question.Number);
                    cmd.Parameters.AddWithValue("title", question.Title);

                    cmd.ExecuteNonQuery();
                    question.Id = (int)cmd.LastInsertedId;
                }

                if(question.Type >= 5 && question.Type <= 9) {
                    foreach(Field field in question.Fields) {
                        using (MySqlCommand cmd = Connection.CreateCommand()) {
                            cmd.CommandText = "INSERT INTO kysymys_kentat (kysymys_id, rivi_resurssi_id, sarake_resurssi_id) " +
                                "VALUES (@questionId, @rowResourceId, @columnResourceId)";

                            cmd.Parameters.AddWithValue("questionId", question.Id);
                            cmd.Parameters.AddWithValue("rowResourceId", field.RowResourceId);
                            cmd.Parameters.AddWithValue("columnResourceId", field.ColumnResourceId);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public void Update(Question question) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "UPDATE kysymykset SET kysymysnro = @number, kysymysotsikko = @title WHERE id = @id";
                cmd.Parameters.AddWithValue("number", question.Number);
                cmd.Parameters.AddWithValue("title", question.Title);
                cmd.Parameters.AddWithValue("id", question.Id);

                cmd.ExecuteNonQuery();
            }
        }

        protected override void Map(IDataRecord record, Question entity) {
            entity.Id = (int)record["id"];
            entity.SurveyId = (int)record["kysely_id"];
            entity.Type = (int)record["kysymystyyppi_id"];
            entity.Number = (int)record["kysymysnro"];
            entity.Title = (string)record["kysymysotsikko"];
        }
    }
}
