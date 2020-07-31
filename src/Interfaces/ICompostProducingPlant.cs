namespace Trestlebridge.Interfaces
{
    //An interface used for all seed-producing plants
    public interface ICompostProducingPlant
    {
        //Returns a double - how much compost this plant produces
        double HarvestCompost();

        string Type {get;}
    }
}