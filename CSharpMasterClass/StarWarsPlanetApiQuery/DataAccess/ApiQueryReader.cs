using Newtonsoft.Json;
using StarWarsPlanetApiQuery.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsPlanetApiQuery.DataAccess
{
    internal class ApiQueryReader : IApiQueryReader
    {
        public async Task<string> Read(string baseAddress, string requestUri)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            HttpResponseMessage response = await client.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            return json;

        }

        public Planet DeSerializePlanet(string json)
        {
            Planet planet = JsonConvert.DeserializeObject<Planet>(json)!;
            return planet;
        }
    }
}
