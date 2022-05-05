using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class Player
    {
        public int Id = 1;
        public Hand hand;
        
        private static int _nextId = 1;
        
        public Player()
        {
            Id = _nextId++;
        }

    }
}
