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
        public SportsCar(string brand, int model, int year, string sound, double maxSpeedKmh, int numberOfDoors, string Turbo) : base(brand, model, year, sound, maxSpeedKmh, numberOfDoors)
        {
            Turbo = turbo;
        }

        public string Turbo { get; set; } = 50;
    
    }
}
