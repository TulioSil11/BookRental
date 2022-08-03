using Newtonsoft.Json;

namespace BookRental.Models
{
    public class UserDto
    {
        [JsonProperty("iD_USER")]
        public int IdOfUser { get; set; }

        [JsonProperty("namE_USER")]
        public string NameOfUser { get; set; }

        [JsonProperty("datE_OF_BIRTH")]
        public string DateOfBirth { get; set; }

        [JsonProperty("telefhone")]
        public string Telefhone { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }


        [JsonProperty("statusOfSearch")]
        public bool StatusOfSearch { get; set; }

        [JsonProperty("mensage")]
        public string Mensage { get; set; }

        [JsonProperty("informations")]
        public Informations Informations { get; set; }
    }

    public class Informations
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("mensage")]
        public string Mensage { get; set; }
    }
}
