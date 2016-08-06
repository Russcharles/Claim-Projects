using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Cards
    { public Suit mySuit { get; set; }
      public Value myValue { get; set; }
        public enum Suit
        {
            Clubs, Diamonds, Hearts, Spades
        }

        public enum Value
        {
            two= 2, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace
        }
    }
}
