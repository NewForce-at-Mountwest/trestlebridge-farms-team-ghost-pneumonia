// using System;
// using Trestlebridge.Interfaces;
// using Trestlebridge.Models;
// using Trestlebridge.Models.Facilities;
// using Trestlebridge.Models.Plants;

// namespace Trestlebridge.Actions {
//     public class PurchaseSeed {
//         public static void CollectInput (Farm farm) {
//             Console.WriteLine ("1. Sesame");
//             Console.WriteLine ("2. Sunflower");
//             Console.WriteLine ("3. Wildflower");


//             Console.WriteLine ();
//             Console.WriteLine ("Choose seed to purchase.");

//             Console.Write ("> ");
//             string choice = Console.ReadLine ();

//             switch (Int32.Parse(choice))
//             {
//                 case 1:
//                     ChooseGrazingField.CollectInput(farm, new Sesame());
//                     break;
//                 default:
//                     break;
//             }
//         }
//     }
// }