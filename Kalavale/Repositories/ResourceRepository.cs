using System.Collections.Generic;
using System.Data;
using Kalavale.Entities;
using MySql.Data.MySqlClient;

namespace Kalavale.Repositories {
    class ResourceRepository : Repository<Resource> {
        public ResourceRepository() : base("resurssit") { }

        public void Add(Resource resource) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "INSERT INTO resurssit (id, nimi, resurssityyppi_id) VALUES (@id, @name, @type) "+
                    "ON DUPLICATE KEY UPDATE nimi=@name, resurssityyppi_id=@type";

                cmd.Parameters.AddWithValue("id", resource.Id);
                cmd.Parameters.AddWithValue("name", resource.Name);
                cmd.Parameters.AddWithValue("type", resource.Type);

                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Resource> GetByType(int type) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "SELECT * FROM resurssit WHERE resurssityyppi_id = @type";
                cmd.Parameters.AddWithValue("type", type);

                return ToList(cmd);
            }
        }

        protected override void Map(IDataRecord record, Resource entity) {
            entity.Id = (int)record["id"];
            entity.Name = record["nimi"].ToString();
            entity.Type = (int)record["resurssityyppi_id"];
        }
    }
}
