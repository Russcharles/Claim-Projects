using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public class Game
    {
        
        List<Player> players;
        private int ante;
        Pot pot = new Pot();

        Game(List<Player> players, int ante)
        {
            this.players = players;
            this.ante = ante;

        }
        
        public void PlayGame()
        {
            PlayRound();
        }
        private void PlayRound()
        {
            AnteUp();
            Deal();
        }

        private void Deal()
        {
            int counter = 0;
            foreach (Player player in players)
            { counter += 1;
                
                Hand hand = new Hand(counter);
                player.hand = hand;
            }

        }


        private void AnteUp()
        {
            foreach (Player player in players)
            {
                player.wallet.balance -= ante;
                pot.value += ante;

            }
        }

        
    }
 }
            

