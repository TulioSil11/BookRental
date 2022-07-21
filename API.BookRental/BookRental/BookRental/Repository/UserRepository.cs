using BookRental.Entities;
using BookRental.Models;
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

        public async Task<bool> InsertUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password)
        {
            bool result = false;
            try
            {
                using (var connexao = new MySqlConnection(_connection))
                {
                    connexao.Open();
                    var stringBuilder = new System.Text.StringBuilder(84);
                    stringBuilder.AppendLine("INSERT INTO book_rental.users(NAME_USER, EMAIL, DATE_OF_BIRTH,TELEFHONE,PASSWORD)");
                    stringBuilder.AppendLine($"VALUES ('{Name}', '{Email}', '{DateOfBirth}', '{Telefhone}', '{Password}');");

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

        public async Task<IEnumerable<UserDto>> SearchUserAsync(string email, string senha)
        {
            IEnumerable<UserDto> Result = null;
            try
            {
                using (var connexao = new MySqlConnection(_connection))
                {
                    connexao.Open();
                    var stringBuilder = new System.Text.StringBuilder(84);
                    stringBuilder.AppendLine("SELECT * FROM book_rental.users");
                    stringBuilder.AppendLine($"WHERE EMAIL = '{email}' AND PASSWORD = '{senha}'");

                    Result = await connexao.QueryAsync<UserDto>(stringBuilder.ToString());
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while entering the user");
            }
         
             return Result;
        }
    }
}
