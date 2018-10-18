using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectShuffler.Deck
{
    public class SuitNumber : IComparable<int>
    {        
        public int Number { get; }        

        public SuitNumber(int suitNumber)
        {
            Number = suitNumber;
        }

        public int CompareTo(int otherNumber)
        {
            if (Number < otherNumber) return 1;
            if (Number > otherNumber) return -1;
            else return 0;
        }
    }
}
