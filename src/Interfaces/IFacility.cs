using System.Collections.Generic;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Interfaces
{
    //An interface for all facilities that will be added to the farm
    public interface IFacility<T>
    {
        //A double to store the capacity of each facility
        double Capacity { get; }

        //Blueprint for two methods to add resources to the facility. One method takes a single resource to add, while the second method takes a whole list of resources to add
        void AddResource (T resource);
        void AddResource (List<T> resources);
    }
}