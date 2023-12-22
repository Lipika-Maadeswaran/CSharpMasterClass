namespace DiceRollingApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            NumberGuessing numberGuessing = new NumberGuessing(6, random);

            Console.WriteLine("Welcome to Dice Rolling game ! " +
                "\nInstruction : " +
                "\n1. 3 chances are given to guess the number.\n");

            numberGuessing.ExecuteNumberGuessing();
        }
    }
}