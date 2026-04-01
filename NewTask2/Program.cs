using NewTask2.Interfaces;
using NewTask2.Models;

namespace NewTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer customer1 = new("Elmir", "Baku");
                Customer customer2 = new("Feyzullah", "Sumgait");
                Customer customer3 = new("Murad", "Baku");

                CargoService cargoService = new();

                cargoService.AddCostumer(customer1);
                cargoService.AddCostumer(customer2);
                cargoService.AddCostumer(customer3);

                Courier courier1 = new("Namized", true);
                Courier courier2 = new("Ramiz", true);
                Courier courier3 = new("Elsen", true);

                cargoService.AddCourier(courier1);
                cargoService.AddCourier(courier2);
                cargoService.AddCourier(courier3);

                CargoOrder order1 = new() { CourierId = 3, CustomerId = 3, TotalPrice = 200 };

                cargoService.CreateOrder(order1);
                CargoOrder order2 = new() { CourierId = 3, CustomerId = 3, TotalPrice = 200 };
                cargoService.CreateOrder(order2);

                cargoService.CompleteOrder(1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
