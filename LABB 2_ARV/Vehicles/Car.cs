using System;
public class Car : Vehicle
{
	public int numberOfDoors;
	// Constructor in Car 'calls' the vehicle constructor
	public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
	{
		numberOfDoors = numberOfDoors;
	}

	// properties
	public int NumberOfDoors { get; set; }
	public double TrunkCapacityLiters { get; set; }
	public bool IsElectreic { get; set; }

	// A private property dissimmilar to Motorcycle and Truck
	public string enclosedPassengerCabin { get; set; }

	// method for car
	public override void Cruise()
	{
		Console.WriteLine($"{Brand} car is cruising on the road.");
	}


}
