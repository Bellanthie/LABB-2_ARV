public abstract class Vehicle
{

    // Attributes below: also variables
    public string Brand { get; set; }
    public int Model { get; set; }
    public int Year { get; set; }
    public string Sound { get; set; }
    public double MaxSpeedKmh { get; set; }

    // Common methods within the Vehicle class
    public void StartEngine()
    {
        global::System.Console.WriteLine("The vehicle starts...");
    }

    public void Break()
    {
        global::System.Console.WriteLine("The vehicle stops!");
    }


    public void Accelerate()
    {
        global::System.Console.WriteLine("The vehicle accelerates.");
    }

    public void Honk()
    {
        global::System.Console.WriteLine("The vehicle gives out an alarm sound a.k.a. 'honk'.");
    }

    // Constructor below
    public Vehicle(string brand, int model, int year, string sound, double maxSpeedKmh)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Sound = sound;
        MaxSpeedKmh = maxSpeedKmh;
    }
}

