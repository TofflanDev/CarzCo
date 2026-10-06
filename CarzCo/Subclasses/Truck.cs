using System;
using System.Collections.Generic;
using System.Text;

namespace CarzCo.Subclasses
{
    internal class Truck : Vehicle
    {
        public Truck (string truckBrand, string truckModel, string Brand, string Model) : base (Brand, Model)
        {
            truckBrand = Brand;
            truckModel = Model;
        }
        //ärver
        //make sound
        public void MakeSound ()
        {
            Console.WriteLine("Vroom!");
        }
    }
}
