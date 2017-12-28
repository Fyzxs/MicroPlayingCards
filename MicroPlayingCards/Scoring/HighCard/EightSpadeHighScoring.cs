using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class EightSpadeHighScoring : IScoring
    {
        private readonly IScoring _next;
        public EightSpadeHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Spades.Eight)) return Score.EightSpadeHigh;
            return _next.Scoring(hand);
        }
    }
}