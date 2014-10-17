namespace PokerTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class PokerHandsCheckerIsFourOfAKindTest
    {
        [TestMethod]
        public void TestIsFourOfAKindWithFourKingsDifferentSuits()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool result = handChecker.IsFourOfAKind(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestIsFourOfAKindWithFourKingsSameSuits()
        {
            PokerHandsChecker handChecker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool result = handChecker.IsFourOfAKind(hand);
            Assert.AreEqual(false, result);
        }
    }
}
