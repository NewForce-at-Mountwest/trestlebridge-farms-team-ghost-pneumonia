using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Cow : IResource, IGrazing, IMeatProducing {

        //A 128-bit unique ID that is automatically generated
        private Guid _id = Guid.NewGuid();

        //Each cow produces 18.25kg of meat
        private double _meatProduced = 18.25;

        //ShortId is a version of the _id that only shows the first few characters. It's used a lot in ToString() functions
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        //Feed set to 5.4 kg per day
        public double GrassPerDay { get; set; } = 5.4;

        //Type set to cow
        public string Type { get; } = "Cow";

        // Methods

        //Graze method names the cow by its short ID and displays how much grass it consumed
        public void Graze () {
            Console.WriteLine($"Cow {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        //Method to process the cow into meat.
        public double Butcher () {
            return _meatProduced;
        }

        //A method to make an specific cow say Mooo!
        public override string ToString () {
            return $"Cow {this._shortId}. Mooo!";
        }
    }
}