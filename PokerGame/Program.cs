using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public class Program
    {                      
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Start Poker Game");
            Console.WriteLine("2) Exit program");

            string result = Console.ReadLine();
            Console.Clear();

            if (result == "1")
            {
                Setup setup = new Setup();

                setup.PlayerName();
                
                setup.AmountOfPlayers();
                
                setup.AnteSize();
                
                setup.StartingAmount();

                // game loop
                setup.Play();
            }
        }
    }
}
                           
        
           
        




         
    

