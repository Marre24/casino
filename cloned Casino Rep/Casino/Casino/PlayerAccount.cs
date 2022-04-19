using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class PlayerAccount
    {
        public readonly string username;
        public string password;
        public readonly int balance;

        public PlayerAccount(string playerData)
        {
            username = playerData.Split(';')[0];
            password = playerData.Split(';')[1];
            balance = int.Parse(playerData.Split(';')[2]);
        }

        
        public override string ToString() { return username; }


    }
}
