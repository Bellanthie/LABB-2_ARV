using System.Reflection;

public class Motorcycle : Vehicle
{
    
    // Constructor in Motorcycle 'calls' the vehicle constructor
    public Motorcycle(string brand, int model, int year, string sound, double maxSpeedKmh, int numberOfSeats)
            : base(brand, year, model, sound, maxSpeedKmh)

    {
        NumberOfSeats = numberOfSeats;
    }
    
    // properties (egenskaper)
    public int NumberOfSeats { get; set; } = 1; //defaul value

    // method for motorcycle
    public void Wheelie()
    {
        Console.WriteLine($"{Brand} motorcycle is running/driving on one wheel.");
    }
}
