using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    internal class Constants
    {
        public static Regex regexForIndex = new Regex(@"^([0-9]|[1-9][0-9]|100)$");
    }
}
