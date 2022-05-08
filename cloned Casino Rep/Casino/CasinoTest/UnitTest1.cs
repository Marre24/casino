using System.ComponentModel.DataAnnotations.Schema;
using Casino;
using NUnit.Framework;

namespace CasinoTest
{
    public class Tests
    {
        private Table table;

        [SetUp]
        public void Setup()
        {
             table = new Table(new Deck(6), new BlackJackDealer());


        }

        [Test]
        public void Test1()
        {
            Player player = new Player();

            table.join(player);

            Assert.IsTrue(table.AtTable(player));
        }

        [Test]
        public void Test2()
        {
            Player player = new Player();


            Assert.IsFalse(table.AtTable(player));
        }

        [Test]
        public void Test3()
        {
            DeckOfCards deck = new RiggedDeck(new  Card(CardColor.clubs, CardValue.queen), new Card(CardColor.clubs, CardValue.ace));
            Table table = new Table(deck, new BlackJackDealer());

            Player player = new Player();
            table.join(player);

            table.DealTo(player);

            Card card = table.Hit(player);

            Assert.AreEqual(21, table.HandValueFor(player));

        }
    }
}