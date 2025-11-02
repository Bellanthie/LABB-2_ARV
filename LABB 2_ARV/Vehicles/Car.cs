using System;
public class Car : Vehicle
{
	public int NumberOfDoors;
	// Constructor in Car 'calls' the vehicle constructor
	public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
	{
		numberOfDoors = numberOfDoors;
	}

	public int NumberOfDoors { get; set; }
	public double TrunkCapacityLiters { get; set; }
	public bool IsElectreic { get; set; }


}
