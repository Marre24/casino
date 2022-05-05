using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    internal class Hand
    {
        private readonly List<Card> cards = new List<Card>(); 
        public PictureBox rightCard;
        public PictureBox leftCard;

        internal int Value()
        {
            int sum = 0;
            var aCards = cards.Select(c => c.FaceValue(c.value));

            foreach (var value in aCards)
            {
                sum += value;
            }

            return sum; 
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
