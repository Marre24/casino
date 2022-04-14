using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Card
    {
        public CardColor color;
        public CardValue value;
        public Card(CardColor color, CardValue value)
        {
            this.color = color;
            this.value = value;
        }

        public override string ToString()
        {
            return $"{color.ToString()} {value.ToString()}";
        }

        public static int GetIndex(string value)
        {
            return (int)Enum.Parse(typeof(CardValue), value);
        }
    }



}
