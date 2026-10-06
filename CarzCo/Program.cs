using CarzCo.Subclasses;

namespace CarzCo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car volvo = new Car("Volvo", "S40");


            volvo.PrintVehicleInfo();
            volvo.Drive();
        }
    }
}
