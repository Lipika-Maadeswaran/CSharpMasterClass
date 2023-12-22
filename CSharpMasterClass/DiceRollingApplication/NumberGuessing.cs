using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollingApplication
{
    internal class NumberGuessing
    {
        private readonly int SidesOfDice;
        private readonly Random _random;

        public NumberGuessing(int sidesOfDice, Random random)
        {
            SidesOfDice = sidesOfDice;
            _random = random;
        }

        /// <summary>
        /// Generating random numbers.
        /// </summary>
        /// <returns>random number.</returns>
        public int GenerateDiceRoll() => _random.Next(1, SidesOfDice);

        /// <summary>
        /// Checks if the number entered by user is same as the generated number.
        /// </summary>
        /// <param name="number">User entered number.</param>
        /// <returns>If Same.</returns>
        public bool IsSameAsDiceRoll(int number)
        {
            if (number == GenerateDiceRoll())
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Checks user won or lost.
        /// </summary>
        public void ExecuteNumberGuessing()
        {
            for (int i = 3; i >= 1; i--)
            {
                Console.WriteLine($"You have {i} chances left !  " +
                    $"\nGuess the number : ");
                int.TryParse(Console.ReadLine(), out int number);

                if (IsSameAsDiceRoll(number))
                {
                    Console.WriteLine("Hurrayy! You win :)");
                    break;
                }
                Console.WriteLine("Oops :( " +
                    "\nTry again!");
            }
            Console.WriteLine("You have lost the match ! \nBetter luck next time");
        }
    }
}
