using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PlayerId = System.Int32;


namespace Casino
{
     internal class Player
    {
        public int PlayerId = 1;
        public Hand hand = new Hand();
        public State state = new State(StateType.Spectating);

        private static int _nextId = 1;
        
        public Player()
        {
            PlayerId = _nextId++;

        }




    }
}
