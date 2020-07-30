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

            //List filtering out Natrual Fields that are at capactity
            List<NaturalField> openNaturalFields = farm.NaturalFields.Where(field => field.PlantsCount() < field.Capacity).ToList();

            //Prints the list of fields that aren't at capacity
            Console.WriteLine("0. Return to main menu");
            for (int i = 0; i < openNaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field  (Plants: {openNaturalFields[i].PlantsCount()})");
            }


            Console.WriteLine();

            // How can I output the type of plant chosen here?
            Console.WriteLine($"Place the plant where?");

            Console.Write("> ");

            while (true)
            {
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    if (choice >= 1 && choice <= openNaturalFields.Count)
                    {
                        openNaturalFields[choice - 1].AddResource(plant);
                        Console.WriteLine("The plant was successfully added to the natural field.");
                        Thread.Sleep(2000);
                        break;
                    }
                    else if (choice == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input.  Please try again.");
                        Console.Write("> ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect input.");
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