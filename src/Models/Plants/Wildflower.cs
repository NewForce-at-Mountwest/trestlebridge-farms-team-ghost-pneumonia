using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ICompostProducingPlant
    {
        private double _compostProduced = 0.51;
        public string Type { get; } = "Wildflower";

        public double HarvestCompost()
        {
            return 0.51;
        }

        public override string ToString () {
            return $"Wildflower. Yum!";
        }
    }

    
}