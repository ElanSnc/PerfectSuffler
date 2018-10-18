using PerfectSuffler.Deck;
using NUnit.Framework;
using AutoFixture;

namespace PerfectShuffler.Test
{
    public class PerfectShufflerTests
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
            Assert.AreEqual(cardsInTheDeck,deck.CardLeftInTheDeck());
        }
    }
}
