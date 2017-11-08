using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalavale.Entities;
using MySql.Data.MySqlClient;

namespace Kalavale.Repositories {
    class FishingAreaRepository : Repository<FishingArea> {
        public FishingAreaRepository() : base("kalastusalueet") { }

        public void Add(FishingArea area) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "INSERT INTO kalastusalueet (nimi, tutkimusalue_id) VALUES (@name, @researchAreaId)";
                cmd.Parameters.AddWithValue("name", area.Name);
                cmd.Parameters.AddWithValue("researchAreaId", area.ResearchAreaId);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(FishingArea area) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "UPDATE kalastusalueet SET nimi = @name, kalastusalue_id = @researchAreaId WHERE id = @id";
                cmd.Parameters.AddWithValue("name", area.Name);
                cmd.Parameters.AddWithValue("researchAreaId", area.ResearchAreaId);
                cmd.Parameters.AddWithValue("id", area.Id);

                cmd.ExecuteNonQuery();
            }
        }

        protected override void Map(IDataRecord record, FishingArea entity) {
            entity.Id = (int)record["id"];
            entity.Name = (string)record["nimi"];
            entity.ResearchAreaId = (int)record["tutkimusalue_id"];
        }
    }
}
