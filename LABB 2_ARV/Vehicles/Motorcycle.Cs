
public class Motorcycle : Car
{

    public int numberofSeats;
    // Constructor in Car 'calls' the vehicle constructor
    public Motorcycle(string brand, int year, int numberOfDoors)
            : base(brand, year)

    {
        numberOfDoors = numberOfDoors;
    }

    // properties (egenskaper)
    public int NumberOfDoors { get; set; }
    public double TrunkCapacityLiters { get; set; }
    public bool IsElectreic { get; set; }

    // A private property dissimmilar to Motorcycle and Truck (en individuell egenskap som skiljer ena fordonet från det andra)
    public string enclosedBody { get; set; }

    // method for car
    public override void Cruise()
    {
        Console.WriteLine($"{Brand} car is cruising on the road.");
}
