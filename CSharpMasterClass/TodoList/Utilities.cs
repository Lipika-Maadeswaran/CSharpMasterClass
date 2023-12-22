using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TodoList
{
    internal class Utilities
    {
        public Operations operations;
        public List<string> TodoList;
        public Utilities(Operations operationsInstance, List<string> todoList)
        {
            this.operations = operationsInstance;
            this.TodoList = todoList;
        }


        /// <summary>
        /// Validates inputs
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="regex">Regex to validate</param>
        /// <returns>T</returns>
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

        /// <summary>
        /// Display message to console.
        /// </summary>
        public void DisplayMessage()
        {
            var isExitRequested = false;

            while (!isExitRequested)
            {
                StringBuilder stringBuilder = new StringBuilder(
                    "Choose any operation : " +
                    "\n1. Add a TODO " +
                    "\n2. View TODO " +
                    "\n3. Delete TODO " +
                    "\n4. Update TODO " +
                    "\n5. Exit");
                Console.WriteLine(stringBuilder);

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter Description to add : ");
                        operations.AddToDoItems(ValidateInputs<string>(Constants.regexForAlphabet));
                        break;
                    case "2":
                        if (TodoList.Count > 0)
                        {
                            Console.WriteLine("Items in ToDo list are :  ");
                            operations.ViewToDoItems();
                        }
                        else
                        {
                            Console.WriteLine("ToDo List is Empty ! \nAdd items !");
                        }
                        break;
                    case "3":
                        if (TodoList.Count > 0)
                        {
                            Console.WriteLine("Enter index to delete : ");
                            int.TryParse(ValidateInputs<string>(Constants.regexForIndex), out int index);
                            operations.RemoveFromToDoItems(index);
                        }
                        else
                        {
                            Console.WriteLine("ToDo List is Empty ! \nAdd items !");
                        }
                        break;
                    case "4":
                        if (TodoList.Count > 0)
                        {
                            Console.WriteLine("Enter index to update : ");
                            int.TryParse(ValidateInputs<string>(Constants.regexForIndex), out int indexToUpdate);
                            operations.UpdateTodoItems(indexToUpdate);
                        }
                        else
                        {
                            Console.WriteLine("ToDo List is Empty ! \nAdd items !");
                        }
                        break;
                    case "5":
                        isExitRequested = true;
                        Console.WriteLine("Thank You ! \nExiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice !");
                        break;
                }
            }
        }
    }
}
