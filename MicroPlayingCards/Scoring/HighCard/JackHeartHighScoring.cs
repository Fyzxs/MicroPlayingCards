using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class JackHeartHighScoring : IScoring
    {
        private readonly IScoring _next;
        public JackHeartHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Hearts.Jack)) return Score.JackHeartHigh;
            return _next.Scoring(hand);
        }
    }
}