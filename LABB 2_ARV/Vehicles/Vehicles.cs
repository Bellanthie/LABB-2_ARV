public abstract class Vehicle
{

    // Attributes below: also variables
    public string Brand { get; set; } = "No Brand";
    public int Model { get; set; } = 1987;
    public int Year { get; set; } = 2018;
    public string Sound { get; set; } = "Vrooom";
    public double MaxSpeedKmh { get; set; } = 280;



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

