using StarWarsPlanetApiQuery.App;
using StarWarsPlanetApiQuery.DataAccess;
using StarWarsPlanetApiQuery.UserInteraction;
using static System.Net.WebRequestMethods;

namespace StarWarsPlanetApiQuery
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            bool isExitRequested = false;
            string baseAddress = "https://swapi.dev/api/";
            string requestUri = "planets/?format=json";

            try
            {
                IApiQueryReader apiQueryReader = new ApiQueryReader();
                var json = await apiQueryReader.Read(baseAddress, requestUri);
                var planet = apiQueryReader.DeSerializePlanet(json);

                PlanetStatisticsAnalyzer operation = new PlanetStatisticsAnalyzer(planet);

                UserInteractor userInteractor = new UserInteractor(planet);

                userInteractor.DisplayMessage("Welcome to Star Wars Planet !\n");
                userInteractor.DisplayPlanetTable();

                while (!isExitRequested)
                {
                    userInteractor.DisplayMessage("\nThe statistics of which property would you like to see? " +
                        "\n1. Population " +
                        "\n2. Diameter " +
                        "\n3. Surface water " +
                        "\n4. Exit");

                    var choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            operation.PlanetsPopulation();
                            break;
                        case "2":
                            operation.PlanetsDiameter();
                            break;
                        case "3":
                            operation.PlanetsSurfaceWater();
                            break;
                        case "4":
                            isExitRequested = true;
                            Console.WriteLine("Thank You !");
                            break;
                        default:
                            Console.WriteLine("Invalid Input!");
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}