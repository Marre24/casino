using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PlayerId = System.Int32;


namespace Casino
{
     public class Player
    {
        public int playerId = 1;
        public Hand hand = new Hand();
        private State state = new State(StateType.Spectating);

        private static int _nextId = 1;
        
        public Player()
        {
            playerId = _nextId++;

        }

        public override bool Equals(object obj)
        {
            Player other = obj as Player;
            return playerId.Equals(other.playerId);
        }

        public override int GetHashCode()
        {
            return playerId;
        }

        internal void StartPlaying()
        {
            state = new State(StateType.Playing);
        }

        internal bool WaitingForCard()
        {
            return state == new State(StateType.Undealt);
        }

        internal bool HasStopped()
        {
            return state == new State(StateType.Busted) || new State(StateType.Stopped) == state;
        }


    }
}
