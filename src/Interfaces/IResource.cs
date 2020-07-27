namespace Trestlebridge.Interfaces
{
    //An interface used for anything that's considered a resource
    public interface IResource
    {
        //A string that simply holds the type of the resource ("Cow" for cow, "Ostrich" for ostrich, etc)
        string Type { get; }
    }
}