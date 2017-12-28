using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class SevenHeartHighScoring : IScoring
    {
        private readonly IScoring _next;
        public SevenHeartHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Hearts.Seven)) return Score.SevenHeartHigh;
            return _next.Scoring(hand);
        }
    }
}