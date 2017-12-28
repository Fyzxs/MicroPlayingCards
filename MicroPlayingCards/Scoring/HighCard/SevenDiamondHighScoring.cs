using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class SevenDiamondHighScoring : IScoring
    {
        private readonly IScoring _next;
        public SevenDiamondHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Diamonds.Seven)) return Score.SevenDiamondHigh;
            return _next.Scoring(hand);
        }
    }
}