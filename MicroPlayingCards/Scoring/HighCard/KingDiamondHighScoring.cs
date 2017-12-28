using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class KingDiamondHighScoring : IScoring
    {
        private readonly IScoring _next;
        public KingDiamondHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Diamonds.King)) return Score.KingDiamondHigh;
            return _next.Scoring(hand);
        }
    }
}