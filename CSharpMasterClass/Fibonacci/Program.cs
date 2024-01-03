namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello!");
                Console.WriteLine("Enter number:");
                int.TryParse(Console.ReadLine(), out int number);
                foreach(var input in Fibonacci.Generate(number))
                {
                    Console.WriteLine(input);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}