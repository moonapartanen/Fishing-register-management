using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalavale.Entities;
using MySql.Data.MySqlClient;

namespace Kalavale.Repositories {
    class SurveyRepository : Repository<Survey> {
        public SurveyRepository() : base("kyselyt") { }

        public void Add(Survey survey) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "INSERT INTO kyselyt (id, nimi, luontipvm) VALUES (@id, @name, @creationDate) " +
                    "ON DUPLICATE KEY UPDATE nimi=@name, luontipvm=@creationDate";

                cmd.Parameters.AddWithValue("id", survey.Id);
                cmd.Parameters.AddWithValue("name", survey.Name);
                cmd.Parameters.AddWithValue("creationDate", survey.CreationDate);

                cmd.ExecuteNonQuery();
                survey.Id = (int)cmd.LastInsertedId;
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

        protected override void Map(IDataRecord record, Survey entity) {
            entity.Id = (int)record["id"];
            entity.Name = record["nimi"].ToString();
            entity.CreationDate = record["luontipvm"].ToString();
        }
    }
}
