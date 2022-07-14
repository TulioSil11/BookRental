using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRental.Entities
{
    public class UserRegistration
    {
        public string  Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Telefhone { get; set; }
        public string Key { get; set; }

    }
}
