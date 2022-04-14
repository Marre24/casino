using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Decks : List<Card>
    {
        public enum Value
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

        public enum Color
        {
            spades,
            cloves,
            hearts,
            diamonds
        }

        //public Decks CreateDecks(int deckCount)
        //{
        //    Decks decks = new Decks();
        //    for (int i = 0; i < deckCount; i++)
        //    {
        //        decks.Add(CreateOneDeck());
        //    }
        //    return decks;
        //}



        int valueCounter = 0;
        int colorCounter = 0;
        public List<Card> deck = new List<Card>();

        private List<Card> CreateOneDeck()
        {
            foreach (int i in Enum.GetValues(typeof(Color)))
            {
                var color = (Color)colorCounter;
                foreach (int index in Enum.GetValues(typeof(Value)))
                {
                    var value = (Value)valueCounter; 
                    Card card = new Card(Convert.ToString(color), Convert.ToInt32(value));
                    deck.Add(card);
                    valueCounter++;
                }
                colorCounter++;
            }

            return deck;
        }

        //public List<Card> deck;


        //public List<Card> CreateOneDeck()
        //{


        //    return deck;
        //}



    }
}
