using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    //Implements the Facility interface, and this is a facility with a type of IGrazing
    public class DuckHouse : IFacility<IGrazing>
    {
        //Stores an int for how many resources this facility can hold (12 grazing animals in this case)
        private int _capacity = 12;
        //Creates a unique id for this Duck House
        private Guid _id = Guid.NewGuid();

        //A list of grazing animals stored in this Duck house
        private List<IGrazing> _animals = new List<IGrazing>();

        //Returns the field capacity. Allows _capacity to stay private but still use that number elsewhere
        public double Capacity {
            get {
                return _capacity;
            }
        }

        //Adds a single grazing animal to the Duck House
        public void AddResource (IGrazing animal)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        //Adds a whole list of grazing animals to the Duck House
        public void AddResource (List<IGrazing> animals) 
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        //Outputs a large string of all resources stored in this Duck House
        public override string ToString()
        {
            //Creates a new string to store the upcoming info
            StringBuilder output = new StringBuilder();
            //Creates a short id by taking the first few characters of the regular id
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            //Adds to our output string
            output.Append($"Duck House {shortId} has {this._animals.Count} animals\n");
            //Calls the ToString() method for every animal in this Duck House and adds it to our output string
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            //Returns our output string
            return output.ToString();

            
        }
    }
}