using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storing_and_Sorting_Star_Wars_Planets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Planet> planets = new List<Planet>();

            planets.Add(new Planet("Endor", 30000, "Outer Rim Territories"));
            planets.Add(new Planet("Naboo", 450000000, "Mid Rim"));
            planets.Add(new Planet("Tatooine", 200000, "Outer Rim Territories"));
            planets.Add(new Planet("Coruscant", 100000000, "Core Worlds"));

            Console.WriteLine("List of Star Wars Planets:");
            foreach (Planet planet in planets)
            {
                planet.DisplayPlanetInfo();
            }

            planets.Sort((p1, p2) => p1.Population.CompareTo(p2.Population));

            Console.WriteLine("\nPlanets sorted by population:");
            foreach(Planet planet in planets)
            {
                planet.DisplayPlanetInfo();
            }

            bool addingPlanets = true;

            while(addingPlanets)
            {
                Console.Write("Do you want to add a new planet? (yes/no): ");
                string response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    Planet.AddPlanet(planets);
                }
                else
                {
                    addingPlanets = false;
                }
            }

            planets.Sort((p1, p2) => p1.Population.CompareTo(p2.Population));

            Console.WriteLine("\nUpdated list of planets sorted by population:");
            foreach (Planet planet in planets)
            {
                planet.DisplayPlanetInfo();
            }


            Console.ReadKey();
        }
    }
}
