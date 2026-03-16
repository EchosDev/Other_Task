using Code.Models;

namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diff;
            Order order1 = new Order(1, "Laptop", 2, 1500m);

            OnlineOrder onlineOrder1 = new OnlineOrder(2, "Smartphone", 1, 800, 6200);

            onlineOrder1.showOnlineInfo();

        }
    }
}
