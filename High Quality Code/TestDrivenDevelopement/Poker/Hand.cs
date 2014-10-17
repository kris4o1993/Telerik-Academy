namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Hand : IHand
    {
        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public IList<ICard> Cards { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var card in this.Cards)
            {
                result.Append(string.Format("{0} ", card.ToString()));
            }

            return result.ToString().Trim();
        }
    }
}
