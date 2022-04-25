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

        public int FaceValue(CardValue value)
        {
            int faceValue;
            if (value == CardValue.ace)
            {
                faceValue = (int)CardValue.jack;
                return faceValue;
            }

            if (value > CardValue.ten)
            {
                faceValue = (int)CardValue.ten;
                return faceValue;
            }

            faceValue = (int)value;

            return faceValue;
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
