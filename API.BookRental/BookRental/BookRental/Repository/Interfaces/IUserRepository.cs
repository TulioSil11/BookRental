using BookRental.Entities;

namespace BookRental.Repository.Interfaces
{
    public interface IUserRepository
    {
         Task<bool> InsertUserAsync(User user);
         Task<User> SearchUserAsync(User user);
    }
}
