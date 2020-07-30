using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    //Implements the Facility interface, and this is a facility with a type of IGrazing
    public class NaturalField : IFacility<ICompostProducingPlant>
    {
        //Stores an int for how many resources this facility can hold (65 PLANTS)
        private int _capacity = 60;
        //Creates a unique id 
        private Guid _id = Guid.NewGuid();

        //A list of plants stored in this facility
        private List<ICompostProducingPlant> _plants = new List<ICompostProducingPlant>();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public int PlantsCount()
        {
            return _plants.Count;
        }
        public void AddResource(ICompostProducingPlant plant)
        {
            _plants.Add(plant);
        }

        public void AddResource(List<ICompostProducingPlant> plants)
        {
            _plants.AddRange(plants);
        }

        public override string ToString()
        {
            //Creates a new string to store the upcoming info
            StringBuilder output = new StringBuilder();
            //Creates a short id by taking the first few characters of the regular id
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            //Adds to our output string
            output.Append($"Natural field {shortId} has {this._plants.Count} plants\n");
            //Calls the ToString() method for every animal in this grazing field and adds it to our output string
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            //Returns our output string
            return output.ToString();


        }
    }
}