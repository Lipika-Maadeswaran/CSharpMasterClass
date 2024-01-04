namespace PasswordGenerator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var passwordGenerator = new PasswordGenerator(
                                 new RandomWrapper());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(passwordGenerator.Generate(5, 10, false));
            }
        }
    }
}