namespace PokerTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class PokerHandsCheckerIsStraightTest
    {
        [TestMethod]
        public void TestIsFourOfAKindWithFiveKings()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades)
            });

            bool result = handChecker.IsFourOfAKind(hand);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestIsStraightWithFiveSequentialCards()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Spades)
            });

            bool result = handChecker.IsStraight(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestIsStraightWithFiveSequentialCardsSameSuit()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds)
            });

            bool result = handChecker.IsStraight(hand);
            Assert.AreEqual(false, result);
        }
    }
}
