using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Casino
{
    public class Hand
    {
        private readonly List<Card> cards = new List<Card>();


        internal int Value()
        {
            Console.WriteLine(cards.Count);
            if (cards.Count == 0)
            {
                Console.WriteLine("no cards");
                return 0;
            }

            return cards.Select(c => c.FaceValue(c.value)).Aggregate((a,b) => a + b);
        }

        internal void AddCard(Card c)
        {
            cards.Add(c);
            Console.WriteLine(c);
        }
    }
}
