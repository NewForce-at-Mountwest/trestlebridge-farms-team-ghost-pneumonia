using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Boolean choiceBoolean = true;
            Utils.Clear();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                    Console.WriteLine($"{i + 1}. Grazing Field ({farm.GrazingFields[i].AnimalCount} animals)");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the {animal.Type} where?");

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
                if (choice < 1 || choice > farm.GrazingFields.Count)
                {
                    Console.WriteLine("Please input a number corresponding to a choice");
                }
                else if (farm.GrazingFields[choice - 1].AnimalCount >= farm.GrazingFields[choice - 1].Capacity)
                {
                    Console.WriteLine("This field is full, please choose another!");
                }
                else
                {
                    choiceBoolean = false;
                }
            }

            farm.GrazingFields[choice - 1].AddResource(animal);
            Console.WriteLine($"{animal.Type} successfully added to the field! Press enter to return to the main menu.");
            Console.ReadLine();

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}