namespace Trestlebridge.Interfaces
{
    //An interface for all grass grazing animals
    public interface IGrazing
    {
        //A double to store how much grass a grazing animal can eat per day
        double GrassPerDay { get; set; }
        //A blueprint method, will print a line about how much grass an animal ate in one day
        void Graze();
    }
}