using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.UserInteraction
{
    internal interface IUserInteractor
    {
        public string GetFileNameFromUser();

        public void DisplayMessage(string message);

        public void PrintError(string message);
    }
}
