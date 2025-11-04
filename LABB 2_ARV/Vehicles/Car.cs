using System;
public class Car : Vehicle
{
	// Constructor in Car 'calls' the vehicle constructor
	public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
	{
		numberOfDoors = numberOfDoors;
	}

	// unique property owned by Car
	public int numberOfDoors;
	
	// method for car
	public override void Cruise()
	{
		Console.WriteLine($"{Brand} car is cruising on the road.");
	}


}
