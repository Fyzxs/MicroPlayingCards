using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class TenDiamondHighScoring : IScoring
    {
        private readonly IScoring _next;
        public TenDiamondHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Diamonds.Ten)) return Score.TenDiamondHigh;
            return _next.Scoring(hand);
        }
    }
}