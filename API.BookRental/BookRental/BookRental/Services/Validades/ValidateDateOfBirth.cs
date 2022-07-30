namespace BookRental.Services.Validades
{
    public static class ValidateDateOfBirth
    {
        public static bool Validate(DateTime Age)
        {
            try
            {
                int ageWouldNeed = DateTime.Now.Year - Age.Year;
                if (ageWouldNeed >= 18) return true;
            }
            catch
            {
                return false;
            }
            return false;
        }

    }
}
