using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCacheApplication.DataDownload
{
    internal interface IDataDownloader
    {
        public string DownloadData(string data);

    }
}
