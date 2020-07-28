using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, Chicken animal)
        {
            Boolean choiceBoolean = true;
            Utils.Clear();

            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House ({farm.ChickenHouses[i].AnimalCount} animals)");
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
                if (choice < 1 || choice > farm.ChickenHouses.Count)
                {
                    Console.WriteLine("Please input a number corresponding to a choice");
                }
                else if (farm.ChickenHouses[choice - 1].AnimalCount >= farm.ChickenHouses[choice - 1].Capacity)
                {
                    Console.WriteLine("This house is full, please choose another!");
                }
                else
                {
                    choiceBoolean = false;
                }
            }

            farm.ChickenHouses[choice - 1].AddResource(animal);
            Console.WriteLine("Chicken successfully added to the house! Press enter to return to the main menu.");
            Console.ReadLine();

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}