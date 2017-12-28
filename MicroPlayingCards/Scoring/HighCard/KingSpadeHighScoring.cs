using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class KingSpadeHighScoring : IScoring
    {
        private readonly IScoring _next;
        public KingSpadeHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Spades.King)) return Score.KingSpadeHigh;
            return _next.Scoring(hand);
        }
    }
}