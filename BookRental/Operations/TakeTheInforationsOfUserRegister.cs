using BookRental.Entities;
using System;


namespace BookRental.Operations
{
    public static class TakeTheInforationsOfUserRegister
    {
        public static User TakeInformations()
        {

            User user = new User();

            try
            {
                Console.WriteLine("Cadastro de novo usuario: ");
                Console.Write("Name: ");
                user.Name = Console.ReadLine();

                Console.Write("DateOfBirth: ");
                user.DateOfBirth = DateTime.Parse(Console.ReadLine());

                Console.Write("Email: ");
                user.Email = Console.ReadLine();

                Console.Write("Telefhone: ");
                user.Telefhone = Console.ReadLine();

                Console.Write("Password: ");
                user.Password = Console.ReadLine();

                return user;
            }
            catch (Exception ex)
            {
                return user;
            }
        }
    }
}

