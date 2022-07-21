using Newtonsoft.Json;

namespace BookRental.Models
{
    public class UserDto
    {
        [JsonProperty("IdUsuario")]
        public int ID_USER { get; set; }

        [JsonProperty("Name")]
        public string NAME_USER { get; set; }

        [JsonProperty("DateOfBirth")]
        public string DATE_OF_BIRTH { get; set; }

        [JsonProperty("Telefhone")]
        public string TELEFHONE { get; set; }

        [JsonProperty("Password")]
        public string PASSWORD { get; set; }

    }
}
