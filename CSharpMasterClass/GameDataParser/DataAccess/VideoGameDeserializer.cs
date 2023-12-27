using GameDataParser.Model;
using GameDataParser.UserInteraction;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.DataAccess
{
    internal class VideoGameDeserializer : IVideoGameDeserializer
    {
        private readonly IUserInteractor _userInteractor;

        public VideoGameDeserializer(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public List<VideoGame> DeSerialize(string content)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<VideoGame>>(content)!;

            }
            catch (JsonException ex)
            {
                _userInteractor.PrintError($" File was not in a valid format. JSON Body: {content}, {ex.Message}");
                throw new JsonException($"{ex.Message}", ex);
            }
        }
    }
}
