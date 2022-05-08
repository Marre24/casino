using System.ComponentModel.DataAnnotations.Schema;
using Casino;
using NUnit.Framework;

namespace CasinoTest
{
    public class PlayerTest
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

            Assert.AreEqual(player, player);
        }

        [Test]
        public void Test2()
        {
            Player p1 = new Player();
            Player p2 = new Player();


            Assert.AreNotEqual(p1, p2);
        }


    }
}