
using PerfectShuffler.Cards;
using PerfectShuffler.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PerfectShuffler.Utils.Enums;

namespace PerfectShuffler.Deck
{
    public class PokerDeck : Deck
    {
        private List<Card> Cards;

        public PokerDeck()
        {
            Cards = DeckGenerator.GenerateDeck(DeckType.Poker);
        }

        public override void Shuffle()
        {
            List<Card> ShuffledCards = new List<Card>();
            Random rng = new Random();

            for (int deckLenght = Cards.Count; deckLenght > 0; deckLenght --)
            {
                var card = rng.Next(1, deckLenght);

                ShuffledCards.Add(Cards.ElementAt(card -1));
                Cards.RemoveAt(card -1);
            }

            Cards = ShuffledCards;
        }

        public override void Sort()
        {
            Cards.Sort();
        }

        public int CardLeftInTheDeck()
        {
            return Cards.Count;
        }

        public void Print()
        {
            foreach (Card card in Cards) Console.WriteLine(card.CardValue());
        }
    }
}
