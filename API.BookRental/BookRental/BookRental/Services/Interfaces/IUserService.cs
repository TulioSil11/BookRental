using BookRental.Models;

namespace BookRental.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> LoginAsync(string email, string password);
        Task<UserDto> SearchUserAsync(string email);
        Task<InformationsToReturnDto> InsertUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password);
        
        Task<InformationsToReturnDto> UpdateUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password);

    }
}
