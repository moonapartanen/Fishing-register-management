using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalavale.Entities;
using MySql.Data.MySqlClient;

namespace Kalavale.Repositories {
    class ResourceRepository : Repository<Resource> {
        public ResourceRepository() : base("resurssit") { }

        public void Add(Resource resource) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "INSERT INTO resurssit (nimi, resurssityyppi_id) VALUES (@name, @type)";
                cmd.Parameters.AddWithValue("name", resource.Name);
                cmd.Parameters.AddWithValue("type", resource.Type);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Resource resource) {
            using(MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "UPDATE resurssit SET nimi = @name WHERE id = @id";
                cmd.Parameters.AddWithValue("name", resource.Name);
                cmd.Parameters.AddWithValue("id", resource.Id);

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
            entity.Name = (string)record["nimi"];
            entity.Type = (int)record["resurssityyppi_id"];
        }
    }
}
