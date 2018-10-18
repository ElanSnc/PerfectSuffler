using PerfectShuffler.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectShuffler.Deck
{
    public class Suit : IComparable<Suit>
    {
        public string Kind { get; }

        public int KindValue { get; }

        public Suit(string suitKind)
        {
            Kind = suitKind;

            KindValue = DeckGenerator.PokerDeckSuitValue(suitKind);
        }

        public int CompareTo(Suit otherCardSuit)
        {
            return otherCardSuit.KindValue.CompareTo(KindValue);
        }
    }
}
