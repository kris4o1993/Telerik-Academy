namespace PokerTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class PokerHandsCheckerIsTwoPairTest
    {
        [TestMethod]
        public void TestIsTwoPairWithTwoPairs()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool result = handChecker.IsTwoPair(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestIsTwoPairWithOnePairAndThreeOfAKind()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool result = handChecker.IsTwoPair(hand);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestIsTwoPairWithFourOfAKind()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool result = handChecker.IsTwoPair(hand);
            Assert.AreEqual(false, result);
        }
    }
}
