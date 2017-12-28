using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class AceHeartHighScoring : IScoring
    {
        private readonly IScoring _next;
        public AceHeartHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Hearts.Ace)) return Score.AceHeartHigh;
            return _next.Scoring(hand);
        }
    }
}