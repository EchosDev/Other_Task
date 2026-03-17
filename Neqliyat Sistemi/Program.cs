using Neqliyat_Sistemi.Models;

namespace Neqliyat_Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("Toyota", "Camry", 2020);

            vehicle1.StartEngine();
            vehicle1.Drive(150);
            vehicle1.StopEngine();
            vehicle1.VehicleInfo();

        }
    }
}
