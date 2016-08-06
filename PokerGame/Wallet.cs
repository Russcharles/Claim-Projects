using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Wallet
    {
        int balance { get; set; }

        public override string ToString()
        {
            return "$" + balance;
        }
    }

   
}
