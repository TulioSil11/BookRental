using BookRental.Entities;
using BookRental.Models;
using BookRental.Repository.Interfaces;
using BookRental.Services.Interfaces;

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

        public Task<bool> InsertUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password)
        {
            return _userRepository.InsertUserAsync(Name, DateOfBirth, Email, Telefhone, Password);
        }

        public Task<IEnumerable<UserDto>> SearchUserAsync(string email, string senha)
        {
            return _userRepository.SearchUserAsync(email, senha);
        }
    }
}
