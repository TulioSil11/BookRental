

using BookRental.Entities;
using BookRental.Operations.Services;
using System;
using System.Collections.Generic;
using System.IO;

namespace BookRental.Operations
{
    public class RegisterANewUser
    {
        public static User Register()
        {

            User Informations = TakeTheInforationsOfUserRegister.TakeInformations();
            bool validateInformation = ValidateInformationForRegister.ValidateInformations(Informations);

            if (!validateInformation)
            {
                Console.WriteLine("Ouve um error com o cadastro do usuario.");

                Register();
            }

           string date = Informations.DateOfBirth.ToString("dd \" MMMM \" yyyy"); ;
            return Informations;
        }
    }
}
