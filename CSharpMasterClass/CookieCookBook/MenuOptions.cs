using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
    internal enum MenuOptions
    {
        /// <summary>
        /// Add ingredients to cook book.
        /// </summary>
        AddIngredient = 1,

        /// <summary>
        /// View ingredients in cook book.
        /// </summary>
        ViewIngredient = 2,

        
        /// <summary>
        /// Update the ingredients in cook book.
        /// </summary>
        UpdateIngredient = 3,

        /// <summary>
        /// Delete ingredient in cook book.
        /// </summary>
        RemoveIngredient = 4,

        /// <summary>
        /// Exit to main menu.
        /// </summary>
        MainMenu = 5,
    }
}
