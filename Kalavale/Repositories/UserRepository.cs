using System.Data;
using Kalavale.Entities;
using MySql.Data.MySqlClient;

namespace Kalavale.Repositories {
    class UserRepository : Repository<User> {
        public UserRepository() : base("kayttajat") { }

        public void Add(User user) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "INSERT INTO kayttajat (id, nimi, osoite, postinumero, toimipaikka, vastausavain, tutkimusalue_id) " +
                    "VALUES (@id, @name, @address, @zip, @city, @key, @researchAreaId) " +
                    "ON DUPLICATE KEY UPDATE nimi = @name, osoite = @address, postinumero = @zip, " +
                    "toimipaikka = @city, vastausavain = @key, tutkimusalue_id = @researchAreaId ";

                cmd.Parameters.AddWithValue("id", user.Id);
                cmd.Parameters.AddWithValue("name", user.Name);
                cmd.Parameters.AddWithValue("address", user.Address);
                cmd.Parameters.AddWithValue("zip", user.Zip);
                cmd.Parameters.AddWithValue("city", user.City);
                cmd.Parameters.AddWithValue("key", user.Key);
                cmd.Parameters.AddWithValue("researchAreaId", user.ResearchAreaId);

                cmd.ExecuteNonQuery();
            }
        }

        protected override void Map(IDataRecord record, User entity) {
            entity.Id = (int)record["id"];
            entity.Name = record["nimi"].ToString();
            entity.Address = record["osoite"].ToString();
            entity.Zip = record["postinumero"].ToString();
            entity.City = record["toimipaikka"].ToString();
            entity.Key = record["vastausavain"].ToString();
            entity.ResearchAreaId = (int)record["tutkimusalue_id"];
        }
    }
}
