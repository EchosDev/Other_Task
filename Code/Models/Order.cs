using System;
using System.Collections.Generic;
using System.Text;

namespace Code.Models
{
    internal class Order
    {
        public int Id;
        public string Name;
        public int Count;
        public decimal Price;

        public Order()
        {
            //Console.WriteLine("Order Is Running");
        }

        public Order(int id, string name, int count, decimal price) : this()
        {
            Id = id;
            Name = name;
            Count = count;
            Price = price;
        }
        public Order(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Count = 1;
            Price = price;
        }

        public void totalPrice()
        {
            Console.WriteLine($"Bu Mehsul ucun {Name} umumi qiymet {Count * Price}");
        }

        public void increaseCount(int count = 1)
        {
            Count += count;
        }

        public void showInfo()
        {
            Console.WriteLine($"Sifaris Id: {Id} Mehsul: {Name} Sayi: {Count} Qiymət: {Price} Umumi Mebleg:{Price * Count}");
        }

        public void changePrice(out int diff, decimal price)
        {
            diff = Convert.ToInt32(Price - price);
            Price = price;
        }
    }
}
