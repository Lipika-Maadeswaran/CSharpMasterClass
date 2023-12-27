using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomCacheApplication.DataDownload
{
    internal class DataDownloader : IDataDownloader
    {
        public string DownloadData(string data)
        {
            Thread.Sleep(1000);
            return $"Some data for {data}";
        }
    }
}
