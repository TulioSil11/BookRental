using BookRental.Entities;
using System;


namespace BookRental.Operations
{
    public static class TakeTheInforationsOfUserRegister
    {
        public  static UserRegistration TakeInformations()
        {
            UserRegistration user = new UserRegistration();

            Console.Write("Name: ");
            user.Name = Console.ReadLine();

            Console.Write("DateOfBirth: ");
            user.DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Email: ");
            user.Email = Console.ReadLine();

            Console.Write("Telefhone: ");
            user.Telefhone = Console.ReadLine();

            Console.Write("Key: ");
            user.Key = Console.ReadLine();

            return user;
        }
    }
}
