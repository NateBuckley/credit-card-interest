using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest
{
    public class Wallet
    {
        private List<Card> cards = new List<Card> ();

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public double CalculateWalletInterest()
        {
            double interest = 0;

            foreach (var card in cards)
            {
                interest += card.CalculateSimpleInterest();
            }

            return interest;
        }
    }
}
