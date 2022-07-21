using BookRental.Models;
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
        public static UserDto login()
        {
            UserDto userToReturn = null;
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            var result = LoginInDataBase.LoginAsync(email, password);
                
                

        }
    }
}
