using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class JackSpadeHighScoring : IScoring
    {
        private readonly IScoring _next;
        public JackSpadeHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Spades.Jack)) return Score.JackSpadeHigh;
            return _next.Scoring(hand);
        }
    }
}