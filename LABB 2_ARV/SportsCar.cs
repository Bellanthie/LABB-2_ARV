using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB_2_ARV
{
    //you only have one project, so using 'internal' is fitting. if you had >1 project, you'd use public
    internal class SportsCar : Car
    {
        // Constructor that takes in a unique property (turbo)
        public SportsCar(string brand, int model, int year, string sound, double maxSpeedKmh, int numberOfDoors, int turbo)
            : base(brand, model, year, sound, maxSpeedKmh, numberOfDoors)
        {
            Turbo = turbo;
        }

        public int Turbo { get; set; } //default value

        // Unique method used ONLY for SportsCar
        public void HighSpeed()
        {
            Console.WriteLine($"{ Brand} just hit NoS! Waaa sh**...The engines gona bloooow!");
        }    
    }
}
