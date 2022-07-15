using System;
using System.Collections.Generic;
using BookRental.Entities;
using BookRental.Operations;
using BookRental.Operations.Services;

namespace BookRental
{
    public class Program
    {
        static void Main(string[] args)
        {          
            //Register-------------------
            List<User> resultOfRestiter = RegisterANewUser.Register();
            if (resultOfRestiter != null)
            {
                //Login.login(resultOfRestiter);
            }
            else
            {
                Main(args);
            };
            //---------------------------          

        }
    }
}
