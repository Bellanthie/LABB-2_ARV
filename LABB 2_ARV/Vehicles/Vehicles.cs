public abstract class Vehicle
{
    // Attributes below:
    public string Brand { get; set; }
    public int Model { get; set; }
    public int Year { get; set; }
    public double Weight { get; set; }
    public double FuelLevel { get; set; }
    public double MaxSpeedKmh { get; set; }

    public void Start()
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

}

