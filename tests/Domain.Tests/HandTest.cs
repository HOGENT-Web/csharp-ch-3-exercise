using Xunit;

namespace Domain.Tests
{
  public class HandTest
    {
        private Hand _hand;

        public HandTest()
        {
            _hand = new Hand();
        }

        [Fact]
        public void NewHand_HasNoCards()
        {
            Assert.Equal(0, _hand.NrOfCards);
        }

        [Fact(Skip="Not yet implemented")]
        public void AddCard_EmptyHand_ResultsInHandWithOneCard()
        {
            BlackJackCard card = new BlackJackCard(Suit.Spades, FaceValue.Eight);
            _hand.AddCard(card);
            Assert.Equal(1, _hand.NrOfCards);
        }

        [Fact]
        public void AddCard_AHandWithCards_AddsACard()
        {
            _hand.AddCard(new BlackJackCard(Suit.Spades, FaceValue.Eight));
            _hand.AddCard(new BlackJackCard(Suit.Hearts, FaceValue.Ace));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.King));

            Assert.Equal(3, _hand.NrOfCards);
        }

        [Fact]
        public void TurnAllCardsFaceUp_TurnsAllCardsFaceUp()
        {
            BlackJackCard card = new BlackJackCard(Suit.Hearts, FaceValue.Ace);
            card.TurnCard();
            _hand.AddCard(card);
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _hand.TurnAllCardsFaceUp();
            foreach (BlackJackCard c in _hand.Cards)
                Assert.True(c.FaceUp);
        }

        [Fact]
        public void Value_EmptyHand_IsZero()
        {
            Assert.Equal(0, _hand.Value);
        }

        [Fact]
        public void Value_HandWith6and5_Is11()
        {
            _hand.AddCard(new BlackJackCard(Suit.Diamonds, FaceValue.Six));
            _hand.AddCard(new BlackJackCard(Suit.Spades, FaceValue.Five));
            _hand.TurnAllCardsFaceUp();

            Assert.Equal(11, _hand.Value);
        }

        [Fact]
        public void Value_HandWith5AndKing_Is15()
        {
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Five));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.King));
            _hand.TurnAllCardsFaceUp();

            Assert.Equal(15, _hand.Value);
        }

        [Fact]
        public void Value_HandWithCardsFacingDown_DoesNotAddValuesOfCardsFacingDown()
        {
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Five));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Jack));
            _hand.TurnAllCardsFaceUp();
            _hand.AddCard(new BlackJackCard(Suit.Diamonds, FaceValue.Two));
            _hand.AddCard(new BlackJackCard(Suit.Hearts, FaceValue.Ace));

            Assert.Equal(15, _hand.Value);
        }

        [Fact]
        public void Value_HandWithAceAndNotExceeding21_TakesAceAs11()
        {
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Seven));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Ace));
            _hand.TurnAllCardsFaceUp();

            Assert.Equal(18, _hand.Value);
        }

        [Fact]
        public void ValueHandWithAceAndExceeding21_TakesAceAs1()
        {
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Seven));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Nine));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Ace));
            _hand.TurnAllCardsFaceUp();

            Assert.Equal(17, _hand.Value);
        }

        [Fact]
        public void Value_HandWithAceFaceDown_DoesNotCountAce()
        {
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _hand.TurnAllCardsFaceUp();
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Ace));
            Assert.Equal(4, _hand.Value);
        }
    }
}
