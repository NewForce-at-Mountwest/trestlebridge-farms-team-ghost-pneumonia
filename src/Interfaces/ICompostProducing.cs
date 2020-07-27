namespace Trestlebridge.Interfaces
{
    //An interface for any animal or plant processed for their compost
    public interface ICompostProducing
    {
        //Blueprint for a method that simply returns how much compost this resource creates
        double GatherCompost ();
    }
}