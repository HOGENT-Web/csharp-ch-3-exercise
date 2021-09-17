using System;

namespace Domain
{
    public class BlackJack
    {
        #region Fields
        public static bool FaceUp = true;
        public static bool FaceDown = false;
        private Deck _deck;
        #endregion

        #region Properties
        public GameState GameState { get; private set; }
        public Hand PlayerHand { get; }
        public Hand DealerHand { get; }
        #endregion

        #region Constructors
        public BlackJack()
        {
            throw new NotImplementedException();
        }

        public BlackJack(Deck deck)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        private void Deal()
        {
            throw new NotImplementedException();
        }

        public void PassToDealer()
        {
            throw new NotImplementedException();
        }

        public string GameSummary()
        {
            throw new NotImplementedException();
        }

        public void GivePlayerAnotherCard()
        {
            throw new NotImplementedException();
        }

        private void AddCardToHand(Hand hand, bool faceUp)
        {
            throw new NotImplementedException();
        }

        private void AdjustGameState(GameState? gameState = null)
        {
            throw new NotImplementedException();
        }

        private void LetDealerFinalize()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
