using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB_2_ARV
{
    internal class PickUp : Car
    {
        // constructor that takes in a uniq property
        public PickUp(string brand, int model, int year, string sound, double maxSpeedKmh, int numberOfDoors, int weightCapacity)
            : base(brand, model, year, sound, maxSpeedKmh, numberOfDoors)

        {
            WeightCapacity = weightCapacity;
        }

        public int WeightCapacity { get; set; }

        // Unique method for PickUp
        public void CargoBed()
        {
            Console.WriteLine($"{Brand} is loading 8 kilos of horse-crap");
        }
            
    }
}
