using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class AceDiamondHighScoring : IScoring
    {
        private readonly IScoring _next;
        public AceDiamondHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Diamonds.Ace)) return Score.AceDiamondHigh;
            return _next.Scoring(hand);
        }
    }
}