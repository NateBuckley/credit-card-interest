using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest
{
    public class Person
    {
        private List<Wallet> wallets = new List<Wallet>();

        public void AddWallet(Wallet wallet)
        {
            wallets.Add(wallet);
        }

        public double CalculatePersonInterest()
        {
            double interest = 0;

            foreach (var wallet in wallets)
            {
                interest += wallet.CalculateWalletInterest();
            }

            return interest;
        }
    }
}
