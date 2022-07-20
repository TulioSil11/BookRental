using BookRental.Entities;

namespace BookRental.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> InsertUserAsync(User user);
        Task<User> SearchUserAsync(User user);
    }
}
