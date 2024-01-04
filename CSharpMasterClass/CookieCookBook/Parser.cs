using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CookieCookBook
{
    internal class Parser
    {
        public static T Validate<T>(Regex regex, string inputMessage = "Enter Input :", string errorMessage = "Invalid Input!")
        {
            Console.WriteLine(inputMessage);

            var result = Console.ReadLine();
            while(string.IsNullOrWhiteSpace(result) || !TypeDescriptor.GetConverter(typeof(T)).IsValid(result) || !regex.IsMatch(result))
            {
                Console.WriteLine(errorMessage);

                result = Console.ReadLine();
            } 
            return (T) Convert.ChangeType(result, typeof(T));
        }
    }
}
