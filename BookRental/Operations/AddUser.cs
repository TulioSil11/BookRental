

using BookRental.Entities;
using BookRental.Operations.Services;
using BookRental.Utilies;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BookRental.Operations
{
    public class RegisterANewUser
    {
        public static async Task<bool>  Register()
        {

            User Informations = TakeTheInforationsOfUserRegister.TakeInformations();

            InformationsOfRegisterToReturnDto register = await RegisterUserInDataBase.Register(Informations);

            Console.Clear();
            Console.WriteLine(register.Mensage);

            return register.Status;            

        }
    }
}
