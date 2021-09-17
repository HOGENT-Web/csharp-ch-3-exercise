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
        public IEnumerable<BlackJackCard> Cards { get; }
        public int NrOfCards { get; }
        public int Value { get; }
        #endregion

        #region Constructors
        public Hand()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        public void AddCard(BlackJackCard card)
        {
            throw new NotImplementedException();
        }

        public void TurnAllCardsFaceUp()
        {
            throw new NotImplementedException();
        }

        private int CalculateValue()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
