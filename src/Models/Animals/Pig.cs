using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Pig : IResource, IGrazing, IMeatProducing {

        //A 128-bit unique ID that is automatically generated
        private Guid _id = Guid.NewGuid();

        //Each cow produces 8.4kg of meat
        private double _meatProduced = 8.4;

        //ShortId is a version of the _id that only shows the first few characters. It's used a lot in ToString() functions
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        //Feed set to 3.2 kg per day
        public double GrassPerDay { get; set; } = 3.2;

        //Type set to pig
        public string Type { get; } = "Pig";

        // Methods

        //Graze method names the pig by its short ID and displays how much grass it consumed
        public void Graze () {
            Console.WriteLine($"Pig {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        //Method to process the pig into meat.
        public double Butcher () {
            return _meatProduced;
        }

        //A method to make an specific pig say Oink!
        public override string ToString () {
            return $"Pig {this._shortId}. Oink!";
        }
    }
}