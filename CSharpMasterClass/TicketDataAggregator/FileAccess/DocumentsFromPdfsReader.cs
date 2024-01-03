using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

namespace TicketDataAggregator.FileAccess
{

    public class DocumentsFromPdfsReader : IDocumentsReader
    {
        public IEnumerable<string> Read(string directory)
        {
            foreach (var filePath in Directory.GetFiles(
                directory, "*.pdf"))
            {
                using PdfDocument document = PdfDocument.Open(filePath);
                // Page number starts from 1, not 0.
                Page page = document.GetPage(1);
                yield return page.Text;
            }
        }
    }

}
