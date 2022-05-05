using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Casino
{
    class BlackJackDealer
    {
        Dictionary<Player, Hand> hands = new Dictionary<Player, Hand>();
        Player dealer = new Player();
        public void TakeCards(Deck deck, PictureBox Pb_DealerLeftCard, PictureBox Pb_DealerRightCard)
        {
            Card c = deck.DrawCard(hands, dealer);
            Pb_DealerLeftCard.Image = GetCardPic(c);
            c = deck.DrawCard(hands, dealer);
            Pb_DealerRightCard.Image = GetCardPic(c);
        }
        public Image GetCardPic(Card c)
        {
            CardValue value = c.value;
            CardColor color = c.color;
            if (CardValue.ace < value && value <= CardValue.ten)
            {
                string valueString = ((int)value).ToString();
                return Image.FromFile($"{valueString}_of_{color}.PNG");
            }
            if (value == CardValue.ace)
            {
                return Image.FromFile($"{value}_of_{color}.PNG");
            }
            return Image.FromFile($"{value}_of_{color}2.PNG");
        }







    }
}
