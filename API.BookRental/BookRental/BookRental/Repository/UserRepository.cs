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

        public async Task<InformationsToReturnDto> InsertUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password)
        {
            InformationsToReturnDto result = new InformationsToReturnDto();

            result.Status = false;

            try
            {
                using (var connexao = new MySqlConnection(_connection))
                {
                    connexao.Open();
                    var stringBuilder = new System.Text.StringBuilder(84);
                    stringBuilder.AppendLine("INSERT INTO book_rental.users(NAME_USER, EMAIL, DATE_OF_BIRTH,TELEFHONE,PASSWORD)");
                    stringBuilder.AppendLine($"VALUES ('{Name}', '{Email}', '{DateOfBirth}', '{Telefhone}', '{Password}');");

                    var InsertCnpj = await connexao.QueryAsync<UserDto>(stringBuilder.ToString());

                    if (InsertCnpj != null)
                    {
                        result.Status = true;
                        result.Mensage = "Successful registration.";
                        return result;
                    }
                    result.Status = false;
                    result.Mensage = "It was not possible to register. Try again later.";

                }

            }
            catch (Exception)
            {
                result.Status = false;
                result.Mensage = "It was not possible to register. Try again later.";
            }

            return result;
        }

        public async Task<InformationsToReturnDto> SearchEmailAsync(string email)
        {
            InformationsToReturnDto SearchEmail = new InformationsToReturnDto();
            try
            {
                using (var connexao = new MySqlConnection(_connection))
                {
                    connexao.Open();
                    var stringBuilder = new System.Text.StringBuilder(84);
                    stringBuilder.AppendLine("SELECT * FROM book_rental.users");
                    stringBuilder.AppendLine($"WHERE EMAIL = '{email}'");

                    var Result = await connexao.QueryFirstOrDefaultAsync<UserDto>(stringBuilder.ToString());

                    if(Result != null)
                    {
                        SearchEmail.Status = true;
                        SearchEmail.Mensage = "Email found";
                        return SearchEmail;
                    }

                    SearchEmail.Status = false;
                    SearchEmail.Mensage = "Email not found";
                    return SearchEmail;
                }
            }
            catch (Exception ex)
            {
                SearchEmail.Status = false;
                SearchEmail.Mensage = $"Error: {ex.Message}";
                return SearchEmail;
            }
        }

        public async Task<UserDto> SearchUserAsync(string email, string password)
        {
            UserDto SearchEmail = new UserDto();
            UserDto Result = new UserDto();
            try
            {
                using (var connexao = new MySqlConnection(_connection))
                {
                    connexao.Open();
                    var stringBuilder = new System.Text.StringBuilder(84);
                    stringBuilder.AppendLine("SELECT * FROM book_rental.users");
                    stringBuilder.AppendLine($"WHERE EMAIL = '{email}'");

                    SearchEmail = await connexao.QueryFirstOrDefaultAsync<UserDto>(stringBuilder.ToString());

                    if (SearchEmail != null)
                    {
                        var stringBuilder1 = new System.Text.StringBuilder(84);
                        stringBuilder1.AppendLine("SELECT * FROM book_rental.users");
                        stringBuilder1.AppendLine($"WHERE EMAIL = '{email}' AND PASSWORD = '{password}'");

                        Result = await connexao.QueryFirstOrDefaultAsync<UserDto>(stringBuilder1.ToString());

                        if (Result != null)
                        {
                            Result.StatusOfSearch = true;
                            Result.Mensage = "Successful login";

                            return Result;
                        }
                        Result = new UserDto();
                        Result.StatusOfSearch = false;
                        Result.Mensage = "Password invalidates";
                        return Result;

                    }

                    Result.StatusOfSearch = false;
                    Result.Mensage = "Email invalidates";
                    return Result;

                }

            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred while entering the user");
            }

            return Result;
        }
    }
}
