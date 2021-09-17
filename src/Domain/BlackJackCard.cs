using System;

namespace Domain
{
    public class BlackJackCard : Card
    {
        #region Properties
        public bool FaceUp { get; set; }
        public int Value { get; }
        #endregion

        #region Constructors
        public BlackJackCard(Suit suit, FaceValue faceValue): base(suit, faceValue)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        public void TurnCard()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
