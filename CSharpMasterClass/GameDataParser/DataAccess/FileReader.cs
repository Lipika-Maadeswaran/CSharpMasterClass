using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.DataAccess
{
    internal class FileReader : IFileReader
    {
        public string ReadContentFromFile(string fileName)
        {
            return File.ReadAllText(fileName);
        }
    }
}
