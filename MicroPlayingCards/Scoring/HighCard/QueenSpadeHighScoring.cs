using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class QueenSpadeHighScoring : IScoring
    {
        private readonly IScoring _next;
        public QueenSpadeHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Spades.Queen)) return Score.QueenSpadeHigh;
            return _next.Scoring(hand);
        }
    }
}