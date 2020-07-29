using System;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ProcessingOptions
    {
        public static void CollectInput()
        {
            //menu for processing resources
            Console.WriteLine("1. Seed Harvester");
            Console.WriteLine("2. Meat Processor");
            Console.WriteLine("3. Egg Gatherer");
            Console.WriteLine("4. Composter");
            Console.WriteLine("5. Feather Harvester");

            Console.WriteLine();
            Console.WriteLine("Choose equipment to use.");

            Console.Write("> ");
            string input = Console.ReadLine();

          //added timer and a console writeline to test if the options menu works the way it's supposed to
            if (input == "1")
            {
                Console.WriteLine("Seed Harvestor");
                Thread.Sleep(2000);
            }
            else if (input == "2")
            {
                Console.WriteLine("Meat Processor");
                Thread.Sleep(2000);

            }
            else if (input == "3")
            {
                Console.WriteLine("Egg Gatherer");
                Thread.Sleep(2000);

            }
            else if (input == "4")
            {
                Console.WriteLine("Composter");
                Thread.Sleep(2000);
            }
            else if (input == "5")
            {
                Console.WriteLine("Feather Harvester");
                Thread.Sleep(2000);

            }
            else
            {
                //error handling
                Console.WriteLine($"Invalid input: {input}");
                Console.WriteLine("Returning to the main menu");
                Thread.Sleep(2000);
            }

        }

    }
}