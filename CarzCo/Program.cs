using CarzCo.Subclasses;

namespace CarzCo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Volvo", "S40");

            Console.WriteLine(car);
            car.Drive();

            Motorcycle ferrari = new Motorcycle("Ferrari", "model x");

            ferrari.Drive();

            ferrari.PrintVehicleInfo();
        }
    }
}
