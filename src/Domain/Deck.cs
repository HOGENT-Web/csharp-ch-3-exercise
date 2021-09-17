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
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        public BlackJackCard Draw()
        {
            throw new NotImplementedException();
        }

        private void Shuffle()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
