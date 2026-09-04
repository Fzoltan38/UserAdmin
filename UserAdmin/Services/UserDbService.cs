using MySqlConnector;
using UserAdmin.Models;

namespace UserAdmin.Services
{
    class UserDbService
    {
        public string ConnectionString = "Server=localhost;Database=useradmin;User=root;Password=;";

        public void Add(User user)
        {
            var connection = new MySqlConnection(ConnectionString);
            connection.Open();

            string sql = "";

            connection.Close();
        }
    }
}
