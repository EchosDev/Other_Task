using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask2.Models
{
    public class Customer
    {
        private static int _id = 0;
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Customer(string name, string city)
        {
            Name = name;
            City = city;
            _id++;
            CustomerId = _id ;
        }
    }
}
