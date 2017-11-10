using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalavale.Entities;
using MySql.Data.MySqlClient;

namespace Kalavale.Repositories {
    class WaterSystemRepository : Repository<WaterSystem> {
        public WaterSystemRepository() : base("vesistot") { }

        public void Add(WaterSystem ws) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "INSERT INTO vesistot (id, nimi) VALUES (@id, @name) " +
                    "ON DUPLICATE KEY UPDATE nimi=@name";

                cmd.Parameters.AddWithValue("id", ws.Id);
                cmd.Parameters.AddWithValue("name", ws.Name);

                cmd.ExecuteNonQuery();
            }
        }

        protected override void Map(IDataRecord record, WaterSystem entity) {
            entity.Id = (int)record["id"];
            entity.Name = (string)record["nimi"];
        }
    }
}
