using BookRental.Models;
using BookRental.Utilies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookRental.Operations
{
    public static class Login
    {
        public static async Task<UserDto> login()
        {
            Console.Write("Email: ");
            string Email = Console.ReadLine();

            Console.Write("Password: ");
            string Password = Console.ReadLine();

            var Result = await LoginInDataBase.LoginAsync(Email, Password);  

            Console.Clear();
            Console.WriteLine(Result.Mensage);


            return Result;
        }
    }
}
