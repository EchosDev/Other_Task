using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask2.Models
{
    public class Courier
    {
        private static int _id = 0;

        public int CourierId { get; set; }

        public string Name { get; set; }

        public bool IsAviable { get; set; }

        public Courier(string name, bool isAviable)
        {
            Name = name;
            IsAviable = isAviable;
            _id ++;
            CourierId = _id;
        }
    }
}
