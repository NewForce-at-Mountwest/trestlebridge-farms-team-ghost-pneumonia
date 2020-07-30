using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, Chicken animal)
        {
            Boolean choiceBoolean = true;
            Boolean placeBoolean = true;
            Utils.Clear();

            List<ChickenHouse> availableHouses = farm.ChickenHouses.Where(singleHouse => singleHouse.AnimalCount < singleHouse.Capacity).ToList(); 

            if(availableHouses.Count == 0){
                    Console.WriteLine("0. Return to main menu");
            }

            for (int i = 0; i < availableHouses.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("0. Return to main menu");
                }
                string chickenString = "chicken";
                if (availableHouses[i].AnimalCount != 1){
                    chickenString += "s";
                }
                Console.WriteLine($"{i + 1}. Chicken House ({availableHouses[i].AnimalCount} {chickenString})");
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
                else if (choice < 1 || choice > availableHouses.Count)
                {
                    Console.WriteLine("Please input a number corresponding to a choice");
                }
                else if (availableHouses[choice - 1].AnimalCount >= availableHouses[choice - 1].Capacity)
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
                availableHouses[choice - 1].AddResource(animal);
                Console.WriteLine("Chicken successfully added to the house! Press enter to return to the main menu.");
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