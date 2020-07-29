using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Chicken : IResource, IFeeding, IMeatProducing, IEggProducing, IFeatherProducing {

        //A 128-bit unique ID that is automatically generated
        private Guid _id = Guid.NewGuid();

        //Each chicken produces 18.25kg of meat
        private double _meatProduced = 1.7;
        private double _eggsProduced = 7;
        private double _feathersProduced = .5;

        //ShortId is a version of the _id that only shows the first few characters. It's used a lot in ToString() functions
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        //Type set to chicken
        public string Type { get; } = "Chicken";
        public double FeedPerDay { get; set; } = 0.9;

        // Methods

        //Method to process the chicken into meat.
        public double Butcher () {
            return _meatProduced;
        }

        //A method to make an specific chicken say Cluck!
        public override string ToString () {
            return $"Chicken {this._shortId}. Cluck!";
        }

        public void EatFeed()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }

        public double GatherEggs()
        {
            return _eggsProduced;
        }

        public double GatherFeathers()
        {
            return _feathersProduced;
        }
    }
}