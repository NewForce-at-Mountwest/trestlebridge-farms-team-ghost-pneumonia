using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, Duck animal)
        {
            Boolean choiceBoolean = true;
            Boolean placeBoolean = true;
            Utils.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("0. Return to main menu");
                }
                Console.WriteLine($"{i + 1}. Duck House ({farm.DuckHouses[i].AnimalCount} animals, out of {farm.DuckHouses[i].Capacity})");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            int choice = 1;

            while (choiceBoolean)
            {
                Console.Write("> ");

                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("No number detected");
                }
                if (choice == 0)
                {
                    choiceBoolean = false;
                    placeBoolean = false;
                }
                else if (choice < 1 || choice > farm.DuckHouses.Count)
                {
                    Console.WriteLine("Please input a number corresponding to a choice");
                }
                else if (farm.DuckHouses[choice - 1].AnimalCount >= farm.DuckHouses[choice - 1].Capacity)
                {
                    Console.WriteLine("This house is full, please choose another!");
                }
                else
                {
                    choiceBoolean = false;
                }
            }

            if (placeBoolean)
            {
                farm.DuckHouses[choice - 1].AddResource(animal);
                Console.WriteLine("Duck successfully added to the house! Press enter to return to the main menu.");
                Console.ReadLine();
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}