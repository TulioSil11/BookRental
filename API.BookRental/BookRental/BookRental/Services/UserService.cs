using BookRental.Entities;
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

        public Task<bool> InsertUserAsync(User user)
        {
            return _userRepository.InsertUserAsync(user);
        }

        public Task<User> SearchUserAsync(User user)
        {
            return _userRepository.SearchUserAsync(user);
        }
    }
}
