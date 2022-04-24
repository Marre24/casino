using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class Hand
    {
        List<Card> cards = new List<Card>(); 


        internal string value()
        {
            cards.Select(c => c.value.FaceValue()).Aggregate();
            return "21";
        }



        internal bool CanSplit()
        {
            return cards.Count == 2 && cards.Count != cards.Distinct().Count();
        }

        internal void AddCard(Card c)
        {
            cards.Add(c);
        }
    }
}
