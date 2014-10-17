namespace PokerTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void TestHandWithFiveCardsToString()
        {
            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Hearts)
            });

            string result = hand.ToString();
            Assert.AreEqual("7♦ J♣ A♥ 3♠ 6♥", result);
        }

        [TestMethod]
        public void TestHandWithOneCardToString()
        {
            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
            });

            string result = hand.ToString();
            Assert.AreEqual("J♦", result);
        }

        [TestMethod]
        public void TestHandWithNoCardsToString()
        {
            Hand hand = new Hand(new List<ICard>());

            string result = hand.ToString();
            Assert.AreEqual(string.Empty, result);
        }
    }
}
