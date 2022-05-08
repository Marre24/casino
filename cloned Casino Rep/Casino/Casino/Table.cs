using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Table
    {
        private DeckOfCards deck;
        private BlackJackDealer blackJackDealer;
        readonly Dictionary<Player, Hand> hands = new Dictionary<Player, Hand>();


        public Table(DeckOfCards deck, BlackJackDealer blackJackDealer)
        {
            this.deck = deck;
            this.blackJackDealer = blackJackDealer;
        }

        public void join(Player player)
        {
            hands.Add(player, new Hand());

        }

        public bool AtTable(Player player)
        {
            return hands.ContainsKey(player);
        }

        public void DealTo(Player player)
        {
            if (!hands.ContainsKey(player))
                throw new Exception("Player not present at table");

            hands[player].AddCard(deck.DrawCard());
            

        }

        public Card Hit(Player player)
        {

            Card c = deck.DrawCard();
            hands[player].AddCard(c);
            return c;
        }

        public int HandValueFor(Player player)
        {
            return hands[player].Value();
        }
    }
}
