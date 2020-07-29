using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;


namespace Trestlebridge.Models.Facilities {
    //Implements the Facility interface, and this is a facility with a type of IGrazing
    //Dylan: Changed IGrazing to Duck, as Duck doesn't use the IGrazing interface
    public class DuckHouse : IFacility<Duck>
    {
        //Stores an int for how many resources this facility can hold (50 grazing animals in this case)
        private int _capacity = 12;
        //Creates a unique id for this grazing field
        private Guid _id = Guid.NewGuid();

        //A list of grazing animals stored in this grazing field
        private List<Duck> _animals = new List<Duck>();

        //Returns the field capacity. Allows _capacity to stay private but still use that number elsewhere
        public double Capacity {
            get {
                return _capacity;
            }
        }

        //Added by Dylan so that I can count how many animals are in each facility
        public int AnimalCount {
            get {
                return _animals.Count;
            }
        }

        //Adds a single grazing animal to the field
        public void AddResource (Duck animal)
        {
            // TODO: implement this...
            _animals.Add(animal);
        }

        //Adds a whole list of grazing animals to the field
        public void AddResource (List<Duck> animals) 
        {
            // TODO: implement this...
            _animals.AddRange(animals);
        }

        //Outputs a large string of all resources stored in this grazing field
        public override string ToString()
        {
            //Creates a new string to store the upcoming info
            StringBuilder output = new StringBuilder();
            //Creates a short id by taking the first few characters of the regular id
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            //Adds to our output string
            output.Append($"Duck House {shortId} has {this._animals.Count} animals\n");
            //Calls the ToString() method for every animal in this grazing field and adds it to our output string
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            //Returns our output string
            return output.ToString();

            
        }
    }
}