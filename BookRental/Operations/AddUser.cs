

using BookRental.Entities;
using BookRental.Operations.Services;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BookRental.Operations
{
    public class RegisterANewUser
    {
        public static bool Register()
        {

            User Informations = TakeTheInforationsOfUserRegister.TakeInformations();
            bool validateInformation = ValidateInformationForRegister.ValidateInformations(Informations);

            if (!validateInformation)
            {
                Console.WriteLine("\nOuve um error com o cadastro do usuario.\n");

                Register();
            }

           string date = Informations.DateOfBirth.ToString("dd/MM/yyyy");

            var result = RegisterUserInDataBase.Register(Informations).ToString();
            if (result == "true");
            {
                return true;
            }
            
                return false;
            

        }
    }
}
