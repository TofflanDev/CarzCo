using System;
using System.Collections.Generic;
using System.Text;
using CarzCo.Interface;

namespace CarzCo.Subclasses
{
    internal class Truck : Vehicle, IDriveable
    {
        public Truck ( string aBrand, string aModel) : base (aBrand, aModel)
        {
            
            Model = aModel;
            Brand = aBrand;
        }
        //ärver
        //make sound
        public void Drive ()
        {
            Console.WriteLine("Truck vroom!");
        }
    }
}
