using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {
        public static void CollectInput(Farm farm)
        {
            Boolean choiceBoolean = true;
            int choice = -1;

            Console.WriteLine("0. Back to main menu");
            Console.WriteLine("1. Cow");
            Console.WriteLine("2. Pig");
            Console.WriteLine("3. Chicken");
            Console.WriteLine("4. Duck");
            Console.WriteLine("5. Goat");
            Console.WriteLine("6. Ostrich");
            Console.WriteLine("7. Sheep");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");
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
                if (choice < 0 || choice > 7)
                {
                    Console.WriteLine("Please input a number corresponding to a choice");
                }
                else
                {
                    choiceBoolean = false;
                }
            }
            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                case 2:
                    ChooseGrazingField.CollectInput(farm, new Pig());
                    break;
                case 3:
                    ChooseChickenHouse.CollectInput(farm, new Chicken());
                    break;
                case 4:
                    ChooseDuckHouse.CollectInput(farm, new Duck());
                    break;
                case 5:
                    ChooseGrazingField.CollectInput(farm, new Goat());
                    break;
                case 6:
                    ChooseGrazingField.CollectInput(farm, new Ostrich());
                    break;
                case 7:
                    ChooseGrazingField.CollectInput(farm, new Sheep());
                    break;
                default:
                    break;
            }

        }
    }
}