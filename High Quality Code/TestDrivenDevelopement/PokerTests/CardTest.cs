namespace PokerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void TestSevenOfDiamondsToString()
        {
            Card card = new Card(CardFace.Seven, CardSuit.Diamonds);
            string cardInfo = card.ToString();
            Assert.AreEqual("7♦", cardInfo);
        }

        [TestMethod]
        public void TestJackOfClubsToString()
        {
            Card card = new Card(CardFace.Jack, CardSuit.Clubs);
            string cardInfo = card.ToString();
            Assert.AreEqual("J♣", cardInfo);
        }

        [TestMethod]
        public void TestAceOfHeartsToString()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Hearts);
            string cardInfo = card.ToString();
            Assert.AreEqual("A♥", cardInfo);
        }

        [TestMethod]
        public void TestThreeOfSpadesToString()
        {
            Card card = new Card(CardFace.Three, CardSuit.Spades);
            string cardInfo = card.ToString();
            Assert.AreEqual("3♠", cardInfo);
        }

        // ♣
        // ♦
        // ♥
        // ♠
    }
}
