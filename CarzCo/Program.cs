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

            


            Car volvo = new Car("Volvo", "S40");


            volvo.PrintVehicleInfo();
            volvo.Drive();

            Motorcycle ferrari = new Motorcycle("Ferrari", "model x");

            ferrari.Drive();

            ferrari.PrintVehicleInfo();
        }
    

    public void AddVehicle(List<Vehicle> vehicles, Vehicle aVehicle)
        {
            vehicles.Add(aVehicle);
           
        }

    public void RemoveVehicle(List<Vehicle> vehicles, Vehicle aVehicle)
        {
            vehicles.Remove(aVehicle);
        }





    }
}
