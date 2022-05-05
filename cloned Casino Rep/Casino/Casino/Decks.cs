using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Casino
{
    public enum CardValue : int
    {
        ace = 1,
        two = 2,
        three = 3,
        four = 4,
        five = 5,
        six = 6,
        seven = 7,
        eight = 8,
        nine = 9,
        ten = 10,
        jack = 11,
        queen = 12,
        king = 13
    }
    public enum CardColor : int
    {
        spades = 1,
        clubs = 2,
        hearts = 3,
        diamonds = 4
    }

    class Deck
    {
        private static Random rng = new Random();
        public List<Card> CreateDecks(int deckCount)
        {
            for (int i = 0; i < deckCount; i++)
            {
                SetupDeck();
            }
            return deck;
        }

        public List<Card> deck = new List<Card>();

        public List<Card> SetupDeck()
        {
            foreach (int colorIndex in Enum.GetValues(typeof(CardColor)))
            {
                var color = (CardColor)colorIndex;
                foreach (int cardIndex in Enum.GetValues(typeof(CardValue)))
                {
                    var value = (CardValue)cardIndex; 
                    Card card = new Card(color, value);
                    deck.Add(card);
                }
            }
            return deck;
        }

        public void ShuffleDeck()
        {
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }
        public Card DrawCard(Dictionary<Player, Hand> hands, Player player)
        {
            Card card = deck[0];
            deck.RemoveAt(0);
            hands[player].AddCard(card);
            return card;
        }
    }
}
