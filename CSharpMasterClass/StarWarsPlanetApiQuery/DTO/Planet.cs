using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsPlanetApiQuery.DTO
{
    public record Result(
        [property: JsonProperty("name")] string name,
        [property: JsonProperty("rotation_period")] string rotation_period,
        [property: JsonProperty("orbital_period")] string orbital_period,
        [property: JsonProperty("diameter")] string diameter,
        [property: JsonProperty("climate")] string climate,
        [property: JsonProperty("gravity")] string gravity,
        [property: JsonProperty("terrain")] string terrain,
        [property: JsonProperty("surface_water")] string surface_water,
        [property: JsonProperty("population")] string population,
        [property: JsonProperty("residents")] IReadOnlyList<string> residents,
        [property: JsonProperty("films")] IReadOnlyList<string> films,
        [property: JsonProperty("created")] DateTime created,
        [property: JsonProperty("edited")] DateTime edited,
        [property: JsonProperty("url")] string url
    );

    public readonly record struct Planet(
        [property: JsonProperty("count")] int count,
        [property: JsonProperty("next")] string next,
        [property: JsonProperty("previous")] object previous,
        [property: JsonProperty("results")] IReadOnlyList<Result> results
    );


}
