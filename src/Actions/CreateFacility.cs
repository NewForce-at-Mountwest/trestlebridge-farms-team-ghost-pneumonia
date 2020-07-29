using System;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Natural field");
            Console.WriteLine("4. Chicken House");
            Console.WriteLine("5. Duck House");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

          //menu for creating facilities
          //changed it from the code that was given 
          //now it looks and functions just like the main menu
            if (input == "1")
            {
                farm.AddGrazingField(new GrazingField());
                Console.WriteLine("Your Facility has been added");

            }
            else if (input == "2")
            {
                farm.AddPlowedField(new PlowedField());
                Console.WriteLine("Your Facility has been added");

            }
            else if (input == "3")
            {
                farm.AddNaturalField(new NaturalField());
                Console.WriteLine("Your Facility has been added");

            }
            else if (input == "4")
            {
                farm.AddChickenHouse(new ChickenHouse());
                Console.WriteLine("Your Facility has been added");

            }
            else if (input == "5")
            {
                farm.AddDuckHouse(new DuckHouse());
                Console.WriteLine("Your Facility has been added");

            }
            //error handling
            else
            {
                Console.WriteLine($"Invalid input: {input}");
                Console.WriteLine("Returning to the main menu");
                Thread.Sleep(2000);
            }

        }

    }
}

