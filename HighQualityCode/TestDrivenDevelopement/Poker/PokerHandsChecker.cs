namespace Poker
{
    using System;
    using System.Linq;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face &&
                        hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            int sameFaceCount = 1;

            for (int i = 0; i < hand.Cards.Count - 3; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        sameFaceCount++;
                    }
                }

                if (sameFaceCount == 4)
                {
                    return true;
                }

                sameFaceCount = 1;
            }

            return true;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            if (!this.IsValidHand(hand) || this.IsFlush(hand))
            {
                return false;
            }

            var handSorted = hand.Cards.OrderBy(c => (int)c.Face).ToArray();

            for (int i = 0; i < handSorted.Length - 1; i++)
            {
                if ((int)handSorted[i].Face != (int)handSorted[i + 1].Face - 1)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            int sameFaces = 1;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                sameFaces = 1;

                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        sameFaces++;
                    }
                }

                if (sameFaces == 3)
                {
                    return true;
                }
            }

            return true;
        }

        public bool IsTwoPair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            bool result = this.HasNumberOfPairs(hand, 2);

            return result;
        }

        public bool IsOnePair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            bool result = this.HasNumberOfPairs(hand, 1);

            return result;
        }

        public bool IsHighCard(IHand hand)
        {
            if (!this.IsValidHand(hand) || this.IsOnePair(hand) || this.IsTwoPair(hand) ||
                this.IsThreeOfAKind(hand) || this.IsFourOfAKind(hand) || this.IsStraight(hand) ||
                this.IsStraightFlush(hand) || this.IsFlush(hand) || this.IsFullHouse(hand))
            {
                return false;
            }

            return true;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        private bool HasNumberOfPairs(IHand hand, int numberOfPairsWanted)
        {
            int countPairs = 0;
            int sameFaces = 1;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                sameFaces = 1;

                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        sameFaces++;
                    }
                }

                if (sameFaces == 2)
                {
                    countPairs++;
                }

                if (countPairs > numberOfPairsWanted || sameFaces > 2)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
