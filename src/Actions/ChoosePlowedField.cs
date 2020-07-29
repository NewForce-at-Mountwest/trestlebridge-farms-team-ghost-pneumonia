using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, ISeedProducing plant)
        {
            Utils.Clear();

            List<PlowedField> openPlowedFields = farm.PlowedFields.Where(field => field.PlantsCount() < field.Capacity).ToList();

            if (farm.PlowedFields.Count == 0)
            {
                Console.WriteLine("0. Return to main menu");
            }

            for (int i = 0; i < openPlowedFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field (Plants: {openPlowedFields[i].PlantsCount()})");
            }


            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the plant where?");

            Console.Write("> ");
            try
            {
                int choice = Int32.Parse(Console.ReadLine());
                openPlowedFields[choice - 1].AddResource(plant);
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input.  Returning to main menu!");
                Thread.Sleep(3000);
            }

            

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}