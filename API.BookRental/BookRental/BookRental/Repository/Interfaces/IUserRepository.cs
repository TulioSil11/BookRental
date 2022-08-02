using BookRental.Models;

namespace BookRental.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<InformationsToReturnDto> SearchEmailAsync(string email);
        Task<InformationsToReturnDto> InsertUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password);
        Task<UserDto> SearchUserAsync(string email, string password);
    }
}
