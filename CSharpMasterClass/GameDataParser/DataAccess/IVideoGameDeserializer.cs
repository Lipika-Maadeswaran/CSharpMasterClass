using GameDataParser.Model;

namespace GameDataParser.DataAccess
{
    internal interface IVideoGameDeserializer
    {
        List<VideoGame> DeSerialize(string content);
    }
}