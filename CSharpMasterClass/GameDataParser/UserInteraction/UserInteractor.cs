using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.UserInteraction
{
    internal class UserInteractor : IUserInteractor
    {
        public T GetInput<T>(string message, string errorMessage = "Invalid Input !")
        {
            DisplayMessage(message);

            var result = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(result))
            {
                PrintError(errorMessage);
                result = Console.ReadLine();
            }

            while (!File.Exists(result))
            {
                PrintError("File Not Found !");
                result = Console.ReadLine();
            }

            return (T)Convert.ChangeType(result, typeof(T))!;
        }

        public string GetFileNameFromUser()
        {
            var fileName = GetInput<string>("Enter the name of the file to read : ");

            return fileName;
        }

        public void DisplayMessage(string content)
        {
            Console.WriteLine(content);
        }

        public void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
