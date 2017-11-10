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
                cmd.CommandText = "INSERT INTO kalastusalueet (id, nimi, tutkimusalue_id) VALUES (@id, @name, @researchAreaId) " +
                    "ON DUPLICATE KEY UPDATE nimi=@name, tutkimusalue_id=@researchAreaId";

                cmd.Parameters.AddWithValue("id", area.Id);
                cmd.Parameters.AddWithValue("name", area.Name);
                cmd.Parameters.AddWithValue("researchAreaId", area.ResearchAreaId);

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
