using MySqlConnector;
using UserAdmin.Models;

namespace UserAdmin.Services
{
    class UserDbService
    {
        public string ConnectionString = "Server=localhost;Database=useradmin;User=root;Password=;";

        public void Add(User user)
        {
            using var connection = new MySqlConnection(ConnectionString);
            connection.Open();

            string sql = @"INSERT INTO `users`(`username`, `email`, `password`, `registeredAt`) 
VALUES (@Username,@Email,@Password,@RegisteredAt)";

            connection.Close();
        }
    }
}
