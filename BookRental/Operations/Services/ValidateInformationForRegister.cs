using BookRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRental.Operations.Services
{
    public static class ValidateInformationForRegister
    {
        public static bool ValidateInformations(User userInformation)
        {

            if (userInformation.Name == null || userInformation.DateOfBirth == null ||
                userInformation.Email == null || userInformation.Telefhone == null ||
                userInformation.Key == null)
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
