namespace CustomLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userInteractor = new UserInteractor();
            var list = new SinglyLinkedList<int>();
            bool isExitRequested = false;

            while(!isExitRequested)
            {
                Console.WriteLine("The List of operations available :" +
                "\n1. Add " +
                "\n2. AddToFront  " +
                "\n3. AddToEnd " +
                "\n4. Contains " +
                "\n5. Remove " +
                "\n6. Clear" +
                "\n7. View Elements " +
                "\n8. Exit");
                Enum.TryParse(Console.ReadLine(), out MenuOptions choice);

                switch (choice)
                {
                    case MenuOptions.Add:
                        Console.WriteLine("Adding Elements: ");
                        var elementsToAdd = userInteractor.GetInputElements();
                        foreach(var element in elementsToAdd)
                        {
                            list.Add(element);
                        }
                        Console.WriteLine("Elements Added Successfully !");
                        break;
                    case MenuOptions.AddToFront:
                        Console.WriteLine("Adding Elements: ");
                        var elementsToAddFront = userInteractor.GetInputElements();
                        foreach (var element in elementsToAddFront)
                        {
                            list.AddToFront(element);
                        }
                        Console.WriteLine("Elements Added Successfully !");
                        break;
                    case MenuOptions.AddToEnd:
                        Console.WriteLine("Adding Elements: ");
                        var elementsToAddToEnd = userInteractor.GetInputElements();
                        foreach (var element in elementsToAddToEnd)
                        {
                            list.AddToEnd(element);
                        }
                        Console.WriteLine("Elements Added Successfully !");
                        break;
                    case MenuOptions.Contains:
                        Console.WriteLine("Enter element to check if contains : ");
                        var elementToCheck = userInteractor.ValidateInputs<int>(Constants.regexForIndex);
                        if (!list.Contains(elementToCheck))
                        {
                            Console.WriteLine("Element not present !");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Element present!");
                        }
                        break;
                    case MenuOptions.Remove:
                        Console.WriteLine("Enter element to check if contains : ");
                        var elementToRemove = userInteractor.ValidateInputs<int>(Constants.regexForIndex);
                        if (!list.Remove(elementToRemove))
                        {
                            Console.WriteLine("Element not present !");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Element deleted successfully!");
                        }
                        break;
                    case MenuOptions.Clear:
                        list.Clear();
                        break;
                    case MenuOptions.View:
                        foreach(var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case MenuOptions.Exit:
                        isExitRequested = true;
                        break;
                }
            }
        }
    }
}
