using System.Text;

namespace TodoList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                List<string> todoList = new List<string>();
                Operations operations = new Operations(todoList);
                Utilities utilities = new Utilities(operations, todoList);
                Console.WriteLine("Welcome to ToDoList Application!");

                utilities.DisplayMessage();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}