using PerfectShuffler.Cards;
using PerfectShuffler.Deck;
using PerfectSuffler;
using System;
using System.Collections.Generic;
using static PerfectShuffler.Utils.Enums;

namespace PerfectShuffler.Utils
{
    public static class DeckGenerator
    {
        public static List<Card> GenerateDeck(DeckType typeOfDeck)
        {
            switch (typeOfDeck)
            {
                case DeckType.Poker:
                    return GeneratePokerDeck();

                default:
                    throw new InvalidCastException(string.Format(ErrorMessages.InvalidDeckType,Enum.GetName(typeof(DeckType), typeOfDeck)));
            }
        }

        public static List<Card> GeneratePokerDeck()
        {
            List<Card> deck = new List<Card>();

            foreach (PokerDeckSuits suit in (PokerDeckSuits[])Enum.GetValues(typeof(PokerDeckSuits)))
            {
                for (int numberOfCards = 1; numberOfCards <= (int)CardNumbersPerSuit.Poker; numberOfCards ++)
                {
                    deck.Add(new Card(new Suit((string)suit.ToString()), new SuitNumber(numberOfCards)));
                }
            }

            return deck;
        }

        public static int PokerDeckSuitValue (string suit)
        {     
            switch (suit.ToUpper())
            {
                case "H":
                    return 4;
                case "C":
                    return 3;
                case "D":
                    return 2;
                case "S":
                    return 1;
                default:
                    throw new InvalidCastException(ErrorMessages.InvalidSuitValue);
            }
        }
    }
}
