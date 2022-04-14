using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Casino
{
    public enum CardValue
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
        knight = 11,
        queen = 12,
        king = 13
    }
    public enum CardColor
    {
        spades = 1,
        cloves = 2,
        hearts = 3,
        diamonds = 4
    }

    class Deck
    {

        private static Random rng = new Random();
        //public Decks CreateDecks(int deckCount)
        //{
        //    Decks decks = new Decks();
        //    for (int i = 0; i < deckCount; i++)
        //    {
        //        decks.Add(CreateOneDeck());
        //    }
        //    return decks;
        //}



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
        public Card DrawCard()
        {
            Card card = deck[0];
            deck.RemoveAt(0);
            return card;
        }

        //public List<Card> deck;


        //public List<Card> CreateOneDeck()
        //{


        //    return deck;
        //}



    }
}
