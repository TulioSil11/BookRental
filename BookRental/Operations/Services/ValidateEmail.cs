using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRental.Operations.Services
{
    public static class ValidateEmail
    {
        public static bool validateFormatOfEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
