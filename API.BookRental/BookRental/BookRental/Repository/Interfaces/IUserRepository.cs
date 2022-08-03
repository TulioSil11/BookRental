using BookRental.Models;

namespace BookRental.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<InformationsToReturnDto> InsertUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password);
        Task<UserDto> SearchUserAsync(string email);

        Task<UserDto> LoginAsync(string email, string password);

        Task<InformationsToReturnDto> UpdateUserAsync(string Name, string DateOfBirth, string Email, string Telefhone, string Password);

    }
}
