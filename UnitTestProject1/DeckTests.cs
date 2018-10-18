using NUnit.Framework;
using AutoFixture;
using PerfectShuffler.Deck;
using PerfectShuffler.Cards;
using System;
using static PerfectShuffler.Utils.Enums;

namespace PerfectShuffler.Test
{
    public class DeckTests
    {
        private IFixture fixture = new Fixture();

        [Test]
        public void Shuffling_MustNotAlterDeckSize()
        {
            // Arrange      
            var deck = fixture.Create<PokerDeck>();
            var cardsInTheDeck = deck.CardLeftInTheDeck();

            // Act
            deck.Shuffle();

            // Assert
            Assert.AreEqual(cardsInTheDeck, deck.CardLeftInTheDeck());
        }

        [Test]
        public void Sorting_MustNotAlterDeckSize()
        {
            // Arrange      
            var deck = fixture.Create<PokerDeck>();
            var cardsInTheDeck = deck.CardLeftInTheDeck();

            // Act
            deck.Sort();

            // Assert
            Assert.AreEqual(cardsInTheDeck, deck.CardLeftInTheDeck());
        }

        [Test]
        public void CardNumberValue_ShouldBeInverse()
        {
            // Arrange                 
            var suit = new Suit("H");
            var positiveNumberCard = new Card(suit, fixture.Create<SuitNumber>());
            var negativeNumberCard = new Card(suit, new SuitNumber(-1));

            // Act
            var expectedValue = positiveNumberCard.CompareTo(negativeNumberCard);

            // Assert
            Assert.AreEqual(1, expectedValue);
        }

        [Test]
        public void PokerDeck_ShouldHaveTheRightSuits()
        {
            // Arrange     
            var wrongSuit = fixture.Create<string>();
            var suitNumber = fixture.Create<SuitNumber>();

            // Act           

            // Assert
            Assert.Throws<InvalidCastException>(() => new Card(new Suit(wrongSuit), suitNumber));
        }
    }
}