using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Models
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string name, string email, string password = null)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
