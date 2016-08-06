using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Deck
    {
        LinkedList<Cards> allCards = new LinkedList<Cards>();
        LinkedList<Cards> dealtCards = new LinkedList<Cards>();
        
        public void Shuffle()
        {
            Random r = new Random();


        }

        public void Deal()
        {

        }


    }
}
