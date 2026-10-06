using System;
using System.Collections.Generic;
using System.Text;
using CarzCo.Interface;

namespace CarzCo.Subclasses
{
    internal class Motorcycle : Vehicle, IDriveable
    {
        public Motorcycle(string aBrand, string aModel) : base(aBrand, aModel)
        {
            Brand = aBrand;
            Model = aModel;
        }

        public void Drive()
        {
            Console.WriteLine("Motorcycle drives away");
        }

    
    }
}
