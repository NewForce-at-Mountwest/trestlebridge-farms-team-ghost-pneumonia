using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Goat : IResource, IGrazing, ICompostProducing {

        //A 128-bit unique ID that is automatically generated
        private Guid _id = Guid.NewGuid();

        private double _compostProduced = 7.5;


        //ShortId is a version of the _id that only shows the first few characters. It's used a lot in ToString() functions
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        //Feed set to 5.4 kg per day
        public double GrassPerDay { get; set; } = 5.4;

        //Type set to goat
        public string Type { get; } = "Goat";

        // Methods

        //Graze method names the cow by its short ID and displays how much grass it consumed
        public void Graze () {
            Console.WriteLine($"Goat {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        //A method to make an specific goat say Blaaa!
        public override string ToString () {
            return $"Goat {this._shortId}. Blaaa!";
        }

        public double GatherCompost()
        {
            return _compostProduced;
        }
    }
}