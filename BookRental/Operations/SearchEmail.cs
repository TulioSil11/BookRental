﻿using BookRental.Entities;
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
    public static class SearchEmail
    {
        public static async Task<UserDto> Search (string email)
        {
            UserDto autenticacao = new UserDto();
            try
            {
                using (var restCliente = new RestClient())
                {
                    var requisicao = new RestRequest($"https://localhost:7279/api/User?email={email}", Method.Get);

                    var resposta = await restCliente.ExecuteAsync(requisicao);
                    switch (resposta.StatusCode)
                    {
                        case System.Net.HttpStatusCode.OK:
                            autenticacao = JsonConvert.DeserializeObject<UserDto>(resposta.Content);
                            break;

                        default:
                            autenticacao.Informations.Status = false;
                            Console.Clear();
                            autenticacao.Mensage = "It was not possible to search email. Try again later.";
                            break;
                    }

                }
            }
            catch (Exception)
            {
                autenticacao.Informations.Status = false;
                autenticacao.Mensage = "An error has occurred";
            }

            return autenticacao;
        }
    }
}

