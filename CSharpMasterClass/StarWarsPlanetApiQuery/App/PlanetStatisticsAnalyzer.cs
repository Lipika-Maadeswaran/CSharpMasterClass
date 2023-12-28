using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using StarWarsPlanetApiQuery.DTO;

namespace StarWarsPlanetApiQuery.App
{
    internal class PlanetStatisticsAnalyzer
    {
        private readonly Planet _planet;
        public PlanetStatisticsAnalyzer(Planet planet)
        {
            _planet = planet;
        }


        public void PlanetsDiameter()
        {
            var planetsDiameter = _planet.results
            .Where(results => long.TryParse(results.diameter, out _))
            .Select(results => new { Name = results.name, Diameter = long.Parse(results.diameter) })
            .ToList();

            if (planetsDiameter.Any())
            {
                var minDiameter = planetsDiameter
                    .OrderBy(results => results.Diameter)
                    .First();

                Console.WriteLine($"Planet with the minimum Diameter is: {minDiameter.Name}" +
                    $" with Diameter : {minDiameter.Diameter}");

                var maxDiameter = planetsDiameter
                    .OrderBy(results => results.Diameter)
                    .Last();

                Console.WriteLine($"Planet with the Maximum Diameter is: {maxDiameter.Name}" +
                    $" with Diameter : {maxDiameter.Diameter}");
            }
        }

        public void PlanetsSurfaceWater()
        {
            var planetsSurfaceWater = _planet.results
            .Where(results => long.TryParse(results.surface_water, out _))
            .Select(results => new { Name = results.name, SurfaceWater = long.Parse(results.surface_water) })
            .ToList();

            if (planetsSurfaceWater.Any())
            {
                var minSurfaceWaterPlanet = planetsSurfaceWater
                    .OrderBy(planet => planet.SurfaceWater)
                    .First();

                Console.WriteLine($"Planet with the minimum SurfaceWater is: {minSurfaceWaterPlanet.Name}" +
                    $" with SurfaceWater : {minSurfaceWaterPlanet.SurfaceWater}");

                var maxSurfaceWaterPlanet = planetsSurfaceWater
                    .OrderBy(planet => planet.SurfaceWater)
                    .Last();

                Console.WriteLine($"Planet with the maximum SurfaceWater is: {maxSurfaceWaterPlanet.Name}" +
                    $" with SurfaceWater : {maxSurfaceWaterPlanet.SurfaceWater}");
            }
            else
            {
                Console.WriteLine("No planets with known Surface water found.");
            }
        }

        public void PlanetsPopulation()
        {
            var planetsPopulation = _planet.results
            .Where(results => long.TryParse(results.population, out _))
            .Select(results => new { Name = results.name, Population = long.Parse(results.population) })
            .ToList();

            if (planetsPopulation.Any())
            {
                var minPopulation = planetsPopulation
                    .OrderBy(results => results.Population)
                    .First();

                Console.WriteLine($"Planet with the minimum population is: {minPopulation.Name}" +
                    $" with population : {minPopulation.Population}");

                var maxPopulation = planetsPopulation
                    .OrderBy(results => results.Population)
                    .Last();

                Console.WriteLine($"Planet with the Maximum population is: {maxPopulation.Name}" +
                    $" with population : {maxPopulation.Population}");
            }
        }
    }
}
