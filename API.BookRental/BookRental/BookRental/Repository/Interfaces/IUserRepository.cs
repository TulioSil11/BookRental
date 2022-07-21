using BookRental.Entities;
using BookRental.Models;

namespace BookRental.Repository.Interfaces
{
    public interface IUserRepository
    {
         Task<bool> InsertUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password);
        Task<IEnumerable<UserDto>> SearchUserAsync(string email, string senha);
    }
}
