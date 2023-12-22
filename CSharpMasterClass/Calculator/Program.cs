using System.Linq.Expressions;
using System.Text;

namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Calculator calculator = new Calculator();
                Utilities utilities = new Utilities(calculator);

                Console.WriteLine("Welcome to World of Numbers!");
                utilities.DisplayMessage();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}