using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTrinhA.DTO
{
    public class UserRegister
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserRegister(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
