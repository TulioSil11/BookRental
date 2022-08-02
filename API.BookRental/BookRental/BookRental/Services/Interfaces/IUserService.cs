using BookRental.Models;

namespace BookRental.Services.Interfaces
{
    public interface IUserService
    {
        Task<InformationsToReturnDto> SearchEmailAsync(string email);
        Task<UserDto> SearchUserAsync(string email, string password);
        Task<InformationsToReturnDto> InsertUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password);
        
    }
}
