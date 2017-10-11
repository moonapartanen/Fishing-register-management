using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Kalavale
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public string dbmFishQuery = "SELECT name FROM fishes";
        public string dbmMethodQuery = "SELECT name FROM methods";
        public string dbmUserQuery = "SELECT username FROM users";

        public DBConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "fishingregister";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Ei yhteyttä tietokantaan.");
                        break;

                    case 1045:
                        MessageBox.Show("Väärät käyttäjätunnukset tietokantaan, yritä uudelleen!");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public System.Data.DataTable Select(string query)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            return dt;
        }

        public void ManageDatabase(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Exit()
        {
            this.CloseConnection(); // TÄMÄ PITÄÄ TEHDÄ OHJELMAN SULKEUDUTTUA
        }
    }
}
