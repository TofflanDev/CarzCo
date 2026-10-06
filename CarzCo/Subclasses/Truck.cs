using System;
using System.Collections.Generic;
using System.Text;
using CarzCo.Interface;

namespace CarzCo.Subclasses
{
    internal class Truck : Vehicle, IDriveable
    {
        public Truck (string truckBrand, string truckModel, string Brand, string Model) : base (Brand, Model)
        {
            truckBrand = Brand;
            truckModel = Model;
        }
        //ärver
        //make sound
        public void Drive ()
        {
            Console.WriteLine("Truck vroom!");
        }
    }
}
