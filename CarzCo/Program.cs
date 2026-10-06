using System.Security.Cryptography.X509Certificates;
using CarzCo.Subclasses;

namespace CarzCo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Vehicle> vechiles = new List<Vehicle>()
            {
                
            };

            


            //Car volvo = new Car("Volvo", "S40");
            Truck truck = new Truck("Scania", "R500");
            Truck truck2 = new Truck("Volvo", "FH16");

            vechiles.Add(truck); vechiles.Add(truck2);

            FilterVehicles<Truck>(vechiles);

            //volvo.PrintVehicleInfo();
            //volvo.Drive();

            //Motorcycle ferrari = new Motorcycle("Ferrari", "model x");

            //ferrari.Drive();

            //ferrari.PrintVehicleInfo();
        }
    

    static public void AddVehicle(List<Vehicle> vehicles, Vehicle aVehicle)
        {
            vehicles.Add(aVehicle);
           
        }

    static public void RemoveVehicle(List<Vehicle> vehicles, Vehicle aVehicle)
        {
            vehicles.Remove(aVehicle);
        }





    

    static public void FilterVehicles <T>(List<Vehicle> vehicleList) where T  : Vehicle
        {
            foreach (var vehicle in vehicleList.OfType<T>())
            {
                vehicle.PrintVehicleInfo();
            }
        }
}
}
