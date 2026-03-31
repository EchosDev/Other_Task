using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utilities.Exceptions
{
    public class CardNumberExistException : Exception
    {
        private static string _message = "Kart nomresi verilenler bazasinda movcuddur! Lutfen yoxlama aparin";
        public CardNumberExistException() : base(_message) { }
    }
}
