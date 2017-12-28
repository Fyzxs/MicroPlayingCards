using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class QueenHeartHighScoring : IScoring
    {
        private readonly IScoring _next;
        public QueenHeartHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Hearts.Queen)) return Score.QueenHeartHigh;
            return _next.Scoring(hand);
        }
    }
}