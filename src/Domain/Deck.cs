using System;
using System.Collections.Generic;

namespace Domain
{
    public class Deck
    {
        #region Fields
        private Random _random;
        protected IList<BlackJackCard> _cards;
        #endregion

        #region Constructors
        public Deck()
        {
            _random = new Random();
            _cards = new List<BlackJackCard>(52);

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                foreach (FaceValue faceValue in Enum.GetValues(typeof(FaceValue)))
                    _cards.Add(new BlackJackCard(suit, faceValue));

            Shuffle();
        }
        #endregion

        #region Methods
        public BlackJackCard Draw()
        {
            if (_cards.Count == 0)
                throw new InvalidOperationException("Cannot draw card from empty deck");

            var card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }

        private void Shuffle()
        {
            for (int i = 0; i < _cards.Count * 3; i++)
            {
                int randomPosition = _random.Next(0, _cards.Count);
                var card = _cards[randomPosition];
                _cards.RemoveAt(randomPosition);
                _cards.Add(card);
            }
        }
        #endregion
    }
}
