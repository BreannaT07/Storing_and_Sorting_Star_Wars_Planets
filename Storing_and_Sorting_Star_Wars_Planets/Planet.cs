using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storing_and_Sorting_Star_Wars_Planets
{
    public class Planet
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public string Region { get; set; }

        public Planet(string name, int population, string region)
        {
            Name = name;
            Population = population;
            Region = region;
        }

        public void DisplayPlanetInfo()
        {
            Console.WriteLine($"Name: {Name}, Population: {Population}, Region: {Region}");
        }

        public static void AddPlanet(List<Planet> planets)
        {
            Console.Write("Enter the name of the planet: ");
            string name = Console.ReadLine();

            Console.Write("Enter the population of the planet: ");
            int population = int.Parse(Console.ReadLine());

            Console.Write("Enter the region of the planet: ");
            string region = Console.ReadLine();

            planets.Add(new Planet(name, population, region));
        }
    }
}
