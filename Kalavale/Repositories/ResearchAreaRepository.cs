using System.Data;
using Kalavale.Entities;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Kalavale.Repositories {
    class ResearchAreaRepository : Repository<ResearchArea> {
        public ResearchAreaRepository() : base("tutkimusalueet") { }

        public void Add(ResearchArea rs) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "INSERT INTO tutkimusalueet (id, nimi, vesisto_id) VALUES (@id, @name, @waterSystemId) " +
                    "ON DUPLICATE KEY UPDATE nimi=@name, vesisto_id=@waterSystemId";

                cmd.Parameters.AddWithValue("id", rs.Id);
                cmd.Parameters.AddWithValue("name", rs.Name);
                cmd.Parameters.AddWithValue("waterSystemId", rs.WaterSystemId);

                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<ResearchArea> GetByWaterSystem(WaterSystem ws) {
            using(MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "SELECT * FROM tutkimusalueet WHERE vesisto_id = @id";
                cmd.Parameters.AddWithValue("id", ws.Id);

                return ToList(cmd);
            }
        }

        protected override void Map(IDataRecord record, ResearchArea entity) {
            entity.Id = (int)record["id"];
            entity.WaterSystemId = (int)record["vesisto_id"];
            entity.Name = record["nimi"].ToString();
        }
    }
}
