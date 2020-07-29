using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseBothPlantFields
    {
        public static void CollectInput<T>(Farm farm, T plant)
        where T : ISeedProducing, ICompostProducingPlant
        {
            Utils.Clear();

            List<PlowedField> openPlowedFields = farm.PlowedFields.Where(field => field.PlantsCount() < field.Capacity).ToList();
            List<NaturalField> openNaturalFields = farm.NaturalFields.Where(field => field.PlantsCount() < field.Capacity).ToList();

            if (openPlowedFields.Count + openNaturalFields.Count == 0)
            {
                Console.WriteLine("0. Return to main menu");
            }

            for (int i = 0; i < openPlowedFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field  (Plants: {openPlowedFields[i].PlantsCount()})");
            }

            for (int i = openPlowedFields.Count; i < openPlowedFields.Count + openNaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field  (Plants: {openNaturalFields[i - openPlowedFields.Count].PlantsCount()})");
            }


            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the plant where?");

            Console.Write("> ");
            while (true)
            {
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    if (choice >= 1 && choice <= openPlowedFields.Count)
                    {
                        openPlowedFields[choice - 1].AddResource(plant);
                        break;

                    }
                    else if (choice > openPlowedFields.Count && choice <= openPlowedFields.Count + openNaturalFields.Count)
                    {
                        openNaturalFields[choice - 1 - openPlowedFields.Count].AddResource(plant);
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Number was not in the correct range.  Please try again");
                        Console.Write("> ");
                    };
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect input.  Please try again!");
                    Console.Write("> ");
                }
            }



            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}