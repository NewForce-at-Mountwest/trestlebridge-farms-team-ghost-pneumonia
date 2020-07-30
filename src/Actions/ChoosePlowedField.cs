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

         
                Console.WriteLine("0. Return to Main Menu");
           

            for (int i = 0; i < openPlowedFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field (Plants: {openPlowedFields[i].PlantsCount()})");
            }


            Console.WriteLine();

            // How can I output the type of plant chosen here?
            Console.WriteLine($"Place the plant where?");
            

            Console.Write("> ");

            //Checks that the correct input was entered.
            while (true)
            {
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    if (choice >= 1 && choice <= openPlowedFields.Count)
                    {
                        openPlowedFields[choice - 1].AddResource(plant);
                        Console.WriteLine("The plant was successfully added to the plowed field.");
                        Thread.Sleep(2000);
                        break;
                    }
                    else if(choice == 0)
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
                    Console.WriteLine("Incorrect input.  Please try again.");
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