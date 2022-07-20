using BookRental.Entities;
using BookRental.Repository.Interfaces;
using Dapper;
using MySql.Data.MySqlClient;

namespace BookRental.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IConfiguration _config;
        private readonly ILogger<UserRepository> _logger;
        private readonly string _connection;

        public UserRepository(IConfiguration config, ILogger<UserRepository> logger)
        {
            _config = config;
            _logger = logger;
            _connection = _config.GetConnectionString("DefaultConnection");
        }

        public async Task<bool> InsertUserAsync(User user)
        {
            bool result = false;
            try
            {
                using (var connexao = new MySqlConnection(_connection))
                {
                    connexao.Open();
                    var stringBuilder = new System.Text.StringBuilder(84);
                    stringBuilder.AppendLine("INSERT INTO book_rental.users(NAME_USER, DATE_OF_BIRTH,TELEFHONE,PASSWORD)");
                    stringBuilder.AppendLine($"VALUES ('{user.Name}', '{user.DateOfBirth}', '{user.Telefhone}', '{user.Password}');");

                    var InsertCnpj = await connexao.QueryAsync<User>(stringBuilder.ToString());

                    if(InsertCnpj != null)
                    {
                        result = true;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while entering the user");
            }

            return result;
        }

        public async Task<User> SearchUserAsync(User user)
        {
            try
            {
                using (var connexao = new MySqlConnection(_connection))
                {
                    connexao.Open();
                    var stringBuilder = new System.Text.StringBuilder(84);
                    stringBuilder.AppendLine("INSERT INTO book_rental.users(NAME_USER, DATE_OF_BIRTH,TELEFHONE,PASSWORD)");
                    stringBuilder.AppendLine($"VALUES ('{user.Name}', '{user.DateOfBirth}', '{user.Telefhone}', '{user.Password}');");

                    var Result = await connexao.QueryAsync<User>(stringBuilder.ToString());

                    if (Result != null)
                    {
                        return Result;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while entering the user");
            }
        }
    }
}
