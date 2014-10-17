namespace PokerTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class PokerHandsCheckerIsFlushTest
    {
        [TestMethod]
        public void TestIsFlushTrue()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds)
            });

            bool result = handChecker.IsFlush(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestIsFlushFalse()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Spades)
            });

            bool result = handChecker.IsFlush(hand);
            Assert.AreEqual(false, result);
        }
    }
}