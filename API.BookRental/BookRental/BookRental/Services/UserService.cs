using BookRental.Models;
using BookRental.Repository.Interfaces;
using BookRental.Services.Interfaces;
using BookRental.Services.Validades;
using BookRental.Utilies;

namespace BookRental.Services
{
    public class UserService: IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly IUserRepository _userRepository;

        public UserService (ILogger<UserService> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        public async Task<InformationsToReturnDto> InsertUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password)
        {
            
            var validatesInformations = ValidateInformationForRegister.ValidateInformations(Name, DateOfBirth, Email, Telefhone, Password);

            if(!validatesInformations.Status)
            {
                return validatesInformations;
            }

            Password = MD5Hash.CalculaHash(Password);

            return await _userRepository.InsertUserAsync(Name, DateOfBirth, Email, Telefhone, Password);
        }

        public async Task<UserDto> SearchUserAsync(string email, string password)
        {
            password = MD5Hash.CalculaHash(password);

            return await _userRepository.SearchUserAsync(email, password);
        }

        public async Task<InformationsToReturnDto> SearchEmailAsync(string email)
        {
            return await _userRepository.SearchEmailAsync(email);
        }
    }
}
