﻿using BookRental.Models;
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
        public async Task<UserDto> SearchUser(string email, string password)
        {
            var result = await _userServico.SearchUserAsync(email, password);

            return result;
        }


        [HttpGet("Email")]
        public async Task<InformationsToReturnDto> SearchEmail(string email)
        {
            var result = await _userServico.SearchEmailAsync(email);

            return result;
        }

        [HttpPost]
        public async Task<InformationsToReturnDto> InsertUser (string Name, string DateOfBirth, string Email, string Telefhone, string Password)
        {
            var result = await _userServico.InsertUserAsync(Name, DateOfBirth, Email, Telefhone, Password);

            return result;
        }
    }
}
