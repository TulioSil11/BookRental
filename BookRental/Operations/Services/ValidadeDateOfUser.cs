using BookRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRental.Operations.Services
{
    public static class ValidadeDateOfUser
    {
        public static bool validateDateOfBirth(DateTime Age)
        {
            int ageWouldNeed = DateTime.Now.Year - Age.Year;
            if (ageWouldNeed >= 18) return true;

            return false;
        }
    }
}
