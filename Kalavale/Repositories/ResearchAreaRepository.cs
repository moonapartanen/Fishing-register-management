using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalavale.Entities;
using MySql.Data.MySqlClient;

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

        protected override void Map(IDataRecord record, ResearchArea entity) {
            entity.Id = (int)record["id"];
            entity.Name = (string)record["nimi"];
        }
    }
}
