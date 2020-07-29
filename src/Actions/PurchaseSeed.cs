using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class PurchaseSeed
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("0. Return to Main Menu");
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Sunflower");
            Console.WriteLine("3. Wildflower");


            Console.WriteLine();
            Console.WriteLine("Choose seed to purchase.");

            Console.Write("> ");

            while (true)
            {
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            break;
                        case 1:
                            ChoosePlowedField.CollectInput(farm, new Sesame());
                            break;
                        case 2:
                            ChooseBothPlantFields.CollectInput(farm, new Sunflower());
                            break;
                        case 3:
                            ChooseNaturalField.CollectInput(farm, new Wildflower());
                            break;
                        default:
                            Console.WriteLine("That is not the correct input.  Please try again.");
                            Console.Write("> ");
                            break;
                    }
                    if (choice >= 0 && choice <= 3)
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("That is not the correct input.  Please try again.");
                    Console.Write("> ");
                }
            }
        }
    }
}