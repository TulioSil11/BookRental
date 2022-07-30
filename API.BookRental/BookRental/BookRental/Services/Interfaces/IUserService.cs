using BookRental.Models;

namespace BookRental.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> SearchUserAsync(string email, string password);
        Task<InformationsOfRegisterToReturnDto> InsertUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password);
        
    }
}
