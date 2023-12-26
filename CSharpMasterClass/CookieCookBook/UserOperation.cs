using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
    internal class UserOperation
    {
        private User user;
        private readonly IFileOperation fileOperation;

        public UserOperation(User user, IFileOperation fileOperation)
        {
            this.user = user;
            this.fileOperation = fileOperation;
        }

        public User ActiveUser { get; set; }


        public void AddIngredient()
        {
           DisplayIngredient();
            Console.WriteLine("Choose your ingredient : " +
                "\nPressing Esc key would stop adding the ingredients!");

            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
                var ingredientNumber = Parser.Validate<int>(Constants.regexForNumbers, "Enter Ingredient number : ");

                if(ingredientNumber < Ingredient.Ingredients.Count)
                {
                    Ingredient.UserIngredients.Add(Ingredient.Ingredients[ingredientNumber - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid Input! Enter again");
                }
            }

            Console.WriteLine("Ingredients successfully added !");
        }

        public void DisplayIngredient()
        {
            Console.WriteLine("The Ingredients available : ");
            int i = 1;
            foreach (var ingredient in Ingredient.Ingredients)
            {
                Console.WriteLine($"{i}. {ingredient}");
                i++;
            }
        }

        public void ViewIngredient()
        {
            if (Ingredient.UserIngredients.Count < 0)
            {
                Console.WriteLine("Add Ingredients");
            }
            else
            {
                int i = 1;
                foreach (var ingredient in Ingredient.UserIngredients)
                {
                    Console.WriteLine($"{i}. {ingredient}");
                    i++;
                }
            }
        }

        public void UpdateIngredient()
        {
            ViewIngredient();

            var indexToUpdate = Parser.Validate<int>(Constants.regexForNumbers, "Choose which one to update !");

            if(indexToUpdate < Ingredient.UserIngredients.Count)
            {
                var valueToUpdate = Parser.Validate<string>(Constants.regexForAlphabet, "Enter value to update");

                Ingredient.UserIngredients[indexToUpdate] = valueToUpdate;
            }

        }

        public void DeleteIngredient()
        {
            ViewIngredient();

            var indexToDelete = Parser.Validate<int>(Constants.regexForNumbers, "Choose which one to delete !");

            if(indexToDelete < Ingredient.UserIngredients.Count)
            {
                Ingredient.UserIngredients.RemoveAt(indexToDelete - 1);
                Console.WriteLine("Successfully Deleted !");
            }

        }
    }
}
