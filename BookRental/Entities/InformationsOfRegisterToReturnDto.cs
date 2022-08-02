using Newtonsoft.Json;

namespace BookRental.Entities
{
    public class InformationsOfRegisterToReturnDto
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("mensage")]
        public string Mensage { get; set; }

     }
}