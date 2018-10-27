using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            // Add Jupiter and Saturn to planetList
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // Create a lastPlanets list that contains Neptune and Uranus
            List<string> lastPlanets = new List<string>() { "Neptune", "Uranus" };

            // Add lastPlanets to planetList
            planetList.AddRange(lastPlanets);

            // Insert Venus and Eart into the appropriate indexes in planetList
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            //  Add Pluto to planetList
            planetList.Add("Pluto");

            //  Get the rocky planets from planetList and move to another list
            var rockyPlanets = planetList.GetRange(0, 4);

            // Looping through planetList to see what's in it at this stage.
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            //  Looping through rockyPlanets to check if it only has Mercury, Venus, Earth, and Mars
            foreach (string rock in rockyPlanets)
            {
                Console.WriteLine(rock);
            }

            // Remove Pluto from planetList because it's not a real planet.  Sad.
            planetList.Remove("Pluto");

            // Checking to see if Pluto is no longer at the end of the list.
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }
        }
    }
}
