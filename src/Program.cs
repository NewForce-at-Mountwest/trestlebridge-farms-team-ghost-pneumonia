using System;
using System.Linq;
using System.Threading;
using Trestlebridge.Actions;
using Trestlebridge.Models;

namespace Trestlebridge
{
    class Program
    {

        // method that displays the danner when the program runs
        static void DisplayBanner()
        {
            Utils.Clear();
            Console.WriteLine();
            Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
        |T||r||e||s||t||l||e||b||r||i||d||g||e|
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                    |F||a||r||m||s|
                    +-++-++-++-++-+");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {


            //color of the application
            //such an eyesore
            //who the hell though this was a good idea???
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;


            //instance of a new farm type
            Farm Trestlebridge = new Farm();


            //main menu
            while (true)
            {
                DisplayBanner();

                //list of options
                //added the option for processing options menu on option 5
                //changed exit to option 6
                Console.WriteLine("1. Create Facility");
                Console.WriteLine("2. Purchase Animals");
                Console.WriteLine("3. Purchase Seeds");
                Console.WriteLine("4. Display Farm Status");
                Console.WriteLine("5. Processing Options");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Choose a FARMS option");
                Console.Write("> ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    DisplayBanner();
                    CreateFacility.CollectInput(Trestlebridge);
                }
                else if (option == "2")
                {
                    DisplayBanner();
                    PurchaseStock.CollectInput(Trestlebridge);
                }
                else if (option == "4")
                {
                    DisplayBanner();
                    //Calls the ToString() function in Farm.cs. This sets off a cascade of calling multiple ToString() functions
                    Console.WriteLine(Trestlebridge);
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                }
                //this will bring you to the processing options menu
                else if (option == "5")
                {
                    //calls the display banner method
                    DisplayBanner();
                    //calls the collect input method from ProcessingOptions.cs
                    ProcessingOptions.CollectInput();
                }
                else if (option == "6")
                {
                    Console.WriteLine("Today is a great day for farming");
                    break;
                }
                else
                {
                    //this will tell you that whatever key you hit was invalid
                    Console.WriteLine($"Invalid option: {option}");
                    //this pauses the error message 
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
