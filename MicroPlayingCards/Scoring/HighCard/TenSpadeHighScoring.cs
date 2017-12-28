using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class TenSpadeHighScoring : IScoring
    {
        private readonly IScoring _next;
        public TenSpadeHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Spades.Ten)) return Score.TenSpadeHigh;
            return _next.Scoring(hand);
        }
    }
}