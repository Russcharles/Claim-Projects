using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Hand
        
    { List<Cards> hand {get; set;}
        private int value;
        public enum HandRank
        {
            HighCard, OnePair, TwoPairs, ThreeOfAKind, Straight, Flush, FullHouse, FourOfAKind, StraightFlush, RoyalFlush
        }
        public Hand(int value)
        {
            this.value = value;
                 
        
        }
        public bool IsBetterThan(Hand other)
        {
            return this.value > other.value;


        }
        public bool IsEqualTo(Hand other)
        {
            return this.value == other.value;


        }
        
        }
    }

