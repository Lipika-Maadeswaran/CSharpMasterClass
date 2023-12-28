using ConsoleTables;
using StarWarsPlanetApiQuery.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsPlanetApiQuery.UserInteraction
{
    internal class UserInteractor
    {
        private readonly Planet _planet;
        public UserInteractor(Planet planet)
        {
            _planet = planet;
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void DisplayPlanetTable()
        {
            var displayPlanets = new ConsoleTable("Name", "Diameter", "Surface water", "Population");
            foreach (var planet in _planet.results)
            {
                displayPlanets.AddRow(planet.name, planet.diameter, planet.surface_water, planet.population);
            }

            displayPlanets.Write();
        }
    }
}
