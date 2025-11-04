public abstract class Vehicle
{

    // Attributes below: also variables
    public string Brand { get; set; }
    public int Model { get; set; }
    public int Year { get; set; }
    public string Sound { get; set; }
    public double MaxSpeedKmh { get; set; }

    // 3 Common methods within the Vehicle class
    public void StartEngine()
    {
        Console.WriteLine("The vehicle starts...");
        Console.WriteLine(Sound); //vehicle startup sound
    }

    public void Break()
    {
        Console.WriteLine("The vehicle stops!");
    }


    public void Accelerate()
    {
        Console.WriteLine("The vehicle accelerates.");
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

