using System;
using System.Collections.Generic;

namespace Domain
{
    public class Hand
    {
        #region Fields
        private IList<BlackJackCard> _cards;
        #endregion

        #region Properties
        public IEnumerable<BlackJackCard> Cards
        {
            get { return _cards; }
        }
        public int NrOfCards
        {
            get { return _cards.Count; }
        }
        public int Value
        {
            get { return CalculateValue(); }
        }
        #endregion

        #region Constructors
        public Hand()
        {
            _cards = new List<BlackJackCard>();
        }
        #endregion

        #region Methods
        public void AddCard(BlackJackCard card)
        {
            _cards.Add(card);
        }

        public void TurnAllCardsFaceUp()
        {
            foreach (var card in Cards)
                if (!card.FaceUp)
                    card.TurnCard();
        }

        private int CalculateValue()
        {
            int sum = 0;
            bool hasAce = false;

            foreach (var card in Cards)
            {
                sum += card.Value;
                if (card.FaceUp && card.FaceValue == FaceValue.Ace)
                    hasAce = true;
            }

            if (hasAce && (sum + 10) <= 21)
                sum += 10;

            return sum;
        }
        #endregion
    }
}
