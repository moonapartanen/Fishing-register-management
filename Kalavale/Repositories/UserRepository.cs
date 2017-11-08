using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalavale.Entities;
using MySql.Data.MySqlClient;

namespace Kalavale.Repositories {
    class UserRepository : Repository<User> {
        public UserRepository() : base("kayttajat") { }

        public void Add(User user) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "INSERT INTO kayttajat (nimi, osoite, postinumero, toimipaikka, vastausavain, tutkimusalue_id) " +
                    "VALUES (@name, @address, @zip, @city, @key, @researchAreaId)";

                cmd.Parameters.AddWithValue("name", user.Name);
                cmd.Parameters.AddWithValue("address", user.Address);
                cmd.Parameters.AddWithValue("zip", user.Zip);
                cmd.Parameters.AddWithValue("city", user.City);
                cmd.Parameters.AddWithValue("key", user.Key);
                cmd.Parameters.AddWithValue("researchAreaId", user.ResearchAreaId);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(User user) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "UPDATE kayttajat SET nimi = @name, osoite = @address, postinumero = @zip, "
                    + "toimipaikka = @city, tutkimusalue_id = @researchAreaId WHERE id = @id";

                cmd.Parameters.AddWithValue("name", user.Name);
                cmd.Parameters.AddWithValue("address", user.Address);
                cmd.Parameters.AddWithValue("zip", user.Zip);
                cmd.Parameters.AddWithValue("city", user.City);
                cmd.Parameters.AddWithValue("key", user.Key);
                cmd.Parameters.AddWithValue("researchAreaId", user.ResearchAreaId);
                cmd.Parameters.AddWithValue("id", user.Id);

                cmd.ExecuteNonQuery();
            }
        }

        protected override void Map(IDataRecord record, User entity) {
            entity.Id = (int)record["id"];
            entity.Name = (string)record["nimi"];
            entity.Address = (string)record["osoite"];
            entity.Zip = (string)record["postinumero"];
            entity.City = (string)record["toimipaikka"];
            entity.Key = (string)record["vastausavain"];
            entity.ResearchAreaId = (int)record["tutkimusalue_id"];
        }
    }
}
