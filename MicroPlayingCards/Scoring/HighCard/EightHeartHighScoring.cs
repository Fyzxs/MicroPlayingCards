using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class EightHeartHighScoring : IScoring
    {
        private readonly IScoring _next;
        public EightHeartHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Hearts.Eight)) return Score.EightHeartHigh;
            return _next.Scoring(hand);
        }
    }
}