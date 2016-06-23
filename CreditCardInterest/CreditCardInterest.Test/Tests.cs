using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CreditCardInterest;

namespace CreditCardInterest.Test
{
    [TestFixture]
    public class Tests
    {
        static Card visa = new Card(.1);
        static Card mastercard = new Card(.05);
        static Card discover = new Card(.01);
        
        [Test]
        public void Test1()
        {
            Wallet wallet = new Wallet();
            Person person = new Person();

            wallet.AddCard(visa);
            wallet.AddCard(mastercard);
            wallet.AddCard(discover);
            person.AddWallet(wallet);

            double personInterest = person.CalculatePersonInterest();
            Assert.AreEqual(personInterest, 16);
        }

        [Test]
        public void Test2()
        {
            Wallet wallet1 = new Wallet();
            Wallet wallet2 = new Wallet();
            Person person = new Person();

            wallet1.AddCard(visa);
            wallet1.AddCard(discover);
            wallet2.AddCard(mastercard);
            person.AddWallet(wallet1);
            person.AddWallet(wallet2);

            double personInterest = person.CalculatePersonInterest();
            Assert.AreEqual(personInterest, 16);
        }
        [Test]
        public void Test3()
        {
            Wallet wallet1 = new Wallet();
            Wallet wallet2 = new Wallet();
            Person person1 = new Person();
            Person person2 = new Person();

            wallet1.AddCard(mastercard);
            wallet1.AddCard(visa);
            wallet1.AddCard(discover);
            wallet2.AddCard(visa);
            wallet2.AddCard(mastercard);
            person1.AddWallet(wallet1);
            person2.AddWallet(wallet2);

            double person1Interest = person1.CalculatePersonInterest();
            double person2Interest = person2.CalculatePersonInterest();
            Assert.AreEqual(person1Interest, 16);
            Assert.AreEqual(person2Interest, 15);
        }
    }
}
