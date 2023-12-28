using StarWarsPlanetApiQuery.DTO;

namespace StarWarsPlanetApiQuery.DataAccess
{
    internal interface IApiQueryReader
    {
        public Task<string> Read(string baseAddress, string requestUri);

        public Planet DeSerializePlanet(string json);
    }
}