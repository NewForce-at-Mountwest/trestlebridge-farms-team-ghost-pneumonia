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
            int choice = 1;


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
                if (choice < 1 || choice > 7)
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
                case 1:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                default:
                    break;
            }

        }
    }
}