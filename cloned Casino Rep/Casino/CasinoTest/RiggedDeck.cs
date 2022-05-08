using System.Collections.Generic;
using System.Linq;
using Casino;
using NUnit.Framework;

namespace CasinoTest
{
    public class RiggedDeck : DeckOfCards
    {
        private List<Card> cards;


        public RiggedDeck(params Card[] cards)
        {
            this.cards = cards.ToList();
        }

        public Card DrawCard()
        {
            Card c = cards[0];
            cards.RemoveAt(0);
            return c;
        }
    }
}