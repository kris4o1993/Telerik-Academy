namespace PokerTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class PokerHandsCheckerIsOnePairTest
    {
        [TestMethod]
        public void TestIsOnePairWithOnlyOnePair()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds)
            });

            bool result = handChecker.IsOnePair(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestIsOnePairWithTwoPairs()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Diamonds)
            });

            bool result = handChecker.IsOnePair(hand);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestIsOnePairWithOnlyOnePairAtTheEnd()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool result = handChecker.IsOnePair(hand);
            Assert.AreEqual(true, result);
        }
    }
}
