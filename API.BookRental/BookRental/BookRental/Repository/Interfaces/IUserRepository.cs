using BookRental.Models;

namespace BookRental.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<InformationsOfRegisterToReturnDto> InsertUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password);
        Task<UserDto> SearchUserAsync(string email, string password);
    }
}
