using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Setup
    {   
        private int ante;
        private string result2;
        static List<Player> players = new List<Player>();
        
        public void PlayerName()
        {
            Console.WriteLine("What is your name?");
            result2 = Console.ReadLine();
            Console.Clear();
            
        }

        public void Play()
        {
            while (players.Count(x => x.wallet.balance > 0) > 1)
            {
                // ante

                // deal

                // evaluate winner

                // pay winner
            }

            // show winner
        }
        
        
        public void AmountOfPlayers()
        {
            bool validPlayers = false;
            do
            {
                Console.WriteLine("Select how many players(3 or 4)");
                string result3 = Console.ReadLine();
                if ((result3 == "3") || (result3 == "4"))
                {
                    validPlayers = true;

                    int numplayers = int.Parse(result3);

                    for (int i = 0; i < numplayers; i++)

                    { 
                        players.Add(new Player("Computer " + i.ToString()));

                    }
                    
                }
                

            }
            
            while (!validPlayers);
            players[0].name = result2;
            Console.Clear();
            
        }
        
        public void AnteSize()
        {
            bool userEnterInt;
            do
            {
                Console.WriteLine("Pick an ante size in a full dollar amount");
                string result4 = Console.ReadLine();
                userEnterInt = int.TryParse(result4, out ante);
            }

            while (!userEnterInt);
            Console.Clear();
        }
        public void StartingAmount()
        {

            bool validWallet = false;
            do
            {
                Console.WriteLine("Pick starting wallet amount(must be three times the ante amount)");
                string result5 = Console.ReadLine();
                int walletAmount = int.Parse(result5);
                if (walletAmount >= 3 * ante)
                {
                    validWallet = true;
                    foreach (Player player in players)
                    {

                        Wallet wallet = new Wallet();
                        wallet.balance = walletAmount;
                        player.wallet = wallet;
                        Console.Clear();
                        Console.WriteLine("Players names and Starting amounts:" + player.name + " " + player.wallet);
                        Console.ReadLine();
                    }


                }
            }
            while (!validWallet);

        }
    }
    
}
