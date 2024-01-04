using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
    public class User
    {
        [JsonConstructor]
        public User() { }
        public User(string userName, string password)
        {
            UserName = userName;
            Password = new Password(password);
        }

        public string UserName { get; set; }

        public Password Password { get; set; }

        public Ingredient Ingredient { get; set; }

    }
}
