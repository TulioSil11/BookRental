using BookRental.Entities;
using BookRental.Models;

namespace BookRental.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> InsertUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password);
        Task<IEnumerable<UserDto>> SearchUserAsync(string email, string senha);
    }
}
