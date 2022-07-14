using BookRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRental.Operations
{
    public static class ValidateInformationForRegister
    {
        public static bool Validate(UserRegistration userInformation)
        {
            bool result = true;

            if (userInformation.Name == null)
            {
                result = false; 
            }else
            {
                userInformation.Name = userInformation.Name.ToUpper();
            }


            return result;


        }
    }
}
