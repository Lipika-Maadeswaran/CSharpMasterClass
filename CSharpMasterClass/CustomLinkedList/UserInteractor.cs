using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    internal class UserInteractor
    {
        public int[] GetInputElements()
        {
            Console.WriteLine("Enter the total number of elements : ");
            var totalNumberOfElements = ValidateInputs<int>(Constants.regexForIndex);
            var elements = new int[totalNumberOfElements];
            Console.WriteLine("Enter Elements : ");
            for (int i = 0; i < totalNumberOfElements; i++)
            {
                elements[i] = ValidateInputs<int>(Constants.regexForIndex);
            }
            return elements;
        }

        public T ValidateInputs<T>(Regex regex)
        {
            var result = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(result) || !regex.IsMatch(result))
            {
                Console.Write("Enter valid input");
                result = Console.ReadLine();
            }
            return (T)Convert.ChangeType(result, typeof(T));
        }
    }
}
