namespace Trestlebridge.Interfaces
{
    //An interface for any animal processed for their eggs
    public interface IEggProducing
    {
        //Blueprint for a method that simply returns how many eggs the animal can produce
        double GatherEggs ();
    }
}