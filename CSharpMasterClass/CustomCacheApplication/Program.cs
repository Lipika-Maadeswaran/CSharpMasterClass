using CustomCacheApplication.DataDownload;

namespace CustomCacheApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Caching Mechanism");

            //Using Caching
            Console.WriteLine("Using Caching");
            var dataDownloader = new CachingDataDownloader(
                new DataDownloader());
            Console.WriteLine(dataDownloader.DownloadData("Id1"));
            Console.WriteLine(dataDownloader.DownloadData("Id2"));
            Console.WriteLine(dataDownloader.DownloadData("Id3"));
            Console.WriteLine(dataDownloader.DownloadData("Id2"));
            Console.WriteLine(dataDownloader.DownloadData("Id1"));


            //Without using Caching
            Console.WriteLine("\nWithout using Caching");
            var dataDownloaderWithoutCaching = new DataDownloader();
            Console.WriteLine(dataDownloaderWithoutCaching.DownloadData("Id1"));
            Console.WriteLine(dataDownloaderWithoutCaching.DownloadData("Id2"));
            Console.WriteLine(dataDownloaderWithoutCaching.DownloadData("Id3"));
            Console.WriteLine(dataDownloaderWithoutCaching.DownloadData("Id2"));
            Console.WriteLine(dataDownloaderWithoutCaching.DownloadData("Id1"));
        }
    }
}