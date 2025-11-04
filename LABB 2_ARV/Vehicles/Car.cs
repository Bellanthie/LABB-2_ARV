using System;
public class Car : Vehicle
{
	// Constructor in Car 'calls' the vehicle constructor: When i want to create a new 'vehicle/car', the constructor will ask for ALL the following properties)
	public Car(string brand, int model, int year, string sound, double maxSpeedKmh, int numberOfDoors)
        : base(brand, year, model, sound, maxSpeedKmh)
	{
		// Analogy: Casper har en egenskap (krulligt hår) som han INTE kan ärva av mig OCH som han har själv--> i.e. NumberOfDoors
		NumberOfDoors = numberOfDoors; //lowercase är värdet
	}

	// unique property owned by Car
	public int NumberOfDoors { get; set; } = 4;
	
	// method for car
	public void Cruise()
	{
		Console.WriteLine($"{Brand} car is cruising on the road.");
	}

	// för att tillåta car att göra en override funktion, måste man skriva i VEHICLE en virtual funktion (detta ensures att car gör en egen 
	// funktion om den vill)
}
