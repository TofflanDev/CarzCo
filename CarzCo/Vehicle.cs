using System;
using System.Collections.Generic;
using System.Text;

namespace CarzCo
{
    abstract class Vehicle
    {

        public List<Vehicle> vehiclesList = new List<Vehicle>();

        public string Brand { get; set; } = " ";
        public string Model { get; set; } = " ";
            
        public Vehicle()
        {
        }
        public Vehicle(string aBrandName,string aModelName)
        {

        }
        public void PrintVehicleInfo()
        {
            Console.WriteLine($"Vehicle Brand: {Brand}" +
                $" Model: {Model}");
        }

    }
}
