namespace Trestlebridge.Interfaces
{
    //An interface for all animals that eat animal feed
    public interface IFeeding
    {
        //A double to store how much feed an animal can eat per day
        double FeedPerDay { get; set; }
        //A blueprint method, will print a line about how much feed an animal ate in one day
        void EatFeed();
    }
}