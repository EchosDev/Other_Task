using ConsoleApp1.Models;
using ConsoleApp1.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utilities.Helper
{
    public static class Extentions
    {
        public static string MaskCardNumber(this string cardNumber)
        {
            string firstPartOfCard = cardNumber.Substring(0, 4);
            string secondPartOfCard = cardNumber.Substring(12, 4);
            return $"{firstPartOfCard} **** **** {secondPartOfCard}";
        }

        public static void ExpenseWithBonus(this Card card, decimal price)
        {
            if (card.Balance < price)
            {
                Console.WriteLine("Emeliyyat mumkun olmadi! Cixarmaq Istediyiniz deyer balansdan kicik olmalidir");
                Console.WriteLine($"Balansiniz:{card.Balance}\n" +
                                  $"Cekmek istediyiniz deyer:{price}");
            }

            switch (card.Bank)
            {
                case Bank.ABB:
                    card.Bonus += price * 0.02m;
                    break;
                case Bank.Kapital:
                    card.Bonus += price * 0.04m;
                    break;
                case Bank.Leo:
                    card.Bonus += price * 0.05m;
                    break;
            }
            Console.WriteLine($"Kart Bonusunuz:{card.Bonus}");
        }
    }
}
