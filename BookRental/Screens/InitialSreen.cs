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
        public static async Task SreenLogin()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|                                    |");
            Console.WriteLine("|Login:                              |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("| Or                                 |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("|Create a new acount                 |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("|Enter [L] to login,                 |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("|[C] to create a new account         |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("|and [R]Recover password             |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("--------------------------------------");

            string option = Console.ReadLine().ToUpper();

            switch(option)
            {
                case "L":
                    Console.Clear();
                    var login = await Login.login();

                    if(!login.StatusOfSearch)
                    {
                        Thread.Sleep(4000);
                        Console.Clear();

                        await SreenLogin();
                    }

                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Chamar tela home");

                break;

                case "C":
                    Console.Clear();
                    var registerUser = await RegisterANewUser.Register();

                    Thread.Sleep(3000);
                    Console.Clear();

                    await SreenLogin();
                break;

                case "R":
                    await RecuperePassword.Recupere();
                    Thread.Sleep(3000);
                    Console.Clear();

                    await SreenLogin();
                break;

                default:
                    Console.WriteLine("Choose one of the options.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    await SreenLogin();
                break;

            };          

        }
    }
}
