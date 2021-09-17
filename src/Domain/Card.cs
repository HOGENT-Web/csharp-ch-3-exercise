namespace Domain
{
    public class Card
    {
        #region Properties
        public FaceValue FaceValue { get; }
        public Suit Suit { get; }
        #endregion

        #region Constructors
        public Card(Suit suit, FaceValue faceValue)
        {
            Suit = suit;
            FaceValue = faceValue;
        }
        #endregion
    }
}
