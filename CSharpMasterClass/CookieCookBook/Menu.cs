using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
    internal class Menu
    {
        public void UserMenu(User user, IFileOperation fileOperation)
        {
            UserOperation userOperation = new UserOperation(user, fileOperation);
            Console.Clear();
            bool isExitRequested = false;

            while(!isExitRequested)
            {
                StringBuilder userMenuOptions = new StringBuilder(
                    "Choose one operation : " +
                    "\n1. Add Ingredient " +
                    "\n2. View Ingredient " +
                    "\n3. Update Ingredient " +
                    "\n4. Delete Ingredient " +
                    "\n5. Exit");
                Console.WriteLine(userMenuOptions);

                Enum.TryParse(Console.ReadLine(),out MenuOptions menuOptions);

                switch(menuOptions)
                {
                    case MenuOptions.AddIngredient:
                        Console.WriteLine("Adding ingredient");
                        userOperation.AddIngredient();
                        break;
                    case MenuOptions.ViewIngredient:
                        userOperation.ViewIngredient();
                        break;
                    case MenuOptions.UpdateIngredient:
                        userOperation.UpdateIngredient();
                        break;
                    case MenuOptions.RemoveIngredient:
                        Console.WriteLine("Remove Ingredient");
                        userOperation.DeleteIngredient();
                        break;
                    case MenuOptions.MainMenu:
                        isExitRequested = true;
                        fileOperation.WriteDetailsToFile(user);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
