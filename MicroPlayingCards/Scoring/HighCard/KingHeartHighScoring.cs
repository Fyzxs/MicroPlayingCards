using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class KingHeartHighScoring : IScoring
    {
        private readonly IScoring _next;
        public KingHeartHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Hearts.King)) return Score.KingHeartHigh;
            return _next.Scoring(hand);
        }
    }
}