using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck : IResource, IFeeding, IEggProducing, IFeatherProducing {

        //A 128-bit unique ID that is automatically generated
        private Guid _id = Guid.NewGuid();

        private double _eggsProduced = 6;
        private double _feathersProduced = .75;

        //ShortId is a version of the _id that only shows the first few characters. It's used a lot in ToString() functions
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        //Type set to duck
        public string Type { get; } = "Duck";
        public double FeedPerDay { get; set; } = 0.8;

        // Methods

        //A method to make an specific duck say QUOCK!
        public override string ToString () {
            return $"Duck {this._shortId}. QUOCK!";
        }

        public void EatFeed()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of feed");
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