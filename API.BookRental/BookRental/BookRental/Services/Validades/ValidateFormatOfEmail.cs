namespace BookRental.Services.Validades
{
    public static class ValidateFormatOfEmail
    {
        public static bool Validate(string email)
        {
            try
            {
                var _email = new System.Net.Mail.MailAddress(email);
                return _email.Address == email;
            }
            catch//(Exception ex)
            {
                return false;
            }
        }
    }
}
