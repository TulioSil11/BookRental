using BookRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRental.Operations.Services
{
    public static class Login
    {
        public static bool login(List<User> resultOfRestiter)
        {

            UserLogin login = new UserLogin();
            Console.WriteLine("Login ");
            Console.Write("Email: ");
            login.Login = Console.ReadLine();

            Console.Write("Senha: ");
            login.Password = Console.ReadLine();

            foreach(var item in resultOfRestiter)
            {
                if (login.Login == item.Email && login.Password == item.Password) return true;
                
            }

            return false;
        }
    }
}
