using Newtonsoft.Json;

namespace BookRental.Entities
{
    public class InformationsOfRegisterToReturnDto
    {
        [JsonProperty("statusOfRegister")]
        public bool StatusOfRegister { get; set; }

        [JsonProperty("mensage")]
        public string Mensage { get; set; }

     }
}