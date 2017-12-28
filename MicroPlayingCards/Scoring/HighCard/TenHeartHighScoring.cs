using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class TenHeartHighScoring : IScoring
    {
        private readonly IScoring _next;
        public TenHeartHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Hearts.Ten)) return Score.TenHeartHigh;
            return _next.Scoring(hand);
        }
    }
}