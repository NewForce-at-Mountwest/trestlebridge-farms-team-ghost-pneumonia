using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, ICompostProducingPlant plant)
        {
            Utils.Clear();

            List<NaturalField> openNaturalFields = farm.NaturalFields.Where(field => field.PlantsCount() < field.Capacity).ToList();


            if (openNaturalFields.Count == 0)
            {
                Console.WriteLine("0. Return to main menu");
            }

            for (int i = 0; i < openNaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field  (Plants: {openNaturalFields[i].PlantsCount()})");
            }


            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the plant where?");

            Console.Write("> ");
            try
            {
                int choice = Int32.Parse(Console.ReadLine());
                
                openNaturalFields[choice - 1].AddResource(plant);
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input.");
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