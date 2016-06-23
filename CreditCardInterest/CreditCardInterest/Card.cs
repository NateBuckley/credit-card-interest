using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest
{
    public class Card
    {
        private double InterestRate {get; set;}
        private int balance = 100;

        public Card(double interest)
        {
            InterestRate = interest;
        }

        public double CalculateSimpleInterest()
        {
            double simpleInterest = balance * InterestRate;
            return simpleInterest;
        }
    }
}
