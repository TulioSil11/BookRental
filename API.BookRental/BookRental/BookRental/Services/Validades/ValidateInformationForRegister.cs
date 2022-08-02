using BookRental.Models;

namespace BookRental.Services.Validades
{
    public static class ValidateInformationForRegister
    {
        public static InformationsToReturnDto ValidateInformations(string Name, string DateOfBirth, string Email, string Telefhone, string Password)
        {

            InformationsToReturnDto informations = new InformationsToReturnDto();

            if (Name == null || DateOfBirth == null ||
                Email == null || Telefhone == null ||
                Password == null)
            {
                informations.Status = false;
                informations.Mensage = "Fill in all fields.";
                return informations;
            }

            if (!ValidateDateOfBirth.Validate(DateTime.Parse(DateOfBirth)))
            {
                informations.Status = false;
                informations.Mensage = "It is necessary to be over 18 years old to register.";

                return informations;
            }

            if (!ValidateFormatOfEmail.Validate(Email))
            {
                informations.Status = false;
                informations.Mensage = "Invalid e-mail";

                return informations;
            }

            if (Password.Length < 8)
            {
               informations.Status = false;
               informations.Mensage = "Password must contain at least 8 characters";

                return informations;
            };

            informations.Status = true;
            informations.Mensage = "The information is valid";


            return informations;
        }
    }
}
