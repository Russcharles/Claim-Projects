﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Player
    {
        public Player(string name)
        {
            this.name = name;
        }
        
        public Hand hand { get; set; }

        public Wallet wallet { get; set; }

        public string name { get; set;  }

    }

}
