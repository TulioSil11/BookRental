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
        public static async Task<bool> Register(User user)
        {
             bool autenticacao = false;
            try
            {
                using (var restCliente = new RestClient())
                {
                    var requisicao = new RestRequest($"https://localhost:7279/api/User?Name={user.Name}&DateOfBirth={user.DateOfBirth.ToString("dd/MM/yyyy")}&Email={user.Email}&Telefhone={user.Telefhone}&Password={user.Password}", Method.Post);

                    var resposta = await restCliente.ExecuteAsync(requisicao);

                    switch (resposta.Content)
                    {
                        case "true":
                            autenticacao = true;
                            break;

                        default:
                            Console.WriteLine("Ouve um error com o cadastro do usuario."); ;
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
            
            }
            return autenticacao;
        }
    }
}
