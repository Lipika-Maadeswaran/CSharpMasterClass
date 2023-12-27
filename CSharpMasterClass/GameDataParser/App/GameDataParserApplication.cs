using GameDataParser.DataAccess;
using GameDataParser.UserInteraction;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.App
{
    internal class GameDataParserApplication
    {
        private readonly IUserInteractor _userInteractor;
        private readonly IFileReader _fileReader;
        private readonly IGamesPrinter _gamesPrinter;
        private readonly IVideoGameDeserializer _videoGameDeserializer;

        public GameDataParserApplication(
            IUserInteractor userInteractor,
            IFileReader fileReader,
            IGamesPrinter gamesPrinter,
            IVideoGameDeserializer videoGameDeserializer)
        {
            _userInteractor = userInteractor;
            _fileReader = fileReader;
            _gamesPrinter = gamesPrinter;
            _videoGameDeserializer = videoGameDeserializer;
        }

        public void RunProcess()
        {
            string fileName = _userInteractor.GetFileNameFromUser();
            string fileContents = _fileReader.ReadContentFromFile(fileName);
            var videoGames = _videoGameDeserializer.DeSerialize(fileContents);
            _gamesPrinter.Print(videoGames);
        }
    }
}
