using BookRental.Entities;
using System;

namespace BookRental.Operations.Services
{
    public static class ValidateInformationForRegister
    {
        public static bool ValidateInformations(User userInformation)
        {

            if (userInformation.Name == null || userInformation.DateOfBirth == null ||
                userInformation.Email == null || userInformation.Telefhone == null ||
                userInformation.Password == null)
            {                
                return false;
            }

            var ageWouldNeed = ValidadeDateOfUser.validateDateOfBirth(userInformation.DateOfBirth);
            if (!ageWouldNeed)
            {
                Console.WriteLine("E necessario ser maior de idade para criar uma conta.");
                return false;
            }

            if (!ValidateEmail.validateFormatOfEmail(userInformation.Email))
            {
                Console.WriteLine("Email invalido.");
                return false;
            }


            return true;
        }

    }
}
