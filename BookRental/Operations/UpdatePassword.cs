using BookRental.Entities;
using BookRental.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRental.Operations
{
    public static class UpdateUserInDataBase
    {
        public static async Task<UserDto> Update(string Email, string Password)
        {
            UserDto user =  await SearchEmail.Search(Email);

            UserDto autenticacao = new UserDto();
            try
            {
                using (var restCliente = new RestClient())
                {
                    var requisicao = new RestRequest($"https://localhost:7279/api/User?Name={user.NameOfUser}&DateOfBirth={user.DateOfBirth}&Email={Email}&Telefhone={user.Telefhone}&Password={Password}", Method.Put);

                    var resposta = await restCliente.ExecuteAsync(requisicao);
                    switch (resposta.StatusCode)
                    {
                        case System.Net.HttpStatusCode.OK:
                            autenticacao =  JsonConvert.DeserializeObject<UserDto>(resposta.Content);
                            break;

                        default:
                            autenticacao.Informations.Status = false;
                            Console.Clear();
                            autenticacao.Mensage = "It was not possible to register. Try again later.";
                            break;
                    }

                }
            }
            catch(Exception)
            {
                autenticacao.Informations.Status = false;
                autenticacao.Mensage = "An error has occurred";
            }

            
            return autenticacao;
        }
    }
}
