

using BookRental.Entities;
using BookRental.Operations.Services;
using System;
using System.Collections.Generic;

namespace BookRental.Operations
{
    public class RegisterANewUser
    {
        public static List<User> Register()
        {
            List<User> DataOfUser = new List<User>();

            User Informations = TakeTheInforationsOfUserRegister.TakeInformations();
            bool validateInformation = ValidateInformationForRegister.ValidateInformations(Informations);

            if (!validateInformation)
            {
                Console.WriteLine("Ouve um error com o cadastro do usuario.");

                Register();
            }

            DataOfUser.Add(Informations);

            return DataOfUser;
        }
    }
}
