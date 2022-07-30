using BookRental.Entities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRental.Operations
{
    public static class RegisterUserInDataBase
    {
        public static async Task<InformationsOfRegisterToReturnDto> Register(User user)
        {
             InformationsOfRegisterToReturnDto autenticacao = new InformationsOfRegisterToReturnDto();
            try
            {
                using (var restCliente = new RestClient())
                {
                    var requisicao = new RestRequest($"https://localhost:7279/api/User?Name={user.Name}&DateOfBirth={user.DateOfBirth.ToString("dd/MM/yyyy")}&Email={user.Email}&Telefhone={user.Telefhone}&Password={user.Password}", Method.Post);

                    var resposta = await restCliente.ExecuteAsync(requisicao);
                    switch (resposta.StatusCode)
                    {
                        case System.Net.HttpStatusCode.OK:
                            autenticacao =  JsonConvert.DeserializeObject<InformationsOfRegisterToReturnDto>(resposta.Content);
                            break;

                        default:
                            autenticacao.StatusOfRegister = false;
                            Console.Clear();
                            autenticacao.Mensage = "It was not possible to register. Try again later.";
                            break;
                    }

                }
            }
            catch(Exception)
            {
                autenticacao.StatusOfRegister = false;
                autenticacao.Mensage = "An error has occurred";
            }

            
            return autenticacao;
        }
    }
}
