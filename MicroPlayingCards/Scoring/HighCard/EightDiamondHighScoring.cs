using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class EightDiamondHighScoring : IScoring
    {
        private readonly IScoring _next;
        public EightDiamondHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Diamonds.Eight)) return Score.EightDiamondHigh;
            return _next.Scoring(hand);
        }
    }
}