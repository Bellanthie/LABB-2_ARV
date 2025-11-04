using System;
public class Truck : Vehicle
{
    public int numberofSeats;
    // Constructor in Car 'calls' the vehicle constructor
    public Truck(string brand, int model, int year, string sound, double maxSpeedKmh, int numberOfTires)
            : base(brand, year, model, sound, maxSpeedKmh)

    {
        NumberOfTires = numberOfTires;
    }

    // properties (egenskaper)
    public int NumberOfTires { get; set; } = 8;
    

    // Unique method for Truck
    public void Retarder()
    {
        Console.WriteLine($"{Brand} Truck is using eco-breaks.");
    }
}