using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utilities.Exceptions
{
    public class CardNumberException : Exception
    {
        private static string _message = "Kart nomresi 16 reqemden kicik olmamalidir"; 
        public CardNumberException() : base(_message) { }
    }
}
