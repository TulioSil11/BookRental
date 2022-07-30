using BookRental.Models;

namespace BookRental.Services.Validades
{
    public static class ValidateInformationForRegister
    {
        public static InformationsOfRegisterToReturnDto ValidateInformations(string Name, string DateOfBirth, string Email, string Telefhone, string Password)
        {

            InformationsOfRegisterToReturnDto informations = new InformationsOfRegisterToReturnDto();

            if (Name == null || DateOfBirth == null ||
                Email == null || Telefhone == null ||
                Password == null)
            {
                informations.StatusOfRegister = false;
                informations.Mensage = "Fill in all fields.";
                return informations;
            }

            if (!ValidateDateOfBirth.Validate(DateTime.Parse(DateOfBirth)))
            {
                informations.StatusOfRegister = false;
                informations.Mensage = "It is necessary to be over 18 years old to register.";

                return informations;
            }

            if (!ValidateFormatOfEmail.Validate(Email))
            {
                informations.StatusOfRegister = false;
                informations.Mensage = "Invalid e-mail";

                return informations;
            }

            if (Password.Length < 8)
            {
               informations.StatusOfRegister = false;
               informations.Mensage = "Password must contain at least 8 characters";

                return informations;
            };

            informations.StatusOfRegister = true;
            informations.Mensage = "The information is valid";


            return informations;
        }
    }
}
