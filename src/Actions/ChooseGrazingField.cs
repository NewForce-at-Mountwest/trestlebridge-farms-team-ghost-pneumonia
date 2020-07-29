using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Boolean choiceBoolean = true;
            Boolean placeBoolean = true;
            IResource animalResource = (IResource) animal;
            Utils.Clear();

            List<GrazingField> availableFields = farm.GrazingFields.Where(singleField => singleField.AnimalCount < singleField.Capacity).ToList(); 

            if(availableFields.Count == 0){
                    Console.WriteLine("0. Return to main menu");
            }

            for (int i = 0; i < availableFields.Count; i++)
            {
                if(i == 0){
                    Console.WriteLine("0. Return to main menu");
                }
                Console.WriteLine($"{i + 1}. Grazing Field ({availableFields[i].AnimalCount} animals, out of {availableFields[i].Capacity})");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the {animalResource.Type} where?");

            int choice = -1;

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
                if (choice == 0){
                    choiceBoolean = false;
                    placeBoolean = false;
                }
                else if (choice < 1 || choice > availableFields.Count)
                {
                    Console.WriteLine("Please input a number corresponding to a choice");
                }
                else if (availableFields[choice - 1].AnimalCount >= availableFields[choice - 1].Capacity)
                {
                        Console.WriteLine("This field is full, please choose another!");
                }
                else
                {
                    choiceBoolean = false;
                }
            }

            if (placeBoolean)
            {
                availableFields[choice - 1].AddResource(animal);
                Console.WriteLine($"{animalResource.Type} successfully added to the field! Press enter to return to the main menu.");
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