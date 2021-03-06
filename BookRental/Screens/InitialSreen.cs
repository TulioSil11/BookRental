using BookRental.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookRental.Screens
{
    public static class InitialSreen
    {
        public static void SreenLogin()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|                                    |");
            Console.WriteLine("|Login:                              |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("| Or                                 |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("|Create a new acount                 |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("|Enter [L] to login and              |");
            Console.WriteLine("|[C] to create a new account         |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("--------------------------------------");

            string option = Console.ReadLine().ToUpper();

            if (option == "L")
            {
                Console.Clear();
                Login.login();
            }
            else
            {
                Console.Clear();
                var registerUser = RegisterANewUser.Register();
                if(registerUser == true)
                {
                    Console.WriteLine("\nUsuario cadastrado");
                    Thread.Sleep(3000);
                    Console.Clear();
                    SreenLogin();
                }
                Console.WriteLine("Ocorreu um erro. Tente novamente");
                Thread.Sleep(3000);
                Console.Clear();
                SreenLogin();
            }


        }
    }
}
