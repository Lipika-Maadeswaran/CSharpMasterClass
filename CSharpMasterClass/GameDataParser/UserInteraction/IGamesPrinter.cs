using GameDataParser.Model;

namespace GameDataParser.UserInteraction
{
    internal interface IGamesPrinter
    {
        public void Print(List<VideoGame> videoGames);
    }
}