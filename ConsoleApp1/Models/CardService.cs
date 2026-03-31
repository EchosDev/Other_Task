using ConsoleApp1.Utilities.Exceptions;
using ConsoleApp1.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class CardService : ICardService
    {
        //public static Card[] Cards = { };
        public static List<Card> Cards = new List<Card>();

        public void AddCard(Card card)
        {
            foreach (var existedcard in Cards)
            {
                if (existedcard.CardNumber == card.CardNumber)
                {
                    throw new CardNumberExistException();
                }
            }

            Cards.Add(card);

            Console.WriteLine($"Kartiniz ugurla elave olundu: {card.CardNumber}");
        }
    }
}
