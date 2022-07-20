using BookRental.Entities;
using BookRental.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userServico;

        public UserController (IUserService userServico)
        {
            _userServico = userServico;
        }


        [HttpGet]
        public async Task<bool> SearchUser(User user)
        {
            var result = await _userServico.InsertUserAsync(user);

            return result;
        }

        [HttpPost]
        public async Task<bool> InsertUser (User user)
        {
            var result = await _userServico.InsertUserAsync(user);

            return result;
        }
    }
}
