using NewTask2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask2.Models
{
    public class CargoOrder
    {
        private static int _id = 0;
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CourierId { get; set; }
        public decimal TotalPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public CargoOrder()
        {
            OrderStatus = OrderStatus.Created;
            CreatedAt = DateTime.Now;
            _id ++;
            Id = _id;
        }
        public void UptadeStatus(OrderStatus orderStatus)
        {
            if (OrderStatus == OrderStatus.Cancelled || OrderStatus == OrderStatus.Delivered)
            {
                Console.WriteLine($"Order has {OrderStatus}");
            }
            else
            {
                OrderStatus = orderStatus;
                Console.WriteLine($"Order status has changed to '{OrderStatus}'");
            }
        }
        public override string ToString()
        {
            return $"""
                Order ID : {Id}
                Customer ID : {CustomerId}
                Courier ID : {CourierId}
                Total Price : {TotalPrice}
                """;
        }
    }
}
