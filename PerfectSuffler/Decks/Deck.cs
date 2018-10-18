using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectShuffler.Deck
{
    public abstract class Deck
    {
        public Deck()
        {             

        }

        public abstract void Sort();

        public abstract void Shuffle();

    }
}
