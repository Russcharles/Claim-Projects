using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Program
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
                Console.WriteLine("What is your name?");
                string result2 = Console.ReadLine();

                Console.WriteLine("Select how many players(3 or 4)");
                string result3 = Console.ReadLine();

                Console.WriteLine("Pick an ante size in a full dollar amount");
                string result4 = Console.ReadLine();

                Console.WriteLine("Pick starting wallet amount(must be three times the ante amount)");
                string result5 = Console.ReadLine();




            }

            else if (result == "2")
            {

            }
        }
    }
}
