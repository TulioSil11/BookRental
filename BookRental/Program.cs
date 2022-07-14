using System;
using BookRental.Operations;

namespace BookRental
{
    public class Program
    {
        static void Main(string[] args)
        {
            //login;
            //Register
            var Informations = TakeTheInforationsOfUserRegister.TakeInformations();
            var validateInformation = ValidateInformationForRegister.Validate(Informations);


        }
    }
}
