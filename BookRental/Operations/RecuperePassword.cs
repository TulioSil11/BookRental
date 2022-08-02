using BookRental.Screens;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BookRental.Operations
{

    public static class RecuperePassword
    {

        public static async Task Recupere()
        {
            Console.WriteLine("Enter your email to send us an account recovery code.");
            Console.Write("E-mail: ");

            string email = Console.ReadLine();

            var searchEmail = await SearchEmail.Search(email);

            Console.WriteLine(searchEmail.Mensage);

            if(!searchEmail.Status)
            {
                Thread.Sleep(3000);
                Console.Clear();

                await InitialSreen.SreenLogin();
            }

            Thread.Sleep(3000);
            Console.Clear();

            int code = 11515;

            Console.WriteLine("Loading...");

            if(!SendEmail.Send(email, "Book Rental - New Password", $"Your code to recover your password and :{code}"))
            {
                Console.WriteLine("An error has occurred, try again.");
                Thread.Sleep(3000);
                Console.Clear();

                await InitialSreen.SreenLogin();
            }

            Console.Clear();
            Console.Write("Ente your recovery code: ");
            int Code = int.Parse(Console.ReadLine());

            if (Code != code)
            {
                Console.WriteLine("Invalid code, try again.");
                Thread.Sleep(4000);
                Console.Clear();

                await InitialSreen.SreenLogin();
            }


            Console.Write("Enter your new password: ");
            string NewKey = Console.ReadLine();

            //chamar metodo para atualizar senha
        }

    }
}