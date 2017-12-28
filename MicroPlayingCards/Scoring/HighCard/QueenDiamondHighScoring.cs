using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class QueenDiamondHighScoring : IScoring
    {
        private readonly IScoring _next;
        public QueenDiamondHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Diamonds.Queen)) return Score.QueenDiamondHigh;
            return _next.Scoring(hand);
        }
    }
}