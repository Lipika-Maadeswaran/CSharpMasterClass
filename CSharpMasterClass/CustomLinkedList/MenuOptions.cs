using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public enum MenuOptions
    {
        //Add items to list.
        Add = 1,

        //Add items to front.
        AddToFront = 2,

        //Add items to end.
        AddToEnd = 3,

        //Checks element present.
        Contains = 4,

        //Removes the element.
        Remove = 5,

        //Clears the list.
        Clear = 6,

        //Views all the item in list.
        View = 7,

        //Exits the application.
        Exit = 8
    }
}
