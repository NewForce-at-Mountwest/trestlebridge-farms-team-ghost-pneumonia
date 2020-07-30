using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, ICompostProducingPlant
    {
        public string Type { get; } = "Sunflower";

        private int _seedsProduced = 150;

        private double _compostProduced = 0.36;
        public double Harvest()
        {
            return _seedsProduced;
        }

        public double HarvestCompost()
        {
            return _compostProduced;
        }

        public override string ToString()
        {
            return $"Sunflower. Yum!";
        }
    }
}