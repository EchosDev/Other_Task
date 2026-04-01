using NewTask2.Enums;
using NewTask2.Models;

namespace NewTask2.Interfaces
{
    public interface ICargoService
    {
        void AddCostumer(Customer customer);
        void AddCourier(Courier courier);
        void CreateOrder(CargoOrder order);
        void CompleteOrder(int orderid);
    }

    public class CargoService : ICargoService
    {
        static Customer[] Customers = new Customer[0];
        static Courier[] Couriers = new Courier[0];
        static CargoOrder[] CargoOrders = new CargoOrder[0];
        public void AddCostumer(Customer customer)
        {
            Array.Resize(ref Customers, Customers.Length + 1);
            Customers[Customers.Length - 1] = customer;
        }
        public void AddCourier(Courier courier)
        {
            Array.Resize(ref Couriers, Couriers.Length + 1);
            Couriers[Couriers.Length - 1] = courier;
        }
        public void CreateOrder(CargoOrder order)
        {
            if (order.CustomerId == 0 || order.CustomerId >Customers.Length)
            {
                throw new Exception("Customer Id is empty or not exist");
            }
            else if (order.CourierId == 0 || order.CourierId > Couriers.Length)
            {
                throw new Exception("Courier Id is empty or not exist");
            }
            else
            {
                foreach (var courier in Couriers)
                {
                    if (order.CourierId == courier.CourierId)
                    {
                        if (!courier.IsAviable)
                        {
                            throw new Exception("Courier is not aviable");
                        }
                        else
                        {
                            Array.Resize(ref CargoOrders, CargoOrders.Length + 1);
                            CargoOrders[CargoOrders.Length - 1] = order;
                            Console.WriteLine("Courier accepted order Please Wait!");
                            courier.IsAviable = false;
                            break;
                        }
                    }
                }
            }
        }
        public void CompleteOrder(int orderid)
        {
            int count = 0;
            foreach (var order in CargoOrders)
            {
                if (orderid == order.Id)
                {
                    order.OrderStatus = OrderStatus.Delivered;
                    Console.WriteLine($"Order has completed! Order Status is {order.OrderStatus}");
                    count++;

                    foreach (var courier in Couriers)
                    {
                        if (order.CourierId == courier.CourierId)
                        {
                            courier.IsAviable = true;
                        }
                    }
                }
            }
            if (count == 0)
            {
                throw new Exception("Order is not exist! Please enter valid order id");
            }
        }
    }
}
