using System;
using System.Collections.Generic;
using System.Text;

namespace Code.Models
{
    internal class OnlineOrder : Order
    {
        public int DeliveryLength;

        public OnlineOrder(int id, string name, int count, decimal price, int delireyLength)
            : base(id, name, count, price)
        {
            DeliveryLength = delireyLength;
        }

        public void showOnlineInfo()
        {
            if (DeliveryLength > 5000)
            {
                Console.WriteLine($"Sifaris Id: {Id} Mehsul: {Name} Sayi: {Count} Qiymet: {Price} Umumi Mebleg:{Price * Count} Mesafe:{DeliveryLength} Catdilma Qiymeti: {DeliveryLength / 1000 * 2} Umumi Mebleg Catdirilma ile: {Price * Count + (DeliveryLength / 1000 * 2)}");
            }
            else 
            {
                Console.WriteLine($"Sifaris Id: {Id} Mehsul: {Name} Sayi: {Count} Qiymet: {Price} Umumi Mebleg:{Price * Count} Mesafe:{DeliveryLength}");
            }

        }

    }
}
