

using BookRental.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace BookRental.Operations
{
    public static class LoginInDataBase
    {
        public static async Task<UserDto> LoginAsync(string email, string password)
        {
            UserDto autenticacao = null;
            try
            {
                using (var restCliente = new RestClient())
                {
                    var requisicao = new RestRequest($"https://localhost:7279/api/User?email={email}&senha={password}", Method.Get);

                    var resposta = await restCliente.ExecuteAsync(requisicao);

                    switch (resposta.StatusCode)
                    {
                        case System.Net.HttpStatusCode.OK:
                            autenticacao =  JsonConvert.DeserializeObject<UserDto>(resposta.Content);
                            break;

                        default:
                            Console.WriteLine("Ocorreu um erro: " + resposta.StatusCode); 
                            break;
                    }

                }
            }
            catch (Exception ex)
            {

            }
            UserDto userToReturn = null;

            userToReturn.ID_USER = autenticacao.ID_USER;
            userToReturn.NAME_USER = autenticacao.NAME_USER;
            userToReturn.DATE_OF_BIRTH = autenticacao.NAME_USER;
            userToReturn.
            return autenticacao;
        }
    }
}
