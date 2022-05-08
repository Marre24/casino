using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public enum StateType
    {
        Spectating,
        Undealt,
        Playing,
        Busted,
        Stopped
    }
    internal class State
    {
        public State(StateType type)
        {
            StateType ActiveState = type;
        }


    }
}
