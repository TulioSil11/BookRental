

using BookRental.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace BookRental.Operations
{
    public static class LoginInDataBase
    {
        public static async Task<UserDto> LoginAsync(string Email, string Password)
        {
            UserDto user = new UserDto();
            try
            {
                using (var restCliente = new RestClient())
                {
                    var requisicao = new RestRequest($"https://localhost:7279/api/User?email={Email}&password={Password}", Method.Get);

                    var resposta =  await restCliente.ExecuteAsync(requisicao); 

                    switch (resposta.StatusCode)
                    {
                        case System.Net.HttpStatusCode.OK:
                            user =  JsonConvert.DeserializeObject<UserDto>(resposta.Content);
                            break;

                        default:
                            Console.WriteLine("Ocorreu um erro: " + resposta.StatusCode); 
                            break;
                    }

                }
            }
            catch
            {

            }
  
            return user;
        }
    }
}
