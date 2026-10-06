using CarzCo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

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

        public void Drive()
        {
            Console.WriteLine("Volvo dives away");
        }


        //ÄRVER FRÅN Vehicle 
        //SUBKLASS KLASS

    }
}
