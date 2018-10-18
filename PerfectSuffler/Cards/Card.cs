using PerfectShuffler.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectShuffler.Cards
{
    public class Card : IComparable<Card>
    {
        private Suit suit;
        private readonly SuitNumber suitNumber;

        public string CardValue()
        {
            return string.Format("{0} {1}", suit.Kind, suitNumber.Number);
        }        

        public Card(Suit suitType, SuitNumber number)
        {
            suit = suitType;
            suitNumber = number;
        }
       
        public int CompareTo(Card otherCard)
        {            
            if (suit.KindValue == otherCard.suit.KindValue)
            {
                return suitNumber.Number.CompareTo(otherCard.suitNumber.Number);
            }            
            return otherCard.suit.KindValue.CompareTo(suit.KindValue);
        }
    }
}
