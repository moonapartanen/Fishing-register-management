using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
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

        protected virtual IEnumerable<T> ToList(MySqlCommand cmd) {
            using(MySqlDataReader reader = cmd.ExecuteReader()) {
                List<T> items = new List<T>();

                while (reader.Read()) {
                    var item = new T();
                    Map(reader, item);
                    items.Add(item);
                }

                return items;
            }
        }

        public void Remove(int id) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "DELETE FROM @tableName WHERE id = @id";
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("tableName", _tableName);

                cmd.ExecuteNonQuery();
            }
        }

        public virtual T GetById(int id) {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "SELECT * FROM @tableName WHERE id = @id";
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("tableName", _tableName);

                MySqlDataReader reader = cmd.ExecuteReader();

                var item = new T();

                reader.Read();
                Map(reader, item);

                return item;
            }
        }

        public virtual IEnumerable<T> GetAll() {
            using (MySqlCommand cmd = Connection.CreateCommand()) {
                cmd.CommandText = "SELECT * FROM @tableName";
                cmd.Parameters.AddWithValue("tableName", _tableName);

                return ToList(cmd);
            }
        }

        protected abstract void Map(IDataRecord record, T entity);
    }
}
