using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Kalavale.Entities;
using MySql.Data.MySqlClient;

namespace Kalavale.Repositories {
    abstract class Repository<T> where T : EntityBase, new() {
        private readonly string _tableName;

        internal MySqlConnection Connection {
            get {
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySql"].ConnectionString);
                conn.Open();

                return conn;
            }
        }

        public Repository(string tableName) {
            _tableName = tableName;
        }

        public virtual void Remove(int id) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "DELETE FROM " + _tableName + " WHERE id = @id";
                cmd.Parameters.AddWithValue("id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public virtual void Remove(T entity) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "DELETE FROM " + _tableName + " WHERE id = @id";
                cmd.Parameters.AddWithValue("id", entity.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public virtual T GetById(int id) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "SELECT * FROM " + _tableName + " WHERE id = @id";
                cmd.Parameters.AddWithValue("id", id);

                return ToList(cmd).FirstOrDefault();
            }
        }

        public virtual IEnumerable<T> GetAll() {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "SELECT * FROM " + _tableName;

                return ToList(cmd);
            }
        }

        protected virtual IEnumerable<T> ToList(MySqlCommand cmd) {
            using (MySqlDataReader reader = cmd.ExecuteReader()) {
                List<T> items = new List<T>();

                while (reader.Read()) {
                    var item = new T();
                    Map(reader, item);
                    items.Add(item);
                }

                return items;
            }
        }

        protected virtual void Map(IDataRecord record, T entity) { }
    }
}
