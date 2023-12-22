using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    internal class Operations
    {
        List<string> TodoList;
        public Operations(List<string> todoList)
        {
            this.TodoList = todoList;
        }

        /// <summary>
        /// Add items to ToDo list.
        /// </summary>
        /// <param name="itemToAdd">Value to be added.</param>
        public void AddToDoItems(string itemToAdd)
        {
            if(!TodoList.Contains(itemToAdd))
            {
                TodoList.Add(itemToAdd);
                Console.WriteLine($"{itemToAdd} - Added successfully");
            }
            else
            {
                Console.WriteLine("Invalid item!");
            }
        }

        /// <summary>
        /// View ToDo List.
        /// </summary>
        public void ViewToDoItems()
        {
            if (TodoList.Count > 0)
            {
                int i = 1;
                foreach (string item in TodoList)
                {
                    Console.WriteLine($"{i}. {item}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No items added !");
            }
        }

        /// <summary>
        /// Removes the item from TODO List.
        /// </summary>
        /// <param name="itemToRemove">Index to Remove.</param>
        public void RemoveFromToDoItems(int itemToRemove)
        {
            if (itemToRemove < TodoList.Count+1)
            {
                Console.WriteLine($"{TodoList[itemToRemove-1]} - Deleted successfully");
                TodoList.RemoveAt(itemToRemove - 1);
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }

        /// <summary>
        /// Updates the items in TODO List.
        /// </summary>
        /// <param name="itemToUpdate">Index to update.</param>
        public void UpdateTodoItems(int itemToUpdate)
        {
            if (itemToUpdate < TodoList.Count+1)
            {
                Console.WriteLine("Enter description : ");
                var updatedValue = Console.ReadLine();
                TodoList[itemToUpdate - 1] = updatedValue!;
                Console.WriteLine("value Updated Successfully !");
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }

    }
}
