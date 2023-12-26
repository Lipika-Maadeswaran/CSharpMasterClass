using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CookieCookBook
{
    internal class Constants
    {
        public static Regex regexForNumbers = new Regex(@"^[1-9]{0,7}$");

        public static Regex regexForAlphabet = new Regex(@"^[A-Za-z]?[a-zA-z ]+$");
    }
}
