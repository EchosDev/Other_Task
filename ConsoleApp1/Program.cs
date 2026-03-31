using ConsoleApp1.Models;
using ConsoleApp1.Utilities.Enums;
using ConsoleApp1.Utilities.Exceptions;
using ConsoleApp1.Utilities.Helper;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Card card = new(2000, "4169738883883592", Bank.ABB);
                Card card1 = new(2000, "4169738883883592", Bank.ABB);

                Console.WriteLine(card.WithDraw(1400));

                Console.WriteLine(card.CardNumber.MaskCardNumber());
                card.ExpenseWithBonus(200);

                CardService cardService = new CardService();

                cardService.AddCard(card);
                cardService.AddCard(card1);
            }
            catch (CardNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CardNumberExistException ex)
            {
                Console.WriteLine(ex.Message);
            }            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
