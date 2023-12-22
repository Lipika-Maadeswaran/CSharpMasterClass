using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Utilities
    {
        public Calculator calculator;
        public Utilities(Calculator calculatorInstance) 
        { 
            calculator = calculatorInstance;
        }

        public double GetInputs()
        {
            double.TryParse(Console.ReadLine(), out double input);
            return input;
        }

        public void DisplayMessage()
        {
            var choice = string.Empty;

            while (choice != "Exit")
            {
                StringBuilder stringBuilder = new StringBuilder(
                    "Choose any operation" +
                    "\n1. [A] - Addition " +
                    "\n2. [S] - Subtraction " +
                    "\n3. [M] - Multiplication " +
                    "\n4. [D] - Division " +
                    "\n5. [E] - Exit");
                Console.WriteLine(stringBuilder);
                choice = Console.ReadLine();
                var printMessage = $"Enter values : ";

                switch (choice)
                {
                    case "1":
                    case "A":
                    case "a":
                        Console.WriteLine(printMessage);
                        Console.WriteLine(calculator.Addition(GetInputs(), GetInputs()));
                        break;
                    case "2":
                    case "S":
                    case "s":
                        Console.WriteLine(printMessage);
                        Console.WriteLine(calculator.Subtraction(GetInputs(), GetInputs()));
                        break;
                    case "3":
                    case "M":
                    case "m":
                        Console.WriteLine(printMessage);
                        Console.WriteLine(calculator.Multiplication(GetInputs(), GetInputs()));
                        break;
                    case "4":
                    case "D":
                    case "d":
                        Console.WriteLine(printMessage);
                        Console.WriteLine(calculator.Division(GetInputs(), GetInputs()));
                        break;
                    case "5":
                    case "E":
                    case "e":
                        choice = "Exit";
                        Console.WriteLine("Thank you ! \nExiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
