using DiceRollGame.Game;
using DiceRollGame.UserCommunication;

namespace DiceRollGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var dice = new Dice(random);
            var userCommunication = new ConsoleUserCommunication();
            var guessingGame = new GuessingGame(dice, userCommunication);

            GameResult gameResult = guessingGame.Play();
            guessingGame.PrintResult(gameResult);
        }
    }
}