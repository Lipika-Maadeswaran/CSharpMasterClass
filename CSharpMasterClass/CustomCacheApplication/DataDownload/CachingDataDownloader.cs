using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomCacheApplication.Model;

namespace CustomCacheApplication.DataDownload
{
    internal class CachingDataDownloader : IDataDownloader
    {
        private readonly IDataDownloader _dataDownloader;
        private readonly Cache<string, string> _cache = new();

        public CachingDataDownloader(IDataDownloader dataDownloader)
        {
            _dataDownloader = dataDownloader;
        }

        public string DownloadData(string data)
        {
            return _cache.GetData(data, _dataDownloader.DownloadData);
        }


    }
}
