using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Ostrich : IResource, IGrazing, IMeatProducing, IEggProducing {

        //Creates a unique id for each ostrich, which is sometimes printed as a shortId by the ToString() function
        private Guid _id = Guid.NewGuid();
        //A double for how much meat is produced when an ostrich is processed
        private double _meatProduced = 2.6;
        private double _eggsProduced = 3;

        //ShortId is a version of the _id that only shows the first few characters. It's used a lot in ToString() functions
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        //How much grass each ostrich consumes per day
        public double GrassPerDay { get; set; } = 2.3;
        //Returns the type of animal, as a string
        public string Type { get; } = "Ostrich";

        // Methods
        //Just a print method using a shortID and grass per day
        public void Graze () {
            Console.WriteLine($"Ostrich {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        //Returns how much meat is produced per ostrich
        public double Butcher () {
            return _meatProduced;
        }

        //Called by other ToString() functions, returns a string including the ostrich's shortId
        public override string ToString () {
            return $"Ostrich {this._shortId}. Squack!";
        }

        public double GatherEggs()
        {
            return _eggsProduced;
        }
    }
}