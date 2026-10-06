using CarzCo.Subclasses;

namespace CarzCo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car volvo = new Car("Volvo", "S40");

            Console.WriteLine(volvo);
            volvo.PrintVehicleInfo();
            volvo.Drive();
        }
    }
}
