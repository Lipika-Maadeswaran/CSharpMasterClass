using GameDataParser.App;
using GameDataParser.DataAccess;
using GameDataParser.UserInteraction;
using log4net.Config;
using System.Linq.Expressions;

namespace GameDataParser
{
    internal class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()!.DeclaringType);

        public static void Main(string[] args)
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));

            Console.WriteLine("Welcome to World of Games!");

            var userInteractor = new UserInteractor();
            var fileReader = new FileReader();
            var gamesPrinter = new GamesPrinter(userInteractor);
            var videoGameDeserializer = new VideoGameDeserializer(userInteractor);

            var gameDataParser = new GameDataParserApplication(
                userInteractor,
                fileReader,
                gamesPrinter,
                videoGameDeserializer
                ); 

            try
            {
                gameDataParser.RunProcess();
            }
            catch(Exception ex)
            {
                userInteractor.PrintError($"The application has experianced an unexpected error ! {ex.Message}");
                log.Info($"Exception Message : {ex.Message} \nStack Trace : {ex.StackTrace}");
            }
        }
    }
}