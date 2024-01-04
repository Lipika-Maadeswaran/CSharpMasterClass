using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
    public class Password
    {
        [JsonConstructor]
        public Password() { }


        public Password(string password)
        {
            this.EncodedPassword = EncodePassword(password);
        }

        public string EncodedPassword { get; set; }

        public string EncodePassword(string password)
        {
            byte[] bytes = new byte[password.Length];
            bytes = Encoding.UTF8.GetBytes(password);
            var encodedPassword = Convert.ToBase64String(bytes, 0, bytes.Length);
            return encodedPassword;
        }

        public bool PasswordChecker(string password)
        {
            var encodedPassword = EncodePassword(password);
            return (encodedPassword == this.EncodedPassword);
        }
    }
}
