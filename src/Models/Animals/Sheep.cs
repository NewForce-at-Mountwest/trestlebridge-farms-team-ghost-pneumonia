using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Sheep : IResource, IGrazing, IMeatProducing {

        //A 128-bit unique ID that is automatically generated
        private Guid _id = Guid.NewGuid();

        //Each sheep produces 5kg of meat
        private double _meatProduced = 5.0;

        //ShortId is a version of the _id that only shows the first few characters. It's used a lot in ToString() functions
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        //Feed set to 4 kg per day
        public double GrassPerDay { get; set; } = 4;

        //Type set to sheep
        public string Type { get; } = "Sheep";

        // Methods

        //Graze method names the sheep by its short ID and displays how much grass it consumed
        public void Graze () {
            Console.WriteLine($"Sheeo {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        //Method to process the sheep into meat.
        public double Butcher () {
            return _meatProduced;
        }

        //A method to make an specific sheep say Baaa!
        public override string ToString () {
            return $"Sheep {this._shortId}. Baaa!";
        }
    }
}