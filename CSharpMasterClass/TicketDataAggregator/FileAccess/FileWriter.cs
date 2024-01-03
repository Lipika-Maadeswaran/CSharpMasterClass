using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TicketDataAggregator.FileAccess.FileWriter;

namespace TicketDataAggregator.FileAccess
{

    public class FileWriter : IFileWriter
    {
        public void Write(
            string content, params string[] pathParts)
        {
            var resultPath = Path.Combine(pathParts);
            File.WriteAllText(resultPath, content);
            Console.WriteLine("Results saved to " + resultPath);
        }
    }

}
