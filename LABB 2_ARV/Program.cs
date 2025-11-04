namespace LABB_2_ARV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create vehicles
            Truck truck = new Truck("Volvo", 2018, 2025, "Vroom", 90, 8);
            Motorcycle motorcycle = new Motorcycle("Bmw", 2008, 2015, "Bruääää", 180, 1);
            Car car = new Car("Honda", 2005, 2021, "Vraaraarooom", 240, 4);
            PickUp pickup = new PickUp("Ferrari", 1967, 1980, "BRRUUU", 300, 4);


            // Start Egnition
            car.StartEngine();
            motorcycle.StartEngine();
            truck.StartEngine();
            pickUp.StartEngine();
            Console.ReadKey();//keeps the console open instead of closing unexpectadly

        }
    }
}
