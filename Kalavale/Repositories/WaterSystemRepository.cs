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
                cmd.CommandText = "INSERT INTO vesistot (nimi) VALUES (@name)";
                cmd.Parameters.AddWithValue("name", ws.Name);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(WaterSystem ws) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "UPDATE vesistot SET nimi = @name WHERE id = @id";
                cmd.Parameters.AddWithValue("name", ws.Name);
                cmd.Parameters.AddWithValue("id", ws.Id);

                cmd.ExecuteNonQuery();
            }
        }

        protected override void Map(IDataRecord record, WaterSystem entity) {
            entity.Id = (int)record["id"];
            entity.Name = (string)record["nimi"];
        }
    }
}
