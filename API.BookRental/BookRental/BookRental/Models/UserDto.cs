using Newtonsoft.Json;

namespace BookRental.Models
{
    public class UserDto
    {
        public int ID_USER { get; set; }

        public string? NAME_USER { get; set; }

        public string? DATE_OF_BIRTH { get; set; }

        public string? TELEFHONE { get; set; }

        public string? PASSWORD { get; set; }

        public bool? StatusOfSearch { get; set; }

        public string? Mensage { get; set; }

    }
}
