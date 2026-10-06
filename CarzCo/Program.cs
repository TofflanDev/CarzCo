using System.Security.Cryptography.X509Certificates;
using CarzCo.Subclasses;

namespace CarzCo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Vehicle> vehiclesList = new List<Vehicle>();

            Car car = new Car("Volvo", "S40");
            Motorcycle motorcycle = new Motorcycle("Ferrari", "model x");
            Truck truck = new Truck("Scania", "R500");
            Truck truck2 = new Truck("Volvo", "FH16");

            Console.WriteLine("Car\n");
            Console.WriteLine(car);
            car.Drive();

            Console.WriteLine("\nMotorcycle\n");
            motorcycle.PrintVehicleInfo();
            motorcycle.Drive();
            Console.WriteLine("\n");
            AddVehicle(vehiclesList, truck);

            FilterVehicles<Truck>(vehiclesList);


        }


        static public void AddVehicle(List<Vehicle> vehicles, Vehicle aVehicle)
        {
            vehicles.Add(aVehicle);

        }

        static public void RemoveVehicle(List<Vehicle> vehicles, Vehicle aVehicle)
        {
            vehicles.Remove(aVehicle);
        }

        static public void FilterVehicles<T>(List<Vehicle> vehicleList) where T : Vehicle
        {
            foreach (var vehicle in vehicleList.OfType<T>())
            {
                vehicle.PrintVehicleInfo();
            }
        }
    }
}
