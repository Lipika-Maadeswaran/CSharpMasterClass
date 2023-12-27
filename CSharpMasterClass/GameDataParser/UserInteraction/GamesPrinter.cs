using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDataParser.Model;

namespace GameDataParser.UserInteraction
{
    internal class GamesPrinter : IGamesPrinter
    {
        private readonly IUserInteractor _userInteractor;

        public GamesPrinter(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public void Print(List<VideoGame> videoGames)
        {
            if (videoGames.Count > 0)
            {
                _userInteractor.DisplayMessage("Loaded Games are : ");
                foreach (var videoGame in videoGames)
                {
                    _userInteractor.DisplayMessage($"{videoGame.Name}, released in {videoGame.ReleasedDate}, rating : {videoGame.Rating}");
                }
            }
            else
            {
                _userInteractor.DisplayMessage("No Games added in the file!");
            }
        }
    }
}
