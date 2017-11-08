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
                cmd.CommandText = "INSERT INTO tutkimusalueet (nimi, vesisto_id) VALUES (@name, @waterSystemId)";
                cmd.Parameters.AddWithValue("name", rs.Name);
                cmd.Parameters.AddWithValue("waterSystemId", rs.WaterSystemId);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(ResearchArea rs) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "UPDATE tutkimusalueet SET nimi = @name, vesisto_id = @WaterSystemId WHERE id = @id";
                cmd.Parameters.AddWithValue("name", rs.Name);
                cmd.Parameters.AddWithValue("waterSystemId", rs.WaterSystemId);
                cmd.Parameters.AddWithValue("id", rs.Id);

                cmd.ExecuteNonQuery();
            }
        }

        protected override void Map(IDataRecord record, ResearchArea entity) {
            entity.Id = (int)record["id"];
            entity.Name = (string)record["nimi"];
        }
    }
}
