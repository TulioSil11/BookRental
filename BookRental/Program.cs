using System.Threading.Tasks;
using BookRental.Screens;

namespace BookRental
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            await InitialSreen.SreenLogin();           

        }
    }
}
