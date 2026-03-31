using ConsoleApp1.Utilities.Enums;
using ConsoleApp1.Utilities.Exceptions;

namespace ConsoleApp1.Models
{
    public class Card
    {
        private static int _id = 0;

        public int Id { get; private set; }
        public decimal Balance { get; set; }
        public decimal Bonus { get; set; }
        private string _cardNumber;

        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                if (value.Length < 16)
                {
                    throw new CardNumberException();
                }
                else
                {
                    _cardNumber = value;
                }
            }
        }

        public Bank Bank { get; set; }


        public Card(decimal balance, string cardNumber, Bank bank)
        {
            Balance = balance;
            CardNumber = cardNumber;
            Bank = bank;
            Id = _id + 1;
        }

        public bool WithDraw(decimal value)
        {
            if (value <= Balance)
            {
                Balance -= value;
                Console.WriteLine($"""
                    Emelliyyat ugurla basa catdi!
                    Hazirki Balansiniz: {Balance}
                    """);
                return true;
            }
            else
            {
                Console.WriteLine("Emeliyyat mumkun olmadi! Cixarmaq Istediyiniz deyer balansdan kicik olmalidir");
                Console.WriteLine($"Balansiniz:{Balance}\n" +
                                  $"Cekmek istediyiniz deyer:{value}");
                return false;
            }
        }

    }
}
