namespace Trestlebridge.Interfaces
{
    //An interface for any animal processed for their meat
    public interface IMeatProducing
    {
        //Blueprint for a method that simply returns how much meat is produced when the animal is butchered
        double Butcher ();
    }
}