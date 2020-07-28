using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ProcessingOptions
    {
        public static void CollectInput()
        {
            Console.WriteLine("1. Seed Harvester");
            Console.WriteLine("2. Meat Processor");
            Console.WriteLine("3. Egg Gatherer");
            Console.WriteLine("4. Composter");
            Console.WriteLine("5. Feather Harvester");

            Console.WriteLine();
            Console.WriteLine("Choose equipment to use.");

            Console.Write("> ");
            string input = Console.ReadLine();


            if (input == "1")
            {
            Console.WriteLine("Seed Harvestor");
            }
            else if (input == "2")
            {
                 Console.WriteLine("Meat Processor");

            }
            else if (input == "3")
            {
             Console.WriteLine("Egg Gatherer");

            }
            else if (input == "4")
            {
                Console.WriteLine("Composter");
            }
            else if (input == "5")
            {
              Console.WriteLine("Feather Harvester");

            }
            else
            {
                Console.WriteLine($"Invalid input: {input}");
            }

        }

    }
}