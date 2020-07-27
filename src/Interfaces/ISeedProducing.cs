namespace Trestlebridge.Interfaces
{
    //An interface used for all seed-producing plants
    public interface ISeedProducing
    {
        //Returns a double - how many seeds this resource produces
        double Harvest ();
    }
}