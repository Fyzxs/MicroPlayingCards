using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class JackDiamondHighScoring : IScoring
    {
        private readonly IScoring _next;
        public JackDiamondHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Diamonds.Jack)) return Score.JackDiamondHigh;
            return _next.Scoring(hand);
        }
    }
}