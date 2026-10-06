using CarzCo.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CarzCo.Subclasses
{
    internal class Car : Vehicle, IDriveable
    {

        public Car(string aBrand, string aModel)
            : base(aBrand, aModel)
        {
            Brand = aBrand;
            Model = aModel;
        }

        public override string ToString()
        {
            return $"{Brand} {Model}";
        }
        public void Drive()
        {
            Console.WriteLine("Car vrom vrom");
        }


    }
}
