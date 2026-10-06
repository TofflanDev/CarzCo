using System;
using System.Collections.Generic;
using System.Text;

namespace CarzCo.Subclasses
{
    internal class Truck : Vehicle
    {
        public Truck (string Brand, string Model) : base (Brand, Model)
        {

        }
        //ärver
        //make sound
        public void MakeSound ()
        {
            Console.WriteLine("Nu brummar det av truckens motorer.");
        }
    }
}
