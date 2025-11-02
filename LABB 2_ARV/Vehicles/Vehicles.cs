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

    public void Stop()
    {
        global::System.Console.WriteLine("The vehicle stops!");
    }


    public void Accelerate()
    {
        global::System.Console.WriteLine("The vehicle accelerates.");
    }
}

