using PerfectShuffler.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectShuffler
{
    class Program
    {
        static void Main(string[] args)
        {

            PokerDeck pokerDeck = new PokerDeck();

            pokerDeck.Print();

            Console.WriteLine("We will Shuffle now");

            pokerDeck.Shuffle();
                        
            pokerDeck.Print();

            Console.WriteLine("we will Order now");

            pokerDeck.Sort();

            pokerDeck.Print();


            Console.ReadLine();

        }
    }
}
