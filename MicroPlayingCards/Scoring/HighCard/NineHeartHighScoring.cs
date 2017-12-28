using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class NineHeartHighScoring : IScoring
    {
        private readonly IScoring _next;
        public NineHeartHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Hearts.Nine)) return Score.NineHeartHigh;
            return _next.Scoring(hand);
        }
    }
}