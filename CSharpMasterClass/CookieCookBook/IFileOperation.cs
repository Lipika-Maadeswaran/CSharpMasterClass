using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
    public interface IFileOperation 
    {
        public string CreateFileName(User user);

        public bool ValidateLogIn(string userName, string password, User user);

        public bool SignUpUser(User user);

        public bool CheckUserNameUnique(string userName);

        public void WriteDetailsToFile(User user);
    }

}
