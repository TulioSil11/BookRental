using System;

namespace BookRental.Operations{

    public static class RecuperePassword{
    
    public static void Recupere(){
        Console.WriteLine("Enter your email to send us an account recovery code.");
        Console.Write("E-mail: ");

        string email = Console.ReadLine();
        
        Console.WriteLine("Ente your recovery code: ");

        string Code = Console.ReadLine();
    }

    }
}