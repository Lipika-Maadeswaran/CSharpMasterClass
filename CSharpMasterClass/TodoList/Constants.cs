using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TodoList
{
    internal class Constants
    {
        /// <summary>
        /// Regex for Index.
        /// </summary>
        public static Regex regexForIndex = new Regex(@"^[1-9]{0,7}$");

        public static Regex regexForAlphabet = new Regex(@"^[A-Za-z0-9]+$");

    }
}
